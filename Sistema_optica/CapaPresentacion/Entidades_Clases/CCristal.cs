using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class CCristal
    {
        //Strin para conectarse en Netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int IdCristal { get; set; }
        public string Material { get; set; }
        public int Stock { get; set; }

        public void cargarComboBoxCristales(ComboBox comboBoxCristal)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdCristal, Material FROM Cristal WHERE Stock > 0";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Cristal");
                    comboBoxCristal.DataSource = ds.Tables["Cristal"];
                    comboBoxCristal.DisplayMember = "Material";
                    comboBoxCristal.ValueMember = "IdCristal";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void altaCristales(string material, int stock)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio) )
            {
                try
                {
                    string consulta = "INSERT INTO Cristal (Material, Stock) VALUES (@Material, @Stock)";
                    SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                    comandoInsercion.Parameters.AddWithValue("@Material", material);
                    comandoInsercion.Parameters.AddWithValue("@Stock", stock);

                } 
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error generado al dar de alta un producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void verCristales (DataGridView dataGridCristales)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Cristal", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridCristales.DataSource = dtbl;
            }
        }

        public void modificarCristal (int id_cristal, string material, int stock, DataGridView dataGridCristales)
        {
            DataGridViewRow fila = dataGridCristales.SelectedRows[0];
            //El ID del cliente no sera modificable ya que sera su numero de identificacion
            int id_Cristalnuevo = id_cristal;//int.Parse(TDni.Text)
            string materialNuevoCl = material;//TNombre.Text
            int stockNuevo = stock;//TApellido.Text

            string query = "UPDATE Cristal MATERIAL = @Material, STOCK = @Stock WHERE ID_CRISTAL = @ID_CRISTAL";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                //comandoBaja.Parameters.AddWithValue("@DNI", dniNuevoCl);
                comandoBaja.Parameters.AddWithValue("@Material", materialNuevoCl);
                comandoBaja.Parameters.AddWithValue("@Stock", stockNuevo);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito la información del cristal", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Si el empleado se ha registrado con exito se debe refrescar el datagridview de los empleados para poder ver los cambios
                CCliente verEmpleados = new CCliente();
                verEmpleados.verClientes(dataGridCristales);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al modificar la información del cristal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bajaCristal (DataGridView dataGridCristal)
        {
            //Funcion que da de baja al cliente
            DataGridViewRow fila = dataGridCristal.SelectedRows[0];
            int idcristal = (int)fila.Cells["id_cristal"].Value;
            bool estadoCristal = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Cristal SET Estado_cristal = @Estado_cristal WHERE IDCRISTAL = @IDCRISTAL";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@EstadoCristal", estadoCristal);
                comandoBaja.Parameters.AddWithValue("@IDCRISTAL", idcristal);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha deshabilitado el cristal", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CCristal actualizarCristal = new CCristal();
                actualizarCristal.verCristales(dataGridCristal);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void restaurarCristal (DataGridView dataGridCristales)
        {
            //Funcion que restaura al cliente
            DataGridViewRow fila = dataGridCristales.SelectedRows[0];
            int idCristal = (int)fila.Cells["idCristal"].Value;
            bool estadoCristal = true;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Cristal SET EstadoCristal = @EstadoCristal WHERE IDCRISTAL = @IDCRISTAL";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@EstadoCristal", estadoCristal);
                comandoBaja.Parameters.AddWithValue("@IDCRISTAL", idCristal);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha restaurado el cristal", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CCristal actualizarCristales = new CCristal();
                actualizarCristales.verCristales(dataGridCristales);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

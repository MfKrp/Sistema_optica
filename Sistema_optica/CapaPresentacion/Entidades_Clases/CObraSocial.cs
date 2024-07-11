using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace CapaPresentacion.Entidades_Clases
{
    internal class CObraSocial
    {
        //String para conectarse en Netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int IdObraSocial { get; set; }
        public string NombreObraSocial { get; set; }
        public bool EstadoObraSocial { get; set; }
        public float CoberturaMarco { get; set; }
        public float CoberturaCristal { get; set; }

        /*Generar metodo para cargar obras sociales*/

        /*Hacer metodo para modificar, eliminar, y mostrar las obras sociales*/

        public void cargarComboBoxObraSocial(ComboBox comboBoxObraSocial)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT NombreObraSocial, IdObraSocial FROM Obra_Social";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Obra_social");
                    comboBoxObraSocial.DataSource = ds.Tables["Obra_social"];
                    comboBoxObraSocial.DisplayMember = "NombreObraSocial";
                    comboBoxObraSocial.ValueMember = "IdObraSocial";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void verObrasSociales (DataGridView dataGridObraSocial)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Obra_social", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridObraSocial.DataSource = dtbl;
            }
        }

        public void altaObraSocial (string nombreObraSocial, float coberturaMarco, float coberturaCristal)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "INSERT INTO Obra_social (NombreObraSocial, EstadoObraSocial, CoberturaMarco, CoberturaCristal) VALUES (@NOMBREOBRA, @ESTADOOBRA, @COBERTURAMARCO, @COBERTURACRISTAL)";
                    SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                    comandoInsercion.Parameters.AddWithValue("@NOMBREOBRA", nombreObraSocial);
                    comandoInsercion.Parameters.AddWithValue("@ESTADOOBRA", true);
                    comandoInsercion.Parameters.AddWithValue("@COBERTURAMARCO", coberturaMarco);
                    comandoInsercion.Parameters.AddWithValue("@COBERTURACRISTAL", coberturaCristal);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error generado al dar de alta el crital", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void modificarObraSocial(int idObraSocial, string nombreObraSocial, float coberturaMarco, float coberturaCristal, DataGridView dataGridObrasSociales)
        {
            DataGridViewRow fila = dataGridObrasSociales.SelectedRows[0];
            //El ID de la obra social no sera modificable ya que sera su numero de identificacion
            int id_ObraSocial = idObraSocial;
            string nuevoNombreObra = nombreObraSocial;
            float nuevaCoberturaMarco = coberturaMarco;//TNombre.Text
            float nuevaCoberturaCristal = coberturaCristal;//TApellido.Text

            string query = "UPDATE ObraSocial NombreObraSocial = @NOMBREOBRASOCIAL, CoberturaMarco = @COBERTURAMARCO, CoberturaCristal = @COBERTURACRISTAL WHERE IdObraSocial = @IDOBRASOCIAL";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoModificacion = new SqlCommand(query, conexion);

            try
            {
                comandoModificacion.Parameters.AddWithValue("@NOMBREOBRASOCIAL", nuevoNombreObra);
                comandoModificacion.Parameters.AddWithValue("@COBERTURAMARCO", nuevaCoberturaMarco);
                comandoModificacion.Parameters.AddWithValue("@COBERTURACRISTAL", nuevaCoberturaCristal);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoModificacion.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito la información de la obra social", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Los cambios realizados en las obras sociales se visualizan en el datagrid
                CObraSocial actualizarObrasSociales = new CObraSocial();
                actualizarObrasSociales.verObrasSociales(dataGridObrasSociales);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al modificar la información de la obra social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void bajaObraSocial (DataGridView dataGridObrasSociales)
        {
            //Funcion que da de baja al cliente
            DataGridViewRow fila = dataGridObrasSociales.SelectedRows[0];
            int idcristal = (int)fila.Cells["idObraSocial"].Value;
            bool estadoObraSocial = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE ObraSocial SET EstadoObraSocial = @ESTADOOBRASOCIAL WHERE ID = @IDCRISTAL";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@ESTADOOBRASOCIAL", estadoObraSocial);
                comandoBaja.Parameters.AddWithValue("@IDCRISTAL", idcristal);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha deshabilitado la obra social", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CCristal actualizarCristal = new CCristal();
                actualizarCristal.verCristales(dataGridObrasSociales);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja de la obra social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void restaurarObraSocial (DataGridView dataGridObrasSociales)
        {
            //Funcion que restaura al cliente
            DataGridViewRow fila = dataGridObrasSociales.SelectedRows[0];
            int idOBraSocial = (int)fila.Cells["idObraSocial"].Value;
            bool estadoObraSocial = true;
            string query = "UPDATE Obra_Social SET EstadoObraSocial = @ESTADOOBRASOCIAL WHERE IdObraSocial = @IDOBRASOCIAL";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@ESTADOOBRASOCIAL", estadoObraSocial);
                comandoBaja.Parameters.AddWithValue("@IDOBRASOCIAL", idOBraSocial);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha restaurado la obra social", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CObraSocial verActualizarObrasSociales = new CObraSocial();
                verActualizarObrasSociales.verObrasSociales(dataGridObrasSociales);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja la obra social", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

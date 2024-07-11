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
    public class CFormaPago
    {
        //Strin para conectarse en Netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";


        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        /*Hacer funciones CRUD para las formas de pago*/

        public int IdFormaPago { get; set; }
        public string Descripcion { get; set; }
        public float Interes { get; set; }

        public void cargarComboBox(ComboBox comboBoxTipo)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdFormaPago, Descripcion FROM Forma_pago";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Forma_pago");
                    comboBoxTipo.DataSource = ds.Tables["Forma_pago"];
                    comboBoxTipo.DisplayMember = "Descripcion";
                    comboBoxTipo.ValueMember = "IdFormaPago";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void altaFormaPago (string descripcion, float interes)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "INSERT INTO Forma_pago (descripcion, interes) VALUES (@Descripcion, @Interes)";
                    SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                    comandoInsercion.Parameters.AddWithValue("@Descripcion", descripcion);
                    comandoInsercion.Parameters.AddWithValue("@Interes", interes);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error generado al dar de alta una Forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void verFormasDePago (DataGridView dataGridFormasPago)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Forma_pago", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridFormasPago.DataSource = dtbl;
            }
        }

        public void modifFormaPago (int id_formaPago, string descripcion, float interes, DataGridView dataGridFormasPago)
        {
            DataGridViewRow fila = dataGridFormasPago.SelectedRows[0];
            //El ID del cliente no sera modificable ya que sera su numero de identificacion
            int id_FormaPago = id_formaPago;//int.Parse(TDni.Text)
            string descripcionNueva = descripcion;//TNombre.Text
            float interesNuevo = interes;//TApellido.Text

            string query = "UPDATE Forma_pago DESCRIPCION = @DESCRIPCION, INTERES = @INTERES WHERE ID_FORMAPAGO = @ID_FORMAPAGO";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                //comandoBaja.Parameters.AddWithValue("@DNI", dniNuevoCl);
                comandoBaja.Parameters.AddWithValue("@DESCRIPCION", descripcionNueva);
                comandoBaja.Parameters.AddWithValue("@INTERES", interesNuevo);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito la información de la forma de pago", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Si el empleado se ha registrado con exito se debe refrescar el datagridview de los empleados para poder ver los cambios
                CCliente verEmpleados = new CCliente();
                verEmpleados.verClientes(dataGridFormasPago);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al modificar la información de la forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bajaFormaPago (DataGridView dataGridFormasPago)
        {
            //Funcion que da de baja al cliente
            DataGridViewRow fila = dataGridFormasPago.SelectedRows[0];
            int idFormaPago = (int)fila.Cells["idFormaPago"].Value;
            bool estadoFormaPago = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Forma_pago SET EstadoFormaPago = @ESTADOFORMAPAGO WHERE idFormaPago = @IDFORMAPAGO";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@ESTADOFORMAPAGO", estadoFormaPago);
                comandoBaja.Parameters.AddWithValue("@IDCRISTAL", idFormaPago);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha deshabilitado la forma de pago", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CFormaPago actualizarFormaPago = new CFormaPago();
                actualizarFormaPago.verFormasDePago(dataGridFormasPago);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void restaurarFormaPago(DataGridView dataGridFormasPago)
        {
            //Funcion que restaura al cliente
            DataGridViewRow fila = dataGridFormasPago.SelectedRows[0];
            int idFormaPago = (int)fila.Cells["idFormasPago"].Value;
            bool estadoFormaPago = true;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Forma_pago SET EstadoFormaPago = @ESTADOFORMAPAGO WHERE IdFormaPago = @IDFORMAPAGO";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@ESTADOFORMAPAGO", estadoFormaPago);
                comandoBaja.Parameters.AddWithValue("@IDFORMAPAGO", idFormaPago);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha restaurado la forma de pago", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CFormaPago actualizarFormasPago = new CFormaPago();
                actualizarFormasPago.verFormasDePago(dataGridFormasPago);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
}

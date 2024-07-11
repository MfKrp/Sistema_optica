using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class EPerfilEmpleado
    {
        //Strings de conexion
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //String de conexion que se usa para conectarse en Pc de escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        /*Hacer funciones CRUD para los perfiles de empleado*/

        public int IdPerfilEmpleado { get; set; }
        public string Descripcion { get; set; }

        public void cargarTextBoxPerfil (ComboBox comboBoxPerfil)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdPerfilEmpleado, Descripcion FROM PerfilEmpleado";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PerfilEmpleado");
                    comboBoxPerfil.DataSource = ds.Tables["PerfilEmpleado"];
                    comboBoxPerfil.DisplayMember = "Descripcion";
                    comboBoxPerfil.ValueMember = "IdPerfilEmpleado";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void verPerfilEmpleado (DataGridView dataGridPerfil)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PerfilEmpleado", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridPerfil.DataSource = dtbl;
            }
        }

        public void altaPerfilEmpleado (string descPerfil)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "INSERT INTO PerfilEmpleado (Descripcion) VALUES (@DESCPERFIL)";
                    SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                    comandoInsercion.Parameters.AddWithValue("@DESCPERFIL", descPerfil);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error generado al generar el perfil de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void modificarPerfilEmpleado (int idPerfil, string descPerfil, DataGridView dataGridPerfiles)
        {
            DataGridViewRow fila = dataGridPerfiles.SelectedRows[0];
            //El ID de la obra social no sera modificable ya que sera su numero de identificacion
            int idEstiloModificar = idPerfil;
            string nuevaDescripcion = descPerfil;

            string query = "UPDATE Marca PerfilEmpleado = @DESCPERFIL WHERE idPerfilEmpleado = @IDPERFILEMPLEADO";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoModificacion = new SqlCommand(query, conexion);

            try
            {
                comandoModificacion.Parameters.AddWithValue("@DESCPERFIL", nuevaDescripcion);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoModificacion.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito la información del perfil de usuario", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Los cambios realizados en los estilos se visualizan en el datagrid
                EMarca actualizarFormas = new EMarca();
                actualizarFormas.verMarca(dataGridPerfiles);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al modificar la informacion de los perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

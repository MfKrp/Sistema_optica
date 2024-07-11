using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class EEstilo
    {
        //String usado para conectarse en netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //string usado para conectarse en Pc de escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        /*Hacer funciones CRUD para los estilos*/

        public int IdEstilo { get; set; }
        public string Descripcion { get; set; }

        public void cargarComboBoxEstilos (ComboBox comboBoxEstilo)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdEstilo, Descripcion FROM Estilo";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Estilo");
                    comboBoxEstilo.DataSource = ds.Tables["Estilo"];
                    comboBoxEstilo.DisplayMember = "Descripcion";
                    comboBoxEstilo.ValueMember = "IdEstilo";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void verEstilos (DataGridView dataGridEstilos)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Estilos", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridEstilos.DataSource = dtbl;
            }
        }

        public void altaEstilo(string descEstilo)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "INSERT INTO Estilo (Descripcion) VALUES (@DESCESTILO)";
                    SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                    comandoInsercion.Parameters.AddWithValue("@DESCESTILO", descEstilo);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error generado al generar el estilo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void modificarEstilo(int idEstilo, string descEstilo, DataGridView dataGridEstilos)
        {
            DataGridViewRow fila = dataGridEstilos.SelectedRows[0];
            //El ID de la obra social no sera modificable ya que sera su numero de identificacion
            int idEstiloModificar = idEstilo;
            string nuevaDescripcion = descEstilo;

            string query = "UPDATE Estilo Descripcion = @DESCRESTILO WHERE idEstilo = @IDESTILO";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoModificacion = new SqlCommand(query, conexion);

            try
            {
                comandoModificacion.Parameters.AddWithValue("@DESCESTILO", nuevaDescripcion);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoModificacion.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito la información del estilo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Los cambios realizados en los estilos se visualizan en el datagrid
                EEstilo actualizarObrasSociales = new EEstilo();
                actualizarObrasSociales.verEstilos(dataGridEstilos);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al modificar la informacion del estilo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaPresentacion.Entidades_Clases
{
    internal class EMarca
    {
        //String para conectarse en netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //String para conectarse en escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        /*Hacer funciones CRUD para las marcas*/

        public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        
        //Se carga el combobox de marca con los datos guardados en los registros de esa tabla
        public void cargarComboBox(ComboBox ComboBox)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdMarca, Descripcion FROM Marca";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Marca");
                    ComboBox.DataSource = ds.Tables["Marca"];
                    ComboBox.DisplayMember = "Descripcion";
                    ComboBox.ValueMember = "IdMarca";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void verMarca (DataGridView dataGridMarcas)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Marca", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridMarcas.DataSource = dtbl;
            }
        }

        public void altaMarca (string descMarca)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "INSERT INTO Marca (Descripcion) VALUES (@DESCMARCA)";
                    SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                    comandoInsercion.Parameters.AddWithValue("@DESCMARCA", descMarca);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error generado al generar la marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void modificarForma(int idMarca, string descMarca, DataGridView dataGridMarcas)
        {
            DataGridViewRow fila = dataGridMarcas.SelectedRows[0];
            //El ID de la obra social no sera modificable ya que sera su numero de identificacion
            int idEstiloModificar = idMarca;
            string nuevaDescripcion = descMarca;

            string query = "UPDATE Marca Descripcion = @DESCMARCA WHERE idMarca = @IDMARCA";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoModificacion = new SqlCommand(query, conexion);

            try
            {
                comandoModificacion.Parameters.AddWithValue("@DESMARCA", nuevaDescripcion);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoModificacion.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito la información de la marca", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Los cambios realizados en los estilos se visualizan en el datagrid
                EMarca actualizarFormas = new EMarca();
                actualizarFormas.verMarca(dataGridMarcas);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al modificar la informacion del estilo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class EForma //Esta clase define la forma del marco de los anteojos
    {
        //Strin para conectarse en Netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //String para conectarse en Pc de escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        /*Hacer funciones CRUD para las formas*/

        public int IdForma { get; set; }
        public string Descripcion { get; set; }

        public void cargarComboBox(ComboBox comboBoxTipo)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdForma, Descripcion FROM Forma";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Forma");
                    comboBoxTipo.DataSource = ds.Tables["Forma"];
                    comboBoxTipo.DisplayMember = "Descripcion";
                    comboBoxTipo.ValueMember = "IdForma";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void verFormas (DataGridView dataGridForma)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Forma", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridForma.DataSource = dtbl;
            }
        }

        public void altaForma (string descForma)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "INSERT INTO Forma (Descripcion) VALUES (@DESFORMA)";
                    SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                    comandoInsercion.Parameters.AddWithValue("@DESCFORMA", descForma);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error generado al generar la forma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void modificarForma (int idForma, string descForma, DataGridView dataGridFormas)
        {
            DataGridViewRow fila = dataGridFormas.SelectedRows[0];
            //El ID de la obra social no sera modificable ya que sera su numero de identificacion
            int idEstiloModificar = idForma;
            string nuevaDescripcion = descForma;

            string query = "UPDATE Forma Descripcion = @DESCFORMA WHERE idForma = @IDFORMA";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoModificacion = new SqlCommand(query, conexion);

            try
            {
                comandoModificacion.Parameters.AddWithValue("@DESFORMA", nuevaDescripcion);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoModificacion.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito la información de la forma", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Los cambios realizados en los estilos se visualizan en el datagrid
                EForma actualizarFormas = new EForma();
                actualizarFormas.verFormas(dataGridFormas);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al modificar la informacion del estilo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

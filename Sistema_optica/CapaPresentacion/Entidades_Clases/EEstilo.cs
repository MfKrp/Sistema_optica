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
        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        //string usado para conectarse en Pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int Id_estilo { get; set; }
        public string DescripcionEstilo { get; set; }

        public void cargarComboBoxEstilos (ComboBox comboBoxEstilo)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT Id_estilo, Descripcion FROM Estilo";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Estilo");
                    comboBoxEstilo.DataSource = ds.Tables["Estilo"];
                    comboBoxEstilo.DisplayMember = "Descripcion";
                    comboBoxEstilo.ValueMember = "Id_estilo";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

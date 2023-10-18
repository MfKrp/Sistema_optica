using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion.Entidades_Clases
{
    internal class EMarca
    {
        string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        public void cargarComboBox(ComboBox ComboBox)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string consulta = "SELECT Id_marca, Descripcion FROM Marca";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Marca");
                    ComboBox.DataSource = ds.Tables["Marca"];
                    ComboBox.DisplayMember = "Descripcion";
                    ComboBox.ValueMember = "Id_marca";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

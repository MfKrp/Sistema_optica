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
        string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public void cargarTextBoxPerfil (ComboBox comboBoxPerfil)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string consulta = "SELECT ID_Perfil, Descripcion FROM Tipo_perfil";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tipo_perfil");
                    comboBoxPerfil.DataSource = ds.Tables["Tipo_perfil"];
                    comboBoxPerfil.DisplayMember = "Descripcion";
                    comboBoxPerfil.ValueMember = "ID_perfil";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

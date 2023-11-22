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
        string connectionStringEscritorio = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        //String para conectarse en escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";
        
        public int Id_Marca { get; set; }
        public string DescripcionProd { get; set; }
        
        //Se carga el combobox de marca con los datos guardados en los registros de esa tabla
        public void cargarComboBox(ComboBox ComboBox)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
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

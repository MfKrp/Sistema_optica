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
        string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";
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
    }
}

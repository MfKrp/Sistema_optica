using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class ETipo
    {
        //Strin para conectarse en Netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        //String para conectarse en Pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int Id_tipo { get; set; }
        public string DescripcionProd { get; set; }

        public void cargarComboBox(ComboBox comboBoxTipo)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT ID_Tipo, Nombre FROM Tipo_producto";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tipo_producto");
                    comboBoxTipo.DataSource = ds.Tables["Tipo_producto"];
                    comboBoxTipo.DisplayMember = "Nombre";
                    comboBoxTipo.ValueMember = "ID_Tipo";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

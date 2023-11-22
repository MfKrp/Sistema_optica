using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    public class CTipoPago
    {
        //Strin para conectarse en Netbook
        string connectionStringEscritorio = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        //String para conectarse en Pc de escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int Id_tipo_pago { get; set; }
        public string Descripcion { get; set; }

        public void cargarComboBox(ComboBox comboBoxTipo)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT Id_tipo_pago, Descripcion FROM Forma_pago";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Forma_pago");
                    comboBoxTipo.DataSource = ds.Tables["Forma_pago"];
                    comboBoxTipo.DisplayMember = "Descripcion";
                    comboBoxTipo.ValueMember = "Id_tipo_pago";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

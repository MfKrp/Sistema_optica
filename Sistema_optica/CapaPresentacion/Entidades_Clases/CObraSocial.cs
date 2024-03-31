using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class CObraSocial
    {
        //Strin para conectarse en Netbook
        string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        public int IdObraSocial { get; set; }
        public string NombreObraSocial { get; set; }
        public bool EstadoObraSocial { get; set; }
        public float CoberturaMarco { get; set; }
        public float CoberturaCristal { get; set; }

        /*Generar metodo para cargar obras sociales*/

        /*Hacer metodo para modificar, eliminar, y mostrar las obras sociales*/

        public void cargarComboBoxObraSocial(ComboBox comboBoxObraSocial)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT NombreObraSocial, IdObraSocial FROM Obra_Social";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Obra_social");
                    comboBoxObraSocial.DataSource = ds.Tables["Obra_social"];
                    comboBoxObraSocial.DisplayMember = "NombreObraSocial";
                    comboBoxObraSocial.ValueMember = "IdObraSocial";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

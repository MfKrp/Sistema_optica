using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class CCristal
    {
        //Strin para conectarse en Netbook
        string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        public int IdCristal { get; set; }
        public string Material { get; set; }
        public int Stock { get; set; }

        /*Hacer funcion para cargar cristales*/

        /*Hacer funcion para modificar cristales*/

        /*Hacer funcion para eliminar cristales*/

        /*Hacer funcion para recuperar cristales*/

        /*Hacer funcion para mostrar los cristales*/

        /*Hacer funcion descontar y añadir stock a los cristales*/

        public void cargarComboBoxCristales (ComboBox comboBoxCristal)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdCristal, Material FROM Cristal";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Cristal");
                    comboBoxCristal.DataSource = ds.Tables["Cristal"];
                    comboBoxCristal.DisplayMember = "Material";
                    comboBoxCristal.ValueMember = "IdCristal";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

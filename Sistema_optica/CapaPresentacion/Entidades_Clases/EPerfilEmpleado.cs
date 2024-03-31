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
        //Strings de conexion
        string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";
        
        //String de conexion que se usa para conectarse en Pc de escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        /*Hacer funciones CRUD para los perfiles de empleado*/

        public int IdPerfilEmpleado { get; set; }
        public string Descripcion { get; set; }

        public void cargarTextBoxPerfil (ComboBox comboBoxPerfil)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string consulta = "SELECT IdPerfilEmpleado, Descripcion FROM PerfilEmpleado";
                    SqlDataAdapter da = new SqlDataAdapter(consulta, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PerfilEmpleado");
                    comboBoxPerfil.DataSource = ds.Tables["PerfilEmpleado"];
                    comboBoxPerfil.DisplayMember = "Descripcion";
                    comboBoxPerfil.ValueMember = "IdPerfilEmpleado";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en \n" + e.ToString(), "Error Generado al cargar combobox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Entidades_Clases
{
    internal class CCliente
    {
        string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public void altaCliente (string dniCl,
        string nombreCl,
        string apellidoCl,
        string telefonoCl,
        string direccionCl,
        string correoCl)
        {
            int dni = Int32.Parse(dniCl);
            string nombre = nombreCl;
            string apellido = apellidoCl;
            string telefono = telefonoCl;
            string direccion = direccionCl;
            string correo = correoCl;
            bool estadoCliente = true;

            SqlConnection con = new SqlConnection(connectionString);

            string consulta = "INSERT INTO Cliente (DNI, Nombre, Apellido, Telefono, Direccion, Email, Estado_cliente) VALUES (@DNI, @Nombre, @Apellido, @Telefono, @Direccion, @Correo, @Estado_cliente)";
            SqlCommand comandoInsercion = new SqlCommand(consulta, con);

            comandoInsercion.Parameters.AddWithValue("@DNI", dni);
            comandoInsercion.Parameters.AddWithValue("@Nombre", nombre);
            comandoInsercion.Parameters.AddWithValue("@Apellido", apellido);
            comandoInsercion.Parameters.AddWithValue("@Telefono", telefono);
            comandoInsercion.Parameters.AddWithValue("@Direccion", direccion);
            comandoInsercion.Parameters.AddWithValue("@Correo", correo);
            comandoInsercion.Parameters.AddWithValue("@Estado_cliente", estadoCliente);

            try //try-catch
            {
                con.Open();
                comandoInsercion.ExecuteNonQuery();
                MessageBox.Show("Registros cargados exitosamente");
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error generado.\nDetalles:" + j.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void verClientes(DataGridView dataGridClientes)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Cliente", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridClientes.DataSource = dtbl;
            }
        }
    }
}

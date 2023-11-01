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
        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

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

            SqlConnection con = new SqlConnection(connectionStringEscritorio);

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
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Cliente", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridClientes.DataSource = dtbl;
            }
        }

        public void modificarCliente (int dniCliente,
            string nombreCliente,
            string apellidoCliente,
            string telefonoCliente,
            string direccionCliente,
            string emailCliente,
            DataGridView datagridClientes)
        {

        }

        public void bajaCliente (DataGridView dataGridClientes)
        {
            //Funcion que da de baja al cliente
            DataGridViewRow fila = dataGridClientes.SelectedRows[0];
            int dniCliente = (int)fila.Cells["DNI"].Value;
            bool estadoCliente = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Cliente SET Estado_cliente = @Estado_cliente WHERE DNI = @DNI";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@Estado_cliente", estadoCliente);
                comandoBaja.Parameters.AddWithValue("@DNI", dniCliente);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha dado de baja al cliente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CCliente actualizarEmpleados = new CCliente();
                actualizarEmpleados.verClientes(dataGridClientes);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void restaurarCliente(DataGridView dataGridClientes)
        {
            //Funcion que restaura al cliente
            DataGridViewRow fila = dataGridClientes.SelectedRows[0];
            int dniCliente = (int)fila.Cells["DNI"].Value;
            bool estadoCliente = true;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Cliente SET Estado_cliente = @Estado_cliente WHERE DNI = @DNI";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@Estado_cliente", estadoCliente);
                comandoBaja.Parameters.AddWithValue("@DNI", dniCliente);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha dado de baja al cliente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja al cliente se refresca la tabla
                CCliente actualizarEmpleados = new CCliente();
                actualizarEmpleados.verClientes(dataGridClientes);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

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

        public void modificarCliente (int dniCliente,
            string nombreCliente,
            string apellidoCliente,
            string telefonoCliente,
            string direccionCliente,
            string emailCliente,
            DataGridView datagridClientes)
        {
            DataGridViewRow fila = datagridClientes.SelectedRows[0];
            //El ID del cliente no sera modificable ya que sera su numero de identificacion
            int dniNuevoCl = dniCliente;//int.Parse(TDni.Text)
            string nombreNuevoCl = nombreCliente;//TNombre.Text
            string apellidoNuevoCl = apellidoCliente;//TApellido.Text
            string telNuevoCl = telefonoCliente;//TTelefono.Text
            string dirNuevoCl = direccionCliente;//TDirecion.Text
            string emailNuevoCl = emailCliente;//TDireccion.Text
            
            string query = "UPDATE Cliente SET DNI = @DNI, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Direccion = @Direccion, WHERE DNI = @DNI";
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                comandoBaja.Parameters.AddWithValue("@DNI", dniNuevoCl);
                comandoBaja.Parameters.AddWithValue("@Nombre", nombreNuevoCl);
                comandoBaja.Parameters.AddWithValue("@Apellido", apellidoNuevoCl);
                comandoBaja.Parameters.AddWithValue("@Telefono", telNuevoCl);
                comandoBaja.Parameters.AddWithValue("@Email", emailCliente);
                comandoBaja.Parameters.AddWithValue("@Direccion", dirNuevoCl);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito el Cliente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Si el empleado se ha registrado con exito se debe refrescar el datagridview de los empleados para poder ver los cambios
                CEmpleado verEmpleados = new CEmpleado();
                verEmpleados.verEmpleados(datagridClientes);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bajaCliente (DataGridView dataGridClientes)
        {
            //Funcion que da de baja al cliente
            DataGridViewRow fila = dataGridClientes.SelectedRows[0];
            int dniCliente = (int)fila.Cells["DNI"].Value;
            bool estadoCliente = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Cliente SET Estado_cliente = @Estado_cliente WHERE DNI = @DNI";
            SqlConnection conexion = new SqlConnection(connectionString);
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
            SqlConnection conexion = new SqlConnection(connectionString);
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

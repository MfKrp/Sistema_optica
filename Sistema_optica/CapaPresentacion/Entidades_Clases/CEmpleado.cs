using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace CapaPresentacion.Entidades_Clases
{
    public class CEmpleado
    {
        //String usado para conectarse en netbook
        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        
        //String usado para conectarse en escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int id_empleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string apellidoEmpleado { get; set; }
        public string telEmpleado { get; set; }
        public string emailEmpleado { get; set; }
        public string fechaEmpleado { get; set; }
        public string dniEmpleado { get; set; }
        public string direccionEmpleado { get; set; }
        public int idPerfilEmpleado { get; set; }
        public bool estEmpleado { get; set; }
        public string passEmpleado { get; set; }

        public void altaEmpleado(string dniEmp,
        string codigoPerfilEmp,
        int idEmpleado,
        string nombreEmple,
        string apellidoEmple,
        string telefonoEmple,
        string direccionEmple,
        string correoEmple,
        string fecha_NacimientoEmple,
        string contrasenaEmp)
        {
            //Desarrollo de la funcion para cargar empleado
            //Se capturan los valores
            string dni = dniEmp;
            int codigoPerfEmp = int.Parse(codigoPerfilEmp);
            int id_empleado = idEmpleado;
            string nombreEmp = nombreEmple;
            string apellidoEmp = apellidoEmple;
            string telefonoEmp = telefonoEmple;
            string direccionEmp = direccionEmple;
            string correoEmp = correoEmple;
            string fecha_Nacimiento = fecha_NacimientoEmple;
            string contrasena = contrasenaEmp;

            SqlConnection con = new SqlConnection(connectionStringEscritorio);

            string consulta = "INSERT INTO UsuarioEmpleado (ID_empleado, Nombre, Apellido, Telefono, Email, Fecha_Nacimiento, DNI, Direccion, ID_perfil, Estado_empleado, Contrasena) VALUES (@ID_empleado, @Nombre, @Apellido, @Telefono, @Email, @Fecha_nacimiento, @DNI, @Direccion, @ID_perfil, @Estado_empleado, @Contrasena)";
            SqlCommand comandoInsercion = new SqlCommand(consulta, con);

            comandoInsercion.Parameters.AddWithValue("@ID_empleado", id_empleado);
            comandoInsercion.Parameters.AddWithValue("@Nombre", nombreEmp);
            comandoInsercion.Parameters.AddWithValue("@Apellido", apellidoEmp);
            comandoInsercion.Parameters.AddWithValue("@Telefono", telefonoEmp);
            comandoInsercion.Parameters.AddWithValue("@Email", correoEmp);
            comandoInsercion.Parameters.AddWithValue("@Fecha_nacimiento", fecha_Nacimiento);
            comandoInsercion.Parameters.AddWithValue("@DNI", dni);
            comandoInsercion.Parameters.AddWithValue("@Direccion", direccionEmp);
            comandoInsercion.Parameters.AddWithValue("@ID_perfil", codigoPerfEmp);
            //El empleado siempre que se da de alta es con un estado activo
            comandoInsercion.Parameters.AddWithValue("@Estado_empleado", 1);
            comandoInsercion.Parameters.AddWithValue("@Contrasena", contrasena);

            try
            {
                con.Open();
                comandoInsercion.ExecuteNonQuery();
                MessageBox.Show("Registros insertados exitosamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error Generado.\nDetalles: " + j.ToString(), "Error generado en insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); //una vez insertados los registros se cierra la conexion
            }
        }

        public void modificacionEmpleado (string dniEmple,
        int codigoPerfilEmple,
        int idEmpleado,
        string nombreEmple,
        string apellidoEmple,
        string telefonoEmple,
        string direccionEmple,
        string correoEmple,
        string fecha_NacimientoEmple,
        string contrasenaEmple,
        DataGridView DataGridEmpleados)
        {
            DataGridViewRow fila = DataGridEmpleados.SelectedRows[0];
            //El ID del empleado no sera modificable ya que sera su numero de identificacion
            int id_empleado = (int)fila.Cells["ID_empleado"].Value;
            string nombreEmp = nombreEmple;//TNombre.Text;
            string apellidoEmp = apellidoEmple;//TApellido.Text;
            string telEmp = telefonoEmple;//TTelefono.Text;
            string emailEmp = correoEmple;//TCorreo.Text;
            string nacEmp = fecha_NacimientoEmple;//DTPFechaNac.Value.ToShortDateString();
            string dniEmp = dniEmple;//TDni.Text;
            string dirEmp = correoEmple;//TCorreo.Text;
            int perfilEmp = codigoPerfilEmple;//int.Parse(ComboBox_Perfil.SelectedValue.ToString());
            string contrasenaEmp = contrasenaEmple;//TContrasena.Text;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE UsuarioEmpleado SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Fecha_nacimiento = @Fecha_nacimiento, DNI = @DNI, Direccion = @Direccion, ID_Perfil = @ID_Perfil, Contrasena = @Contrasena WHERE ID_empleado = @ID_empleado";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {

                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                comandoBaja.Parameters.AddWithValue("@ID_empleado", id_empleado);
                comandoBaja.Parameters.AddWithValue("Nombre", nombreEmp);
                comandoBaja.Parameters.AddWithValue("Apellido", apellidoEmp);
                comandoBaja.Parameters.AddWithValue("Telefono", telEmp);
                comandoBaja.Parameters.AddWithValue("Email", emailEmp);
                comandoBaja.Parameters.AddWithValue("Fecha_nacimiento", nacEmp);
                comandoBaja.Parameters.AddWithValue("DNI", dniEmp);
                comandoBaja.Parameters.AddWithValue("Direccion", dirEmp);
                comandoBaja.Parameters.AddWithValue("ID_Perfil", perfilEmp);
                comandoBaja.Parameters.AddWithValue("Contrasena", contrasenaEmp);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito el empleado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Si el empleado se ha registrado con exito se debe refrescar el datagridview de los empleados para poder ver los cambios
                CEmpleado verEmpleados = new CEmpleado();
                verEmpleados.verEmpleados(DataGridEmpleados);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CEmpleado actualizarEmpleados = new CEmpleado();
            actualizarEmpleados.verEmpleados(DataGridEmpleados);
        }

        public void verEmpleados(DataGridView dataGridEmpleados)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Usuarioempleado", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridEmpleados.DataSource = dtbl;
            }
        }

        public void darDeBajaEmpleado(DataGridView dataGridEmpleado)
        {

            DataGridViewRow fila = dataGridEmpleado.SelectedRows[0];
            int id_empleado = (int)fila.Cells["ID_empleado"].Value;
            bool estadoEmpleado = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE UsuarioEmpleado SET Estado_empleado = @estadoEmpleado WHERE ID_empleado = @ID_empleado";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);
                comandoBaja.Parameters.AddWithValue("@ID_empleado", id_empleado);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha dado de baja al empleado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Despues de dar baja el empleado se refresca la tabla
                CEmpleado actualizarEmpleados = new CEmpleado();
                actualizarEmpleados.verEmpleados(dataGridEmpleado);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void restaurarEmpleado (DataGridView dataGridEmpleado)
        {
            //Se comprueba que almenos se haya seleccionado una fila
                DataGridViewRow fila = dataGridEmpleado.SelectedRows[0];
                int id_empleado = (int)fila.Cells["ID_empleado"].Value;
                //se cambia el estado del empleado a true, comprobandose que antes este en false
                bool estadoEmpleado = true;
                string query = "UPDATE UsuarioEmpleado SET Estado_empleado = @estadoEmpleado WHERE ID_empleado = @ID_empleado";
                SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
                conexion.Open();
                SqlCommand comandoBaja = new SqlCommand(query, conexion);

                try
                {
                    comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);
                    comandoBaja.Parameters.AddWithValue("@ID_empleado", id_empleado);
                    //esta linea se usa cuando se hace modificacion
                    comandoBaja.ExecuteNonQuery();

                    MessageBox.Show("Se ha dado restaurado al empleado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException j)
                {
                    MessageBox.Show("Error en: " + j.ToString(), "Error al restaurar empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CEmpleado actualizarEmpleados = new CEmpleado();
                actualizarEmpleados.verEmpleados(dataGridEmpleado);
        }
    }
}

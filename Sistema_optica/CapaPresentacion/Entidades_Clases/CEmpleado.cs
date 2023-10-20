using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    internal class CEmpleado
    {
        string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";

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

            SqlConnection con = new SqlConnection(connectionString);

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
    }
}

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
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //String usado para conectarse en escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int IdEmpleado { get; set; }
        public string NombreEmp { get; set; }
        public string ApellidoEmp { get; set; }
        public string TelefonoEmp { get; set; }
        public string EmailEmp { get; set; }
        public DateTime FechaNacimientoEmp { get; set; }
        public string DniEmp { get; set; }
        public string DireccionEmp { get; set; }
        public int IdPerfilEmpleado { get; set; }
        public bool EstadoEmp { get; set; }
        public string Contrasena { get; set; }

        public void altaEmpleado(string dniEmp,
        string codigoPerfilEmp,
        int idEmpleado,
        string nombreEmple,
        string apellidoEmple,
        string telefonoEmple,
        string direccionEmple,
        string correoEmple,
        DateTime fecha_NacimientoEmple,
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
            DateTime fecha_Nacimiento = fecha_NacimientoEmple;
            string contrasena = contrasenaEmp;

            SqlConnection con = new SqlConnection(connectionStringEscritorio);

            string consulta = "INSERT INTO Empleado (IdEmpleado, NombreEmp, ApellidoEmp, TelefonoEmp, EmailEmp, FechaNacimientoEmp, DniEmp, DireccionEmp, IdPerfilEmpleado, EstadoEmp, Contrasena) VALUES (@IdEmpleado, @NombreEmp, @ApellidoEmp, @TelefonoEmp, @EmailEmp, @FechaNacimientoEmp, @DniEmp, @DireccionEmp, @IdPerfilEmpleado, @EstadoEmp, @Contrasena)";
            SqlCommand comandoInsercion = new SqlCommand(consulta, con);

            comandoInsercion.Parameters.AddWithValue("@IdEmpleado", id_empleado);
            comandoInsercion.Parameters.AddWithValue("@NombreEmp", nombreEmp);
            comandoInsercion.Parameters.AddWithValue("@ApellidoEmp", apellidoEmp);
            comandoInsercion.Parameters.AddWithValue("@TelefonoEmp", telefonoEmp);
            comandoInsercion.Parameters.AddWithValue("@EmailEmp", correoEmp);
            comandoInsercion.Parameters.AddWithValue("@FechaNacimientoEmp", fecha_Nacimiento);
            comandoInsercion.Parameters.AddWithValue("@DniEmp", dni);
            comandoInsercion.Parameters.AddWithValue("@DireccionEmp", direccionEmp);
            comandoInsercion.Parameters.AddWithValue("@IdPerfilEmpleado", codigoPerfEmp);
            //El empleado siempre que se da de alta es con un estado activo
            comandoInsercion.Parameters.AddWithValue("@EstadoEmp", 1);
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
        DateTime fecha_NacimientoEmple,
        string contrasenaEmple,
        DataGridView DataGridEmpleados)
        {
            DataGridViewRow fila = DataGridEmpleados.SelectedRows[0];
            //El ID del empleado no sera modificable ya que sera su numero de identificacion
            int id_empleado = (int)fila.Cells["IdEmpleado"].Value;
            string nombreEmp = nombreEmple;//TNombre.Text;
            string apellidoEmp = apellidoEmple;//TApellido.Text;
            string telEmp = telefonoEmple;//TTelefono.Text;
            string emailEmp = correoEmple;//TCorreo.Text;
            DateTime nacEmp = fecha_NacimientoEmple;//DTPFechaNac.Value.ToShortDateString();
            string dniEmp = dniEmple;//TDni.Text;
            string dirEmp = correoEmple;//TCorreo.Text;
            int perfilEmp = codigoPerfilEmple;//int.Parse(ComboBox_Perfil.SelectedValue.ToString());
            string contrasenaEmp = contrasenaEmple;//TContrasena.Text;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Empleado SET NombreEmp = @NombreEmp, ApellidoEmp = @ApellidoEmp, TelefonoEmp = @TelefonoEmp, EmailEmp = @EmailEmp, FechaNacimientoEmp = @FechaNacimientoEmp, DniEmp = @DniEmp, DireccionEmp = @DireccionEmp, IdPerfilEmpleado = @IdPerfilEmpleado, Contrasena = @Contrasena WHERE Id_empleado = @Id_empleado";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {

                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                comandoBaja.Parameters.AddWithValue("@Id_empleado", id_empleado);
                comandoBaja.Parameters.AddWithValue("@NombreEmp", nombreEmp);
                comandoBaja.Parameters.AddWithValue("@ApellidoEmp", apellidoEmp);
                comandoBaja.Parameters.AddWithValue("@TelefonoEmp", telEmp);
                comandoBaja.Parameters.AddWithValue("@EmailEmp", emailEmp);
                comandoBaja.Parameters.AddWithValue("@Fecha_nacimientoEmp", nacEmp);
                comandoBaja.Parameters.AddWithValue("@DniEmp", dniEmp);
                comandoBaja.Parameters.AddWithValue("@DireccionEmp", dirEmp);
                comandoBaja.Parameters.AddWithValue("@Id_PerfilEmp", perfilEmp);
                comandoBaja.Parameters.AddWithValue("@Contrasena", contrasenaEmp);

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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Empleado", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridEmpleados.DataSource = dtbl;
            }
        }

        public void darDeBajaEmpleado(DataGridView dataGridEmpleado)
        {

            DataGridViewRow fila = dataGridEmpleado.SelectedRows[0];
            int id_empleado = (int)fila.Cells["IdEmpleado"].Value;
            bool estadoEmpleado = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Empleado SET EstadoEmp = @estadoEmpleado WHERE IdEmpleado = @IdEmpleado";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);
                comandoBaja.Parameters.AddWithValue("@IdEmpleado", id_empleado);
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
                int id_empleado = (int)fila.Cells["IdEmpleado"].Value;
                //se cambia el estado del empleado a true, comprobandose que antes este en false
                bool estadoEmpleado = true;
                string query = "UPDATE Empleado SET EstadoEmp = @estadoEmpleado WHERE IdEmpleado = @IdEmpleado";
                SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
                conexion.Open();
                SqlCommand comandoBaja = new SqlCommand(query, conexion);

                try
                {
                    comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);
                    comandoBaja.Parameters.AddWithValue("@IdEmpleado", id_empleado);
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

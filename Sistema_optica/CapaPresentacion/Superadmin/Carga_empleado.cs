using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Superadmin
{
    public partial class Carga_empleado : Form
    {
        string connectionString = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public Carga_empleado()
        {
            InitializeComponent();
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TCodigo_emp_TextChanged(object sender, EventArgs e)
        {
            //Se creara un numero aleatorio de 4 digitos, que se concatenara con el codigo de perfil
        }

        private void TCodigo_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TFecha_nac_TextChanged(object sender, EventArgs e)
        {

        }

        private void TFecha_nac_KeyPress(object sender, KeyPressEventArgs e)
        {
            //s
        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se aceptaran letras y numeros para la direccion
        }

        private void TCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se aceptaran caracteres y numeros
        }

        private void TContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void TContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            //limitar la cantidad de caracteres a 5
        }

        private void Carga_empleado_Load(object sender, EventArgs e)
        {
            EPerfilEmpleado textBoxPerfil = new EPerfilEmpleado();
            textBoxPerfil.cargarTextBoxPerfil(ComboBox_Perfil);
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            TDni.Text = "";
            ComboBox_Perfil.Text = "";
            TCodigo_emp.Text = "";
            TNombre.Text = "";
            TApellido.Text = "";
            TTelefono.Text = "";
            TDireccion.Text = "";
            TCorreo.Text = "";
            TContrasena.Text = "";
        }

        private void DTPNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            //Se comprueba que ningun campo este vacio
            if (TDni.Text == "" || ComboBox_Perfil.Text == "" || TCodigo_emp.Text == "" || TNombre.Text == "" || TApellido.Text == "" || TTelefono.Text == "" || TDireccion.Text == "" || TCorreo.Text == "" || TContrasena.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CEmpleado nuevoEmpleado = new CEmpleado();
                nuevoEmpleado.altaEmpleado(TDni.Text,
                ComboBox_Perfil.SelectedValue.ToString(),
                int.Parse(TCodigo_emp.Text),
                TNombre.Text,
                TApellido.Text,
                TTelefono.Text,
                TDireccion.Text,
                TCorreo.Text,
                DTPNacimiento.Value.ToShortDateString(),
                TContrasena.Text);
                /*
                //Desarrollo de la funcion para cargar empleado
                //Se capturan los valores
                string dni = TDni.Text;
                int codigoPerfEmp = int.Parse(ComboBox_Perfil.Text);
                int id_empleado = int.Parse(TCodigo_emp.Text);
                string nombreEmp = TNombre.Text;
                string apellidoEmp = TApellido.Text;
                string telefonoEmp = TTelefono.Text;
                string direccionEmp = TDireccion.Text;
                string correoEmp = TCorreo.Text;
                string fecha_Nacimiento = DTPNacimiento.Value.ToShortDateString();
                string contrasena = TContrasena.Text;

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
                */
            }
        }
    }
}

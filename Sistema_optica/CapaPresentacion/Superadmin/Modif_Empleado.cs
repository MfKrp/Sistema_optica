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
using CapaPresentacion.Entidades_Clases;

namespace CapaPresentacion.Superadmin
{
    public partial class Modif_Empleado : Form
    {
        //Strings de conexion a la base de datos
        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";
        public Modif_Empleado()
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

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

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

        private void TApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void DGVEmpleadosReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVEmpleadosReg.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = DGVEmpleadosReg.SelectedRows[0];
                int id_empleado = (int)fila.Cells["ID_empleado"].Value;
                string nombreEmp = (string)fila.Cells["Nombre"].Value;
                string apellidoEmp = (string)fila.Cells["Apellido"].Value;
                string telEmp = (string)fila.Cells["Telefono"].Value;
                string emailEmp = (string)fila.Cells["Email"].Value;
                string nacEmp = (string)fila.Cells["Fecha_nacimiento"].Value;
                string dniEmp = (string)fila.Cells["DNI"].Value;
                string dirEmp = (string)fila.Cells["Direccion"].Value;
                //Perfil del empleado

                string contraEmp = (string)fila.Cells["Contrasena"].Value;

                TCodigo_emp.Text = id_empleado.ToString();
                TNombre.Text = nombreEmp;
                TApellido.Text = apellidoEmp;
                TTelefono.Text = telEmp;
                TCorreo.Text = emailEmp;
                TFecha_nac.Text = nacEmp;
                TDni.Text = dniEmp;
                TDireccion.Text = dirEmp;

                TContrasena.Text = contraEmp;
            }
        }

        private void Modif_Empleado_Load(object sender, EventArgs e)
        {
            CEmpleado verEmpleados = new CEmpleado();
            verEmpleados.verEmpleados(DGVEmpleadosReg);

            EPerfilEmpleado textBoxPerfil = new EPerfilEmpleado();
            textBoxPerfil.cargarTextBoxPerfil(ComboBox_Perfil);
        }

        private void BGuardar_Click_1(object sender, EventArgs e)
        {
            if (TDni.Text == "" || ComboBox_Perfil.Text == "" || TCodigo_emp.Text == "" || TNombre.Text == "" || TApellido.Text == "" || TTelefono.Text == "" || TDireccion.Text == "" || TCorreo.Text == "" || TContrasena.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow fila = DGVEmpleadosReg.SelectedRows[0];
                //El ID del empleado no sera modificable ya que sera su numero de identificacion
                int id_empleado = (int)fila.Cells["ID_empleado"].Value;
                string nombreEmp = TNombre.Text;
                string apellidoEmp = TApellido.Text;
                string telEmp = TTelefono.Text;
                string emailEmp = TCorreo.Text;
                string nacEmp = DTPFechaNac.Value.ToShortDateString();
                string dniEmp = TDni.Text;
                string dirEmp = TCorreo.Text;
                int perfilEmp = int.Parse(ComboBox_Perfil.SelectedValue.ToString());
                string contrasenaEmp = TContrasena.Text;
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
                    verEmpleados.verEmpleados(DGVEmpleadosReg);
                }
                catch (SqlException j)
                {
                    MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CEmpleado actualizarEmpleados = new CEmpleado();
                actualizarEmpleados.verEmpleados(DGVEmpleadosReg);
            }
        }

        private void TCodigo_emp_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TFecha_nac_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TDireccion_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TTelefono_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void TCorreo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TContrasena_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BBorrar_Click_1(object sender, EventArgs e)
        {
            TCodigo_emp.Text = "";
            TNombre.Text = "";
            TApellido.Text = "";
            TTelefono.Text = "";
            TCorreo.Text = "";
            TFecha_nac.Text = "";
            TDni.Text = "";
            TDireccion.Text = "";
            ComboBox_Perfil.Text = "";
            TContrasena.Text = "";
        }

        private void ComboBox_Perfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
                /*Orden de los parametros de la funcion de modificacion*/
                /*
                    string dniEmple,
                    int codigoPerfilEmple,
                    int idEmpleado,
                    string nombreEmple,
                    string apellidoEmple,
                    string telefonoEmple,
                    string direccionEmple,
                    string correoEmple,
                    string fecha_NacimientoEmple,
                    string contrasenaEmple,
                    DataGridView DataGridEmpleados
                 */

                if (DGVEmpleadosReg.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    CEmpleado modificacionEmpleado = new CEmpleado();
                    modificacionEmpleado.modificacionEmpleado(TDni.Text,
                    int.Parse(ComboBox_Perfil.SelectedValue.ToString()),
                    int.Parse(TCodigo_emp.Text),
                    TNombre.Text,
                    TApellido.Text,
                    TTelefono.Text,
                    TDireccion.Text,
                    TCorreo.Text,
                    DTPFechaNac.Value.ToShortDateString(),
                    TContrasena.Text,
                    DGVEmpleadosReg);

                }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Superadmin
{
    public partial class Carga_empleado : Form
    {
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

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TDni.Text == "" || ComboBox_Perfil.Text == "" || TCodigo_emp.Text == "" || TNombre.Text == "" || TApellido.Text == "" || TTelefono.Text == "" || TDireccion.Text == "" || TCorreo.Text == "" || TContrasena.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using CapaPresentacion.Entidades_Clases;

namespace CapaPresentacion.Vendedor
{
    public partial class Alta_cliente : Form
    {
        public Alta_cliente()
        {
            InitializeComponent();
        }

        private void TDniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //filtra que solo se puedan ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            /*comprobar que NINGUN campo este vacio*/
            if (TDniCl.Text == "" || TNombreCl.Text == "" || TApellidoCl.Text == "" || TTelefonoCl.Text == "" || TDireccionCl.Text == "" || TEmailCl.Text == "")
            {
                MessageBox.Show("Complete todos los campos para continuar", "Faltan completar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*CCliente clienteNuevo = new CCliente();
                clienteNuevo.altaCliente(TId.Text,
                    TDni.Text,
                    TNombre.Text,
                    TApellido.Text,
                    TTelefono.Text,
                    TDireccion.Text,
                    TCorreo.Text);*/

            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            /*Boton que al hacerle click resetea todos los campos a la normalidad*/
            TDniCl.Text = "";
            TNombreCl.Text = "";
            TApellidoCl.Text = "";
            TTelefonoCl.Text = "";
            TDireccionCl.Text = "";
            TEmailCl.Text = "";
            TNroTarjetaCl.Text = "";
            //Resetear el valor del ComboBox Para que sea el original
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alta_cliente_Load(object sender, EventArgs e)
        {

        }

        private void TNroTarjetaCl_TextChanged(object sender, EventArgs e)
        {

        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {

        }
    }
}

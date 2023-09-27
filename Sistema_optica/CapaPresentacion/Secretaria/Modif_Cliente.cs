using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Secretaria
{
    public partial class Modif_Cliente : Form
    {
        public Modif_Cliente()
        {
            InitializeComponent();
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*codigo que hace que solo se puedan ingresar caracteres, en caso de que no funcione, verficar que en
             la propiedad keypress del campo, este asignada la funcion correspondiente*/
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTelefono_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*Codigo que solo restringe a que se ingresen numeros*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TCorreo_TextChanged(object sender, EventArgs e)
        {

        }
        private void TCorreo_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDireccion_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*En caso de que no funcione, verificar que este asignada esta funcion al evento en la seccion propiedades*/
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}

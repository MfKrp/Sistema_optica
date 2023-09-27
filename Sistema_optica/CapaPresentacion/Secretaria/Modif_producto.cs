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
    public partial class Modif_producto : Form
    {
        public Modif_producto()
        {
            InitializeComponent();
        }

        private void TPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPrecio_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*Ingresar solo numeros*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TColor_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            //Solo caracteres
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}

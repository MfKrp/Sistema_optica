using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Sesion
{
    public partial class Iniciar_sesion : Form
    {
        public Iniciar_sesion()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TCodigo_empleado_sesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCodigo_empleado_sesion_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
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

        private void TContraseña_sesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TContraseña_sesion_KeyPressEventArgs (object sender, KeyPressEventArgs e)
        {

        }
    }
}

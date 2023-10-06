using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class Alta_venta : Form
    {
        public Alta_venta()
        {
            InitializeComponent();
        }

        private void DTGDatosCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TVendedorCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_Vendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_Vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TClienteTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void TClienteTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BReiniciarCarrito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (TDni_Vendedor.Text == "" || TClienteTitular.Text == "" || TCodigoProducto.Text == "" || CBTipo.Text == "" || TColor.Text == "" || CBEstilo.Text == "" || CBMarca.Text == "" || TPrecio.Text == "" || NCantidadCompra.Text == "0")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

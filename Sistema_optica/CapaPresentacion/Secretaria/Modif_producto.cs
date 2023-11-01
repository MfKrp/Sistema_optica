using CapaPresentacion.Capa_datos;
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

        private void TId_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void TId_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TId_prod.Text == "" || /*Combobox de tipo*/ComnboBox_Anteojo.Text == "" || ComboBox_Marca.Text == "" || ComboBox_Estilo.Text == "" || TPrecio.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            TId_prod.Text = "";
            ComnboBox_Anteojo.Text = "";
            ComboBox_Marca.Text = "";
            ComboBox_Estilo.Text = "";
            TPrecio.Text = "";
        }

        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Modif_producto_Load(object sender, EventArgs e)
        {
            CProducto verProductos = new CProducto();
            verProductos.verProductos(DGVProductos);
        }
    }
}

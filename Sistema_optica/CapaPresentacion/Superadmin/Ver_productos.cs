using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Capa_datos;
using CapaPresentacion.Entidades_Clases;
using CapaPresentacion.Secretaria;

namespace CapaPresentacion.Superadmin
{
    public partial class Ver_productos : Form
    {
        public Ver_productos()
        {
            InitializeComponent();
        }

        private void BVerRegistros_Click(object sender, EventArgs e)
        {
            CProducto verProductos = new CProducto();
            verProductos.verProductos(DGV_ListaProd);
        }

        private void DGV_ListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            Modif_producto modificacionProd = new Modif_producto();
            modificacionProd.Show();
            this.Hide();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (DGV_ListaProd.SelectedRows.Count == 1)
            {
                CProducto bajaProducto = new CProducto();
                bajaProducto.bajaProducto(DGV_ListaProd);
            }
            else
            {
                MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BHabilitar_Click(object sender, EventArgs e)
        {
            if (DGV_ListaProd.SelectedRows.Count == 1)
            {
                CProducto rehabilitarProducto = new CProducto();
                rehabilitarProducto.restaurarProd(DGV_ListaProd);
            }
            else
            {
                MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

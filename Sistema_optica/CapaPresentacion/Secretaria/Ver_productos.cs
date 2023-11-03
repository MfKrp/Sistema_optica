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

namespace CapaPresentacion.Secretaria
{
    public partial class Ver_productos : Form
    {
        public Ver_productos()
        {
            InitializeComponent();
        }

        private void BVerProductos_Click(object sender, EventArgs e)
        {
            //Se listan los productos disponibles
            CProducto verProductos = new CProducto();
            verProductos.verProductos(DGV_ListaProd);
        }

        private void DGV_ListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            Modif_producto formModifProd = new Modif_producto();
            formModifProd.Show();
            this.Hide();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {

        }
    }
}

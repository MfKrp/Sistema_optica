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

namespace CapaPresentacion.Vendedor
{
    public partial class Ver_productos : Form
    {
        public Ver_productos()
        {
            InitializeComponent();
        }

        private void BVerProductos_Click(object sender, EventArgs e)
        {
            CProducto verProducto = new CProducto();
            verProducto.verProductos(DGV_ListaProd);
        }

        private void DGV_ListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

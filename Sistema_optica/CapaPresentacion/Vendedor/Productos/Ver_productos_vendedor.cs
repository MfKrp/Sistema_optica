using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor.Productos
{
    public partial class Ver_productos_vendedor : Form
    {
        public Ver_productos_vendedor()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            PVerProductos.BackColor = TemaColor.PrimaryColor;
            DTGListaProductos.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void DTGListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_productos_vendedor_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void PVerProductos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
using Microsoft.Windows.Themes;

namespace CapaPresentacion.Superadmin.Productos
{
    public partial class Ver_productosSuperAdmin : Form
    {
        public Ver_productosSuperAdmin()
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

        private void PVerProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ver_productosSuperAdmin_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        
    }
}

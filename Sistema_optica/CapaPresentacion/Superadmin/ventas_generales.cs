using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Entidades_Clases;

namespace CapaPresentacion.Superadmin
{
    public partial class ventas_generales : Form
    {
        public ventas_generales()
        {
            InitializeComponent();
        }

        private void DGVListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ventas_generales_Load(object sender, EventArgs e)
        {
            CFactura verVentas = new CFactura();
            verVentas.verFacturasGenerales(DGVListaVentas);

            CDetalle verDetalles = new CDetalle();
            verDetalles.verDetalles(DGVentasDetalles);
        }

        private void DGVentasDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

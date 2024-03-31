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

        public void LoadTheme ()
        {
            PTituloVentas.BackColor = TemaColor.PrimaryColor;
            DGVListaVentas.BackgroundColor = TemaColor.SecondaryColor;
            DGVentasDetalles.BackgroundColor = TemaColor.TertiaryColor;
        }

        private void DGVListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ventas_generales_Load(object sender, EventArgs e)
        {
            //Se carga la parte visual del formulario
            LoadTheme();

            CCabecera verVentas = new CCabecera();
            verVentas.verFacturasGenerales(DGVListaVentas);

            CDetalle verDetalles = new CDetalle();
            verDetalles.verDetalles(DGVentasDetalles);
        }

        private void DGVentasDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

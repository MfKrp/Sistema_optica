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

namespace CapaPresentacion.Vendedor
{
    public partial class Ver_ventas : Form
    {
        CEmpleado empleadoLogueado = new CEmpleado();

        public Ver_ventas(CEmpleado empleadoQueSeLoguea)
        {
            InitializeComponent();
            empleadoLogueado = empleadoQueSeLoguea;
        }

        public void LoadTheme()
        {
            PVentasRealizadas.BackColor = TemaColor.PrimaryColor;
            DTGVentasPersonales.BackgroundColor = TemaColor.SecondaryColor;
            IBVerDetalle.BackColor = TemaColor.TertiaryColor;
        }

        private void Ver_ventas_Load(object sender, EventArgs e)
        {
            /*CCabecera verVentasRealizadas = new CCabecera();
            verVentasRealizadas.verFacturasPersonales(DTGVentasPersonales, empleadoLogueado.id_empleado);*/
            LoadTheme();
        }

        private void DTGDatosCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PVentasRealizadas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IBVerDetalle_Click(object sender, EventArgs e)
        {

        }
    }
}

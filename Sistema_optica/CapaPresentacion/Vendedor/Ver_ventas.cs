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

        private void Ver_ventas_Load(object sender, EventArgs e)
        {
            CFactura verVentasRealizadas = new CFactura();
            verVentasRealizadas.verFacturasPersonales(DTGDatosCompra, empleadoLogueado.id_empleado);
        }

        private void DTGDatosCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

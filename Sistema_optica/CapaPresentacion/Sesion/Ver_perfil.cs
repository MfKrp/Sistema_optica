using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaPresentacion.Entidades_Clases;

namespace CapaPresentacion.Inicio_sesion
{
    public partial class Ver_perfil : Form
    {
        CEmpleado empleadoLogueado = new CEmpleado();

        public Ver_perfil(CEmpleado empleadoQueSeLoguea)
        {
            InitializeComponent();
        }

        private void Ver_perfil_Load(object sender, EventArgs e)
        {

        }
    }
}

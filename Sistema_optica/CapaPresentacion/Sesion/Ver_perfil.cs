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
            empleadoLogueado = empleadoQueSeLoguea;
        }

        private void Ver_perfil_Load(object sender, EventArgs e)
        {
            TNombre.Text = empleadoLogueado.nombreEmpleado;
            TApellido.Text = empleadoLogueado.apellidoEmpleado;
            TTelefono.Text = empleadoLogueado.telEmpleado;
            TEmail.Text = empleadoLogueado.emailEmpleado;
            TFecha.Text = empleadoLogueado.fechaEmpleado;
            TDni.Text = empleadoLogueado.dniEmpleado;
            TDireccion.Text = empleadoLogueado.direccionEmpleado;
            switch (empleadoLogueado.idPerfilEmpleado)
            {
                case 1:
                    TRol.Text = "Secretaria";
                    break;

                case 2:
                    TRol.Text = "Superadmin";
                    break;

                case 3:
                    TRol.Text = "Vendedor";
                    break;
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TRol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

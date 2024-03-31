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
using FontAwesome.Sharp;

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
            LoadTheme();
            LNombreEmpleadoValor.Text = empleadoLogueado.NombreEmp;
            LApellidoEmpleado.Text = empleadoLogueado.ApellidoEmp;
            LTelefonoEmpValor.Text = empleadoLogueado.TelefonoEmp;
            LEmailEmpValor.Text = empleadoLogueado.EmailEmp;
            LFechaEmpValor.Text = empleadoLogueado.FechaNacimientoEmp.ToString();
            LDniValor.Text = empleadoLogueado.DniEmp;
            LDireccionEmpValor.Text = empleadoLogueado.DireccionEmp;
            //Cambiar este tipo de codigo por otro en el que se extraiga directamente la descripcion del rol de empleado y se coloque dentro de este texto
            switch (empleadoLogueado.IdPerfilEmpleado)
            {
                case 1:
                    LRolEmpValor.Text = "Secretaria";
                    break;

                case 2:
                    LRolEmpValor.Text = "Superadmin";
                    break;

                case 3:
                    LRolEmpValor.Text = "Vendedor";
                    break;
            }
        }

        private void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
            panel2.BackColor = TemaColor.SecondaryColor;
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

        private void LNombreEmpleadoValor_Click(object sender, EventArgs e)
        {

        }

        private void LApellidoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void LTelefonoEmpValor_Click(object sender, EventArgs e)
        {

        }

        private void LEmailEmpValor_Click(object sender, EventArgs e)
        {

        }

        private void LFechaEmpValor_Click(object sender, EventArgs e)
        {

        }

        private void LDniValor_Click(object sender, EventArgs e)
        {

        }

        private void LDireccionEmpValor_Click(object sender, EventArgs e)
        {

        }

        private void LRolEmpValor_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

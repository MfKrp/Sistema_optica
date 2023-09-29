using CapaPresentacion.Secretaria;
using CapaPresentacion.Superadmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Sesion
{
    public partial class Iniciar_sesion : Form
    {
        public Iniciar_sesion()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TCodigo_empleado_sesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TContraseña_sesion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TContraseña_sesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            /*cuando el formulario se cierre, se reinician los campos*/
            TCodigo_empleado_sesion.Text = "";
            TContraseña_sesion.Text = "";

            this.Show();
        }

        private void BIngresar_Click_1(object sender, EventArgs e)
        {
            /*Falta hacer las comprobaciones restantes para iniciar menus diferentes en base al perfil de
             usuario*/

            Menu_Secretaria form = new Menu_Secretaria();

            form.Show();
            this.Hide(); //se esconde el logueo

            form.FormClosing += frm_closing; /*cuando se cierra el formulario, se activa el manejador frm_closing
                                              que vuelve a mostrar inicio_sesion*/
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            //cuando se haga click en este boton, se cerrara el formulario
            this.Close();
        }
    }
}

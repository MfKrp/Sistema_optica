using CapaPresentacion.Sesion;
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

namespace CapaPresentacion.Secretaria
{
    public partial class Menu_Secretaria : Form
    {
        private static Form formActivo = null;

        public Menu_Secretaria()
        {
            InitializeComponent();
        }

    
    private void abrirForm(ToolStripMenuItem menu, Form formulario)
        {


            if (formActivo != null)
            {
                formActivo.Close();

            }

            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void TSMItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_producto());
        }

        private void TSMBVerClientes_Click(object sender, EventArgs e)
        {

        }

        private void TSMBVerProductos_Click(object sender, EventArgs e)
        {

        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            /*cuando el formulario se cierre, se reinician los campos*/
            /*TCodigo_empleado_sesion.Text = "";
            TContraseña_sesion.Text = "";

            this.Show();*/
        }


        private void TSMBCerrarSesion_Click(object sender, EventArgs e)
        {
         
        }

        private void TSMBVerPerfil_Click(object sender, EventArgs e)
        {

        }

        private void TSMIProductos_Click(object sender, EventArgs e)
        {

        }

        private void TSMICargarProducto_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_producto());
        }

        private void TSMIVerProductos_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_productos());
        }

        private void TSMIVerClientes_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_clientes());
        }

        private void TSMBVerPerfil_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MSBCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //Close();
                Iniciar_sesion form = new Iniciar_sesion();

                form.Show();
                this.Hide(); //se esconde el logueo

                // form.FormClosing += frm_closing;
            }
        }
    }
}

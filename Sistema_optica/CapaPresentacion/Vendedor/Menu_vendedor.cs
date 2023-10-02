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

namespace CapaPresentacion.Vendedor
{
    public partial class Menu_vendedor : Form
    {
        private static ToolStripMenuItem menuActivo = null;
        private static Form formActivo = null;
        public Menu_vendedor()
        {
            InitializeComponent();
        }

        private void abrirForm(ToolStripMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.Teal;
            }
            menu.BackColor = Color.Red;

            menuActivo = menu;

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
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_venta());
        }

        private void TSMBRegistrarCliente_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_cliente());
        }

        private void TSMBVerProductos_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_productos());
        }

        private void TSMBVerVentas_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_ventas());
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
            Iniciar_sesion form = new Iniciar_sesion();

            form.Show();
            this.Hide(); //se esconde el logueo

            // form.FormClosing += frm_closing;
        }
    }
}

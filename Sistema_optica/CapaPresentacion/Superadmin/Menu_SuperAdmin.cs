using CapaPresentacion.Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Superadmin
{
    public partial class Menu_SuperAdmin : Form
    {
        private static ToolStripMenuItem menuActivo = null;
        private static Form formActivo = null;
        public Menu_SuperAdmin()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_empleados());
        }
        private void abrirForm(ToolStripMenuItem menu, Form formulario)
        {

            menu.BackColor = Color.Teal;

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
        private void TSMRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Carga_empleado());
        }

        private void TSMBVerProductos_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_productos());
        }

        private void Menu_SuperAdmin_Load(object sender, EventArgs e)
        {

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            /*cuando el formulario se cierre, se reinician los campos*/
            /*TCodigo_empleado_sesion.Text = "";
            TContraseña_sesion.Text = "";

            this.Show();*/
        }
        private void MSBCerrarSesion_Click(object sender, EventArgs e)
        {
            Iniciar_sesion form = new Iniciar_sesion();

            form.Show();
            this.Hide(); //se esconde el logueo

           // form.FormClosing += frm_closing;
        }
    }
}

using CapaPresentacion.Entidades_Clases;
using CapaPresentacion.Inicio_sesion;
using CapaPresentacion.Sesion;
using CapaPresentacion.Secretaria;
using CapaPresentacion.Secretaria.Obra_social;
using CapaPresentacion.Secretaria.Forma;
using CapaPresentacion.Secretaria.Estilos;
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
        private static ToolStripMenuItem menuActivo = null;
        private static Form formActivo = null;
        CEmpleado empleadoLogueado = new CEmpleado();

        public Menu_Secretaria(CEmpleado usuarioActual)
        {
            InitializeComponent();
            empleadoLogueado = usuarioActual;
            //Inicializar el formulario en pantalla completa
            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            LEmpleadoLogueado.Text = "Bienvenido " + empleadoLogueado.NombreEmp + " " + empleadoLogueado.ApellidoEmp + "\nRol de Usuario: ";
            switch (empleadoLogueado.IdPerfilEmpleado)
            {
                case 1:
                    LEmpleadoLogueado.Text += "Secretario";
                    break;

                case 2:
                    LEmpleadoLogueado.Text += "SuperAdmin";
                    break;

                case 3:
                    LEmpleadoLogueado.Text += "Vendedor";
                    break;
            }
        }

        private void abrirForm(ToolStripMenuItem menu, Form formulario)
        {

            if (formActivo != null)
            {
                formActivo.Close();

            }

            formActivo = formulario;
            formulario.TopLevel = false;
            contenedor.Controls.Add(formulario);
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
           
            formulario.Show();
        }
        /*
        private void TSMItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_producto());
        }
        */
        /*
        private void TSMBVerClientes_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_clientes());
        }
        */
        /*
        private void TSMBVerProductos_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_productos());
        }
        */
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            /*cuando el formulario se cierre, se reinician los campos*/
            /*TCodigo_empleado_sesion.Text = "";
            TContraseña_sesion.Text = "";

            this.Show();*/
        }

        /*
        private void TSMBCerrarSesion_Click(object sender, EventArgs e)
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
        */
        /*
        private void TSMBVerPerfil_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_perfil(empleadoLogueado));
        }
        */
        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MSIAltaProducto_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_productoTerapeutico());
        }

        private void MSIVerClientes_Click(object sender, EventArgs e)
        {
            //abrirForm((ToolStripMenuItem)sender, new Ver_clientes());
        }

        private void MSIVerProductos_Click(object sender, EventArgs e)
        {
            //abrirForm((ToolStripMenuItem)sender, new Ver_productos());
        }

        private void MSIVerPerfil_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_perfil(empleadoLogueado));
        }

        private void MSICerrarSesion_Click(object sender, EventArgs e)
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



        /*Gestor de Clientes*/

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_clientes());
        }

        private void obrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_obras_sociales());
        }

        /*Gestor de Productos*/

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_productosSuper());
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_marcas());
        }

        private void formasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_formas());
        }

        private void estilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_estilos());
        }

        private void cristalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_cristales());
        }

        private void LEmpleadoLogueado_Click(object sender, EventArgs e)
        {

        }

        private void PTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

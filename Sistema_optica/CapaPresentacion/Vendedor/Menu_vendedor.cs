using CapaPresentacion.Sesion;
using CapaPresentacion.Inicio_sesion;
using CapaPresentacion.Superadmin;
using CapaPresentacion.Secretaria;
using CapaPresentacion.Vendedor.Productos;
using CapaPresentacion.Vendedor.Ventas;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Entidades_Clases;

namespace CapaPresentacion.Vendedor
{
    public partial class Menu_vendedor : Form
    {
        private static ToolStripMenuItem menuActivo = null;
        private static Form formActivo = null;

        //String usado para conectarse en Netbook
        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        //Coenxion usada para conectarse en escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        CEmpleado empleadoLogueado = new CEmpleado();

        public Menu_vendedor(CEmpleado empleadoQueSeLoguea)
        {
            InitializeComponent();
            empleadoLogueado = empleadoQueSeLoguea;
            //Inicializa el menu en pantalla completa
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
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        /*
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_venta(empleadoLogueado));
        }
        */
        /*
        private void TSMBRegistrarCliente_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_cliente());
        }
        */
        /*
        private void TSMBVerProductos_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Secretaria.Ver_productos());
        }
        */
        /*
        private void TSMBVerVentas_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_ventas(empleadoLogueado));
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

        private void Menu_vendedor_Load(object sender, EventArgs e)
        {

        }

        /*
        private void TSMBVerPerfil_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_perfil(empleadoLogueado));
        }
        */

        private void LBienvenido_Click(object sender, EventArgs e)
        {
            LEmpleadoLogueado.Text = "Bienvenido: " + empleadoLogueado.NombreEmp + "!";
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /*
        private void TSMBVer_Clientes_Click(object sender, EventArgs e)
        {

            abrirForm((ToolStripMenuItem)sender, new Ver_clientes());
        }
        */
        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IMVerPerfil_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_perfil(empleadoLogueado));
        }

        private void MSIAltaCliente_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_cliente());
        }

        private void MSIVerClientes_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_clientes());
        }

        private void MSIAltaVenta_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_venta(empleadoLogueado));
        }

        private void MSIVerVentas_Click(object sender, EventArgs e)
        {
            //Aca se ven las ventas personales de cada vendedor
            abrirForm((ToolStripMenuItem)sender, new Ver_ventas(empleadoLogueado));
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

        private void MSIVerProductos_Click(object sender, EventArgs e)
        {

        }

        //Gestor de Clientes

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificacionDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*Gestor de Productos*/

        private void altaAnteojoTerapeuticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_anteojoTerapeutico());
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_productos_vendedor());
        }

        /*Gestor de Ventas*/

        private void realizarVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_productoTerapeutico());
        }

        private void verVentasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_ventas(empleadoLogueado));
        }

        private void PTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LEmpleadoLogueado_Click(object sender, EventArgs e)
        {

        }
    }
}

using CapaPresentacion.Sesion;
using CapaPresentacion.Inicio_sesion;
using CapaPresentacion.Superadmin;
using CapaPresentacion.Secretaria;
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
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_venta(empleadoLogueado));
        }

        private void TSMBRegistrarCliente_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Alta_cliente());
        }

        private void TSMBVerProductos_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Secretaria.Ver_productos());
        }

        private void TSMBVerVentas_Click(object sender, EventArgs e)
        {
            abrirForm((ToolStripMenuItem)sender, new Ver_ventas(empleadoLogueado));
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

        private void Menu_vendedor_Load(object sender, EventArgs e)
        {

        }

        private void TSMBVerPerfil_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Ver_perfil verPerfil = new Ver_perfil(empleadoLogueado);
            verPerfil.Show();
        }

        private void LBienvenido_Click(object sender, EventArgs e)
        {
            LBienvenido.Text = "Bienvenido: " + empleadoLogueado.nombreEmpleado + "!";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TSMBVer_Clientes_Click(object sender, EventArgs e)
        {

            abrirForm((ToolStripMenuItem)sender, new Ver_clientes());
        }
    }
}

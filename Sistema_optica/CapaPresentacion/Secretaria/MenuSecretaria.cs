using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Entidades_Clases;
using CapaPresentacion.Inicio_sesion;
using CapaPresentacion.Sesion;
using FontAwesome.Sharp;

namespace CapaPresentacion.Secretaria
{
    public partial class MenuSecretaria : Form
    {
        //Inicializaciones

        private CEmpleado empleadoLogueado;

        //Campos
        private IconButton botonActual;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public MenuSecretaria(CEmpleado empleadoQueSeLoguea)
        {
            InitializeComponent();
            random = new Random();
            empleadoLogueado = empleadoQueSeLoguea;
            BCerrarForm.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metodos
        private Color SeleccionarColorTema()
        {
            int index = random.Next(TemaColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(TemaColor.ColorList.Count);
            }
            tempIndex = index;
            string color = TemaColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (botonActual != (IconButton)btnSender)
                {
                    DisableButton();
                    Color color = SeleccionarColorTema();
                    botonActual = (IconButton)btnSender;
                    botonActual.BackColor = color;
                    botonActual.ForeColor = Color.White;
                    botonActual.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    PanelTitle.BackColor = color;
                    PanelLogo.BackColor = TemaColor.ChangeColorBrightness(color, -0.3);
                    PanelMenuSecretaria.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BProductos.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BClientes.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BVerPerfil.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BCerrarSesion.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    TemaColor.PrimaryColor = color;
                    TemaColor.SecondaryColor = TemaColor.ChangeColorBrightness(color, -0.3);
                    TemaColor.TertiaryColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BCerrarForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenuSecretaria.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(75, 0, 130);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PaneContainer.Controls.Add(childForm);
            this.PaneContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LTitle.Text = childForm.Text;
        }

        //Metodos de componentes

        private void BProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_productosSuper(), sender);
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_clientes(), sender);
        }

        private void BVerPerfil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_perfil(empleadoLogueado), sender);
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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

        private void PaneContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BCerrarForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            LTitle.Text = "HOME";
            PanelTitle.BackColor = Color.FromArgb(119, 0, 207);
            PanelLogo.BackColor = Color.FromArgb(148, 0, 211);
            PanelMenuSecretaria.BackColor = Color.FromArgb(75, 0, 130);
            BProductos.BackColor = Color.FromArgb(75, 0, 130);
            BClientes.BackColor = Color.FromArgb(75, 0, 130);
            BVerPerfil.BackColor = Color.FromArgb(75, 0, 130);
            BCerrarSesion.BackColor = Color.FromArgb(75, 0, 130);
            botonActual = null;
            BCerrarForm.Visible = false;
        }

        private void LEmpLog_Click(object sender, EventArgs e)
        {

        }

        private void MenuSecretaria_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LEmpLog.Text = "Bienvenido " + empleadoLogueado.NombreEmp + " " + empleadoLogueado.ApellidoEmp + "\nRol de Empleado: ";
            switch (empleadoLogueado.IdPerfilEmpleado)
            {
                case 1:
                    LEmpLog.Text += "Secretario";
                    break;
                case 2:
                    LEmpLog.Text += "Superadministrador";
                    break;
                case 3:
                    LEmpLog.Text += "Vendedor";
                    break;
            }
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BMaximate_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelMenuSecretaria_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

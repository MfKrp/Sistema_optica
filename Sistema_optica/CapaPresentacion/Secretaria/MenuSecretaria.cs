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
using CapaPresentacion.Secretaria.Forma;
using FontAwesome.Sharp;
using CapaPresentacion.Secretaria.Estilos;
using CapaPresentacion.Secretaria.Obra_social;
using System.Windows.Media;
using System.Runtime.CompilerServices;
using Krypton.Navigator;
using CapaPresentacion.Superadmin.Productos;
using CapaPresentacion.Secretaria.Marcas;
using CapaPresentacion.Secretaria.Cristales;

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
            this.hideMenu();
            this.hideInternalMenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Metodos
        private System.Drawing.Color SeleccionarColorTema()
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
                    System.Drawing.Color color = SeleccionarColorTema();
                    botonActual = (IconButton)btnSender;
                    botonActual.BackColor = color;
                    botonActual.ForeColor = System.Drawing.Color.White;
                    botonActual.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    PanelTitle.BackColor = color;
                    PanelLogo.BackColor = TemaColor.ChangeColorBrightness(color, -0.3);
                    PanelMenuSecretaria.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BProductos.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BClientes.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BVerPerfil.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    BCerrarSesion.BackColor = TemaColor.ChangeColorBrightness(color, -0.6);

                    PIBAnteojos.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);
                    PIBMarcasAnteojos.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);
                    PIBFormasAnteojos.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);
                    PIBEstilosAnteojos.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);
                    PICBCristales.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);
                    PICBObrasSociales.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);

                    PIBVerClientes.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);
                    PIBModifClientes.BackColor = TemaColor.ChangeColorBrightness(color, -0.8);

                    //subpaneles
                    //subpanel cristales
                    PSPCristales.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBAgregarCristal.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBModificarCristal.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBVerCristales.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);

                    //subpanel estilos
                    PSPEstilos.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBAgregarEstilos.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBModificarEstilo.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBVerEstilos.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);

                    //subpanel formas
                    PSPFormas.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBAgregarForma.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBModificarForma.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBVerFormas.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);

                    //subpanel marcas
                    PSPMarcas.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBAgregarMarca.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBModificarMarca.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBVerMarcas.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);

                    //subpanel obras sociales
                    PSPObrasSociales.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBAgregarObraSocial.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBModificarObraSocial.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBVerObrasSociales.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);

                    //subpanel anteojos
                    PSPAnteojos.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBAltaAccesorio.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBAltaTerapeutico.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBModificarAnteojo.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);
                    SPIBVerAnteojos.BackColor = TemaColor.ChangeColorBrightness(color, -0.12);

                    TemaColor.PrimaryColor = color;
                    TemaColor.SecondaryColor = TemaColor.ChangeColorBrightness(color, -0.3);
                    TemaColor.TertiaryColor = TemaColor.ChangeColorBrightness(color, -0.6);
                    TemaColor.QuaternaryColor = TemaColor.ChangeColorBrightness(color, -0.12);
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
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                    previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
            foreach (Control previousBtn in PanelGestorProductos.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
            foreach (Control previousBtn in PGestorClientes.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
            //subpaneles
            foreach (Control previousBtn in PSPCristales.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
            foreach (Control previousBtn in PSPEstilos.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
            foreach (Control previousBtn in PSPFormas.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
            foreach (Control previousBtn in PSPMarcas.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
            foreach (Control previousBtn in PSPObrasSociales.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            }
            foreach (Control previousBtn in PSPAnteojos.Controls)
            {
                previousBtn.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
                previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            //OpenChildForm(new Ver_productosSuper(), sender);
            showSubMenu(PanelGestorProductos);
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Ver_clientes(), sender);
            showSubMenu(PGestorClientes);
        }

        private void BVerPerfil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_perfil(empleadoLogueado), sender);
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            /*if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();*/
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
            PanelTitle.BackColor = System.Drawing.Color.FromArgb(119, 0, 207);
            PanelLogo.BackColor = System.Drawing.Color.FromArgb(148, 0, 211);
            PanelMenuSecretaria.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            BProductos.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            BClientes.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            BVerPerfil.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);
            BCerrarSesion.BackColor = System.Drawing.Color.FromArgb(75, 0, 130);

            PIBAnteojos.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);
            PIBMarcasAnteojos.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);
            PIBFormasAnteojos.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);
            PIBEstilosAnteojos.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);
            PICBCristales.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);
            PICBObrasSociales.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);

            PIBVerClientes.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);
            PIBModifClientes.BackColor = System.Drawing.Color.FromArgb(30, 0, 50);

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

        private void CBVistaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Botones de submenu

        //funcion que oculta los submenus
        private void hideMenu()
        {
            PanelGestorProductos.Visible = false;
            PGestorClientes.Visible = false;

            //Subpaneles
            /*PSPCristales.Visible = false;
            PSPEstilos.Visible = false;
            PSPFormas.Visible = false;
            PSPMarcas.Visible = false;
            PSPObrasSociales.Visible = false;
            PSPAnteojos.Visible = false;*/

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void hideInternalMenu()
        {
            //Subpaneles
            PSPCristales.Visible = false;
            PSPEstilos.Visible = false;
            PSPFormas.Visible = false;
            PSPMarcas.Visible = false;
            PSPObrasSociales.Visible = false;
            PSPAnteojos.Visible = false;
        }

        private void showInternalMenu(Panel internalMenu)
        {
            if (internalMenu.Visible == false)
            {
                hideInternalMenu();
                internalMenu.Visible = true;
            }
            else
            {
                internalMenu.Visible = false;
            }
        }

        //Panel gestor de productos

        private void BProductos_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void PIBAnteojos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Ver_productosSuper(), sender);
            showInternalMenu(PSPAnteojos);
        }

        private void PIBCristales_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Ver_cristales(), sender);
            showSubMenu(PSPCristales);
        }

        private void PIBObrasSociales_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Ver_obras_sociales(), sender);
            showSubMenu(PSPObrasSociales);
        }

        private void PanelGestorProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        //Panel gestor de clientes

        private void PGestorClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PIBModifClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modif_ClienteVendedor(), sender); //Enrealidad la modificacion es modificacion de cliente secretaria pero hubieron problemas para cambiar el nombre y que no se rompa la aplicacion
        }

        private void PIBVerClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_clientes(), sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        //Panel gestion de anteojos

        private void PSPAnteojos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SPIBAltaAccesorio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alta_productoAccesorio(), sender);
        }

        private void SPIBAltaTerapeutico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alta_productoTerapeutico(), sender);
        }

        private void SPIBModificarAnteojo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modif_producto(), sender);
        }

        private void SPIBVerAnteojos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_productosSuper(), sender);
        }

        //Panel gestion de marcas
        private void PIBMarcasAnteojos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Ver_marcas(), sender);
            showInternalMenu(PSPMarcas);
        }

        private void SPIBAgregarMarca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alta_marca(), sender);
        }

        private void SPIBModificarMarca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modif_marca(), sender);
        }

        private void SPIBVerMarcas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_marcas(), sender);
        }

        //Panel gestion de formas

        private void PIBFormasAnteojos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Ver_formas(), sender);
            showInternalMenu(PSPFormas);
        }

        private void SPIBAgregarForma_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alta_forma(), sender);
        }

        private void SPIBModificarForma_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modif_forma(), sender);
        }

        private void SPIBVerFormas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_formas(), sender);
        }

        //Panel gestion de estilos

        private void PIBEstilosAnteojos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Ver_estilos(), sender);
            showInternalMenu(PSPEstilos);
        }

        private void SPIBAgregarEstilos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alta_estilo(), sender);
        }

        private void SPIBModificarEstilo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modif_estilo(), sender);
        }

        private void SPIBVerEstilos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_estilos(), sender);
        }

        //Panel gestion de cristales

        private void PICBCristales_Click(object sender, EventArgs e)
        {
            showInternalMenu(PSPCristales);
        }

        private void SPIBAgregarCristal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alta_cristal(), sender);
        }

        private void SPIBModificarCristal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modif_cristal(), sender);
        }

        private void SPIBVerCristales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_cristales(), sender);
        }

        //Panel gestion obras sociales

        private void PICBObrasSociales_Click(object sender, EventArgs e)
        {
            showInternalMenu(PSPObrasSociales);
        }

        private void SPIBAgregarObraSocial_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alta_obra_social(), sender);
        }

        private void SPIBModificarObraSocial_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Modif_obra_social(), sender);
        }

        private void SPIBVerObrasSociales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ver_obras_sociales(), sender);
        }
    }
}

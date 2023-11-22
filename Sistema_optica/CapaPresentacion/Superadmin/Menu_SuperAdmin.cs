using CapaPresentacion.Sesion;
using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Inicio_sesion;

namespace CapaPresentacion.Superadmin
{
    public partial class Menu_SuperAdmin : Form
    {
        private static ToolStripMenuItem menuActivo = null;
        private static Form formActivo = null;

        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        CEmpleado empleadoLogueado = new CEmpleado();

        public Menu_SuperAdmin(CEmpleado empleadoQueIngresa)
        {
            InitializeComponent();
            empleadoLogueado = empleadoQueIngresa;
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

        private void TSMBVerPerfil_Click(object sender, EventArgs e)
        {
            Ver_perfil verPerfil = new Ver_perfil(empleadoLogueado);
            verPerfil.Show();
        }

        private void MSSuperAdmin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TSMBBackupBD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStringEscritorio);

            //Fecha que tendra la copia de seguridad
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" +
                System.DateTime.Today.Month.ToString() + "-" +
                System.DateTime.Today.Year.ToString() + "-" +
                System.DateTime.Now.Hour.ToString() + "-" +
                System.DateTime.Now.Minute.ToString() + "-" +
                System.DateTime.Now.Second.ToString() + " OpticaMaribel");

            string queryBackup = "BACKUP DATABASE [OpticaMaribel] TO  DISK = N'C:\\Backups_bdd\\" + nombre_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'OpticaMaribel-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand comandoBackup = new SqlCommand(queryBackup, con);

            try
            {
                con.Open();
                comandoBackup.ExecuteNonQuery();
                MessageBox.Show("La copia de seguridad se ha creado correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si quiere volver a realizar una copia de seguridad, espere un momento y vuelva a presionar el boton");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void TSMButtonRestoreBD_Click(object sender, EventArgs e)
        {
            //Boton que realiza el restore de la base de datos

            string queryRestore = "BACKUP LOG [OpticaMaribel] TO  DISK = N'G:\\Program Files (x86)\\MSSQL16.MSSQLSERVER\\MSSQL\\Backup\\OpticaMaribel_LogBackup_2023-11-06_17-08-39.bak' WITH NOFORMAT, NOINIT,  NAME = N'OpticaMaribel_LogBackup_2023-11-06_17-08-39', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5 RESTORE DATABASE [OpticaMaribel] FROM  DISK = N'C:\\Backups_bdd\\6-11-2023-17-4-27 OpticaMaribel' WITH  FILE = 1,  NOUNLOAD,  STATS = 5";
        }

        private void TSVentas_Click(object sender, EventArgs e)
        {
            ventas_generales verVentas = new ventas_generales();
            verVentas.Show();
        }
    }
}

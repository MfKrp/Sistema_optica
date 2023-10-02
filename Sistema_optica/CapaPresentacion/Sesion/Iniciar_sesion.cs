using CapaPresentacion.Secretaria;
using CapaPresentacion.Superadmin;
using CapaPresentacion.Vendedor;
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

        private void TCodigo_empleado_sesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
            /*Condicional que filtra los usuarios y en base al codigo de perfil que tengan los empleados, lo que determina que pantallas se mostraran
            Codigos de empleado:
            1: Secretaria
            2: SuperAdmin
            3: Vendedor
            */

            /*
            switch (codigoEmpleado)
            {
                case 1:
                    Menu_Secretaria menuSecre = new Menu_Secretaria();
                    menuSecre.Show();
                    this.Hide(); //se esconde el logueo
                    menuSecre.FormClosing += frm_closing;
                    break;
                case 2:
                    Menu_SuperAdmin menuAdmin = new Menu_SuperAdmin();
                    menuAdmin.Show();
                    this.Hide(); //se esconde el 
                    menuAdmin.FormClosing += frm_closing;
                    break;
                case 3:
                    Menu_vendedor menuVend = new Menu_vendedor();
                    menuVend.Show();
                    this.Hide(); //se esconde el 
                    menuVend.FormClosing += frm_closing;
                    break;
            }
            */

            /*Prueba para recuperar los datos de la base, de la tabla tipo_perfil*/

            //Conexion a la base
            /*
            string connectionString = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            //Consulta
            string querySelect = "SELECT * FROM Tipo_Perfil";
            SqlCommand comandoLectura = new SqlCommand(querySelect, con);
            SqlDataReader lectorDatos;
            lectorDatos = comandoLectura.ExecuteReader();

            if (lectorDatos.Read())
            {
                string Id_perfil = lectorDatos.GetValue(0).ToString();
                string descPerfil = lectorDatos.GetValue(1).ToString();
                MessageBox.Show("Datos rescatados: \nId de perfil: " + Id_perfil + "\nDescripcion: " + descPerfil); 
            }
            */
            if (TCodigo_empleado_sesion.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error");
            }
            else if (int.Parse(TCodigo_empleado_sesion.Text) > 3 || int.Parse(TCodigo_empleado_sesion.Text) < 1)
            {
                MessageBox.Show("Ingrese un numero entre 1 y 3", "Error, codigo invalido");
            }
            else
            {
                switch (int.Parse(TCodigo_empleado_sesion.Text))
                {
                    case 1:
                        Menu_Secretaria menuSecre = new Menu_Secretaria();
                        menuSecre.Show();
                        this.Hide(); //se esconde el logueo
                        menuSecre.FormClosing += frm_closing;
                        break;
                    case 2:
                        Menu_SuperAdmin menuAdmin = new Menu_SuperAdmin();
                        menuAdmin.Show();
                        this.Hide(); //se esconde el 
                        menuAdmin.FormClosing += frm_closing;
                        break;
                    case 3:
                        Menu_vendedor menuVend = new Menu_vendedor();
                        menuVend.Show();
                        this.Hide(); //se esconde el 
                        menuVend.FormClosing += frm_closing;
                        break;
                }
            }


            /*
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

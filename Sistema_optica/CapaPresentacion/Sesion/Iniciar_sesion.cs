using CapaPresentacion.Secretaria;
using CapaPresentacion.Superadmin;
using CapaPresentacion.Vendedor;
using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.SqlClient;

namespace CapaPresentacion.Sesion
{
    public partial class Iniciar_sesion : Form
    {
        //string usado para conectarse en netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse desde la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //String usado para conectarse en escritorio
        //ring connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        private CEmpleado empleadoLogueado = new CEmpleado();

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
            if (TCodigo_empleado_sesion.Text == "" || TContraseña_sesion.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error");
            }
            else
            {
                //MessageBox.Show(int.Parse(TCodigo_empleado_sesion.Text) + " " + TContraseña_sesion.Text);
                login(int.Parse(TCodigo_empleado_sesion.Text), "'" + TContraseña_sesion.Text.ToString() + "'");
            }
        }

        private void login(int codigoUsuario, string contrasena)
        {
            string queryObtencionUsuario = "SELECT * FROM Empleado WHERE IdEmpleado = " + codigoUsuario + " AND Contrasena = " + contrasena;
            using (SqlConnection conexion = new SqlConnection(connectionStringEscritorio))
            {
                SqlCommand obtencion = new SqlCommand(queryObtencionUsuario, conexion);
                obtencion.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                obtencion.Parameters.AddWithValue("@Contrasena", contrasena);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = obtencion.ExecuteReader();
                    if (reader.Read())
                    {
                        int id_empleado = reader.GetInt32(0);
                        string nombreUs = reader.GetString(1);
                        string apellidoEmp = reader.GetString(2);
                        string telEmp = reader.GetString(3);
                        string emailEmp = reader.GetString(4);
                        DateTime fechaEmp = reader.GetDateTime(5);
                        string dniEmp = reader.GetString(6);
                        string direccionEmp = reader.GetString(7);
                        int idPerfil = reader.GetInt32(10);
                        bool estEmp = reader.GetBoolean(8);
                        string pass = reader.GetString(9);

                        CEmpleado empleadoLogueado = new CEmpleado()
                        {
                            IdEmpleado = id_empleado,
                            NombreEmp = nombreUs,
                            ApellidoEmp = apellidoEmp,
                            TelefonoEmp = telEmp,
                            EmailEmp = emailEmp,
                            FechaNacimientoEmp = fechaEmp,
                            DniEmp = dniEmp,
                            DireccionEmp = direccionEmp,
                            IdPerfilEmpleado = idPerfil,
                            EstadoEmp = estEmp,
                            Contrasena = pass,
                        };

                        switch (empleadoLogueado.IdPerfilEmpleado)
                        {
                            case 1:
                                MenuSecretaria menuSecre = new MenuSecretaria(empleadoLogueado);
                                menuSecre.Show();
                                this.Hide(); //se esconde el logueo
                                menuSecre.FormClosing += frm_closing;
                                break;
                            case 2:
                                MenuSuperAdmin menuAdmin = new MenuSuperAdmin(empleadoLogueado);
                                menuAdmin.Show();
                                this.Hide(); //se esconde el 
                                menuAdmin.FormClosing += frm_closing;
                                break;
                            case 3:
                                MenuVendedor menuVend = new MenuVendedor(empleadoLogueado);
                                menuVend.Show();
                                this.Hide(); //se esconde el 
                                menuVend.FormClosing += frm_closing;
                                break;
                                //en caso de que sea 4 el codigo se creara uno nuevo que permita ver los reportes de los empleados
                                /*case 4:
                                    break;*/
                            }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no Encontrado, intentelo denuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Error de Base de Datos: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            //cuando se haga click en este boton, se cerrara el formulario y se cerrara la aplicacion
            this.Close();
            Application.Exit();
        }

        private void TContraseña_sesion_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Iniciar_sesion_Load(object sender, EventArgs e)
        {

        }
    }
}

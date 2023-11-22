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
        string connectionStringEscritorio = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
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
            int id_empleado = 0;
            string nombreUs = "";
            string apellidoEmp = "";
            string telEmp = "";
            string emailEmp = "";
            string fechaEmp = "";
            string dniEmp = "";
            string direccionEmp = "";
            int idPerfil = 0;
            bool estEmp = false;
            string pass = "";

            string queryObtencionUsuario = "SELECT * FROM UsuarioEmpleado WHERE ID_empleado = " + codigoUsuario + " AND Contrasena = " + contrasena;
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand obtencion = new SqlCommand(queryObtencionUsuario, conexion);

            try
            {
                SqlDataReader reader = obtencion.ExecuteReader();
                while (reader.Read())
                {
                    id_empleado = reader.GetInt32(0);
                    nombreUs = reader.GetString(1);
                    apellidoEmp = reader.GetString(2);
                    telEmp = reader.GetString(3);
                    emailEmp = reader.GetString(4);
                    fechaEmp = reader.GetString(5);
                    dniEmp = reader.GetString(6);
                    direccionEmp = reader.GetString(7);
                    idPerfil = reader.GetInt32(8);
                    estEmp = reader.GetBoolean(9);
                    pass = reader.GetString(10);
                }

                if (id_empleado == 0 || pass == "" || nombreUs == "")
                {
                    MessageBox.Show("Usuario no encontrado, intentelo denuevo", "Usuario no existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //MessageBox.Show("Usuario: " + nombreUs);
                    //se asignan las variables del logueo al objeto empleado
                    empleadoLogueado.id_empleado = id_empleado;
                    empleadoLogueado.nombreEmpleado = nombreUs;
                    empleadoLogueado.apellidoEmpleado = apellidoEmp;
                    empleadoLogueado.telEmpleado = telEmp;
                    empleadoLogueado.emailEmpleado = emailEmp;
                    empleadoLogueado.fechaEmpleado = fechaEmp;
                    empleadoLogueado.dniEmpleado = dniEmp;
                    empleadoLogueado.direccionEmpleado = direccionEmp;
                    empleadoLogueado.idPerfilEmpleado = idPerfil;
                    empleadoLogueado.estEmpleado = estEmp;
                    empleadoLogueado.passEmpleado = pass;

                    switch (empleadoLogueado.idPerfilEmpleado)
                    {
                        case 1:
                            Menu_Secretaria menuSecre = new Menu_Secretaria(empleadoLogueado);
                            menuSecre.Show();
                            this.Hide(); //se esconde el logueo
                            menuSecre.FormClosing += frm_closing;
                            break;
                        case 2:
                            Menu_SuperAdmin menuAdmin = new Menu_SuperAdmin(empleadoLogueado);
                            menuAdmin.Show();
                            this.Hide(); //se esconde el 
                            menuAdmin.FormClosing += frm_closing;
                            break;
                        case 3:
                            Menu_vendedor menuVend = new Menu_vendedor(empleadoLogueado);
                            menuVend.Show();
                            this.Hide(); //se esconde el 
                            menuVend.FormClosing += frm_closing;
                            break;
                            //en caso de que sea 4 el codigo se creara uno nuevo que permita ver los reportes de los empleados
                            /*case 4:
                                break;*/
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Ingrese un usuario valido" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            //cuando se haga click en este boton, se cerrara el formulario
            this.Close();
        }

        private void TContraseña_sesion_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Iniciar_sesion_Load(object sender, EventArgs e)
        {

        }
    }
}

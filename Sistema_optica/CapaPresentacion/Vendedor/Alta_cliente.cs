using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion.Vendedor
{
    public partial class Alta_cliente : Form
    {
        public Alta_cliente()
        {
            InitializeComponent();
        }

        private void TDniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //filtra que solo se puedan ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            /*comprobar que NINGUN campo este vacio*/
            if (TDni.Text == "" || TNombre.Text == "" || TApellido.Text == "" || TTelefono.Text == "" || TDireccion.Text == "" || TCorreo.Text == "")
            {
                MessageBox.Show("Complete todos los campos para continuar", "Faltan completar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Se capturan los valores
                int dni = Int32.Parse(TDni.Text);
                string nombre = TNombre.Text;
                string apellido = TApellido.Text;
                string telefono = TTelefono.Text;
                string direccion = TDireccion.Text;
                string correo = TCorreo.Text;
                bool estadoCliente = true;

                string stringConexion = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";
                SqlConnection con = new SqlConnection(stringConexion);

                string consulta = "INSERT INTO Cliente (DNI, Nombre, Apellido, Telefono, Direccion, Email, Estado_cliente) VALUES (@DNI, @Nombre, @Apellido, @Telefono, @Direccion, @Correo, @Estado_cliente)";
                SqlCommand comandoInsercion = new SqlCommand(consulta, con);

                comandoInsercion.Parameters.AddWithValue("@DNI", dni);
                comandoInsercion.Parameters.AddWithValue("@Nombre", nombre);
                comandoInsercion.Parameters.AddWithValue("@Apellido", apellido);
                comandoInsercion.Parameters.AddWithValue("@Telefono", telefono);
                comandoInsercion.Parameters.AddWithValue("@Direccion", direccion);
                comandoInsercion.Parameters.AddWithValue("@Correo", correo);
                comandoInsercion.Parameters.AddWithValue("@Estado_cliente", estadoCliente);

                try //try-catch
                {
                    con.Open();
                    comandoInsercion.ExecuteNonQuery();
                    MessageBox.Show("Registros cargados exitosamente");
                }
                catch (SqlException j)
                {
                    MessageBox.Show("Error generado.\nDetalles:" + j.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            /*Boton que al hacerle click resetea todos los campos a la normalidad*/
            TDni.Text = "";
            TNombre.Text = "";
            TApellido.Text = "";
            TTelefono.Text = "";
            TDireccion.Text = "";
            TCorreo.Text = "";
        }
    }
}

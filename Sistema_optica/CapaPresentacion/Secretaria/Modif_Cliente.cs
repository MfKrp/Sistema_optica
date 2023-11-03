using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections;
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
    public partial class Modif_Cliente : Form
    {
        public Modif_Cliente()
        {
            InitializeComponent();
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*codigo que hace que solo se puedan ingresar caracteres, en caso de que no funcione, verficar que en
             la propiedad keypress del campo, este asignada la funcion correspondiente*/
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTelefono_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*Codigo que solo restringe a que se ingresen numeros*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TCorreo_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDireccion_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*En caso de que no funcione, verificar que este asignada esta funcion al evento en la seccion propiedades*/
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TDni.Text == "" || TNombre.Text == "" || TApellido.Text == "" || TTelefono.Text == "" || TCorreo.Text == "" || TDireccion.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DGVClientes.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    /*Parametros de la funcion de modificacion
                     *  int dniCliente,
                        string nombreCliente,
                        string apellidoCliente,
                        string telefonoCliente,
                        string direccionCliente,
                        string emailCliente,
                        DataGridView datagridClientes
                     */
                    CCliente modificarCliente = new CCliente();
                    modificarCliente.modificarCliente(int.Parse(TDni.Text),
                        TNombre.Text,
                        TApellido.Text,
                        TTelefono.Text,
                        TDireccion.Text,
                        TCorreo.Text,
                        DGVClientes);
                }
                
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            TDni.Text = "";
            TNombre.Text = "";
            TApellido.Text = "";
            TTelefono.Text = "";
            TCorreo.Text = "";
            TDireccion.Text = "";
        }



        private void Modif_Cliente_Load(object sender, EventArgs e)
        {
            CCliente verCliente = new CCliente();
            verCliente.verClientes(DGVClientes);
        }

        private void DGVClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVClientes.SelectedRows[0];
            int dniCliente = (int)fila.Cells["DNI"].Value;
            float nombreCliente = (float)fila.Cells["Nombre"].Value;
            int apellidoCliente = (int)fila.Cells["Apellido"].Value;
            int telefonoCliente = (int)fila.Cells["Telefono"].Value;
            int emailCliente = (int)fila.Cells["Marca"].Value;

            TId_prod.Text = id_prod.ToString();
            TPrecio.Text = precProd.ToString();
            TStock.Text = stockProd.ToString();
            ComboBox_Estilo.Text = estiloProd.ToString();
            ComboBox_Marca.Text = marcaProd.ToString();
            ComnboBox_Anteojo.Text = tipoProd.ToString();
        }
    }
}

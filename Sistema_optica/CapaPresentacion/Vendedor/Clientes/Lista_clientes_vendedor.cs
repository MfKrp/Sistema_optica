using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaPresentacion.Capa_datos;
using CapaPresentacion.Entidades_Clases;
using CapaPresentacion;

namespace CapaPresentacion.Vendedor
{
    public partial class Lista_clientes_vendedor : Form
    {
        public CCliente clienteSeleccionado { get; set; }

        public Lista_clientes_vendedor()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            PListaClientes.BackColor = TemaColor.PrimaryColor;
            DTGListaClientes.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            int iFila = e.RowIndex;
            int eColumna = e.ColumnIndex;

            if (iFila >= 0 && iFila >= 0)
            {
                clienteSeleccionado = new CCliente()
                {
                    DniCliente = DTGListaClientes.Rows[iFila].Cells["DNI"].Value.ToString(),
                    NombreCliente = DTGListaClientes.Rows[iFila].Cells["Nombre"].Value.ToString(),
                    ApellidoCliente = DTGListaClientes.Rows[iFila].Cells["Apellido"].Value.ToString(),
                    TelefonoCliente = DTGListaClientes.Rows[iFila].Cells["Telefono"].Value.ToString(),
                    DireccionCliente = DTGListaClientes.Rows[iFila].Cells["Direccion"].Value.ToString(),
                    EmailCliente = DTGListaClientes.Rows[iFila].Cells["Email"].Value.ToString(),
                    Estado_cliente = Convert.ToBoolean(DTGListaClientes.Rows[iFila].Cells["Estado_cliente"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Lista_clientes_vendedor_Load(object sender, EventArgs e)
        {
            CCliente verClientes = new CCliente();
            verClientes.verClientes(DTGListaClientes);
            LoadTheme();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            //Filtro para buscar
            /*string columnaFiltro = comboBox1.SelectedItem.ToString();

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textBox1.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        cm.SuspendBinding();
                        row.Visible = false;
                    }
                }
            }*/

            MessageBox.Show("Funcion en desarrollo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void BBorrar_Click(object sender, EventArgs e)
        {
            /*
            textBox1.Text = "";
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
            */
            MessageBox.Show("Funcion en desarrollo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PListaClientes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

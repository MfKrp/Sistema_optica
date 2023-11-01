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
using CapaPresentacion.Entidades_Clases;
using CapaPresentacion.Secretaria;

namespace CapaPresentacion.Secretaria
{
    public partial class Ver_clientes : Form
    {
        //String que tiene la conexion al server
        string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public Ver_clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_clientes_Load(object sender, EventArgs e)
        {

        }

        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            //Cuando se presione este boton se mostraran los datos de la base de datos en la tabla
            CCliente verClientes = new CCliente();
            verClientes.verClientes(dataGridView1);

            /*
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Cliente", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            */
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            //Cuando se presione este boton se devolvera el estado de un cliente a activo en caso de estar inactivo
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //Pendiente verificar que el cliente no este habilitado antes de llevar acabo la restauracion
                CCliente restaurarCliente = new CCliente();
                restaurarCliente.restaurarCliente(dataGridView1);
            }
            else
            {
                MessageBox.Show("Seleecione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            //Cuando se presiones este boton se pasara el estado del cliente de activo a inactivo
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //Pendiente verificar que el cliente no este deshabilitado
                CCliente bajaCliente = new CCliente();
                bajaCliente.bajaCliente(dataGridView1);
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            //Cuando se presione este boton se invocara una pestaña de modificacion de clientes en la que se podran hacer cambios a los mismos
            Modif_Cliente pestanaModif = new Modif_Cliente();
            pestanaModif.Show();
            this.Hide();
        }
    }
}

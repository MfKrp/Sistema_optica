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

        //Constructor
        public Ver_clientes()
        {
            InitializeComponent();
        }

        //Metodos
        public void LoadTheme()
        {
            PVerClientes.BackColor = TemaColor.TertiaryColor;
            DTGListaClientes.BackgroundColor = TemaColor.SecondaryColor;
        }


        //Componentes
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_clientes_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void IBRehabilitarCliente_Click(object sender, EventArgs e)
        {
            //Cuando se presione este boton se devolvera el estado de un cliente a activo en caso de estar inactivo
            if (DTGListaClientes.SelectedRows.Count == 1)
            {
                //Pendiente verificar que el cliente no este habilitado antes de llevar acabo la restauracion
                CCliente restaurarCliente = new CCliente();
                restaurarCliente.restaurarCliente(DTGListaClientes);
            }
            else
            {
                MessageBox.Show("Seleecione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IBEditar_Click(object sender, EventArgs e)
        {

        }

        private void IBAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void IBEliminarCliente_Click(object sender, EventArgs e)
        {

        }

        private void PVerClientes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

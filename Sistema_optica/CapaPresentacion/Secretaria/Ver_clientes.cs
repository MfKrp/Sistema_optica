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
    }
}

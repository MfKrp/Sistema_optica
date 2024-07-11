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

namespace CapaPresentacion.Secretaria
{
    public partial class Ver_cristales : Form
    {

        //String de conexion en escritorio
        string connectionString = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //funciones de estilizacion
        private void LoadTheme()
        {
            PVerCristales.BackColor = TemaColor.TertiaryColor;
            DTGVCristales.BackgroundColor = TemaColor.SecondaryColor;
        }

        public Ver_cristales()
        {
            InitializeComponent();
        }

        private void PVerCristales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGVCristales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_cristales_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
        }


    }
}

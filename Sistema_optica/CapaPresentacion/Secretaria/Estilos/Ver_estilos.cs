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

namespace CapaPresentacion.Secretaria.Estilos
{
    public partial class Ver_estilos : Form
    {
        //String para conectarse en escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public Ver_estilos()
        {
            InitializeComponent();
        }

        //funciones de estilo

        private void LoadTheme()
        {
            PVerEstilos.BackColor = TemaColor.TertiaryColor;
            DTGVEstilos.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void Ver_estilos_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
        }

        private void PVerEstilos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGVEstilos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

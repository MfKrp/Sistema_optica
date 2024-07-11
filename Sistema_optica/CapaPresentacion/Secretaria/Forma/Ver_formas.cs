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

namespace CapaPresentacion.Secretaria.Forma
{
    public partial class Ver_formas : Form
    {
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public Ver_formas()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            PVerMarcas.BackColor = TemaColor.TertiaryColor; //Este panel tiene los nombres equivocados
            DTGVFormas.BackgroundColor = TemaColor.SecondaryColor;
        }

        //funciones para estilos de la pagina

        private void Ver_formas_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
        }

        private void PVerMarcas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGVFormas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

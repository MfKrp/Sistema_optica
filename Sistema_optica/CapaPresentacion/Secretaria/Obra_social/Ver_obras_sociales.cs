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

namespace CapaPresentacion.Secretaria.Obra_social
{
    public partial class Ver_obras_sociales : Form
    {
        //string para conectarse a la base de datos en la pc de escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //funciones para modificar el estilo de la pagina
        private void LoadTheme()
        {
            PVerObrasSociales.BackColor = TemaColor.TertiaryColor;
            DTGVObrasSociales.BackgroundColor = TemaColor.SecondaryColor;
        }

        public Ver_obras_sociales()
        {
            InitializeComponent();
        }

        private void Ver_obras_sociales_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
        }

        private void PVerObrasSociales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGVObrasSociales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

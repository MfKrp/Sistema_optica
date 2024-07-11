using CapaPresentacion.Entidades_Clases;
using Microsoft.Windows.Themes;
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
    public partial class Ver_marcas : Form
    {
        //string de conexion del escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public Ver_marcas()
        {
            InitializeComponent();
        }

        //funciones para modificar los estilos de la pagina

        private void LoadTheme()
        {
            PVerMarcas.BackColor = TemaColor.TertiaryColor;
            DTGVMarcas.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void Ver_marcas_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
        }

        private void PVerMarcas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGVMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

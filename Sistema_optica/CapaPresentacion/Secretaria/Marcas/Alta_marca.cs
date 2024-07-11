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
    public partial class Alta_marca : Form
    {
        public Alta_marca()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
        }

        private void Alta_marca_Load(object sender, EventArgs e)
        {
            //Se cargan los estilos graficos
            this.LoadTheme();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TDescMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDescMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Cuando se presione este boton se va a resetear el campo de texto de la descripcion de la marca
            TDescMarca.Text = "";
        }

        private void IBAgregarMarca_Click(object sender, EventArgs e)
        {
            if (TDescMarca.Text == "")
            {
                MessageBox.Show("Complete el campo de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //si esta completo el campo se carga la marca sino se muestra un mensaje de error
                EMarca altaMarca = new EMarca();
                altaMarca.altaMarca(TDescMarca.Text);
            }
        }
    }
}

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
    public partial class Alta_forma : Form
    {
        public Alta_forma()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
        }

        private void Alta_forma_Load(object sender, EventArgs e)
        {
            //Carga de estilos visuales
            this.LoadTheme();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TDescForma_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDescForma_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Boton para resetear los campos cuando se presione
            TDescForma.Text = "";
        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
            if (TDescForma.Text != "")
            {
                EForma agregarForma = new EForma();
                agregarForma.altaForma(TDescForma.Text);
            } else
            {
                //Cuando los campos no estan completos
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

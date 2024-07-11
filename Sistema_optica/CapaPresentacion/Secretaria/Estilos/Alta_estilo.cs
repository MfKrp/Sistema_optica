using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Secretaria.Estilos
{
    public partial class Alta_estilo : Form
    {
        public Alta_estilo()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
        }

        private void Alta_estilo_Load(object sender, EventArgs e)
        {
            //Se cargan los estilos visuales
            this.LoadTheme();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TDescEstilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDescEstilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Resetea los campos de texto
            TDescEstilo.Text = "";
        }
        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
            if (TDescEstilo.Text != "")
            {
                EEstilo agregarEstilo = new EEstilo();
                agregarEstilo.altaEstilo(TDescEstilo.Text);
            } else
            {
                MessageBox.Show("Complete los campos para agregar estilos", "Complete los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

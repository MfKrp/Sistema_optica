using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Secretaria.Obra_social
{
    public partial class Alta_obra_social : Form
    {
        public Alta_obra_social()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
            if (TNombreOS.Text == "" || TCoberturaCristal.Text == "" || TCoberturaMarco.Text == "")
            {
                MessageBox.Show("Complete todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //si los campos no estan vacios se hara la alta de la obra social
                CObraSocial generarObraSocial = new CObraSocial();
                generarObraSocial.altaObraSocial(TNombreOS.Text, float.Parse(TCoberturaMarco.Text), float.Parse(TCoberturaCristal.Text));
            }
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Boton que resetea los campos de texto cuando se presiona
            TNombreOS.Text = "";
            TCoberturaCristal.Text = "";
            TCoberturaMarco.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alta_obra_social_Load(object sender, EventArgs e)
        {
            //Se inicializan los temas graficos de la pagina
            this.LoadTheme();
        }

        private void TNombreOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombreOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TCoberturaMarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCoberturaMarco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se aceptan solo numeros decimales, con un solo punto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TCoberturaCristal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCoberturaCristal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se aceptan solo numeros decimales, con un solo punto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

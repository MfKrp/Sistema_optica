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

namespace CapaPresentacion.Secretaria.Cristales
{
    public partial class Alta_cristal : Form
    {
        public Alta_cristal()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
        }

        private void Alta_cristal_Load(object sender, EventArgs e)
        {
            //se cargan los estilos
            this.LoadTheme();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
            //comprobar que los campos no este vacios y si no estan vacios realizar la funcion
            if (TStockCristal.Text == "" || TMaterialCristal.Text == "")
            {
                MessageBox.Show("No se puede generar agregar el cristal si alguno de los campos esta vacio, intente nuevamente", "Error, campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Si no hay campos vacios se realiza la carga del cristal a la base de datos
                CCristal cristalNuevo = new CCristal();
                cristalNuevo.altaCristales(TMaterialCristal.Text, int.Parse(TStockCristal.Text));
            }
        }

        private void TStockCristal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TStockCristal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TMaterialCristal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TMaterialCristal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Cuando este boton se presione se va a resetear el contenido de los campos de texto
            TMaterialCristal.Text = "";
            TStockCristal.Text = "";
        }
    }
}

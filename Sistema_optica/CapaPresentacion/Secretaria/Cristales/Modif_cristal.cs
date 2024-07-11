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
    public partial class Modif_cristal : Form
    {
        public Modif_cristal()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
            panel2.BackColor = TemaColor.TertiaryColor;
            DTGListaCristales.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void Modif_cristal_Load(object sender, EventArgs e)
        {
            //Se cargan estilos visuales
            this.LoadTheme();

            //Se cargan los datos de los cristales al datagrid para visualizarlos
            CCristal verCristales = new CCristal();
            verCristales.verCristales(DTGListaCristales);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGListaCristales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo para cargar los datos de cristales en el datagrid
            DataGridViewRow fila = DTGListaCristales.SelectedRows[0];
            int idCristal = (int)fila.Cells["IdCristal"].Value;
            string materialCristal = fila.Cells["Material"].Value.ToString();
            int stockCristal = (int)fila.Cells["Stock"].Value;

            TIdCristal.Text = idCristal.ToString();
            TMaterialCristal.Text = materialCristal;
            TStockCristal.Text = stockCristal.ToString();
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

        private void TStockCristal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TStockCristal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Cuando se presione este boton se van a resetear todos los campos de texto
            TMaterialCristal.Text = "";
            TStockCristal.Text = "";
        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
            if (TMaterialCristal.Text == "" || TStockCristal.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DTGListaCristales.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    /*Parametros de la funcion de modificacion
                     *  int idCristal,
                        string material,
                        int stock,
                        DataGridView datagridCristales
                     */
                    CCristal modificarCristal = new CCristal();
                    modificarCristal.modificarCristal(int.Parse(TIdCristal.Text),
                        TMaterialCristal.Text,
                        int.Parse(TStockCristal.Text),
                        DTGListaCristales);

                }

            }
        }

        private void TIdCristal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIdCristal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

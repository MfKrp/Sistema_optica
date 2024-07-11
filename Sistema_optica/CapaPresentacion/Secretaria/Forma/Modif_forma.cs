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
    public partial class Modif_forma : Form
    {
        public Modif_forma()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
            panel2.BackColor = TemaColor.TertiaryColor;
            DTGListaFormas.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void Modif_forma_Load(object sender, EventArgs e)
        {
            //se cargan estilos visuales
            this.LoadTheme();

            //se cargan todas las formas a los datagrids
            this.cargarFormas(DTGListaFormas);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGListaFormas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo para cargar los datos de formas a los campos de texto
            DataGridViewRow fila = DTGListaFormas.SelectedRows[0];
            int idForma = (int)fila.Cells["IdForma"].Value;
            string descForma = fila.Cells["Material"].Value.ToString();

            LIdFor.Text = idForma.ToString();
            TDescForma.Text = descForma;
        }

        private void cargarFormas(DataGridView dataGridFormas)
        {
            //se visualizan las formas
            EForma cargarFormas = new EForma();
            cargarFormas.verFormas(dataGridFormas);
        }

        private void LIdFor_TextChanged(object sender, EventArgs e)
        {

        }

        private void LIdFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TDescForma_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDescForma_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptaran letras
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Boton que resetea los campos de texto
            LIdFor.Text = "";
            TDescForma.Text = "";
        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
            if (LIdFor.Text == "" || TDescForma.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DTGListaFormas.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EForma modificarCristal = new EForma();
                    modificarCristal.modificarForma(int.Parse(LIdFor.Text),
                        TDescForma.Text,
                        DTGListaFormas);

                }

            }
        }
    }
}

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
    public partial class Modif_obra_social : Form
    {
        public Modif_obra_social()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            PTObrasSociales.BackColor = TemaColor.TertiaryColor;
            PNLObrasSociales.BackColor = TemaColor.TertiaryColor;
            DTGListaObrasSociales.BackgroundColor = TemaColor.QuaternaryColor;
        }

        public void cargarDataGrid(DataGridView dataGrid)
        {
            CObraSocial cargarObraSocial = new CObraSocial();
            cargarObraSocial.verObrasSociales(dataGrid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Modif_obra_social_Load(object sender, EventArgs e)
        {
            //Se cargan estilos visuales
            this.LoadTheme();

            //Se cargan los datos al datagrid
            this.cargarDataGrid(DTGListaObrasSociales);
        }

        private void PNLObrasSociales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGListaObrasSociales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo para cargar los datos de cristales en el datagrid
            DataGridViewRow fila = DTGListaObrasSociales.SelectedRows[0];
            int idObraSocial = (int)fila.Cells["IdObraSocial"].Value;
            string nombreObraSocial = fila.Cells["NombreObraSocial"].Value.ToString();
            float coberturaMarco = (float)fila.Cells["CoberturaMarco"].Value;
            float coberturaCristal = (float)fila.Cells["CoberturaCristal"].Value;

            TIdObraSocial.Text = idObraSocial.ToString();
            TNombreOS.Text = nombreObraSocial;
            TCoberturaMarco.Text = coberturaMarco.ToString();
            TCoberturaCristal.Text = coberturaCristal.ToString();
        }

        private void TIdObraSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIdObraSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void BResetearTB_Click(object sender, EventArgs e)
        {
            //Boton que resetea los campos cuando se presiona
            TIdObraSocial.Text = "";
            TNombreOS.Text = "";
            TCoberturaMarco.Text = "";
            TCoberturaCristal.Text = "";
        }

        private void IBModificarOS_Click(object sender, EventArgs e)
        {
            if (TIdObraSocial.Text == "" || TNombreOS.Text == "" || TCoberturaCristal.Text == "" || TCoberturaMarco.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DTGListaObrasSociales.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CObraSocial modificarCristal = new CObraSocial();
                    modificarCristal.modificarObraSocial(int.Parse(TIdObraSocial.Text),
                        TNombreOS.Text,
                        float.Parse(TCoberturaCristal.Text),
                        float.Parse(TCoberturaMarco.Text),
                        DTGListaObrasSociales);

                }

            }
        }
    }
}

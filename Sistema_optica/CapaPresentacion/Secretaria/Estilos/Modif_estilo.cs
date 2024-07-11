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

namespace CapaPresentacion.Secretaria.Estilos
{
    public partial class Modif_estilo : Form
    {
        public Modif_estilo()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
            panel2.BackColor = TemaColor.SecondaryColor;
            DTGListaEstilos.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void Modif_estilo_Load(object sender, EventArgs e)
        {
            //Se cargan los estilos visuales
            this.LoadTheme();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGListaEstilos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //codigo para cargar los estilos al datagrid
            DataGridViewRow fila = DTGListaEstilos.SelectedRows[0];
            int idEstilo = (int)fila.Cells["IdEstilo"].Value;
            string descripcionEstilo = fila.Cells["Descripcion"].Value.ToString();

            TIdEstilo.Text = idEstilo.ToString();
            TDescEstilo.Text = descripcionEstilo;
        }

        private void TIdEstilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIdEstilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo se aceptan numeros, aunque ni siquiera deberia poder alterarse este campo
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            //Cuando se presione este boton se resetearan todos las campos de text
            TIdEstilo.Text = "";
            TDescEstilo.Text = "";
        }

        private void IBModificarEstilo_Click(object sender, EventArgs e)
        {
            if (TIdEstilo.Text != "" || TDescEstilo.Text != "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DTGListaEstilos.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    EEstilo agregarEstilo = new EEstilo();
                    agregarEstilo.modificarEstilo(int.Parse(TIdEstilo.Text),
                        TDescEstilo.Text,
                        DTGListaEstilos);

                }

            }
            
        }
    }
}

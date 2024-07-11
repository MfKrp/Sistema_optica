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

namespace CapaPresentacion.Secretaria.Marcas
{
    public partial class Modif_marca : Form
    {
        public Modif_marca()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            panel1.BackColor = TemaColor.TertiaryColor;
            panel2.BackColor = TemaColor.TertiaryColor;
            DTGListaMarcas.BackgroundColor = TemaColor.SecondaryColor;
        }

        public void cargarDataGrid(DataGridView dataGridMarcas)
        {
            EMarca cargarMarcas = new EMarca();
            cargarMarcas.verMarca(dataGridMarcas);
        }

        private void Modif_marca_Load(object sender, EventArgs e)
        {
            //Se cargan los estilos visuales
            this.LoadTheme();

            //Se carga el datagrid con las marcas
            this.cargarDataGrid(DTGListaMarcas);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGListaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Codigo para cargar las marcas en el datagrid
        }

        private void TIdMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIdMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TDescMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDescMarca_KeyPress(object sender, EventArgs e)
        {

        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //boton que resetea los campos cuando se presiona
        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
            if (TIdMarca.Text == "" || TDescMarca.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DTGListaMarcas.SelectedRows.Count < 1)
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
                    EMarca modificarMarca = new EMarca();
                    modificarMarca.modificarForma(int.Parse(TIdMarca.Text),
                        TDescMarca.Text,
                        DTGListaMarcas);

                }

            }
        }
    }
}

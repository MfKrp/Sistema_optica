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

namespace CapaPresentacion.Superadmin.Productos
{
    public partial class Alta_productoAccesorio : Form
    {
        public Alta_productoAccesorio()
        {
            InitializeComponent();
        }

        private void Alta_productoAccesorio_Load(object sender, EventArgs e)
        {
            this.LoadTheme();
        }

        public void LoadTheme()
        {
            //Se cargan los colores de la aplicacion
            panel1.BackColor = TemaColor.TertiaryColor;

            //Se carga el combobox de la marca
            EMarca comboBoxMarca = new EMarca();
            comboBoxMarca.cargarComboBox(ComboBox_Marca);

            //Se carga el combobox del estilo
            EEstilo comboBoxEstilo = new EEstilo();
            comboBoxEstilo.cargarComboBoxEstilos(ComboBox_Estilo);

            //Se carga el combobox de las formas
            EForma comboBoxFormas = new EForma();
            comboBoxFormas.cargarComboBox(CBFormaAnteojo);

            //Se cargan los combobox del cristal, en este caso se tiene que verificar que el stock del cristal sea mayor a 1, que seria que hay una par de anteojos, si hay stock, se muestra, sino no se muestra en el combobox
            CCristal comboBoxCristal = new CCristal();
            comboBoxCristal.cargarComboBoxCristales(CBCristalAnteojo);

        }

        private void LCargarAnteojo_Click(object sender, EventArgs e)
        {

        }

        private void LMarca_Click(object sender, EventArgs e)
        {

        }

        private void LEstilo_Click(object sender, EventArgs e)
        {

        }

        private void LFormaAnteojo_Click(object sender, EventArgs e)
        {

        }

        private void LCristalAnteojo_Click(object sender, EventArgs e)
        {

        }

        private void LPrecio_Click(object sender, EventArgs e)
        {

        }

        private void LStock_Click(object sender, EventArgs e)
        {

        }

        private void LColorAnteojo_Click(object sender, EventArgs e)
        {

        }

        private void LGeneroAnteojo_Click(object sender, EventArgs e)
        {

        }

        private void IBAgregarOS_Click(object sender, EventArgs e)
        {
           
        }

        private void IBResDatos_Click(object sender, EventArgs e)
        {
            //Cuando se agrega un anteojo que es accesorio la graduacion es de 0
            ComboBox_Marca.SelectedIndex = -1;
            ComboBox_Estilo.SelectedIndex = -1;
            CBFormaAnteojo.SelectedIndex = -1;
            CBCristalAnteojo.SelectedIndex = -1;
            TPrecio.Text = "";
            TStock.Text = "";
            CBColorAnteojo.SelectedIndex = -1;
            CBGeneroAnteojo.SelectedIndex = -1;
        }
    }
}

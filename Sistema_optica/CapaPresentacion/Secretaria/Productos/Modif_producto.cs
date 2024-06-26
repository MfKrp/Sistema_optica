﻿using CapaPresentacion.Capa_datos;
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

namespace CapaPresentacion.Secretaria
{
    public partial class Modif_producto : Form
    {
        public Modif_producto()
        {
            InitializeComponent();
        }

        private void TPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPrecio_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            /*Ingresar solo numeros*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TColor_KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {
            //Solo caracteres
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TId_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void TId_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se aceptan numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            /*if (Combobox de tipoComnboBox_Anteojo.Text == "" || ComboBox_Marca.Text == "" || ComboBox_Estilo.Text == "" || TPrecio.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Parametros funcion
                    int id_prod,
                    float precProd,
                    int stockProd,
                    int estiloProd,
                    int marcaProd,
                    int tipoProd,
                    DataGridView dataGridProductos
                 

                //Si no se selecciona ninguna fila se arroja un error
                if (DGVProductos.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Seleccione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    parametros de la funcion de modificacion
                        int id_prod,
                        float precProd,
                        int stockProd,
                        int estiloProd,
                        int marcaProd,
                        int tipoProd,
                        DataGridView dataGridProductos
                     
                    CAnteojo modificarProducto = new CAnteojo();
                    modificarProducto.modificacionProducto(int.Parse(TId_prod.Text),
                        float.Parse(TPrecio.Text),
                        int.Parse(TStock.Text),
                        int.Parse(ComboBox_Estilo.SelectedValue.ToString()),
                        int.Parse(ComboBox_Marca.SelectedValue.ToString()),
                        int.Parse(ComnboBox_Anteojo.SelectedValue.ToString()),
                        DGVProductos);
                }
            }*/
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            /*TId_prod.Text = "";
            ComnboBox_Anteojo.Text = "";
            ComboBox_Marca.Text = "";
            ComboBox_Estilo.Text = "";
            TPrecio.Text = "";*/
        }

        private void DGVProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (DTGListaAnteojos.SelectedRows.Count == 1)
            {
                
                 * int id_prod,
                   float precProd,
                   int stockProd,
                   int estiloProd,
                   int marcaProd,
                   int tipoProd,
                 
                DataGridViewRow fila = DTGListaAnteojos.SelectedRows[0];
                int id_prod = (int)fila.Cells["Id_producto"].Value;
                double precProd = (double)fila.Cells["Precio_unitario"].Value;
                int stockProd = (int)fila.Cells["Stock"].Value;
                int estiloProd = (int)fila.Cells["Estilo"].Value;
                int marcaProd = (int)fila.Cells["Marca"].Value;
                int tipoProd = (int)fila.Cells["Tipo"].Value;

                TId_prod.Text = id_prod.ToString();
                TPrecio.Text = precProd.ToString();
                TStock.Text = stockProd.ToString();
                ComboBox_Estilo.Text = estiloProd.ToString();
                ComboBox_Marca.Text = marcaProd.ToString();
                ComnboBox_Anteojo.Text = tipoProd.ToString();
            }*/
        }

        private void Modif_producto_Load(object sender, EventArgs e)
        {
            CAnteojo verProductos = new CAnteojo();
            verProductos.verProductos(DTGListaAnteojos);

            EMarca cargarCBMarca = new EMarca();
            cargarCBMarca.cargarComboBox(ComboBox_Marca);

            EEstilo cargarCBEstilo = new EEstilo();
            cargarCBEstilo.cargarComboBoxEstilos(ComboBox_Estilo);

            EForma cargarCBTipo = new EForma();
            //cargarCBTipo.cargarComboBox(ComnboBox_Anteojo);
        }

        private void ComboBox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Estilo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComnboBox_Anteojo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTGListaAnteojos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

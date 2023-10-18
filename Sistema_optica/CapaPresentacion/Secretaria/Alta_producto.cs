﻿using CapaPresentacion.Capa_datos;
using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Secretaria
{
    public partial class Alta_producto : Form
    {

        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        //String para conectarse a la base de datos
        public Alta_producto()
        {
            InitializeComponent();
        }

        private void Alta_producto_Load(object sender, EventArgs e)
        {

            EMarca OcomboBox = new EMarca();

            OcomboBox.cargarComboBox(ComboBox_Marca);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void TPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TId_prod_TextChanged(object sender, EventArgs e)
        {

        }

        private void TId_prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox que solo acepta numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ComnboBox_Anteojo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TId_prod.Text == "" || ComnboBox_Anteojo.Text == "" || ComboBox_Genero.Text == "" || TColor.Text == "" || ComboBox_Marca.Text == "" || ComboBox_Estilo.Text == "" || TPrecio.Text == "" || TStock.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CProducto datos = new CProducto();
                datos.altaProducto(TId_prod.Text, ComnboBox_Anteojo.Text, TPrecio.Text, ComboBox_Genero.Text, TColor.Text, TStock.Text, ComboBox_Estilo.Text, ComboBox_Marca.SelectedValue.ToString());
                //MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Desarrollo de la funcion para dar de alta un producto
            }
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            TId_prod.Text = "";
            ComnboBox_Anteojo.Text = "";
            ComboBox_Genero.Text = "";
            TColor.Text = "";
            ComboBox_Marca.Text = "";
            ComboBox_Estilo.Text = "";
            TPrecio.Text = "";
        }
    }
}

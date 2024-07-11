using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Capa_datos;
using CapaPresentacion.Entidades_Clases;
using Microsoft.Windows.Themes;

namespace CapaPresentacion.Secretaria
{
    public partial class Ver_productosSuper : Form
    {
        public Ver_productosSuper()
        {
            InitializeComponent();
        }

        public void LoadTheme()
        {
            PVerProductos.BackColor = TemaColor.TertiaryColor;
            DTGListaProductos.BackgroundColor = TemaColor.SecondaryColor;
        }

        private void BVerProductos_Click(object sender, EventArgs e)
        {
            //Se listan los productos disponibles
            CAnteojo verProductos = new CAnteojo();
            verProductos.verProductos(DTGListaProductos);
        }

        private void DGV_ListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            Modif_producto formModifProd = new Modif_producto();
            formModifProd.Show();
            this.Hide();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (DTGListaProductos.SelectedRows.Count == 1)
            {
                //Pendiente verificar que el cliente no este deshabilitado
                CAnteojo bajaProducto = new CAnteojo();
                bajaProducto.bajaProducto(DTGListaProductos);
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            //Cuando se presione este boton se devolvera el estado de un cliente a activo en caso de estar inactivo
            if (DTGListaProductos.SelectedRows.Count == 1)
            {
                //Pendiente verificar que el cliente no este habilitado antes de llevar acabo la restauracion
                CAnteojo restaurarProducto = new CAnteojo();
                restaurarProducto.restaurarProd(DTGListaProductos);
            }
            else
            {
                MessageBox.Show("Seleecione almenos una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DTGListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_productosSuper_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void PVerProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBOpcionVistaPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using CapaPresentacion;
using CapaPresentacion.Capa_datos;
using CapaPresentacion.Entidades_Clases;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace CapaPresentacion.Vendedor
{
    public partial class Alta_venta : Form
    {

        CEmpleado empleadoLogueado { get; set; }
        CCliente clienteSeleccionado { get; set; }

        CProducto productoNuevoSeleccionado { get; set; }

        CFactura compraCliente = new CFactura();

        public Alta_venta(CEmpleado empleadoConectado)
        {
            InitializeComponent();
            empleadoLogueado = empleadoConectado;
        }

        private void DTGDatosCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TVendedorCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_Vendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_Vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TClienteTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void TClienteTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BReiniciarCarrito_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (DTGDatosCompra.RowCount > 0)
            {
                DTGDatosCompra.Rows.Clear();
            }
            TPrecioTotal.Text = "";
            TNumeroFactura.Text = generarNumeroAleatorio().ToString();
        }

        private void BAgregarProd_Click(object sender, EventArgs e)
        {
            //Esta funcion agrega los productos al datagrid de carrito

            //verificacion de que ninguno de los campos esten vacios
            if (TCodigoProducto.Text == "" || TMarcaAnt.Text == "" || TTipoAnt.Text == "" || TEstiloAnt.Text == "" || CBGenero.Text == "" || CBGenero.Text == "" || NCantidadCompra.Value <= 0 || TPrecio.Text == "")
            {
                MessageBox.Show("Complete todos los campos antes de agregar el producto al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DTGDatosCompra.Rows.Add(TCodigoProducto.Text, TMarcaAnt.Text, TTipoAnt.Text, TEstiloAnt.Text, CColor.Text, CBGenero.Text, NCantidadCompra.Value, TPrecio.Text);

                CProducto descontarStock = new CProducto();
                descontarStock.descontarStock(Convert.ToInt32(NCantidadCompra.Value), Convert.ToInt32(TCodigoProducto.Text));

                float precioTotal = 0;

                foreach (DataGridViewRow dr in DTGDatosCompra.Rows)
                {
                    if (TPrecioTotal.Text == "")
                    {
                        precioTotal = Convert.ToSingle(TPrecio.Text) * Convert.ToInt32(NCantidadCompra.Value);
                    }
                    else
                    {
                        precioTotal = Convert.ToSingle(TPrecioTotal.Text) + Convert.ToSingle(TPrecio.Text) * Convert.ToInt32(NCantidadCompra.Value);
                    }

                }

                TPrecioTotal.Text = precioTotal.ToString();

                CProducto verProductos = new CProducto();
                verProductos.verProductos(DGProductos);
            }

        }

        private void BRegistrarCompra_Click(object sender, EventArgs e)
        {
            //en esta variable se guardaran la cantidad de registros que posee el datagrid
            int cantidadRegistros = 0;
            CFactura ultimoDetalle = new CFactura();
            int detalleAnterior = ultimoDetalle.obtenerUltimoDetalle();

            //Si la cuenta de registros es igual a 0 entonces no se realiza la venta
            if (DTGDatosCompra.RowCount == 0 || TDniCliente.Text == "")
            {
                MessageBox.Show("Seleccione un producto como minimo para poder realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cantidadRegistros = DTGDatosCompra.RowCount;
                compraCliente.registrarCabecera(Convert.ToInt32(TNumeroFactura.Text),
                    Convert.ToSingle(TPrecioTotal.Text),
                    empleadoLogueado.id_empleado,
                    Convert.ToInt32(TDniCliente.Text),
                    Convert.ToInt32(CBFormaPago.SelectedValue.ToString()),
                    FechaVenta.Value.ToShortDateString());

                for (int i = detalleAnterior; i < DTGDatosCompra.RowCount; i++)
                {
                    DataGridViewRow row = DTGDatosCompra.Rows[i];

                    int idDetalle = i;
                    int cantidad = Convert.ToInt32(row.Cells["DGVColumnaCantidad"].Value);
                    int idProducto = Convert.ToInt32(row.Cells["DTGColumaIdProducto"].Value);
                    int nroFactura = Convert.ToInt32(TNumeroFactura.Text);
                    string Color = row.Cells["DGVColumnaColor"].Value.ToString();
                    string Genero = row.Cells["DGVColumnaGenero"].Value.ToString();

                    compraCliente.registrarDetalle(idDetalle,
                        cantidad,
                        idProducto,
                        nroFactura,
                        Color,
                        Genero);
                }

                MessageBox.Show("Se han cargado todos los registros de venta exitosamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*-----------SE GENERA TICKET DE VENTA--------------*/

                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

                string paginahtml_text = Properties.Resources.plantilla.ToString();

                //Reemplazo de valores que se encuentran en la factura
                paginahtml_text = paginahtml_text.Replace("@CLIENTE", clienteSeleccionado.Nombre + " " + clienteSeleccionado.Apellido);
                paginahtml_text = paginahtml_text.Replace("@Descripcion", CBFormaPago.Text);
                paginahtml_text = paginahtml_text.Replace("@Nro_factura", TNumeroFactura.Text);
                paginahtml_text = paginahtml_text.Replace("@Nombre", empleadoLogueado.nombreEmpleado);
                paginahtml_text = paginahtml_text.Replace("@Apellido", empleadoLogueado.apellidoEmpleado);
                paginahtml_text = paginahtml_text.Replace("@DOCUMENTO", clienteSeleccionado.DNI.ToString());
                paginahtml_text = paginahtml_text.Replace("@FECHA", FechaVenta.Value.ToShortDateString());
                paginahtml_text = paginahtml_text.Replace("@TOTAL", TPrecioTotal.Text);

                string filas = string.Empty;

                foreach (DataGridViewRow row in DTGDatosCompra.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["DGVColumnaCantidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["DTGColumaIdProducto"].Value.ToString() + " " + row.Cells["DGVColumnaMarca"].Value.ToString() + " " + row.Cells["DGVColumnaTipo"].Value.ToString() + " " + row.Cells["DGVColumnaEstiloanteojo"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["DTCPrecioUnitario"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }

                paginahtml_text = paginahtml_text.Replace("@FILAS", filas);

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();

                        pdfDoc.Add(new Phrase(""));

                        using (StringReader sr = new StringReader(paginahtml_text))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();

                        stream.Close();
                    }
                }

                //===== LIMPIAR LOS CAMPOS =======

                DTGDatosCompra.Rows.Clear();
                TDniCliente.Clear();
                TNumeroFactura.Text = generarNumeroAleatorio().ToString();
                TCodigoProducto.Clear();
                TTipoAnt.Clear();
                TMarcaAnt.Clear();
                TEstiloAnt.Clear();
                CBGenero.SelectedItem = null;
                CColor.SelectedItem = null;
                TPrecio.Clear();
                TPrecioTotal.Clear();
                CBFormaPago.SelectedItem = null;

            }
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

        private void TCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Controls.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alta_venta_Load(object sender, EventArgs e)
        {
            //cuando se carga se coloca el dni de la sesion conecta
            TDni_Vendedor.Text = empleadoLogueado.dniEmpleado.ToString();

            CProducto verProductos = new CProducto();
            verProductos.verProductos(DGProductos);

            TNumeroFactura.Text = generarNumeroAleatorio().ToString();

            CTipoPago cargarTiposPago = new CTipoPago();
            cargarTiposPago.cargarComboBox(CBFormaPago);
        }

        public int generarNumeroAleatorio()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private void DGProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BBuscarDni_Click(object sender, EventArgs e)
        {
            using (var modal = new Lista_clientes_vendedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TDniCliente.Text = modal.clienteSeleccionado.DNI.ToString();
                }

                clienteSeleccionado = modal.clienteSeleccionado;

            }
        }

        private void CBGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TDniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("LLegue a condicional");

            int iFila = e.RowIndex;
            int eColumna = e.ColumnIndex;



            if (iFila >= 0 && iFila >= 0)
            {

                productoNuevoSeleccionado = new CProducto()
                {
                    ID_producto = Convert.ToInt32(DGProductos.Rows[iFila].Cells["Id_Producto"].Value.ToString()),
                    Precio_unitario = Convert.ToSingle(DGProductos.Rows[iFila].Cells["Precio_unitario"].Value.ToString()),
                    Stock = Convert.ToInt32(DGProductos.Rows[iFila].Cells["Stock"].Value.ToString()),
                    EstiloProd = Convert.ToInt32(DGProductos.Rows[iFila].Cells["Estilo"].Value.ToString()),
                    MarcaProd = Convert.ToInt32(DGProductos.Rows[iFila].Cells["Marca"].Value.ToString()),
                    TipoProducto = Convert.ToInt32(DGProductos.Rows[iFila].Cells["Tipo"].Value.ToString()),
                    EstadoProducto = Convert.ToBoolean(DGProductos.Rows[iFila].Cells["Estado_producto"].Value.ToString())
                };


                TCodigoProducto.Text = productoNuevoSeleccionado.ID_producto.ToString();//DGProductos.Rows[iFila].Cells["Id_Producto"].Value.ToString();

                //se ha utilizado este metodo porque fue por cuestiones de tiempo cuando enrealidad se podria haber hecho extrayendo desde la base de datos
                switch (productoNuevoSeleccionado.EstiloProd/*DGProductos.Rows[iFila].Cells["Estilo"].Value*/)
                {
                    case 1:
                        TEstiloAnt.Text = "Cat Eye";
                        break;

                    case 2:
                        TEstiloAnt.Text = "Oval";
                        break;

                    case 3:
                        TEstiloAnt.Text = "Round Eye";
                        break;

                    case 4:
                        TEstiloAnt.Text = "Wrap";
                        break;

                    case 5:
                        TEstiloAnt.Text = "Wayfarer";
                        break;
                }

                switch (productoNuevoSeleccionado.MarcaProd/*DGProductos.Rows[iFila].Cells["Marca"].Value*/)
                {
                    case 1:
                        TMarcaAnt.Text = "Ray Ban";
                        break;

                    case 2:
                        TMarcaAnt.Text = "Vogue";
                        break;

                    case 3:
                        TMarcaAnt.Text = "One Saenz";
                        break;

                    case 4:
                        TMarcaAnt.Text = "Rusty";
                        break;

                    case 5:
                        TMarcaAnt.Text = "Reef";
                        break;
                }

                switch (productoNuevoSeleccionado.TipoProducto/*DGProductos.Rows[iFila].Cells["Tipo"].Value*/)
                {
                    case 1:
                        TTipoAnt.Text = "Normales";
                        break;

                    case 2:
                        TTipoAnt.Text = "Sol";
                        break;
                }

                TPrecio.Text = productoNuevoSeleccionado.Precio_unitario.ToString();//DGProductos.Rows[iFila].Cells["Precio_unitario"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TPrecioTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BEliminarProd_Click(object sender, EventArgs e)
        {
            //Funcion que elimina un producto del carrito

            if (DTGDatosCompra.SelectedRows.Count > 0)
            {
                //Cuando un producto se elimina del carrito lo que se hace es devolver el stock de ese producto que estaba en el carrito
                CProducto recuperarStock = new CProducto();
                //recuperarStock.recuperarStock();

                int indiceDeFila = DTGDatosCompra.CurrentCell.RowIndex;
                DataGridViewRow fila = DTGDatosCompra.SelectedRows[0];
                int cantidadProducto = Convert.ToInt32(fila.Cells["DGVColumnaCantidad"].Value);
                float precioProducto = Convert.ToSingle(fila.Cells["DTCPrecioUnitario"].Value);
                float precioTotalProducto = cantidadProducto * precioProducto;
                float precioFinalExtraido = Convert.ToSingle(TPrecioTotal.Text);
                float precioFinalNuevo = precioFinalExtraido - precioTotalProducto;
                TPrecioTotal.Text = precioFinalNuevo.ToString();
                DTGDatosCompra.Rows.RemoveAt(indiceDeFila);
            }
            else
            {
                //Sino se muestra un mensaje de error
                MessageBox.Show("Seleccione un producto del carrito para quitarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bultimodetalle_Click(object sender, EventArgs e)
        {
            /*CFactura verUltimodetalle = new CFactura();
            int ultimo = verUltimodetalle.obtenerUltimoDetalle();

            MessageBox.Show("Ultimo detalle: " + ultimo.ToString());*/

        }
    }
}

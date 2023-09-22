namespace CapaPresentacion.Vendedor
{
    partial class Alta_venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MSLRegistrarVenta = new ToolStripMenuItem();
            LVendedorActual = new Label();
            LCliente = new Label();
            LFechaVta = new Label();
            TVendedorCargo = new TextBox();
            TClienteTitular = new TextBox();
            TFechaCompra = new TextBox();
            DTGDatosCompra = new DataGridView();
            panel1 = new Panel();
            BAgregarProd = new Button();
            BReiniciarCarrito = new Button();
            BRegistrarCompra = new Button();
            LPrecioVenta = new Label();
            TPrecioTotal = new TextBox();
            LInfoProd = new Label();
            LIDProdCompra = new Label();
            textBox4 = new TextBox();
            LNombreProdCompra = new Label();
            textBox5 = new TextBox();
            LCantidadCompra = new Label();
            LPrecioCompra = new Label();
            NCantidadCompra = new NumericUpDown();
            TPrecioCompra = new TextBox();
            LTipoCompra = new Label();
            textBox6 = new TextBox();
            LEstiloCompra = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            LGeneroCompra = new Label();
            LMarcaCompra = new Label();
            textBox9 = new TextBox();
            DGCId_Producto = new DataGridViewTextBoxColumn();
            DGCNombreProd = new DataGridViewTextBoxColumn();
            DTCVendedorCargo = new DataGridViewTextBoxColumn();
            DGCCliente = new DataGridViewTextBoxColumn();
            DTCFecha = new DataGridViewTextBoxColumn();
            DTGCCantidad = new DataGridViewTextBoxColumn();
            DTCPrecioUnitario = new DataGridViewTextBoxColumn();
            DTGCEliminar = new DataGridViewButtonColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NCantidadCompra).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DarkViolet;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLRegistrarVenta });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 60);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSLRegistrarVenta
            // 
            MSLRegistrarVenta.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MSLRegistrarVenta.ForeColor = Color.White;
            MSLRegistrarVenta.Name = "MSLRegistrarVenta";
            MSLRegistrarVenta.Size = new Size(207, 56);
            MSLRegistrarVenta.Text = "Registrar Venta";
            // 
            // LVendedorActual
            // 
            LVendedorActual.AutoSize = true;
            LVendedorActual.Location = new Point(12, 79);
            LVendedorActual.Name = "LVendedorActual";
            LVendedorActual.Size = new Size(99, 15);
            LVendedorActual.TabIndex = 1;
            LVendedorActual.Text = "Vendedor a cargo";
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Location = new Point(294, 79);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(78, 15);
            LCliente.TabIndex = 2;
            LCliente.Text = "Cliente titular";
            // 
            // LFechaVta
            // 
            LFechaVta.AutoSize = true;
            LFechaVta.Location = new Point(540, 79);
            LFechaVta.Name = "LFechaVta";
            LFechaVta.Size = new Size(89, 15);
            LFechaVta.TabIndex = 3;
            LFechaVta.Text = "Fecha de venta:";
            // 
            // TVendedorCargo
            // 
            TVendedorCargo.Location = new Point(117, 76);
            TVendedorCargo.Name = "TVendedorCargo";
            TVendedorCargo.Size = new Size(100, 23);
            TVendedorCargo.TabIndex = 6;
            // 
            // TClienteTitular
            // 
            TClienteTitular.Location = new Point(378, 76);
            TClienteTitular.Name = "TClienteTitular";
            TClienteTitular.Size = new Size(100, 23);
            TClienteTitular.TabIndex = 7;
            // 
            // TFechaCompra
            // 
            TFechaCompra.Location = new Point(642, 76);
            TFechaCompra.Name = "TFechaCompra";
            TFechaCompra.Size = new Size(146, 23);
            TFechaCompra.TabIndex = 8;
            // 
            // DTGDatosCompra
            // 
            DTGDatosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDatosCompra.Columns.AddRange(new DataGridViewColumn[] { DGCId_Producto, DGCNombreProd, DTCVendedorCargo, DGCCliente, DTCFecha, DTGCCantidad, DTCPrecioUnitario, DTGCEliminar });
            DTGDatosCompra.Location = new Point(12, 231);
            DTGDatosCompra.Name = "DTGDatosCompra";
            DTGDatosCompra.RowTemplate.Height = 25;
            DTGDatosCompra.Size = new Size(624, 207);
            DTGDatosCompra.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(LMarcaCompra);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(LGeneroCompra);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(LEstiloCompra);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(LTipoCompra);
            panel1.Controls.Add(TPrecioCompra);
            panel1.Controls.Add(NCantidadCompra);
            panel1.Controls.Add(LPrecioCompra);
            panel1.Controls.Add(LCantidadCompra);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(LNombreProdCompra);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(LIDProdCompra);
            panel1.Controls.Add(LInfoProd);
            panel1.Location = new Point(12, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 120);
            panel1.TabIndex = 10;
            // 
            // BAgregarProd
            // 
            BAgregarProd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BAgregarProd.Location = new Point(642, 171);
            BAgregarProd.Name = "BAgregarProd";
            BAgregarProd.Size = new Size(146, 54);
            BAgregarProd.TabIndex = 12;
            BAgregarProd.Text = "Agregar";
            BAgregarProd.UseVisualStyleBackColor = true;
            // 
            // BReiniciarCarrito
            // 
            BReiniciarCarrito.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BReiniciarCarrito.Location = new Point(642, 105);
            BReiniciarCarrito.Name = "BReiniciarCarrito";
            BReiniciarCarrito.Size = new Size(146, 60);
            BReiniciarCarrito.TabIndex = 13;
            BReiniciarCarrito.Text = "Reiniciar Carrito";
            BReiniciarCarrito.UseVisualStyleBackColor = true;
            // 
            // BRegistrarCompra
            // 
            BRegistrarCompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarCompra.Location = new Point(642, 387);
            BRegistrarCompra.Name = "BRegistrarCompra";
            BRegistrarCompra.Size = new Size(146, 51);
            BRegistrarCompra.TabIndex = 14;
            BRegistrarCompra.Text = "Registrar";
            BRegistrarCompra.UseVisualStyleBackColor = true;
            // 
            // LPrecioVenta
            // 
            LPrecioVenta.AutoSize = true;
            LPrecioVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecioVenta.Location = new Point(674, 334);
            LPrecioVenta.Name = "LPrecioVenta";
            LPrecioVenta.Size = new Size(92, 21);
            LPrecioVenta.TabIndex = 15;
            LPrecioVenta.Text = "Precio Total:";
            // 
            // TPrecioTotal
            // 
            TPrecioTotal.Location = new Point(642, 358);
            TPrecioTotal.Name = "TPrecioTotal";
            TPrecioTotal.Size = new Size(146, 23);
            TPrecioTotal.TabIndex = 16;
            // 
            // LInfoProd
            // 
            LInfoProd.AutoSize = true;
            LInfoProd.Location = new Point(228, 9);
            LInfoProd.Name = "LInfoProd";
            LInfoProd.Size = new Size(143, 15);
            LInfoProd.TabIndex = 0;
            LInfoProd.Text = "Informacion de producto:";
            // 
            // LIDProdCompra
            // 
            LIDProdCompra.AutoSize = true;
            LIDProdCompra.Location = new Point(15, 35);
            LIDProdCompra.Name = "LIDProdCompra";
            LIDProdCompra.Size = new Size(101, 15);
            LIDProdCompra.TabIndex = 1;
            LIDProdCompra.Text = "Codigo Producto:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 23);
            textBox4.TabIndex = 2;
            // 
            // LNombreProdCompra
            // 
            LNombreProdCompra.AutoSize = true;
            LNombreProdCompra.Location = new Point(15, 77);
            LNombreProdCompra.Name = "LNombreProdCompra";
            LNombreProdCompra.Size = new Size(59, 15);
            LNombreProdCompra.TabIndex = 3;
            LNombreProdCompra.Text = "Producto:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(80, 74);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93, 23);
            textBox5.TabIndex = 4;
            // 
            // LCantidadCompra
            // 
            LCantidadCompra.AutoSize = true;
            LCantidadCompra.Location = new Point(228, 35);
            LCantidadCompra.Name = "LCantidadCompra";
            LCantidadCompra.Size = new Size(58, 15);
            LCantidadCompra.TabIndex = 5;
            LCantidadCompra.Text = "Cantidad:";
            // 
            // LPrecioCompra
            // 
            LPrecioCompra.AutoSize = true;
            LPrecioCompra.Location = new Point(369, 35);
            LPrecioCompra.Name = "LPrecioCompra";
            LPrecioCompra.Size = new Size(43, 15);
            LPrecioCompra.TabIndex = 6;
            LPrecioCompra.Text = "Precio:";
            // 
            // NCantidadCompra
            // 
            NCantidadCompra.Location = new Point(292, 33);
            NCantidadCompra.Name = "NCantidadCompra";
            NCantidadCompra.Size = new Size(71, 23);
            NCantidadCompra.TabIndex = 7;
            // 
            // TPrecioCompra
            // 
            TPrecioCompra.Location = new Point(413, 32);
            TPrecioCompra.Name = "TPrecioCompra";
            TPrecioCompra.Size = new Size(81, 23);
            TPrecioCompra.TabIndex = 8;
            // 
            // LTipoCompra
            // 
            LTipoCompra.AutoSize = true;
            LTipoCompra.Location = new Point(183, 77);
            LTipoCompra.Name = "LTipoCompra";
            LTipoCompra.Size = new Size(33, 15);
            LTipoCompra.TabIndex = 9;
            LTipoCompra.Text = "Tipo:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(215, 74);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(71, 23);
            textBox6.TabIndex = 10;
            // 
            // LEstiloCompra
            // 
            LEstiloCompra.AutoSize = true;
            LEstiloCompra.Location = new Point(292, 77);
            LEstiloCompra.Name = "LEstiloCompra";
            LEstiloCompra.Size = new Size(38, 15);
            LEstiloCompra.TabIndex = 11;
            LEstiloCompra.Text = "Estilo:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(336, 74);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(71, 23);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(467, 74);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(71, 23);
            textBox8.TabIndex = 13;
            // 
            // LGeneroCompra
            // 
            LGeneroCompra.AutoSize = true;
            LGeneroCompra.Location = new Point(413, 77);
            LGeneroCompra.Name = "LGeneroCompra";
            LGeneroCompra.Size = new Size(48, 15);
            LGeneroCompra.TabIndex = 14;
            LGeneroCompra.Text = "Genero:";
            // 
            // LMarcaCompra
            // 
            LMarcaCompra.AutoSize = true;
            LMarcaCompra.Location = new Point(502, 35);
            LMarcaCompra.Name = "LMarcaCompra";
            LMarcaCompra.Size = new Size(43, 15);
            LMarcaCompra.TabIndex = 16;
            LMarcaCompra.Text = "Marca:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(546, 32);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(71, 23);
            textBox9.TabIndex = 15;
            // 
            // DGCId_Producto
            // 
            DGCId_Producto.HeaderText = "ID Producto";
            DGCId_Producto.Name = "DGCId_Producto";
            // 
            // DGCNombreProd
            // 
            DGCNombreProd.HeaderText = "Nombre";
            DGCNombreProd.Name = "DGCNombreProd";
            // 
            // DTCVendedorCargo
            // 
            DTCVendedorCargo.HeaderText = "Vendedor";
            DTCVendedorCargo.Name = "DTCVendedorCargo";
            // 
            // DGCCliente
            // 
            DGCCliente.HeaderText = "Cliente";
            DGCCliente.Name = "DGCCliente";
            // 
            // DTCFecha
            // 
            DTCFecha.HeaderText = "Fecha";
            DTCFecha.Name = "DTCFecha";
            // 
            // DTGCCantidad
            // 
            DTGCCantidad.HeaderText = "Cantidad";
            DTGCCantidad.Name = "DTGCCantidad";
            // 
            // DTCPrecioUnitario
            // 
            DTCPrecioUnitario.HeaderText = "Precio Unitario";
            DTCPrecioUnitario.Name = "DTCPrecioUnitario";
            // 
            // DTGCEliminar
            // 
            DTGCEliminar.HeaderText = "Acción";
            DTGCEliminar.Name = "DTGCEliminar";
            // 
            // Alta_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TPrecioTotal);
            Controls.Add(LPrecioVenta);
            Controls.Add(BRegistrarCompra);
            Controls.Add(BReiniciarCarrito);
            Controls.Add(BAgregarProd);
            Controls.Add(panel1);
            Controls.Add(DTGDatosCompra);
            Controls.Add(TFechaCompra);
            Controls.Add(TClienteTitular);
            Controls.Add(TVendedorCargo);
            Controls.Add(LFechaVta);
            Controls.Add(LCliente);
            Controls.Add(LVendedorActual);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Alta_venta";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NCantidadCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLRegistrarVenta;
        private Label LVendedorActual;
        private Label LCliente;
        private Label LFechaVta;
        private TextBox TVendedorCargo;
        private TextBox TClienteTitular;
        private TextBox TFechaCompra;
        private DataGridView DTGDatosCompra;
        private Panel panel1;
        private Button BAgregarProd;
        private Button BReiniciarCarrito;
        private Button BRegistrarCompra;
        private Label LPrecioVenta;
        private TextBox TPrecioTotal;
        private TextBox textBox5;
        private Label LNombreProdCompra;
        private TextBox textBox4;
        private Label LIDProdCompra;
        private Label LInfoProd;
        private Label LMarcaCompra;
        private TextBox textBox9;
        private Label LGeneroCompra;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label LEstiloCompra;
        private TextBox textBox6;
        private Label LTipoCompra;
        private TextBox TPrecioCompra;
        private NumericUpDown NCantidadCompra;
        private Label LPrecioCompra;
        private Label LCantidadCompra;
        private DataGridViewTextBoxColumn DGCId_Producto;
        private DataGridViewTextBoxColumn DGCNombreProd;
        private DataGridViewTextBoxColumn DTCVendedorCargo;
        private DataGridViewTextBoxColumn DGCCliente;
        private DataGridViewTextBoxColumn DTCFecha;
        private DataGridViewTextBoxColumn DTGCCantidad;
        private DataGridViewTextBoxColumn DTCPrecioUnitario;
        private DataGridViewButtonColumn DTGCEliminar;
    }
}
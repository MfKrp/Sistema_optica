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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            LVendedorActual = new Label();
            LCliente = new Label();
            LFechaVta = new Label();
            DTGDatosCompra = new DataGridView();
            DTGColumaIdProducto = new DataGridViewTextBoxColumn();
            DGVColumnaMarca = new DataGridViewTextBoxColumn();
            DGVColumnaTipo = new DataGridViewTextBoxColumn();
            DGVColumnaEstiloanteojo = new DataGridViewTextBoxColumn();
            DGVColumnaColor = new DataGridViewTextBoxColumn();
            DGVColumnaGenero = new DataGridViewTextBoxColumn();
            DGVColumnaCantidad = new DataGridViewTextBoxColumn();
            DTCPrecioUnitario = new DataGridViewTextBoxColumn();
            LMarcaCompra = new Label();
            TPrecio = new TextBox();
            LGeneroCompra = new Label();
            LEstiloCompra = new Label();
            LTipoCompra = new Label();
            NCantidadCompra = new NumericUpDown();
            LPrecioCompra = new Label();
            LCantidadCompra = new Label();
            TCodigoProducto = new TextBox();
            LIDProdCompra = new Label();
            LInfoProd = new Label();
            BAgregarProd = new Button();
            BReiniciarCarrito = new Button();
            BRegistrarCompra = new Button();
            LPrecioVenta = new Label();
            TPrecioTotal = new TextBox();
            LColor = new Label();
            panel1 = new Panel();
            TEstiloAnt = new TextBox();
            TMarcaAnt = new TextBox();
            TTipoAnt = new TextBox();
            CColor = new ComboBox();
            CBGenero = new ComboBox();
            panel2 = new Panel();
            LListaProductos = new Label();
            DGProductos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FechaVenta = new DateTimePicker();
            TDni_Vendedor = new TextBox();
            BBuscarDni = new Button();
            TDniCliente = new TextBox();
            BEliminarProd = new Button();
            CBFormaPago = new ComboBox();
            LFormaPago = new Label();
            TNumeroFactura = new TextBox();
            LNrofactura = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NCantidadCompra).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGProductos).BeginInit();
            SuspendLayout();
            // 
            // LVendedorActual
            // 
            LVendedorActual.Anchor = AnchorStyles.None;
            LVendedorActual.AutoSize = true;
            LVendedorActual.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            LVendedorActual.ForeColor = Color.FromArgb(0, 64, 64);
            LVendedorActual.Location = new Point(59, 65);
            LVendedorActual.Name = "LVendedorActual";
            LVendedorActual.Size = new Size(137, 21);
            LVendedorActual.TabIndex = 1;
            LVendedorActual.Text = "Vendedor a cargo";
            // 
            // LCliente
            // 
            LCliente.Anchor = AnchorStyles.None;
            LCliente.AutoSize = true;
            LCliente.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            LCliente.ForeColor = Color.FromArgb(0, 64, 64);
            LCliente.Location = new Point(297, 65);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(62, 21);
            LCliente.TabIndex = 2;
            LCliente.Text = "Cliente";
            // 
            // LFechaVta
            // 
            LFechaVta.Anchor = AnchorStyles.None;
            LFechaVta.AutoSize = true;
            LFechaVta.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            LFechaVta.ForeColor = Color.FromArgb(0, 64, 64);
            LFechaVta.Location = new Point(473, 94);
            LFechaVta.Name = "LFechaVta";
            LFechaVta.Size = new Size(107, 19);
            LFechaVta.TabIndex = 3;
            LFechaVta.Text = "Fecha de venta:";
            // 
            // DTGDatosCompra
            // 
            DTGDatosCompra.AllowUserToAddRows = false;
            DTGDatosCompra.AllowUserToDeleteRows = false;
            DTGDatosCompra.AllowUserToResizeColumns = false;
            DTGDatosCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            DTGDatosCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DTGDatosCompra.Anchor = AnchorStyles.None;
            DTGDatosCompra.BackgroundColor = Color.CadetBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DTGDatosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DTGDatosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDatosCompra.Columns.AddRange(new DataGridViewColumn[] { DTGColumaIdProducto, DGVColumnaMarca, DGVColumnaTipo, DGVColumnaEstiloanteojo, DGVColumnaColor, DGVColumnaGenero, DGVColumnaCantidad, DTCPrecioUnitario });
            DTGDatosCompra.Location = new Point(6, 344);
            DTGDatosCompra.Name = "DTGDatosCompra";
            DTGDatosCompra.RowTemplate.Height = 25;
            DTGDatosCompra.Size = new Size(805, 232);
            DTGDatosCompra.TabIndex = 9;
            DTGDatosCompra.CellContentClick += DTGDatosCompra_CellContentClick;
            // 
            // DTGColumaIdProducto
            // 
            DTGColumaIdProducto.HeaderText = "ID Producto";
            DTGColumaIdProducto.Name = "DTGColumaIdProducto";
            // 
            // DGVColumnaMarca
            // 
            DGVColumnaMarca.HeaderText = "Marca Anteojo";
            DGVColumnaMarca.Name = "DGVColumnaMarca";
            // 
            // DGVColumnaTipo
            // 
            DGVColumnaTipo.HeaderText = "Tipo Anteojo";
            DGVColumnaTipo.Name = "DGVColumnaTipo";
            // 
            // DGVColumnaEstiloanteojo
            // 
            DGVColumnaEstiloanteojo.HeaderText = "Estilo";
            DGVColumnaEstiloanteojo.Name = "DGVColumnaEstiloanteojo";
            // 
            // DGVColumnaColor
            // 
            DGVColumnaColor.HeaderText = "Color";
            DGVColumnaColor.Name = "DGVColumnaColor";
            // 
            // DGVColumnaGenero
            // 
            DGVColumnaGenero.HeaderText = "Genero";
            DGVColumnaGenero.Name = "DGVColumnaGenero";
            // 
            // DGVColumnaCantidad
            // 
            DGVColumnaCantidad.HeaderText = "Cantidad";
            DGVColumnaCantidad.Name = "DGVColumnaCantidad";
            // 
            // DTCPrecioUnitario
            // 
            DTCPrecioUnitario.HeaderText = "Precio";
            DTCPrecioUnitario.Name = "DTCPrecioUnitario";
            // 
            // LMarcaCompra
            // 
            LMarcaCompra.AutoSize = true;
            LMarcaCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LMarcaCompra.Location = new Point(6, 69);
            LMarcaCompra.Name = "LMarcaCompra";
            LMarcaCompra.Size = new Size(63, 23);
            LMarcaCompra.TabIndex = 16;
            LMarcaCompra.Text = "Marca:";
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(68, 142);
            TPrecio.Name = "TPrecio";
            TPrecio.ReadOnly = true;
            TPrecio.Size = new Size(105, 23);
            TPrecio.TabIndex = 15;
            TPrecio.TextChanged += TPrecio_TextChanged;
            TPrecio.KeyPress += TPrecio_KeyPress;
            // 
            // LGeneroCompra
            // 
            LGeneroCompra.AutoSize = true;
            LGeneroCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LGeneroCompra.Location = new Point(7, 107);
            LGeneroCompra.Name = "LGeneroCompra";
            LGeneroCompra.Size = new Size(69, 23);
            LGeneroCompra.TabIndex = 14;
            LGeneroCompra.Text = "Genero:";
            // 
            // LEstiloCompra
            // 
            LEstiloCompra.AutoSize = true;
            LEstiloCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEstiloCompra.Location = new Point(186, 69);
            LEstiloCompra.Name = "LEstiloCompra";
            LEstiloCompra.Size = new Size(58, 23);
            LEstiloCompra.TabIndex = 11;
            LEstiloCompra.Text = "Estilo:";
            // 
            // LTipoCompra
            // 
            LTipoCompra.AutoSize = true;
            LTipoCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTipoCompra.ForeColor = Color.FromArgb(0, 64, 64);
            LTipoCompra.Location = new Point(249, 10);
            LTipoCompra.Name = "LTipoCompra";
            LTipoCompra.Size = new Size(49, 23);
            LTipoCompra.TabIndex = 9;
            LTipoCompra.Text = "Tipo:";
            // 
            // NCantidadCompra
            // 
            NCantidadCompra.Location = new Point(284, 142);
            NCantidadCompra.Name = "NCantidadCompra";
            NCantidadCompra.Size = new Size(58, 23);
            NCantidadCompra.TabIndex = 7;
            // 
            // LPrecioCompra
            // 
            LPrecioCompra.AutoSize = true;
            LPrecioCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecioCompra.Location = new Point(7, 142);
            LPrecioCompra.Name = "LPrecioCompra";
            LPrecioCompra.Size = new Size(62, 23);
            LPrecioCompra.TabIndex = 6;
            LPrecioCompra.Text = "Precio:";
            // 
            // LCantidadCompra
            // 
            LCantidadCompra.AutoSize = true;
            LCantidadCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCantidadCompra.Location = new Point(186, 142);
            LCantidadCompra.Name = "LCantidadCompra";
            LCantidadCompra.Size = new Size(83, 23);
            LCantidadCompra.TabIndex = 5;
            LCantidadCompra.Text = "Cantidad:";
            // 
            // TCodigoProducto
            // 
            TCodigoProducto.Location = new Point(145, 36);
            TCodigoProducto.Name = "TCodigoProducto";
            TCodigoProducto.Size = new Size(77, 23);
            TCodigoProducto.TabIndex = 4;
            TCodigoProducto.TextChanged += TCodigoProducto_TextChanged;
            TCodigoProducto.KeyPress += TCodigoProducto_KeyPress;
            // 
            // LIDProdCompra
            // 
            LIDProdCompra.AutoSize = true;
            LIDProdCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LIDProdCompra.Location = new Point(6, 33);
            LIDProdCompra.Name = "LIDProdCompra";
            LIDProdCompra.Size = new Size(139, 23);
            LIDProdCompra.TabIndex = 1;
            LIDProdCompra.Text = "Codigo Producto:";
            // 
            // LInfoProd
            // 
            LInfoProd.AutoSize = true;
            LInfoProd.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LInfoProd.Location = new Point(6, 0);
            LInfoProd.Name = "LInfoProd";
            LInfoProd.Size = new Size(81, 23);
            LInfoProd.TabIndex = 0;
            LInfoProd.Text = "Producto";
            // 
            // BAgregarProd
            // 
            BAgregarProd.Anchor = AnchorStyles.None;
            BAgregarProd.BackColor = Color.Green;
            BAgregarProd.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BAgregarProd.ForeColor = Color.White;
            BAgregarProd.Location = new Point(817, 215);
            BAgregarProd.Name = "BAgregarProd";
            BAgregarProd.Size = new Size(131, 37);
            BAgregarProd.TabIndex = 12;
            BAgregarProd.Text = "Agregar";
            BAgregarProd.UseVisualStyleBackColor = false;
            BAgregarProd.Click += BAgregarProd_Click;
            // 
            // BReiniciarCarrito
            // 
            BReiniciarCarrito.Anchor = AnchorStyles.None;
            BReiniciarCarrito.BackColor = Color.Red;
            BReiniciarCarrito.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BReiniciarCarrito.ForeColor = Color.White;
            BReiniciarCarrito.Location = new Point(817, 173);
            BReiniciarCarrito.Name = "BReiniciarCarrito";
            BReiniciarCarrito.Size = new Size(131, 37);
            BReiniciarCarrito.TabIndex = 13;
            BReiniciarCarrito.Text = "Reiniciar Carrito";
            BReiniciarCarrito.UseVisualStyleBackColor = false;
            BReiniciarCarrito.Click += BReiniciarCarrito_Click;
            // 
            // BRegistrarCompra
            // 
            BRegistrarCompra.Anchor = AnchorStyles.None;
            BRegistrarCompra.BackColor = Color.Green;
            BRegistrarCompra.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BRegistrarCompra.ForeColor = Color.White;
            BRegistrarCompra.Location = new Point(822, 478);
            BRegistrarCompra.Name = "BRegistrarCompra";
            BRegistrarCompra.Size = new Size(126, 35);
            BRegistrarCompra.TabIndex = 14;
            BRegistrarCompra.Text = "Registrar";
            BRegistrarCompra.UseVisualStyleBackColor = false;
            BRegistrarCompra.Click += BRegistrarCompra_Click;
            // 
            // LPrecioVenta
            // 
            LPrecioVenta.Anchor = AnchorStyles.None;
            LPrecioVenta.AutoSize = true;
            LPrecioVenta.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LPrecioVenta.ForeColor = Color.FromArgb(0, 64, 64);
            LPrecioVenta.Location = new Point(832, 334);
            LPrecioVenta.Name = "LPrecioVenta";
            LPrecioVenta.Size = new Size(112, 23);
            LPrecioVenta.TabIndex = 15;
            LPrecioVenta.Text = "Precio Total:";
            // 
            // TPrecioTotal
            // 
            TPrecioTotal.Anchor = AnchorStyles.None;
            TPrecioTotal.Location = new Point(832, 360);
            TPrecioTotal.Name = "TPrecioTotal";
            TPrecioTotal.Size = new Size(104, 23);
            TPrecioTotal.TabIndex = 16;
            TPrecioTotal.TextChanged += TPrecioTotal_TextChanged;
            // 
            // LColor
            // 
            LColor.AutoSize = true;
            LColor.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LColor.ForeColor = Color.FromArgb(0, 64, 64);
            LColor.Location = new Point(188, 107);
            LColor.Name = "LColor";
            LColor.Size = new Size(56, 23);
            LColor.TabIndex = 19;
            LColor.Text = "Color:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TEstiloAnt);
            panel1.Controls.Add(TMarcaAnt);
            panel1.Controls.Add(TTipoAnt);
            panel1.Controls.Add(CColor);
            panel1.Controls.Add(CBGenero);
            panel1.Controls.Add(LColor);
            panel1.Controls.Add(LInfoProd);
            panel1.Controls.Add(LTipoCompra);
            panel1.Controls.Add(LMarcaCompra);
            panel1.Controls.Add(LGeneroCompra);
            panel1.Controls.Add(NCantidadCompra);
            panel1.Controls.Add(LEstiloCompra);
            panel1.Controls.Add(LCantidadCompra);
            panel1.Controls.Add(TPrecio);
            panel1.Controls.Add(LPrecioCompra);
            panel1.Controls.Add(TCodigoProducto);
            panel1.Controls.Add(LIDProdCompra);
            panel1.ForeColor = Color.FromArgb(0, 64, 64);
            panel1.Location = new Point(16, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 179);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // TEstiloAnt
            // 
            TEstiloAnt.Location = new Point(249, 69);
            TEstiloAnt.Name = "TEstiloAnt";
            TEstiloAnt.ReadOnly = true;
            TEstiloAnt.Size = new Size(93, 23);
            TEstiloAnt.TabIndex = 35;
            // 
            // TMarcaAnt
            // 
            TMarcaAnt.Location = new Point(82, 69);
            TMarcaAnt.Name = "TMarcaAnt";
            TMarcaAnt.ReadOnly = true;
            TMarcaAnt.Size = new Size(91, 23);
            TMarcaAnt.TabIndex = 34;
            // 
            // TTipoAnt
            // 
            TTipoAnt.Location = new Point(249, 36);
            TTipoAnt.Name = "TTipoAnt";
            TTipoAnt.ReadOnly = true;
            TTipoAnt.Size = new Size(93, 23);
            TTipoAnt.TabIndex = 33;
            // 
            // CColor
            // 
            CColor.DropDownStyle = ComboBoxStyle.DropDownList;
            CColor.FormattingEnabled = true;
            CColor.Items.AddRange(new object[] { "AMARILLO", "ROJO", "VIOLETA", "AZUL", "VERDE", "NEGRO", "BLANCO", "ROSA" });
            CColor.Location = new Point(249, 107);
            CColor.Name = "CColor";
            CColor.Size = new Size(93, 23);
            CColor.TabIndex = 32;
            // 
            // CBGenero
            // 
            CBGenero.Anchor = AnchorStyles.None;
            CBGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGenero.FormattingEnabled = true;
            CBGenero.Items.AddRange(new object[] { "M", "F" });
            CBGenero.Location = new Point(82, 107);
            CBGenero.Name = "CBGenero";
            CBGenero.Size = new Size(91, 23);
            CBGenero.TabIndex = 30;
            CBGenero.SelectedIndexChanged += CBGenero_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(LListaProductos);
            panel2.Controls.Add(DGProductos);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(6, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 206);
            panel2.TabIndex = 30;
            // 
            // LListaProductos
            // 
            LListaProductos.Anchor = AnchorStyles.None;
            LListaProductos.AutoSize = true;
            LListaProductos.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            LListaProductos.ForeColor = Color.FromArgb(0, 64, 64);
            LListaProductos.Location = new Point(380, 14);
            LListaProductos.Name = "LListaProductos";
            LListaProductos.Size = new Size(146, 21);
            LListaProductos.TabIndex = 78;
            LListaProductos.Text = "Lista de productos";
            // 
            // DGProductos
            // 
            DGProductos.AllowUserToAddRows = false;
            DGProductos.AllowUserToDeleteRows = false;
            DGProductos.AllowUserToResizeColumns = false;
            DGProductos.AllowUserToResizeRows = false;
            DGProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGProductos.Location = new Point(380, 38);
            DGProductos.MultiSelect = false;
            DGProductos.Name = "DGProductos";
            DGProductos.ReadOnly = true;
            DGProductos.RowTemplate.Height = 25;
            DGProductos.Size = new Size(412, 154);
            DGProductos.TabIndex = 30;
            DGProductos.CellContentClick += DGProductos_CellContentClick;
            DGProductos.CellDoubleClick += DGProductos_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(211, 95);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 33;
            label1.Text = "DNI Cliente";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(20, 95);
            label2.Name = "label2";
            label2.Size = new Size(33, 19);
            label2.TabIndex = 34;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(577, 65);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 35;
            label3.Text = "(dd/mm/aaaa)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(355, 23);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 74;
            label4.Text = "GENERAR VENTA";
            // 
            // FechaVenta
            // 
            FechaVenta.Anchor = AnchorStyles.None;
            FechaVenta.Format = DateTimePickerFormat.Short;
            FechaVenta.Location = new Point(577, 92);
            FechaVenta.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            FechaVenta.Name = "FechaVenta";
            FechaVenta.Size = new Size(171, 23);
            FechaVenta.TabIndex = 75;
            // 
            // TDni_Vendedor
            // 
            TDni_Vendedor.Anchor = AnchorStyles.None;
            TDni_Vendedor.Location = new Point(59, 94);
            TDni_Vendedor.Name = "TDni_Vendedor";
            TDni_Vendedor.ReadOnly = true;
            TDni_Vendedor.Size = new Size(137, 23);
            TDni_Vendedor.TabIndex = 76;
            TDni_Vendedor.TextChanged += TDni_Vendedor_TextChanged;
            TDni_Vendedor.KeyPress += TDni_Vendedor_KeyPress;
            // 
            // BBuscarDni
            // 
            BBuscarDni.BackColor = Color.SteelBlue;
            BBuscarDni.FlatStyle = FlatStyle.Flat;
            BBuscarDni.ForeColor = Color.Black;
            BBuscarDni.Location = new Point(403, 94);
            BBuscarDni.Name = "BBuscarDni";
            BBuscarDni.Size = new Size(58, 23);
            BBuscarDni.TabIndex = 33;
            BBuscarDni.Text = "Buscar";
            BBuscarDni.UseVisualStyleBackColor = false;
            BBuscarDni.Click += BBuscarDni_Click;
            // 
            // TDniCliente
            // 
            TDniCliente.Location = new Point(297, 94);
            TDniCliente.Name = "TDniCliente";
            TDniCliente.ReadOnly = true;
            TDniCliente.Size = new Size(100, 23);
            TDniCliente.TabIndex = 77;
            TDniCliente.TextChanged += TDniCliente_TextChanged;
            // 
            // BEliminarProd
            // 
            BEliminarProd.Anchor = AnchorStyles.None;
            BEliminarProd.BackColor = Color.DodgerBlue;
            BEliminarProd.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BEliminarProd.ForeColor = Color.White;
            BEliminarProd.Location = new Point(817, 258);
            BEliminarProd.Name = "BEliminarProd";
            BEliminarProd.Size = new Size(131, 37);
            BEliminarProd.TabIndex = 78;
            BEliminarProd.Text = "Quitar";
            BEliminarProd.UseVisualStyleBackColor = false;
            BEliminarProd.Click += BEliminarProd_Click;
            // 
            // CBFormaPago
            // 
            CBFormaPago.FormattingEnabled = true;
            CBFormaPago.Items.AddRange(new object[] { "Debito", "Efectivo", "Mercado Pago" });
            CBFormaPago.Location = new Point(832, 412);
            CBFormaPago.Name = "CBFormaPago";
            CBFormaPago.Size = new Size(104, 23);
            CBFormaPago.TabIndex = 79;
            // 
            // LFormaPago
            // 
            LFormaPago.Anchor = AnchorStyles.None;
            LFormaPago.AutoSize = true;
            LFormaPago.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LFormaPago.ForeColor = Color.FromArgb(0, 64, 64);
            LFormaPago.Location = new Point(822, 386);
            LFormaPago.Name = "LFormaPago";
            LFormaPago.Size = new Size(127, 23);
            LFormaPago.TabIndex = 80;
            LFormaPago.Text = "Forma de pago";
            // 
            // TNumeroFactura
            // 
            TNumeroFactura.Anchor = AnchorStyles.None;
            TNumeroFactura.Location = new Point(817, 92);
            TNumeroFactura.Name = "TNumeroFactura";
            TNumeroFactura.ReadOnly = true;
            TNumeroFactura.Size = new Size(100, 23);
            TNumeroFactura.TabIndex = 81;
            TNumeroFactura.TextChanged += textBox1_TextChanged;
            // 
            // LNrofactura
            // 
            LNrofactura.Anchor = AnchorStyles.None;
            LNrofactura.AutoSize = true;
            LNrofactura.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            LNrofactura.Location = new Point(787, 65);
            LNrofactura.Name = "LNrofactura";
            LNrofactura.Size = new Size(149, 21);
            LNrofactura.TabIndex = 82;
            LNrofactura.Text = "Numero de factura";
            // 
            // Alta_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 588);
            Controls.Add(LNrofactura);
            Controls.Add(TNumeroFactura);
            Controls.Add(LFormaPago);
            Controls.Add(CBFormaPago);
            Controls.Add(BEliminarProd);
            Controls.Add(TDniCliente);
            Controls.Add(BBuscarDni);
            Controls.Add(BReiniciarCarrito);
            Controls.Add(TDni_Vendedor);
            Controls.Add(FechaVenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TPrecioTotal);
            Controls.Add(LPrecioVenta);
            Controls.Add(BRegistrarCompra);
            Controls.Add(BAgregarProd);
            Controls.Add(DTGDatosCompra);
            Controls.Add(LFechaVta);
            Controls.Add(LCliente);
            Controls.Add(LVendedorActual);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Alta_venta";
            Text = "Form1";
            Load += Alta_venta_Load;
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)NCantidadCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LVendedorActual;
        private Label LCliente;
        private Label LFechaVta;
        private DataGridView DTGDatosCompra;
        private Button BAgregarProd;
        private Button BReiniciarCarrito;
        private Button BRegistrarCompra;
        private Label LPrecioVenta;
        private TextBox TPrecioTotal;
        private TextBox TCodigoProducto;
        private Label LIDProdCompra;
        private Label LInfoProd;
        private Label LMarcaCompra;
        private TextBox TPrecio;
        private Label LGeneroCompra;
        private Label LEstiloCompra;
        private Label LTipoCompra;
        private NumericUpDown NCantidadCompra;
        private Label LPrecioCompra;
        private Label LCantidadCompra;
        private Label LColor;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker FechaVenta;
        private TextBox TDni_Vendedor;
        private ComboBox CBGenero;
        private ComboBox CColor;
        private Button BBuscarDni;
        private DataGridView DGProductos;
        private Label LListaProductos;
        private TextBox TDniCliente;
        private TextBox TEstiloAnt;
        private TextBox TMarcaAnt;
        private TextBox TTipoAnt;
        private DataGridViewTextBoxColumn DTGColumaIdProducto;
        private DataGridViewTextBoxColumn DGVColumnaMarca;
        private DataGridViewTextBoxColumn DGVColumnaTipo;
        private DataGridViewTextBoxColumn DGVColumnaEstiloanteojo;
        private DataGridViewTextBoxColumn DGVColumnaColor;
        private DataGridViewTextBoxColumn DGVColumnaGenero;
        private DataGridViewTextBoxColumn DGVColumnaCantidad;
        private DataGridViewTextBoxColumn DTCPrecioUnitario;
        private Button BEliminarProd;
        private ComboBox CBFormaPago;
        private Label LFormaPago;
        private TextBox TNumeroFactura;
        private Label LNrofactura;
    }
}
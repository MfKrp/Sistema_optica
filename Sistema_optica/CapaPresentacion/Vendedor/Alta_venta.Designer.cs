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
            TVendedorCargo = new TextBox();
            TClienteTitular = new TextBox();
            TFechaCompra = new TextBox();
            DTGDatosCompra = new DataGridView();
            DGCId_Producto = new DataGridViewTextBoxColumn();
            DGCNombreProd = new DataGridViewTextBoxColumn();
            DTCVendedorCargo = new DataGridViewTextBoxColumn();
            DGCCliente = new DataGridViewTextBoxColumn();
            DTCFecha = new DataGridViewTextBoxColumn();
            DTGCCantidad = new DataGridViewTextBoxColumn();
            DTCPrecioUnitario = new DataGridViewTextBoxColumn();
            DTGCEliminar = new DataGridViewButtonColumn();
            LMarcaCompra = new Label();
            textBox9 = new TextBox();
            LGeneroCompra = new Label();
            LEstiloCompra = new Label();
            LTipoCompra = new Label();
            NCantidadCompra = new NumericUpDown();
            LPrecioCompra = new Label();
            LCantidadCompra = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            LIDProdCompra = new Label();
            LInfoProd = new Label();
            BAgregarProd = new Button();
            BReiniciarCarrito = new Button();
            BRegistrarCompra = new Button();
            LPrecioVenta = new Label();
            TPrecioTotal = new TextBox();
            comboBox1 = new ComboBox();
            LTalle = new Label();
            LColor = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            checkBox_masc = new CheckBox();
            checkBox_fem = new CheckBox();
            checkBox_unisex = new CheckBox();
            checkBox_L = new CheckBox();
            checkBox_s = new CheckBox();
            checkBox_m = new CheckBox();
            checkBox_xs = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NCantidadCompra).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            LCliente.Location = new Point(311, 67);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(62, 21);
            LCliente.TabIndex = 2;
            LCliente.Text = "Cliente";
            // 
            // LFechaVta
            // 
            LFechaVta.Anchor = AnchorStyles.None;
            LFechaVta.AutoSize = true;
            LFechaVta.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LFechaVta.ForeColor = Color.FromArgb(0, 64, 64);
            LFechaVta.Location = new Point(499, 91);
            LFechaVta.Name = "LFechaVta";
            LFechaVta.Size = new Size(135, 23);
            LFechaVta.TabIndex = 3;
            LFechaVta.Text = "Fecha de venta:";
            // 
            // TVendedorCargo
            // 
            TVendedorCargo.Location = new Point(608, 41);
            TVendedorCargo.Name = "TVendedorCargo";
            TVendedorCargo.Size = new Size(136, 23);
            TVendedorCargo.TabIndex = 6;
            TVendedorCargo.TextChanged += TVendedorCargo_TextChanged;
            // 
            // TClienteTitular
            // 
            TClienteTitular.Anchor = AnchorStyles.None;
            TClienteTitular.Location = new Point(311, 91);
            TClienteTitular.Name = "TClienteTitular";
            TClienteTitular.Size = new Size(136, 23);
            TClienteTitular.TabIndex = 7;
            // 
            // TFechaCompra
            // 
            TFechaCompra.Anchor = AnchorStyles.None;
            TFechaCompra.Location = new Point(640, 91);
            TFechaCompra.Name = "TFechaCompra";
            TFechaCompra.Size = new Size(135, 23);
            TFechaCompra.TabIndex = 8;
            // 
            // DTGDatosCompra
            // 
            DTGDatosCompra.AllowUserToAddRows = false;
            DTGDatosCompra.AllowUserToDeleteRows = false;
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
            DTGDatosCompra.Columns.AddRange(new DataGridViewColumn[] { DGCId_Producto, DGCNombreProd, DTCVendedorCargo, DGCCliente, DTCFecha, DTGCCantidad, DTCPrecioUnitario, DTGCEliminar });
            DTGDatosCompra.Location = new Point(6, 344);
            DTGDatosCompra.Name = "DTGDatosCompra";
            DTGDatosCompra.RowTemplate.Height = 25;
            DTGDatosCompra.Size = new Size(805, 232);
            DTGDatosCompra.TabIndex = 9;
            DTGDatosCompra.CellContentClick += DTGDatosCompra_CellContentClick;
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
            // LMarcaCompra
            // 
            LMarcaCompra.AutoSize = true;
            LMarcaCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LMarcaCompra.Location = new Point(263, 87);
            LMarcaCompra.Name = "LMarcaCompra";
            LMarcaCompra.Size = new Size(63, 23);
            LMarcaCompra.TabIndex = 16;
            LMarcaCompra.Text = "Marca:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(491, 138);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(81, 23);
            textBox9.TabIndex = 15;
            // 
            // LGeneroCompra
            // 
            LGeneroCompra.AutoSize = true;
            LGeneroCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LGeneroCompra.Location = new Point(7, 135);
            LGeneroCompra.Name = "LGeneroCompra";
            LGeneroCompra.Size = new Size(69, 23);
            LGeneroCompra.TabIndex = 14;
            LGeneroCompra.Text = "Genero:";
            // 
            // LEstiloCompra
            // 
            LEstiloCompra.AutoSize = true;
            LEstiloCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEstiloCompra.Location = new Point(7, 87);
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
            LTipoCompra.Location = new Point(288, 41);
            LTipoCompra.Name = "LTipoCompra";
            LTipoCompra.Size = new Size(49, 23);
            LTipoCompra.TabIndex = 9;
            LTipoCompra.Text = "Tipo:";
            // 
            // NCantidadCompra
            // 
            NCantidadCompra.Location = new Point(686, 138);
            NCantidadCompra.Name = "NCantidadCompra";
            NCantidadCompra.Size = new Size(58, 23);
            NCantidadCompra.TabIndex = 7;
            // 
            // LPrecioCompra
            // 
            LPrecioCompra.AutoSize = true;
            LPrecioCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecioCompra.Location = new Point(423, 139);
            LPrecioCompra.Name = "LPrecioCompra";
            LPrecioCompra.Size = new Size(62, 23);
            LPrecioCompra.TabIndex = 6;
            LPrecioCompra.Text = "Precio:";
            // 
            // LCantidadCompra
            // 
            LCantidadCompra.AutoSize = true;
            LCantidadCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCantidadCompra.Location = new Point(597, 139);
            LCantidadCompra.Name = "LCantidadCompra";
            LCantidadCompra.Size = new Size(83, 23);
            LCantidadCompra.TabIndex = 5;
            LCantidadCompra.Text = "Cantidad:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(59, 91);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 2;
            // 
            // LIDProdCompra
            // 
            LIDProdCompra.AutoSize = true;
            LIDProdCompra.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LIDProdCompra.Location = new Point(6, 41);
            LIDProdCompra.Name = "LIDProdCompra";
            LIDProdCompra.Size = new Size(139, 23);
            LIDProdCompra.TabIndex = 1;
            LIDProdCompra.Text = "Codigo Producto:";
            // 
            // LInfoProd
            // 
            LInfoProd.AutoSize = true;
            LInfoProd.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LInfoProd.Location = new Point(-1, 0);
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
            // 
            // BReiniciarCarrito
            // 
            BReiniciarCarrito.Anchor = AnchorStyles.None;
            BReiniciarCarrito.BackColor = Color.Red;
            BReiniciarCarrito.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BReiniciarCarrito.ForeColor = Color.White;
            BReiniciarCarrito.Location = new Point(817, 166);
            BReiniciarCarrito.Name = "BReiniciarCarrito";
            BReiniciarCarrito.Size = new Size(131, 44);
            BReiniciarCarrito.TabIndex = 13;
            BReiniciarCarrito.Text = "Reiniciar Carrito";
            BReiniciarCarrito.UseVisualStyleBackColor = false;
            // 
            // BRegistrarCompra
            // 
            BRegistrarCompra.Anchor = AnchorStyles.None;
            BRegistrarCompra.BackColor = Color.Green;
            BRegistrarCompra.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BRegistrarCompra.ForeColor = Color.White;
            BRegistrarCompra.Location = new Point(822, 479);
            BRegistrarCompra.Name = "BRegistrarCompra";
            BRegistrarCompra.Size = new Size(126, 35);
            BRegistrarCompra.TabIndex = 14;
            BRegistrarCompra.Text = "Registrar";
            BRegistrarCompra.UseVisualStyleBackColor = false;
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
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(343, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 17;
            // 
            // LTalle
            // 
            LTalle.AutoSize = true;
            LTalle.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTalle.Location = new Point(520, 87);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(52, 23);
            LTalle.TabIndex = 18;
            LTalle.Text = "Talle:";
            // 
            // LColor
            // 
            LColor.AutoSize = true;
            LColor.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LColor.ForeColor = Color.FromArgb(0, 64, 64);
            LColor.Location = new Point(546, 41);
            LColor.Name = "LColor";
            LColor.Size = new Size(56, 23);
            LColor.TabIndex = 19;
            LColor.Text = "Color:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(332, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 23);
            comboBox2.TabIndex = 20;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(71, 87);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(153, 23);
            comboBox3.TabIndex = 21;
            // 
            // checkBox_masc
            // 
            checkBox_masc.AutoSize = true;
            checkBox_masc.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_masc.Location = new Point(99, 138);
            checkBox_masc.Name = "checkBox_masc";
            checkBox_masc.Size = new Size(109, 22);
            checkBox_masc.TabIndex = 22;
            checkBox_masc.Text = "M (masculino)";
            checkBox_masc.UseVisualStyleBackColor = true;
            // 
            // checkBox_fem
            // 
            checkBox_fem.AutoSize = true;
            checkBox_fem.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_fem.Location = new Point(214, 138);
            checkBox_fem.Name = "checkBox_fem";
            checkBox_fem.Size = new Size(99, 22);
            checkBox_fem.TabIndex = 23;
            checkBox_fem.Text = "F (femenino)";
            checkBox_fem.UseVisualStyleBackColor = true;
            // 
            // checkBox_unisex
            // 
            checkBox_unisex.AutoSize = true;
            checkBox_unisex.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_unisex.Location = new Point(319, 138);
            checkBox_unisex.Name = "checkBox_unisex";
            checkBox_unisex.Size = new Size(86, 22);
            checkBox_unisex.TabIndex = 24;
            checkBox_unisex.Text = "U (unisex)";
            checkBox_unisex.UseVisualStyleBackColor = true;
            // 
            // checkBox_L
            // 
            checkBox_L.AutoSize = true;
            checkBox_L.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_L.Location = new Point(710, 92);
            checkBox_L.Name = "checkBox_L";
            checkBox_L.Size = new Size(34, 22);
            checkBox_L.TabIndex = 25;
            checkBox_L.Text = "L";
            checkBox_L.UseVisualStyleBackColor = true;
            // 
            // checkBox_s
            // 
            checkBox_s.AutoSize = true;
            checkBox_s.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_s.Location = new Point(626, 92);
            checkBox_s.Name = "checkBox_s";
            checkBox_s.Size = new Size(34, 22);
            checkBox_s.TabIndex = 26;
            checkBox_s.Text = "S";
            checkBox_s.UseVisualStyleBackColor = true;
            // 
            // checkBox_m
            // 
            checkBox_m.AutoSize = true;
            checkBox_m.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_m.Location = new Point(666, 92);
            checkBox_m.Name = "checkBox_m";
            checkBox_m.Size = new Size(38, 22);
            checkBox_m.TabIndex = 27;
            checkBox_m.Text = "M";
            checkBox_m.UseVisualStyleBackColor = true;
            // 
            // checkBox_xs
            // 
            checkBox_xs.AutoSize = true;
            checkBox_xs.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_xs.Location = new Point(582, 92);
            checkBox_xs.Name = "checkBox_xs";
            checkBox_xs.Size = new Size(42, 22);
            checkBox_xs.TabIndex = 28;
            checkBox_xs.Text = "XS";
            checkBox_xs.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBox_masc);
            panel1.Controls.Add(checkBox_fem);
            panel1.Controls.Add(checkBox_unisex);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(LColor);
            panel1.Controls.Add(checkBox_xs);
            panel1.Controls.Add(LInfoProd);
            panel1.Controls.Add(checkBox_s);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(LTipoCompra);
            panel1.Controls.Add(checkBox_m);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(TVendedorCargo);
            panel1.Controls.Add(checkBox_L);
            panel1.Controls.Add(LMarcaCompra);
            panel1.Controls.Add(LTalle);
            panel1.Controls.Add(LGeneroCompra);
            panel1.Controls.Add(NCantidadCompra);
            panel1.Controls.Add(LEstiloCompra);
            panel1.Controls.Add(LCantidadCompra);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(LPrecioCompra);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(LIDProdCompra);
            panel1.ForeColor = Color.FromArgb(0, 64, 64);
            panel1.Location = new Point(16, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 179);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(6, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 206);
            panel2.TabIndex = 30;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(272, 95);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 33;
            label1.Text = "DNI";
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
            label3.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(661, 69);
            label3.Name = "label3";
            label3.Size = new Size(101, 19);
            label3.TabIndex = 35;
            label3.Text = "(dd/mm/aaaa)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(355, 9);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 74;
            label4.Text = "GENERAR VENTA";
            // 
            // Alta_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 588);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TPrecioTotal);
            Controls.Add(LPrecioVenta);
            Controls.Add(BRegistrarCompra);
            Controls.Add(BReiniciarCarrito);
            Controls.Add(BAgregarProd);
            Controls.Add(DTGDatosCompra);
            Controls.Add(TFechaCompra);
            Controls.Add(TClienteTitular);
            Controls.Add(LFechaVta);
            Controls.Add(LCliente);
            Controls.Add(textBox4);
            Controls.Add(LVendedorActual);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Alta_venta";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)NCantidadCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LVendedorActual;
        private Label LCliente;
        private Label LFechaVta;
        private TextBox TVendedorCargo;
        private TextBox TClienteTitular;
        private TextBox TFechaCompra;
        private DataGridView DTGDatosCompra;
        private Button BAgregarProd;
        private Button BReiniciarCarrito;
        private Button BRegistrarCompra;
        private Label LPrecioVenta;
        private TextBox TPrecioTotal;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label LIDProdCompra;
        private Label LInfoProd;
        private Label LMarcaCompra;
        private TextBox textBox9;
        private Label LGeneroCompra;
        private Label LEstiloCompra;
        private Label LTipoCompra;
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
        private ComboBox comboBox1;
        private Label LTalle;
        private Label LColor;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private CheckBox checkBox_masc;
        private CheckBox checkBox_fem;
        private CheckBox checkBox_unisex;
        private CheckBox checkBox_L;
        private CheckBox checkBox_s;
        private CheckBox checkBox_m;
        private CheckBox checkBox_xs;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
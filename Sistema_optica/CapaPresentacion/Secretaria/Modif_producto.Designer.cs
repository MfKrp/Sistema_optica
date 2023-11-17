namespace CapaPresentacion.Secretaria
{
    partial class Modif_producto
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
            label2 = new Label();
            BBorrar = new Button();
            BGuardar = new Button();
            LMarca = new Label();
            ComboBox_Estilo = new ComboBox();
            ComnboBox_Anteojo = new ComboBox();
            TId_prod = new TextBox();
            TPrecio = new TextBox();
            LPrecio = new Label();
            LId_prod = new Label();
            LTipo = new Label();
            LEstilo = new Label();
            ComboBox_Marca = new ComboBox();
            DGVProductos = new DataGridView();
            TStock = new TextBox();
            LStock = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(158, 9);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 73;
            label2.Text = "MODIFICAR PRODUCTO";
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.BackColor = Color.Red;
            BBorrar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BBorrar.ForeColor = Color.White;
            BBorrar.Location = new Point(166, 130);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(88, 36);
            BBorrar.TabIndex = 72;
            BBorrar.Text = "Borrar";
            BBorrar.UseVisualStyleBackColor = false;
            BBorrar.Click += BBorrar_Click;
            // 
            // BGuardar
            // 
            BGuardar.Anchor = AnchorStyles.None;
            BGuardar.BackColor = Color.Green;
            BGuardar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(272, 130);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 36);
            BGuardar.TabIndex = 71;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // LMarca
            // 
            LMarca.Anchor = AnchorStyles.None;
            LMarca.AutoSize = true;
            LMarca.BackColor = SystemColors.ButtonFace;
            LMarca.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.Black;
            LMarca.Location = new Point(319, 48);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(57, 23);
            LMarca.TabIndex = 59;
            LMarca.Text = "Marca";
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.Anchor = AnchorStyles.None;
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(67, 88);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(84, 23);
            ComboBox_Estilo.TabIndex = 66;
            ComboBox_Estilo.SelectedIndexChanged += ComboBox_Estilo_SelectedIndexChanged;
            // 
            // ComnboBox_Anteojo
            // 
            ComnboBox_Anteojo.Anchor = AnchorStyles.None;
            ComnboBox_Anteojo.FormattingEnabled = true;
            ComnboBox_Anteojo.Location = new Point(218, 88);
            ComnboBox_Anteojo.Name = "ComnboBox_Anteojo";
            ComnboBox_Anteojo.Size = new Size(87, 23);
            ComnboBox_Anteojo.TabIndex = 67;
            ComnboBox_Anteojo.SelectedIndexChanged += ComnboBox_Anteojo_SelectedIndexChanged;
            // 
            // TId_prod
            // 
            TId_prod.Anchor = AnchorStyles.None;
            TId_prod.Location = new Point(43, 48);
            TId_prod.Name = "TId_prod";
            TId_prod.ReadOnly = true;
            TId_prod.Size = new Size(108, 23);
            TId_prod.TabIndex = 69;
            TId_prod.TextChanged += TId_prod_TextChanged;
            TId_prod.KeyPress += TId_prod_KeyPress;
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.None;
            TPrecio.Location = new Point(218, 48);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(87, 23);
            TPrecio.TabIndex = 70;
            TPrecio.TextChanged += TPrecio_TextChanged;
            TPrecio.KeyPress += TPrecio_KeyPressEventArgs;
            // 
            // LPrecio
            // 
            LPrecio.Anchor = AnchorStyles.None;
            LPrecio.AutoSize = true;
            LPrecio.BackColor = SystemColors.ButtonFace;
            LPrecio.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.Black;
            LPrecio.Location = new Point(156, 48);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(56, 23);
            LPrecio.TabIndex = 62;
            LPrecio.Text = "Precio";
            // 
            // LId_prod
            // 
            LId_prod.Anchor = AnchorStyles.None;
            LId_prod.AutoSize = true;
            LId_prod.BackColor = SystemColors.ButtonFace;
            LId_prod.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LId_prod.ForeColor = Color.Black;
            LId_prod.Location = new Point(10, 48);
            LId_prod.Name = "LId_prod";
            LId_prod.Size = new Size(27, 23);
            LId_prod.TabIndex = 54;
            LId_prod.Text = "ID";
            // 
            // LTipo
            // 
            LTipo.Anchor = AnchorStyles.None;
            LTipo.AutoSize = true;
            LTipo.BackColor = SystemColors.ButtonFace;
            LTipo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTipo.ForeColor = Color.Black;
            LTipo.Location = new Point(158, 88);
            LTipo.Name = "LTipo";
            LTipo.Size = new Size(43, 23);
            LTipo.TabIndex = 55;
            LTipo.Text = "Tipo";
            // 
            // LEstilo
            // 
            LEstilo.Anchor = AnchorStyles.None;
            LEstilo.AutoSize = true;
            LEstilo.BackColor = SystemColors.ButtonFace;
            LEstilo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.Black;
            LEstilo.Location = new Point(9, 88);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(52, 23);
            LEstilo.TabIndex = 61;
            LEstilo.Text = "Estilo";
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.Anchor = AnchorStyles.None;
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(382, 48);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(145, 23);
            ComboBox_Marca.TabIndex = 65;
            ComboBox_Marca.SelectedIndexChanged += ComboBox_Marca_SelectedIndexChanged;
            // 
            // DGVProductos
            // 
            DGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProductos.Location = new Point(12, 172);
            DGVProductos.MultiSelect = false;
            DGVProductos.Name = "DGVProductos";
            DGVProductos.ReadOnly = true;
            DGVProductos.RowTemplate.Height = 25;
            DGVProductos.Size = new Size(515, 319);
            DGVProductos.TabIndex = 74;
            DGVProductos.CellClick += DGVProductos_CellContentClick;
            DGVProductos.CellContentClick += DGVProductos_CellContentClick;
            // 
            // TStock
            // 
            TStock.Location = new Point(382, 91);
            TStock.Name = "TStock";
            TStock.Size = new Size(145, 23);
            TStock.TabIndex = 77;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LStock.Location = new Point(319, 88);
            LStock.Name = "LStock";
            LStock.Size = new Size(51, 23);
            LStock.TabIndex = 78;
            LStock.Text = "Stock";
            // 
            // Modif_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 503);
            Controls.Add(LStock);
            Controls.Add(TStock);
            Controls.Add(DGVProductos);
            Controls.Add(label2);
            Controls.Add(BBorrar);
            Controls.Add(BGuardar);
            Controls.Add(LMarca);
            Controls.Add(ComboBox_Estilo);
            Controls.Add(ComnboBox_Anteojo);
            Controls.Add(TId_prod);
            Controls.Add(TPrecio);
            Controls.Add(LPrecio);
            Controls.Add(LId_prod);
            Controls.Add(LTipo);
            Controls.Add(LEstilo);
            Controls.Add(ComboBox_Marca);
            Name = "Modif_producto";
            Text = "Modif_producto";
            Load += Modif_producto_Load;
            ((System.ComponentModel.ISupportInitialize)DGVProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button BBorrar;
        private Button BGuardar;
        private Label LMarca;
        private ComboBox ComboBox_Estilo;
        private ComboBox ComnboBox_Anteojo;
        private TextBox TId_prod;
        private TextBox TPrecio;
        private Label LPrecio;
        private Label LId_prod;
        private Label LTipo;
        private Label LEstilo;
        private ComboBox ComboBox_Marca;
        private DataGridView DGVProductos;
        private TextBox TStock;
        private Label LStock;
    }
}
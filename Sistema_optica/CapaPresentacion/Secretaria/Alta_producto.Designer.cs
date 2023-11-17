namespace CapaPresentacion.Secretaria
{
    partial class Alta_producto
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
            LId_prod = new Label();
            LAnteojo = new Label();
            label3 = new Label();
            LMarca = new Label();
            LEstilo = new Label();
            LPrecio = new Label();
            ComboBox_Marca = new ComboBox();
            ComboBox_Estilo = new ComboBox();
            ComnboBox_Anteojo = new ComboBox();
            TId_prod = new TextBox();
            TPrecio = new TextBox();
            BBorrar = new Button();
            BGuardar = new Button();
            label2 = new Label();
            LStock = new Label();
            TStock = new TextBox();
            dataGridView1 = new DataGridView();
            LProductosCargados = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LId_prod
            // 
            LId_prod.Anchor = AnchorStyles.None;
            LId_prod.AutoSize = true;
            LId_prod.BackColor = SystemColors.ButtonFace;
            LId_prod.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LId_prod.ForeColor = Color.Black;
            LId_prod.Location = new Point(19, 49);
            LId_prod.Name = "LId_prod";
            LId_prod.Size = new Size(27, 23);
            LId_prod.TabIndex = 0;
            LId_prod.Text = "ID";
            // 
            // LAnteojo
            // 
            LAnteojo.Anchor = AnchorStyles.None;
            LAnteojo.AutoSize = true;
            LAnteojo.BackColor = SystemColors.ButtonFace;
            LAnteojo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LAnteojo.ForeColor = Color.Black;
            LAnteojo.Location = new Point(262, 52);
            LAnteojo.Name = "LAnteojo";
            LAnteojo.Size = new Size(72, 23);
            LAnteojo.TabIndex = 1;
            LAnteojo.Text = "Anteojo ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(13, 271);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 2;
            // 
            // LMarca
            // 
            LMarca.Anchor = AnchorStyles.None;
            LMarca.AutoSize = true;
            LMarca.BackColor = SystemColors.ButtonFace;
            LMarca.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.Black;
            LMarca.Location = new Point(19, 92);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(57, 23);
            LMarca.TabIndex = 5;
            LMarca.Text = "Marca";
            // 
            // LEstilo
            // 
            LEstilo.Anchor = AnchorStyles.None;
            LEstilo.AutoSize = true;
            LEstilo.BackColor = SystemColors.ButtonFace;
            LEstilo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.Black;
            LEstilo.Location = new Point(262, 92);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(52, 23);
            LEstilo.TabIndex = 7;
            LEstilo.Text = "Estilo";
            LEstilo.Click += label8_Click;
            // 
            // LPrecio
            // 
            LPrecio.Anchor = AnchorStyles.None;
            LPrecio.AutoSize = true;
            LPrecio.BackColor = SystemColors.ButtonFace;
            LPrecio.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.Black;
            LPrecio.Location = new Point(19, 132);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(56, 23);
            LPrecio.TabIndex = 8;
            LPrecio.Text = "Precio";
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.Anchor = AnchorStyles.None;
            ComboBox_Marca.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(82, 92);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(146, 23);
            ComboBox_Marca.TabIndex = 11;
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.Anchor = AnchorStyles.None;
            ComboBox_Estilo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(334, 92);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(121, 23);
            ComboBox_Estilo.TabIndex = 12;
            // 
            // ComnboBox_Anteojo
            // 
            ComnboBox_Anteojo.Anchor = AnchorStyles.None;
            ComnboBox_Anteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComnboBox_Anteojo.FormattingEnabled = true;
            ComnboBox_Anteojo.Location = new Point(334, 52);
            ComnboBox_Anteojo.Name = "ComnboBox_Anteojo";
            ComnboBox_Anteojo.Size = new Size(121, 23);
            ComnboBox_Anteojo.TabIndex = 13;
            ComnboBox_Anteojo.SelectedIndexChanged += ComnboBox_Anteojo_SelectedIndexChanged;
            // 
            // TId_prod
            // 
            TId_prod.Anchor = AnchorStyles.None;
            TId_prod.Location = new Point(82, 52);
            TId_prod.Name = "TId_prod";
            TId_prod.Size = new Size(146, 23);
            TId_prod.TabIndex = 15;
            TId_prod.TextChanged += TId_prod_TextChanged;
            TId_prod.KeyPress += TId_prod_KeyPress;
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.None;
            TPrecio.Location = new Point(83, 132);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(145, 23);
            TPrecio.TabIndex = 16;
            TPrecio.TextChanged += TPrecio_TextChanged;
            TPrecio.KeyPress += TPrecio_KeyPress;
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.BackColor = Color.Red;
            BBorrar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BBorrar.ForeColor = Color.White;
            BBorrar.Location = new Point(140, 455);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(88, 36);
            BBorrar.TabIndex = 51;
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
            BGuardar.Location = new Point(246, 455);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 36);
            BGuardar.TabIndex = 50;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(127, 9);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 52;
            label2.Text = "CARGAR UN PRODUCTO";
            // 
            // LStock
            // 
            LStock.Anchor = AnchorStyles.None;
            LStock.AutoSize = true;
            LStock.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LStock.Location = new Point(262, 129);
            LStock.Name = "LStock";
            LStock.Size = new Size(51, 23);
            LStock.TabIndex = 54;
            LStock.Text = "Stock";
            // 
            // TStock
            // 
            TStock.Anchor = AnchorStyles.None;
            TStock.Location = new Point(334, 129);
            TStock.Name = "TStock";
            TStock.Size = new Size(121, 23);
            TStock.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 194);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(436, 255);
            dataGridView1.TabIndex = 56;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LProductosCargados
            // 
            LProductosCargados.Anchor = AnchorStyles.None;
            LProductosCargados.AutoSize = true;
            LProductosCargados.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LProductosCargados.Location = new Point(140, 168);
            LProductosCargados.Name = "LProductosCargados";
            LProductosCargados.Size = new Size(219, 23);
            LProductosCargados.TabIndex = 57;
            LProductosCargados.Text = "Lista de productos cargados";
            // 
            // Alta_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(467, 503);
            Controls.Add(LProductosCargados);
            Controls.Add(dataGridView1);
            Controls.Add(TStock);
            Controls.Add(LStock);
            Controls.Add(label2);
            Controls.Add(BBorrar);
            Controls.Add(BGuardar);
            Controls.Add(LMarca);
            Controls.Add(ComboBox_Estilo);
            Controls.Add(label3);
            Controls.Add(ComnboBox_Anteojo);
            Controls.Add(TId_prod);
            Controls.Add(TPrecio);
            Controls.Add(LPrecio);
            Controls.Add(LId_prod);
            Controls.Add(LAnteojo);
            Controls.Add(LEstilo);
            Controls.Add(ComboBox_Marca);
            ForeColor = Color.Black;
            Name = "Alta_producto";
            Text = "Alta_producto";
            Load += Alta_producto_Load;
            KeyPress += TId_prod_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LId_prod;
        private Label LAnteojo;
        private Label label3;
        private Label LMarca;
        private Label LEstilo;
        private Label LPrecio;
        private ComboBox ComboBox_Marca;
        private ComboBox ComboBox_Estilo;
        private ComboBox ComnboBox_Anteojo;
        private TextBox TId_prod;
        private TextBox TPrecio;
        private Button BBorrar;
        private Button BGuardar;
        private Label label2;
        private Label LStock;
        private TextBox TStock;
        private DataGridView dataGridView1;
        private Label LProductosCargados;
    }
}
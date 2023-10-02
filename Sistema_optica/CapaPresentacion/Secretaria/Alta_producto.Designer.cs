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
            LGenero = new Label();
            LColor = new Label();
            LMarca = new Label();
            LTalle = new Label();
            LEstilo = new Label();
            LPrecio = new Label();
            ComboBox_Genero = new ComboBox();
            ComboBox_Talle = new ComboBox();
            ComboBox_Marca = new ComboBox();
            ComboBox_Estilo = new ComboBox();
            ComnboBox_Anteojo = new ComboBox();
            TColor = new TextBox();
            TId_prod = new TextBox();
            TPrecio = new TextBox();
            BBorrar = new Button();
            BGuardar = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LId_prod
            // 
            LId_prod.Anchor = AnchorStyles.None;
            LId_prod.AutoSize = true;
            LId_prod.BackColor = SystemColors.ButtonFace;
            LId_prod.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LId_prod.ForeColor = Color.Black;
            LId_prod.Location = new Point(62, 111);
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
            LAnteojo.Location = new Point(328, 108);
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
            label3.Location = new Point(107, 344);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 2;
            // 
            // LGenero
            // 
            LGenero.Anchor = AnchorStyles.None;
            LGenero.AutoSize = true;
            LGenero.BackColor = SystemColors.ButtonFace;
            LGenero.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LGenero.ForeColor = Color.Black;
            LGenero.Location = new Point(49, 190);
            LGenero.Name = "LGenero";
            LGenero.RightToLeft = RightToLeft.Yes;
            LGenero.Size = new Size(63, 23);
            LGenero.TabIndex = 3;
            LGenero.Text = "Genero";
            // 
            // LColor
            // 
            LColor.Anchor = AnchorStyles.None;
            LColor.AutoSize = true;
            LColor.BackColor = SystemColors.ButtonFace;
            LColor.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LColor.ForeColor = Color.Black;
            LColor.Location = new Point(410, 190);
            LColor.Name = "LColor";
            LColor.Size = new Size(50, 23);
            LColor.TabIndex = 4;
            LColor.Text = "Color";
            // 
            // LMarca
            // 
            LMarca.Anchor = AnchorStyles.None;
            LMarca.AutoSize = true;
            LMarca.BackColor = SystemColors.ButtonFace;
            LMarca.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.Black;
            LMarca.Location = new Point(52, 263);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(57, 23);
            LMarca.TabIndex = 5;
            LMarca.Text = "Marca";
            // 
            // LTalle
            // 
            LTalle.Anchor = AnchorStyles.None;
            LTalle.AutoSize = true;
            LTalle.BackColor = SystemColors.ButtonFace;
            LTalle.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTalle.ForeColor = Color.Black;
            LTalle.Location = new Point(255, 190);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(46, 23);
            LTalle.TabIndex = 6;
            LTalle.Text = "Talle";
            // 
            // LEstilo
            // 
            LEstilo.Anchor = AnchorStyles.None;
            LEstilo.AutoSize = true;
            LEstilo.BackColor = SystemColors.ButtonFace;
            LEstilo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.Black;
            LEstilo.Location = new Point(53, 319);
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
            LPrecio.Location = new Point(53, 378);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(56, 23);
            LPrecio.TabIndex = 8;
            LPrecio.Text = "Precio";
            // 
            // ComboBox_Genero
            // 
            ComboBox_Genero.Anchor = AnchorStyles.None;
            ComboBox_Genero.FormattingEnabled = true;
            ComboBox_Genero.Location = new Point(113, 193);
            ComboBox_Genero.Name = "ComboBox_Genero";
            ComboBox_Genero.Size = new Size(116, 23);
            ComboBox_Genero.TabIndex = 9;
            // 
            // ComboBox_Talle
            // 
            ComboBox_Talle.Anchor = AnchorStyles.None;
            ComboBox_Talle.FormattingEnabled = true;
            ComboBox_Talle.Location = new Point(307, 193);
            ComboBox_Talle.Name = "ComboBox_Talle";
            ComboBox_Talle.Size = new Size(75, 23);
            ComboBox_Talle.TabIndex = 10;
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.Anchor = AnchorStyles.None;
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(113, 263);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(188, 23);
            ComboBox_Marca.TabIndex = 11;
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.Anchor = AnchorStyles.None;
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(113, 319);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(188, 23);
            ComboBox_Estilo.TabIndex = 12;
            // 
            // ComnboBox_Anteojo
            // 
            ComnboBox_Anteojo.Anchor = AnchorStyles.None;
            ComnboBox_Anteojo.FormattingEnabled = true;
            ComnboBox_Anteojo.Location = new Point(423, 108);
            ComnboBox_Anteojo.Name = "ComnboBox_Anteojo";
            ComnboBox_Anteojo.Size = new Size(178, 23);
            ComnboBox_Anteojo.TabIndex = 13;
            // 
            // TColor
            // 
            TColor.Anchor = AnchorStyles.None;
            TColor.Location = new Point(466, 193);
            TColor.Name = "TColor";
            TColor.Size = new Size(135, 23);
            TColor.TabIndex = 14;
            TColor.TextChanged += TColor_TextChanged;
            TColor.KeyPress += TColor_KeyPress;
            // 
            // TId_prod
            // 
            TId_prod.Anchor = AnchorStyles.None;
            TId_prod.Location = new Point(107, 111);
            TId_prod.Name = "TId_prod";
            TId_prod.Size = new Size(164, 23);
            TId_prod.TabIndex = 15;
            TId_prod.Text = "--";
            TId_prod.TextChanged += TId_prod_TextChanged;
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.None;
            TPrecio.Location = new Point(118, 378);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(105, 23);
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
            BBorrar.Location = new Point(407, 431);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(88, 36);
            BBorrar.TabIndex = 51;
            BBorrar.Text = "Borrar";
            BBorrar.UseVisualStyleBackColor = false;
            // 
            // BGuardar
            // 
            BGuardar.Anchor = AnchorStyles.None;
            BGuardar.BackColor = Color.Green;
            BGuardar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(513, 431);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 36);
            BGuardar.TabIndex = 50;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(199, 29);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 52;
            label2.Text = "CARGAR UN PRODUCTO";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(407, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 138);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // Alta_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(642, 503);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(BBorrar);
            Controls.Add(BGuardar);
            Controls.Add(LMarca);
            Controls.Add(ComboBox_Estilo);
            Controls.Add(label3);
            Controls.Add(ComnboBox_Anteojo);
            Controls.Add(TId_prod);
            Controls.Add(TPrecio);
            Controls.Add(ComboBox_Genero);
            Controls.Add(TColor);
            Controls.Add(LTalle);
            Controls.Add(LPrecio);
            Controls.Add(LColor);
            Controls.Add(LId_prod);
            Controls.Add(LGenero);
            Controls.Add(LAnteojo);
            Controls.Add(LEstilo);
            Controls.Add(ComboBox_Talle);
            Controls.Add(ComboBox_Marca);
            ForeColor = Color.Black;
            Name = "Alta_producto";
            Text = "Alta_producto";
            Load += Alta_producto_Load;
            KeyPress += TId_prod_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LId_prod;
        private Label LAnteojo;
        private Label label3;
        private Label LGenero;
        private Label LColor;
        private Label LMarca;
        private Label LTalle;
        private Label LEstilo;
        private Label LPrecio;
        private ComboBox ComboBox_Genero;
        private ComboBox ComboBox_Talle;
        private ComboBox ComboBox_Marca;
        private ComboBox ComboBox_Estilo;
        private ComboBox ComnboBox_Anteojo;
        private TextBox TColor;
        private TextBox TId_prod;
        private TextBox TPrecio;
        private Button BBorrar;
        private Button BGuardar;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
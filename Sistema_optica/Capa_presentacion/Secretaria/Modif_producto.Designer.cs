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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            BBorrar = new Button();
            BGuardar = new Button();
            LMarca = new Label();
            ComboBox_Estilo = new ComboBox();
            label3 = new Label();
            ComnboBox_Anteojo = new ComboBox();
            TId_prod = new TextBox();
            TPrecio = new TextBox();
            ComboBox_Genero = new ComboBox();
            TColor = new TextBox();
            LTalle = new Label();
            LPrecio = new Label();
            LColor = new Label();
            LId_prod = new Label();
            LGenero = new Label();
            LAnteojo = new Label();
            LEstilo = new Label();
            ComboBox_Talle = new ComboBox();
            ComboBox_Marca = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(403, 266);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 138);
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(195, 32);
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
            BBorrar.Location = new Point(403, 434);
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
            BGuardar.Location = new Point(509, 434);
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
            LMarca.Location = new Point(48, 266);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(57, 23);
            LMarca.TabIndex = 59;
            LMarca.Text = "Marca";
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.Anchor = AnchorStyles.None;
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(109, 322);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(188, 23);
            ComboBox_Estilo.TabIndex = 66;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(103, 347);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 56;
            // 
            // ComnboBox_Anteojo
            // 
            ComnboBox_Anteojo.Anchor = AnchorStyles.None;
            ComnboBox_Anteojo.FormattingEnabled = true;
            ComnboBox_Anteojo.Location = new Point(419, 111);
            ComnboBox_Anteojo.Name = "ComnboBox_Anteojo";
            ComnboBox_Anteojo.Size = new Size(178, 23);
            ComnboBox_Anteojo.TabIndex = 67;
            // 
            // TId_prod
            // 
            TId_prod.Anchor = AnchorStyles.None;
            TId_prod.Location = new Point(103, 114);
            TId_prod.Name = "TId_prod";
            TId_prod.Size = new Size(164, 23);
            TId_prod.TabIndex = 69;
            TId_prod.TextChanged += TId_prod_TextChanged;
            TId_prod.KeyPress += TId_prod_KeyPress;
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.None;
            TPrecio.Location = new Point(114, 381);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(105, 23);
            TPrecio.TabIndex = 70;
            TPrecio.TextChanged += TPrecio_TextChanged;
            TPrecio.KeyPress += TPrecio_KeyPressEventArgs;
            // 
            // ComboBox_Genero
            // 
            ComboBox_Genero.Anchor = AnchorStyles.None;
            ComboBox_Genero.FormattingEnabled = true;
            ComboBox_Genero.Location = new Point(109, 196);
            ComboBox_Genero.Name = "ComboBox_Genero";
            ComboBox_Genero.Size = new Size(116, 23);
            ComboBox_Genero.TabIndex = 63;
            // 
            // TColor
            // 
            TColor.Anchor = AnchorStyles.None;
            TColor.Location = new Point(462, 196);
            TColor.Name = "TColor";
            TColor.Size = new Size(135, 23);
            TColor.TabIndex = 68;
            TColor.TextChanged += TColor_TextChanged;
            TColor.KeyPress += TColor_KeyPressEventArgs;
            // 
            // LTalle
            // 
            LTalle.Anchor = AnchorStyles.None;
            LTalle.AutoSize = true;
            LTalle.BackColor = SystemColors.ButtonFace;
            LTalle.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTalle.ForeColor = Color.Black;
            LTalle.Location = new Point(251, 193);
            LTalle.Name = "LTalle";
            LTalle.Size = new Size(46, 23);
            LTalle.TabIndex = 60;
            LTalle.Text = "Talle";
            // 
            // LPrecio
            // 
            LPrecio.Anchor = AnchorStyles.None;
            LPrecio.AutoSize = true;
            LPrecio.BackColor = SystemColors.ButtonFace;
            LPrecio.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.Black;
            LPrecio.Location = new Point(49, 381);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(56, 23);
            LPrecio.TabIndex = 62;
            LPrecio.Text = "Precio";
            // 
            // LColor
            // 
            LColor.Anchor = AnchorStyles.None;
            LColor.AutoSize = true;
            LColor.BackColor = SystemColors.ButtonFace;
            LColor.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LColor.ForeColor = Color.Black;
            LColor.Location = new Point(406, 193);
            LColor.Name = "LColor";
            LColor.Size = new Size(50, 23);
            LColor.TabIndex = 58;
            LColor.Text = "Color";
            // 
            // LId_prod
            // 
            LId_prod.Anchor = AnchorStyles.None;
            LId_prod.AutoSize = true;
            LId_prod.BackColor = SystemColors.ButtonFace;
            LId_prod.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LId_prod.ForeColor = Color.Black;
            LId_prod.Location = new Point(58, 114);
            LId_prod.Name = "LId_prod";
            LId_prod.Size = new Size(27, 23);
            LId_prod.TabIndex = 54;
            LId_prod.Text = "ID";
            // 
            // LGenero
            // 
            LGenero.Anchor = AnchorStyles.None;
            LGenero.AutoSize = true;
            LGenero.BackColor = SystemColors.ButtonFace;
            LGenero.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LGenero.ForeColor = Color.Black;
            LGenero.Location = new Point(45, 193);
            LGenero.Name = "LGenero";
            LGenero.RightToLeft = RightToLeft.Yes;
            LGenero.Size = new Size(63, 23);
            LGenero.TabIndex = 57;
            LGenero.Text = "Genero";
            // 
            // LAnteojo
            // 
            LAnteojo.Anchor = AnchorStyles.None;
            LAnteojo.AutoSize = true;
            LAnteojo.BackColor = SystemColors.ButtonFace;
            LAnteojo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LAnteojo.ForeColor = Color.Black;
            LAnteojo.Location = new Point(324, 111);
            LAnteojo.Name = "LAnteojo";
            LAnteojo.Size = new Size(72, 23);
            LAnteojo.TabIndex = 55;
            LAnteojo.Text = "Anteojo ";
            // 
            // LEstilo
            // 
            LEstilo.Anchor = AnchorStyles.None;
            LEstilo.AutoSize = true;
            LEstilo.BackColor = SystemColors.ButtonFace;
            LEstilo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.Black;
            LEstilo.Location = new Point(49, 322);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(52, 23);
            LEstilo.TabIndex = 61;
            LEstilo.Text = "Estilo";
            // 
            // ComboBox_Talle
            // 
            ComboBox_Talle.Anchor = AnchorStyles.None;
            ComboBox_Talle.FormattingEnabled = true;
            ComboBox_Talle.Location = new Point(303, 196);
            ComboBox_Talle.Name = "ComboBox_Talle";
            ComboBox_Talle.Size = new Size(75, 23);
            ComboBox_Talle.TabIndex = 64;
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.Anchor = AnchorStyles.None;
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(109, 266);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(188, 23);
            ComboBox_Marca.TabIndex = 65;
            // 
            // Modif_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Modif_producto";
            Text = "Modif_producto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Button BBorrar;
        private Button BGuardar;
        private Label LMarca;
        private ComboBox ComboBox_Estilo;
        private Label label3;
        private ComboBox ComnboBox_Anteojo;
        private TextBox TId_prod;
        private TextBox TPrecio;
        private ComboBox ComboBox_Genero;
        private TextBox TColor;
        private Label LTalle;
        private Label LPrecio;
        private Label LColor;
        private Label LId_prod;
        private Label LGenero;
        private Label LAnteojo;
        private Label LEstilo;
        private ComboBox ComboBox_Talle;
        private ComboBox ComboBox_Marca;
    }
}
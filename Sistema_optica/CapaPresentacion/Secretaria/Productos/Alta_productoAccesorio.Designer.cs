namespace CapaPresentacion.Superadmin.Productos
{
    partial class Alta_productoAccesorio
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
            TStock = new TextBox();
            LStock = new Label();
            LCargarAnteojo = new Label();
            LMarca = new Label();
            ComboBox_Estilo = new ComboBox();
            TPrecio = new TextBox();
            LPrecio = new Label();
            LEstilo = new Label();
            ComboBox_Marca = new ComboBox();
            panel1 = new Panel();
            CBFormaAnteojo = new ComboBox();
            LFormaAnteojo = new Label();
            CBCristalAnteojo = new ComboBox();
            LCristalAnteojo = new Label();
            CBColorAnteojo = new ComboBox();
            LColorAnteojo = new Label();
            CBGeneroAnteojo = new ComboBox();
            LGeneroAnteojo = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TStock
            // 
            TStock.Anchor = AnchorStyles.None;
            TStock.Location = new Point(154, 197);
            TStock.Name = "TStock";
            TStock.Size = new Size(121, 23);
            TStock.TabIndex = 73;
            // 
            // LStock
            // 
            LStock.Anchor = AnchorStyles.None;
            LStock.AutoSize = true;
            LStock.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LStock.Location = new Point(15, 197);
            LStock.Name = "LStock";
            LStock.Size = new Size(127, 20);
            LStock.TabIndex = 72;
            LStock.Text = "Stock del Anteojo:";
            // 
            // LCargarAnteojo
            // 
            LCargarAnteojo.Anchor = AnchorStyles.None;
            LCargarAnteojo.AutoSize = true;
            LCargarAnteojo.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LCargarAnteojo.ForeColor = Color.Purple;
            LCargarAnteojo.Location = new Point(29, 17);
            LCargarAnteojo.Name = "LCargarAnteojo";
            LCargarAnteojo.Size = new Size(235, 23);
            LCargarAnteojo.TabIndex = 71;
            LCargarAnteojo.Text = "Cargar un Anteojo Accesorio";
            // 
            // LMarca
            // 
            LMarca.Anchor = AnchorStyles.None;
            LMarca.AutoSize = true;
            LMarca.BackColor = Color.Transparent;
            LMarca.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.Black;
            LMarca.Location = new Point(15, 52);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(133, 20);
            LMarca.TabIndex = 61;
            LMarca.Text = "Marca del Anteojo:";
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.Anchor = AnchorStyles.None;
            ComboBox_Estilo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(154, 81);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(121, 23);
            ComboBox_Estilo.TabIndex = 65;
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.None;
            TPrecio.Location = new Point(154, 168);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(121, 23);
            TPrecio.TabIndex = 68;
            // 
            // LPrecio
            // 
            LPrecio.Anchor = AnchorStyles.None;
            LPrecio.AutoSize = true;
            LPrecio.BackColor = Color.Transparent;
            LPrecio.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.Black;
            LPrecio.Location = new Point(16, 171);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(132, 20);
            LPrecio.TabIndex = 63;
            LPrecio.Text = "Precio del Anteojo:";
            // 
            // LEstilo
            // 
            LEstilo.Anchor = AnchorStyles.None;
            LEstilo.AutoSize = true;
            LEstilo.BackColor = Color.Transparent;
            LEstilo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.Black;
            LEstilo.Location = new Point(16, 81);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(129, 20);
            LEstilo.TabIndex = 62;
            LEstilo.Text = "Estilo del Anteojo:";
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.Anchor = AnchorStyles.None;
            ComboBox_Marca.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(154, 52);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(121, 23);
            ComboBox_Marca.TabIndex = 64;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(CBGeneroAnteojo);
            panel1.Controls.Add(LGeneroAnteojo);
            panel1.Controls.Add(CBColorAnteojo);
            panel1.Controls.Add(LColorAnteojo);
            panel1.Controls.Add(CBCristalAnteojo);
            panel1.Controls.Add(LCristalAnteojo);
            panel1.Controls.Add(CBFormaAnteojo);
            panel1.Controls.Add(TStock);
            panel1.Controls.Add(LFormaAnteojo);
            panel1.Controls.Add(LStock);
            panel1.Controls.Add(LCargarAnteojo);
            panel1.Controls.Add(LMarca);
            panel1.Controls.Add(ComboBox_Marca);
            panel1.Controls.Add(ComboBox_Estilo);
            panel1.Controls.Add(TPrecio);
            panel1.Controls.Add(LEstilo);
            panel1.Controls.Add(LPrecio);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 328);
            panel1.TabIndex = 76;
            // 
            // CBFormaAnteojo
            // 
            CBFormaAnteojo.Anchor = AnchorStyles.None;
            CBFormaAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFormaAnteojo.FormattingEnabled = true;
            CBFormaAnteojo.Location = new Point(154, 109);
            CBFormaAnteojo.Name = "CBFormaAnteojo";
            CBFormaAnteojo.Size = new Size(121, 23);
            CBFormaAnteojo.TabIndex = 73;
            // 
            // LFormaAnteojo
            // 
            LFormaAnteojo.Anchor = AnchorStyles.None;
            LFormaAnteojo.AutoSize = true;
            LFormaAnteojo.BackColor = Color.Transparent;
            LFormaAnteojo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LFormaAnteojo.ForeColor = Color.Black;
            LFormaAnteojo.Location = new Point(16, 109);
            LFormaAnteojo.Name = "LFormaAnteojo";
            LFormaAnteojo.Size = new Size(134, 20);
            LFormaAnteojo.TabIndex = 72;
            LFormaAnteojo.Text = "Forma del Anteojo:";
            // 
            // CBCristalAnteojo
            // 
            CBCristalAnteojo.Anchor = AnchorStyles.None;
            CBCristalAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCristalAnteojo.FormattingEnabled = true;
            CBCristalAnteojo.Location = new Point(154, 138);
            CBCristalAnteojo.Name = "CBCristalAnteojo";
            CBCristalAnteojo.Size = new Size(121, 23);
            CBCristalAnteojo.TabIndex = 75;
            // 
            // LCristalAnteojo
            // 
            LCristalAnteojo.Anchor = AnchorStyles.None;
            LCristalAnteojo.AutoSize = true;
            LCristalAnteojo.BackColor = Color.Transparent;
            LCristalAnteojo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LCristalAnteojo.ForeColor = Color.Black;
            LCristalAnteojo.Location = new Point(16, 139);
            LCristalAnteojo.Name = "LCristalAnteojo";
            LCristalAnteojo.Size = new Size(135, 20);
            LCristalAnteojo.TabIndex = 74;
            LCristalAnteojo.Text = "Cristal del Anteojo:";
            // 
            // CBColorAnteojo
            // 
            CBColorAnteojo.Anchor = AnchorStyles.None;
            CBColorAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBColorAnteojo.FormattingEnabled = true;
            CBColorAnteojo.Location = new Point(154, 226);
            CBColorAnteojo.Name = "CBColorAnteojo";
            CBColorAnteojo.Size = new Size(121, 23);
            CBColorAnteojo.TabIndex = 77;
            // 
            // LColorAnteojo
            // 
            LColorAnteojo.Anchor = AnchorStyles.None;
            LColorAnteojo.AutoSize = true;
            LColorAnteojo.BackColor = Color.Transparent;
            LColorAnteojo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LColorAnteojo.ForeColor = Color.Black;
            LColorAnteojo.Location = new Point(15, 226);
            LColorAnteojo.Name = "LColorAnteojo";
            LColorAnteojo.Size = new Size(126, 20);
            LColorAnteojo.TabIndex = 76;
            LColorAnteojo.Text = "Color del Anteojo:";
            // 
            // CBGeneroAnteojo
            // 
            CBGeneroAnteojo.Anchor = AnchorStyles.None;
            CBGeneroAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGeneroAnteojo.FormattingEnabled = true;
            CBGeneroAnteojo.Location = new Point(154, 255);
            CBGeneroAnteojo.Name = "CBGeneroAnteojo";
            CBGeneroAnteojo.Size = new Size(121, 23);
            CBGeneroAnteojo.TabIndex = 79;
            // 
            // LGeneroAnteojo
            // 
            LGeneroAnteojo.Anchor = AnchorStyles.None;
            LGeneroAnteojo.AutoSize = true;
            LGeneroAnteojo.BackColor = Color.Transparent;
            LGeneroAnteojo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LGeneroAnteojo.ForeColor = Color.Black;
            LGeneroAnteojo.Location = new Point(15, 255);
            LGeneroAnteojo.Name = "LGeneroAnteojo";
            LGeneroAnteojo.Size = new Size(137, 20);
            LGeneroAnteojo.TabIndex = 78;
            LGeneroAnteojo.Text = "Genero del Anteojo:";
            // 
            // IBResDatos
            // 
            IBResDatos.Anchor = AnchorStyles.None;
            IBResDatos.BackColor = Color.Transparent;
            IBResDatos.FlatStyle = FlatStyle.Flat;
            IBResDatos.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBResDatos.ForeColor = SystemColors.ControlText;
            IBResDatos.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            IBResDatos.IconColor = Color.Purple;
            IBResDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBResDatos.IconSize = 27;
            IBResDatos.Location = new Point(107, 284);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 81;
            IBResDatos.UseVisualStyleBackColor = false;
            // 
            // IBAgregarOS
            // 
            IBAgregarOS.Anchor = AnchorStyles.None;
            IBAgregarOS.BackColor = Color.Transparent;
            IBAgregarOS.FlatStyle = FlatStyle.Flat;
            IBAgregarOS.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarOS.ForeColor = SystemColors.ControlText;
            IBAgregarOS.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarOS.IconColor = Color.Purple;
            IBAgregarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarOS.IconSize = 27;
            IBAgregarOS.Location = new Point(148, 284);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 80;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // Alta_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 354);
            Controls.Add(panel1);
            Name = "Alta_producto";
            Text = "Alta_producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TStock;
        private Label LStock;
        private Label LCargarAnteojo;
        private Label LMarca;
        private ComboBox ComboBox_Estilo;
        private TextBox TPrecio;
        private Label LPrecio;
        private Label LEstilo;
        private ComboBox ComboBox_Marca;
        private Panel panel1;
        private ComboBox CBCristalAnteojo;
        private Label LCristalAnteojo;
        private ComboBox CBFormaAnteojo;
        private Label LFormaAnteojo;
        private ComboBox CBGeneroAnteojo;
        private Label LGeneroAnteojo;
        private ComboBox CBColorAnteojo;
        private Label LColorAnteojo;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
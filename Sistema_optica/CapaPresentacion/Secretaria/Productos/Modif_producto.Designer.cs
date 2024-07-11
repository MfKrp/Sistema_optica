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
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            CBGeneroAnteojo = new ComboBox();
            LGeneroAnteojo = new Label();
            CBColorAnteojo = new ComboBox();
            LColorAnteojo = new Label();
            CBCristalAnteojo = new ComboBox();
            LCristalAnteojo = new Label();
            LFormaAnteojo = new Label();
            panel1 = new Panel();
            CBFormaAnteojo = new ComboBox();
            TStock = new TextBox();
            LStock = new Label();
            LCargarAnteojo = new Label();
            LMarca = new Label();
            ComboBox_Marca = new ComboBox();
            ComboBox_Estilo = new ComboBox();
            TPrecio = new TextBox();
            LEstilo = new Label();
            LPrecio = new Label();
            DTGListaAnteojos = new DataGridView();
            PListaAnteojos = new Panel();
            LListaAnteojos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaAnteojos).BeginInit();
            PListaAnteojos.SuspendLayout();
            SuspendLayout();
            // 
            // IBResDatos
            // 
            IBResDatos.Anchor = AnchorStyles.None;
            IBResDatos.BackColor = Color.Transparent;
            IBResDatos.FlatStyle = FlatStyle.Flat;
            IBResDatos.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBResDatos.ForeColor = SystemColors.ControlText;
            IBResDatos.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            IBResDatos.IconColor = Color.White;
            IBResDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBResDatos.IconSize = 27;
            IBResDatos.Location = new Point(153, 397);
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
            IBAgregarOS.IconColor = Color.White;
            IBAgregarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarOS.IconSize = 27;
            IBAgregarOS.Location = new Point(194, 397);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 80;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // CBGeneroAnteojo
            // 
            CBGeneroAnteojo.Anchor = AnchorStyles.None;
            CBGeneroAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGeneroAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBGeneroAnteojo.FormattingEnabled = true;
            CBGeneroAnteojo.Location = new Point(224, 343);
            CBGeneroAnteojo.Name = "CBGeneroAnteojo";
            CBGeneroAnteojo.Size = new Size(121, 33);
            CBGeneroAnteojo.TabIndex = 79;
            // 
            // LGeneroAnteojo
            // 
            LGeneroAnteojo.Anchor = AnchorStyles.None;
            LGeneroAnteojo.AutoSize = true;
            LGeneroAnteojo.BackColor = Color.Transparent;
            LGeneroAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LGeneroAnteojo.ForeColor = Color.White;
            LGeneroAnteojo.Location = new Point(28, 348);
            LGeneroAnteojo.Name = "LGeneroAnteojo";
            LGeneroAnteojo.Size = new Size(190, 28);
            LGeneroAnteojo.TabIndex = 78;
            LGeneroAnteojo.Text = "Genero del Anteojo:";
            // 
            // CBColorAnteojo
            // 
            CBColorAnteojo.Anchor = AnchorStyles.None;
            CBColorAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBColorAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBColorAnteojo.FormattingEnabled = true;
            CBColorAnteojo.Location = new Point(224, 304);
            CBColorAnteojo.Name = "CBColorAnteojo";
            CBColorAnteojo.Size = new Size(121, 33);
            CBColorAnteojo.TabIndex = 77;
            // 
            // LColorAnteojo
            // 
            LColorAnteojo.Anchor = AnchorStyles.None;
            LColorAnteojo.AutoSize = true;
            LColorAnteojo.BackColor = Color.Transparent;
            LColorAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LColorAnteojo.ForeColor = Color.White;
            LColorAnteojo.Location = new Point(28, 309);
            LColorAnteojo.Name = "LColorAnteojo";
            LColorAnteojo.Size = new Size(174, 28);
            LColorAnteojo.TabIndex = 76;
            LColorAnteojo.Text = "Color del Anteojo:";
            // 
            // CBCristalAnteojo
            // 
            CBCristalAnteojo.Anchor = AnchorStyles.None;
            CBCristalAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCristalAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBCristalAnteojo.FormattingEnabled = true;
            CBCristalAnteojo.Location = new Point(224, 189);
            CBCristalAnteojo.Name = "CBCristalAnteojo";
            CBCristalAnteojo.Size = new Size(121, 33);
            CBCristalAnteojo.TabIndex = 75;
            // 
            // LCristalAnteojo
            // 
            LCristalAnteojo.Anchor = AnchorStyles.None;
            LCristalAnteojo.AutoSize = true;
            LCristalAnteojo.BackColor = Color.Transparent;
            LCristalAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LCristalAnteojo.ForeColor = Color.White;
            LCristalAnteojo.Location = new Point(28, 194);
            LCristalAnteojo.Name = "LCristalAnteojo";
            LCristalAnteojo.Size = new Size(184, 28);
            LCristalAnteojo.TabIndex = 74;
            LCristalAnteojo.Text = "Cristal del Anteojo:";
            // 
            // LFormaAnteojo
            // 
            LFormaAnteojo.Anchor = AnchorStyles.None;
            LFormaAnteojo.AutoSize = true;
            LFormaAnteojo.BackColor = Color.Transparent;
            LFormaAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LFormaAnteojo.ForeColor = Color.White;
            LFormaAnteojo.Location = new Point(28, 155);
            LFormaAnteojo.Name = "LFormaAnteojo";
            LFormaAnteojo.Size = new Size(182, 28);
            LFormaAnteojo.TabIndex = 72;
            LFormaAnteojo.Text = "Forma del Anteojo:";
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
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 477);
            panel1.TabIndex = 77;
            panel1.Paint += panel1_Paint;
            // 
            // CBFormaAnteojo
            // 
            CBFormaAnteojo.Anchor = AnchorStyles.None;
            CBFormaAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFormaAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBFormaAnteojo.FormattingEnabled = true;
            CBFormaAnteojo.Location = new Point(224, 150);
            CBFormaAnteojo.Name = "CBFormaAnteojo";
            CBFormaAnteojo.Size = new Size(121, 33);
            CBFormaAnteojo.TabIndex = 73;
            // 
            // TStock
            // 
            TStock.Anchor = AnchorStyles.None;
            TStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TStock.Location = new Point(224, 266);
            TStock.Name = "TStock";
            TStock.Size = new Size(121, 32);
            TStock.TabIndex = 73;
            TStock.TextChanged += TStock_TextChanged;
            TStock.KeyPress += TStock_KeyPress;
            // 
            // LStock
            // 
            LStock.Anchor = AnchorStyles.None;
            LStock.AutoSize = true;
            LStock.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LStock.ForeColor = Color.White;
            LStock.Location = new Point(28, 267);
            LStock.Name = "LStock";
            LStock.Size = new Size(174, 28);
            LStock.TabIndex = 72;
            LStock.Text = "Stock del Anteojo:";
            // 
            // LCargarAnteojo
            // 
            LCargarAnteojo.Anchor = AnchorStyles.None;
            LCargarAnteojo.AutoSize = true;
            LCargarAnteojo.Font = new Font("Sitka Text", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LCargarAnteojo.ForeColor = Color.White;
            LCargarAnteojo.Location = new Point(60, 25);
            LCargarAnteojo.Name = "LCargarAnteojo";
            LCargarAnteojo.Size = new Size(264, 26);
            LCargarAnteojo.TabIndex = 71;
            LCargarAnteojo.Text = "Cargar un Anteojo Accesorio";
            // 
            // LMarca
            // 
            LMarca.Anchor = AnchorStyles.None;
            LMarca.AutoSize = true;
            LMarca.BackColor = Color.Transparent;
            LMarca.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.White;
            LMarca.Location = new Point(28, 77);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(180, 28);
            LMarca.TabIndex = 61;
            LMarca.Text = "Marca del Anteojo:";
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.Anchor = AnchorStyles.None;
            ComboBox_Marca.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Marca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(224, 72);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(121, 33);
            ComboBox_Marca.TabIndex = 64;
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.Anchor = AnchorStyles.None;
            ComboBox_Estilo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Estilo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(224, 111);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(121, 33);
            ComboBox_Estilo.TabIndex = 65;
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.None;
            TPrecio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TPrecio.Location = new Point(224, 228);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(121, 32);
            TPrecio.TabIndex = 68;
            TPrecio.KeyPress += TPrecio_KeyPressEventArgs;
            // 
            // LEstilo
            // 
            LEstilo.Anchor = AnchorStyles.None;
            LEstilo.AutoSize = true;
            LEstilo.BackColor = Color.Transparent;
            LEstilo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.White;
            LEstilo.Location = new Point(28, 116);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(176, 28);
            LEstilo.TabIndex = 62;
            LEstilo.Text = "Estilo del Anteojo:";
            // 
            // LPrecio
            // 
            LPrecio.Anchor = AnchorStyles.None;
            LPrecio.AutoSize = true;
            LPrecio.BackColor = Color.Transparent;
            LPrecio.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.White;
            LPrecio.Location = new Point(28, 229);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(181, 28);
            LPrecio.TabIndex = 63;
            LPrecio.Text = "Precio del Anteojo:";
            // 
            // DTGListaAnteojos
            // 
            DTGListaAnteojos.BackgroundColor = Color.Plum;
            DTGListaAnteojos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaAnteojos.Dock = DockStyle.Fill;
            DTGListaAnteojos.Location = new Point(390, 72);
            DTGListaAnteojos.Name = "DTGListaAnteojos";
            DTGListaAnteojos.RowTemplate.Height = 25;
            DTGListaAnteojos.Size = new Size(797, 405);
            DTGListaAnteojos.TabIndex = 78;
            DTGListaAnteojos.CellContentClick += DTGListaAnteojos_CellContentClick;
            // 
            // PListaAnteojos
            // 
            PListaAnteojos.BackColor = Color.Thistle;
            PListaAnteojos.Controls.Add(LListaAnteojos);
            PListaAnteojos.Dock = DockStyle.Top;
            PListaAnteojos.Location = new Point(390, 0);
            PListaAnteojos.Name = "PListaAnteojos";
            PListaAnteojos.Size = new Size(797, 72);
            PListaAnteojos.TabIndex = 79;
            PListaAnteojos.Paint += PListaAnteojos_Paint;
            // 
            // LListaAnteojos
            // 
            LListaAnteojos.Anchor = AnchorStyles.None;
            LListaAnteojos.AutoSize = true;
            LListaAnteojos.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LListaAnteojos.ForeColor = Color.White;
            LListaAnteojos.Location = new Point(281, 25);
            LListaAnteojos.Name = "LListaAnteojos";
            LListaAnteojos.Size = new Size(247, 23);
            LListaAnteojos.TabIndex = 72;
            LListaAnteojos.Text = "Lista de Anteojos Registrados";
            // 
            // Modif_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGListaAnteojos);
            Controls.Add(PListaAnteojos);
            Controls.Add(panel1);
            Name = "Modif_producto";
            Text = "Modif_producto";
            Load += Modif_producto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaAnteojos).EndInit();
            PListaAnteojos.ResumeLayout(false);
            PListaAnteojos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private ComboBox CBGeneroAnteojo;
        private Label LGeneroAnteojo;
        private ComboBox CBColorAnteojo;
        private Label LColorAnteojo;
        private ComboBox CBCristalAnteojo;
        private Label LCristalAnteojo;
        private Label LFormaAnteojo;
        private Panel panel1;
        private ComboBox CBFormaAnteojo;
        private TextBox TStock;
        private Label LStock;
        private Label LCargarAnteojo;
        private Label LMarca;
        private ComboBox ComboBox_Marca;
        private ComboBox ComboBox_Estilo;
        private TextBox TPrecio;
        private Label LEstilo;
        private Label LPrecio;
        private DataGridView DTGListaAnteojos;
        private Panel PListaAnteojos;
        private Label LListaAnteojos;
    }
}
namespace CapaPresentacion.Secretaria.Cristales
{
    partial class Modif_cristal
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
            panel1 = new Panel();
            TIdCristal = new TextBox();
            LIdCristal = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            TStockCristal = new TextBox();
            LStockCristal = new Label();
            TMaterialCristal = new TextBox();
            LMaterialCristal = new Label();
            LModifCristal = new Label();
            panel2 = new Panel();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            DTGListaCristales = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaCristales).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(TIdCristal);
            panel1.Controls.Add(LIdCristal);
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(TStockCristal);
            panel1.Controls.Add(LStockCristal);
            panel1.Controls.Add(TMaterialCristal);
            panel1.Controls.Add(LMaterialCristal);
            panel1.Controls.Add(LModifCristal);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 477);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // TIdCristal
            // 
            TIdCristal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TIdCristal.Location = new Point(93, 170);
            TIdCristal.Name = "TIdCristal";
            TIdCristal.ReadOnly = true;
            TIdCristal.Size = new Size(112, 32);
            TIdCristal.TabIndex = 15;
            TIdCristal.TextChanged += TIdCristal_TextChanged;
            TIdCristal.KeyPress += TIdCristal_KeyPress;
            // 
            // LIdCristal
            // 
            LIdCristal.AutoSize = true;
            LIdCristal.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LIdCristal.ForeColor = Color.White;
            LIdCristal.Location = new Point(77, 126);
            LIdCristal.Name = "LIdCristal";
            LIdCristal.Size = new Size(128, 28);
            LIdCristal.TabIndex = 14;
            LIdCristal.Text = "ID del Cristal";
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
            IBResDatos.Location = new Point(110, 395);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 11;
            IBResDatos.UseVisualStyleBackColor = false;
            IBResDatos.Click += IBResDatos_Click;
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
            IBAgregarOS.Location = new Point(151, 395);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // TStockCristal
            // 
            TStockCristal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TStockCristal.Location = new Point(93, 344);
            TStockCristal.Name = "TStockCristal";
            TStockCristal.Size = new Size(112, 32);
            TStockCristal.TabIndex = 4;
            TStockCristal.TextChanged += TStockCristal_TextChanged;
            TStockCristal.KeyPress += TStockCristal_KeyPress;
            // 
            // LStockCristal
            // 
            LStockCristal.AutoSize = true;
            LStockCristal.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LStockCristal.ForeColor = Color.White;
            LStockCristal.Location = new Point(64, 302);
            LStockCristal.Name = "LStockCristal";
            LStockCristal.Size = new Size(166, 28);
            LStockCristal.TabIndex = 3;
            LStockCristal.Text = "Stock disponible:";
            // 
            // TMaterialCristal
            // 
            TMaterialCristal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TMaterialCristal.Location = new Point(93, 267);
            TMaterialCristal.Name = "TMaterialCristal";
            TMaterialCristal.Size = new Size(112, 32);
            TMaterialCristal.TabIndex = 2;
            TMaterialCristal.TextChanged += TMaterialCristal_TextChanged;
            TMaterialCristal.KeyPress += TMaterialCristal_KeyPress;
            // 
            // LMaterialCristal
            // 
            LMaterialCristal.AutoSize = true;
            LMaterialCristal.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LMaterialCristal.ForeColor = Color.White;
            LMaterialCristal.Location = new Point(54, 222);
            LMaterialCristal.Name = "LMaterialCristal";
            LMaterialCristal.Size = new Size(187, 28);
            LMaterialCristal.TabIndex = 1;
            LMaterialCristal.Text = "Material del cristal:";
            // 
            // LModifCristal
            // 
            LModifCristal.AutoSize = true;
            LModifCristal.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LModifCristal.ForeColor = Color.White;
            LModifCristal.Location = new Point(75, 84);
            LModifCristal.Name = "LModifCristal";
            LModifCristal.Size = new Size(155, 26);
            LModifCristal.TabIndex = 0;
            LModifCristal.Text = "Modificar Cristal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(iconButton2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(293, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 74);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 24);
            label1.Name = "label1";
            label1.Size = new Size(155, 26);
            label1.TabIndex = 12;
            label1.Text = "Lista de Cristales";
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 27;
            iconButton1.Location = new Point(463, 315);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(35, 35);
            iconButton1.TabIndex = 11;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = SystemColors.ControlText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 27;
            iconButton2.Location = new Point(504, 315);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(35, 35);
            iconButton2.TabIndex = 10;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // DTGListaCristales
            // 
            DTGListaCristales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaCristales.Dock = DockStyle.Fill;
            DTGListaCristales.Location = new Point(293, 74);
            DTGListaCristales.Name = "DTGListaCristales";
            DTGListaCristales.RowTemplate.Height = 25;
            DTGListaCristales.Size = new Size(894, 403);
            DTGListaCristales.TabIndex = 6;
            DTGListaCristales.CellContentClick += DTGListaCristales_CellContentClick;
            // 
            // Modif_cristal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGListaCristales);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Modif_cristal";
            Text = "Modif_cristal";
            Load += Modif_cristal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaCristales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TStockCristal;
        private Label LStockCristal;
        private TextBox TMaterialCristal;
        private Label LMaterialCristal;
        private Label LModifCristal;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridView DTGListaCristales;
        private Label LIdCristal;
        private TextBox TIdCristal;
    }
}
namespace CapaPresentacion.Secretaria.Cristales
{
    partial class Alta_cristal
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
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            TStockCristal = new TextBox();
            LStockCristal = new Label();
            TMaterialCristal = new TextBox();
            LMaterialCristal = new Label();
            LAgregarCristal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(TStockCristal);
            panel1.Controls.Add(LStockCristal);
            panel1.Controls.Add(TMaterialCristal);
            panel1.Controls.Add(LMaterialCristal);
            panel1.Controls.Add(LAgregarCristal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 477);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
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
            IBResDatos.Location = new Point(651, 313);
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
            IBAgregarOS.Location = new Point(692, 313);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // TStockCristal
            // 
            TStockCristal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TStockCristal.Location = new Point(626, 265);
            TStockCristal.Name = "TStockCristal";
            TStockCristal.Size = new Size(123, 32);
            TStockCristal.TabIndex = 4;
            TStockCristal.TextChanged += TStockCristal_TextChanged;
            TStockCristal.KeyPress += TStockCristal_KeyPress;
            // 
            // LStockCristal
            // 
            LStockCristal.AutoSize = true;
            LStockCristal.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LStockCristal.ForeColor = Color.White;
            LStockCristal.Location = new Point(603, 224);
            LStockCristal.Name = "LStockCristal";
            LStockCristal.Size = new Size(166, 28);
            LStockCristal.TabIndex = 3;
            LStockCristal.Text = "Stock disponible:";
            // 
            // TMaterialCristal
            // 
            TMaterialCristal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TMaterialCristal.Location = new Point(626, 178);
            TMaterialCristal.Name = "TMaterialCristal";
            TMaterialCristal.Size = new Size(123, 32);
            TMaterialCristal.TabIndex = 2;
            TMaterialCristal.TextChanged += TMaterialCristal_TextChanged;
            TMaterialCristal.KeyPress += TMaterialCristal_KeyPress;
            // 
            // LMaterialCristal
            // 
            LMaterialCristal.AutoSize = true;
            LMaterialCristal.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LMaterialCristal.ForeColor = Color.White;
            LMaterialCristal.Location = new Point(593, 134);
            LMaterialCristal.Name = "LMaterialCristal";
            LMaterialCristal.Size = new Size(187, 28);
            LMaterialCristal.TabIndex = 1;
            LMaterialCristal.Text = "Material del cristal:";
            // 
            // LAgregarCristal
            // 
            LAgregarCristal.AutoSize = true;
            LAgregarCristal.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LAgregarCristal.ForeColor = Color.White;
            LAgregarCristal.Location = new Point(612, 88);
            LAgregarCristal.Name = "LAgregarCristal";
            LAgregarCristal.Size = new Size(146, 28);
            LAgregarCristal.TabIndex = 0;
            LAgregarCristal.Text = "Agregar Cristal";
            // 
            // Alta_cristal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 477);
            Controls.Add(panel1);
            Name = "Alta_cristal";
            Text = "Alta_cristal";
            Load += Alta_cristal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TStockCristal;
        private Label LStockCristal;
        private TextBox TMaterialCristal;
        private Label LMaterialCristal;
        private Label LAgregarCristal;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
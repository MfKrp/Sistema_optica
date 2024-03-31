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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 148);
            panel1.TabIndex = 3;
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
            IBResDatos.Location = new Point(207, 105);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 11;
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
            IBAgregarOS.Location = new Point(248, 105);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // TStockCristal
            // 
            TStockCristal.Location = new Point(160, 76);
            TStockCristal.Name = "TStockCristal";
            TStockCristal.Size = new Size(123, 23);
            TStockCristal.TabIndex = 4;
            // 
            // LStockCristal
            // 
            LStockCristal.AutoSize = true;
            LStockCristal.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LStockCristal.Location = new Point(15, 76);
            LStockCristal.Name = "LStockCristal";
            LStockCristal.Size = new Size(122, 20);
            LStockCristal.TabIndex = 3;
            LStockCristal.Text = "Stock disponible:";
            // 
            // TMaterialCristal
            // 
            TMaterialCristal.Location = new Point(160, 43);
            TMaterialCristal.Name = "TMaterialCristal";
            TMaterialCristal.Size = new Size(123, 23);
            TMaterialCristal.TabIndex = 2;
            // 
            // LMaterialCristal
            // 
            LMaterialCristal.AutoSize = true;
            LMaterialCristal.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LMaterialCristal.Location = new Point(15, 43);
            LMaterialCristal.Name = "LMaterialCristal";
            LMaterialCristal.Size = new Size(139, 20);
            LMaterialCristal.TabIndex = 1;
            LMaterialCristal.Text = "Material del cristal:";
            // 
            // LAgregarCristal
            // 
            LAgregarCristal.AutoSize = true;
            LAgregarCristal.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LAgregarCristal.Location = new Point(12, 11);
            LAgregarCristal.Name = "LAgregarCristal";
            LAgregarCristal.Size = new Size(123, 23);
            LAgregarCristal.TabIndex = 0;
            LAgregarCristal.Text = "Agregar Cristal";
            // 
            // Alta_cristal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 172);
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
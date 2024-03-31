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
            TStockCristal = new TextBox();
            LStockCristal = new Label();
            TMaterialCristal = new TextBox();
            LMaterialCristal = new Label();
            LModifCristal = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
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
            panel1.Controls.Add(LModifCristal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 153);
            panel1.TabIndex = 4;
            // 
            // TStockCristal
            // 
            TStockCristal.Location = new Point(170, 76);
            TStockCristal.Name = "TStockCristal";
            TStockCristal.Size = new Size(112, 23);
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
            TMaterialCristal.Location = new Point(170, 43);
            TMaterialCristal.Name = "TMaterialCristal";
            TMaterialCristal.Size = new Size(112, 23);
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
            // LModifCristal
            // 
            LModifCristal.AutoSize = true;
            LModifCristal.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LModifCristal.Location = new Point(12, 11);
            LModifCristal.Name = "LModifCristal";
            LModifCristal.Size = new Size(136, 23);
            LModifCristal.TabIndex = 0;
            LModifCristal.Text = "Modificar Cristal";
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
            IBResDatos.Location = new Point(206, 105);
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
            IBAgregarOS.Location = new Point(247, 105);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // Modif_cristal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 177);
            Controls.Add(panel1);
            Name = "Modif_cristal";
            Text = "Modif_cristal";
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
        private Label LModifCristal;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
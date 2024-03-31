namespace CapaPresentacion.Secretaria.Forma
{
    partial class Modif_forma
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
            LModifForma = new Label();
            LDescripcionForma = new Label();
            TDescForma = new TextBox();
            panel1 = new Panel();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LModifForma
            // 
            LModifForma.AutoSize = true;
            LModifForma.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LModifForma.Location = new Point(12, 11);
            LModifForma.Name = "LModifForma";
            LModifForma.Size = new Size(135, 23);
            LModifForma.TabIndex = 0;
            LModifForma.Text = "Modificar Forma";
            // 
            // LDescripcionForma
            // 
            LDescripcionForma.AutoSize = true;
            LDescripcionForma.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcionForma.Location = new Point(14, 43);
            LDescripcionForma.Name = "LDescripcionForma";
            LDescripcionForma.Size = new Size(133, 20);
            LDescripcionForma.TabIndex = 1;
            LDescripcionForma.Text = "Nombre de Forma:";
            // 
            // TDescForma
            // 
            TDescForma.Location = new Point(153, 43);
            TDescForma.Name = "TDescForma";
            TDescForma.Size = new Size(135, 23);
            TDescForma.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(TDescForma);
            panel1.Controls.Add(LDescripcionForma);
            panel1.Controls.Add(LModifForma);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 113);
            panel1.TabIndex = 2;
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
            IBResDatos.Location = new Point(212, 72);
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
            IBAgregarOS.Location = new Point(253, 72);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // Modif_forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 137);
            Controls.Add(panel1);
            Name = "Modif_forma";
            Text = "Modif_forma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LModifForma;
        private Label LDescripcionForma;
        private TextBox TDescForma;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
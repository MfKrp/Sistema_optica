namespace CapaPresentacion.Secretaria.Forma
{
    partial class Alta_forma
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
            TDescForma = new TextBox();
            LDescripcionForma = new Label();
            LAgregarForma = new Label();
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
            panel1.Controls.Add(TDescForma);
            panel1.Controls.Add(LDescripcionForma);
            panel1.Controls.Add(LAgregarForma);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 112);
            panel1.TabIndex = 1;
            // 
            // TDescForma
            // 
            TDescForma.Location = new Point(151, 43);
            TDescForma.Name = "TDescForma";
            TDescForma.Size = new Size(134, 23);
            TDescForma.TabIndex = 2;
            // 
            // LDescripcionForma
            // 
            LDescripcionForma.AutoSize = true;
            LDescripcionForma.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcionForma.Location = new Point(12, 43);
            LDescripcionForma.Name = "LDescripcionForma";
            LDescripcionForma.Size = new Size(133, 20);
            LDescripcionForma.TabIndex = 1;
            LDescripcionForma.Text = "Nombre de Forma:";
            // 
            // LAgregarForma
            // 
            LAgregarForma.AutoSize = true;
            LAgregarForma.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LAgregarForma.Location = new Point(12, 11);
            LAgregarForma.Name = "LAgregarForma";
            LAgregarForma.Size = new Size(122, 23);
            LAgregarForma.TabIndex = 0;
            LAgregarForma.Text = "Agregar Forma";
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
            IBResDatos.Location = new Point(209, 72);
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
            IBAgregarOS.Location = new Point(250, 72);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // Alta_forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 136);
            Controls.Add(panel1);
            Name = "Alta_forma";
            Text = "Alta_forma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TDescForma;
        private Label LDescripcionForma;
        private Label LAgregarForma;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
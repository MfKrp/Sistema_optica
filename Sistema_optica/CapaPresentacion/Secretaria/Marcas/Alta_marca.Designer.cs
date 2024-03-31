namespace CapaPresentacion.Secretaria
{
    partial class Alta_marca
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
            TDescMarca = new TextBox();
            LDescripcion = new Label();
            LAgregarMarca = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarMarca = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarMarca);
            panel1.Controls.Add(TDescMarca);
            panel1.Controls.Add(LDescripcion);
            panel1.Controls.Add(LAgregarMarca);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 127);
            panel1.TabIndex = 0;
            // 
            // TDescMarca
            // 
            TDescMarca.Location = new Point(150, 43);
            TDescMarca.Name = "TDescMarca";
            TDescMarca.Size = new Size(171, 23);
            TDescMarca.TabIndex = 2;
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcion.Location = new Point(12, 43);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(132, 20);
            LDescripcion.TabIndex = 1;
            LDescripcion.Text = "Nombre de Marca:";
            // 
            // LAgregarMarca
            // 
            LAgregarMarca.AutoSize = true;
            LAgregarMarca.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LAgregarMarca.Location = new Point(12, 11);
            LAgregarMarca.Name = "LAgregarMarca";
            LAgregarMarca.Size = new Size(121, 23);
            LAgregarMarca.TabIndex = 0;
            LAgregarMarca.Text = "Agregar Marca";
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
            IBResDatos.Location = new Point(245, 80);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 11;
            IBResDatos.UseVisualStyleBackColor = false;
            // 
            // IBAgregarMarca
            // 
            IBAgregarMarca.Anchor = AnchorStyles.None;
            IBAgregarMarca.BackColor = Color.Transparent;
            IBAgregarMarca.FlatStyle = FlatStyle.Flat;
            IBAgregarMarca.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarMarca.ForeColor = SystemColors.ControlText;
            IBAgregarMarca.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarMarca.IconColor = Color.Purple;
            IBAgregarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarMarca.IconSize = 27;
            IBAgregarMarca.Location = new Point(286, 80);
            IBAgregarMarca.Name = "IBAgregarMarca";
            IBAgregarMarca.Size = new Size(35, 35);
            IBAgregarMarca.TabIndex = 10;
            IBAgregarMarca.UseVisualStyleBackColor = false;
            // 
            // Alta_marca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 151);
            Controls.Add(panel1);
            Name = "Alta_marca";
            Text = "Alta_marca";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LAgregarMarca;
        private TextBox TDescMarca;
        private Label LDescripcion;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarMarca;
    }
}
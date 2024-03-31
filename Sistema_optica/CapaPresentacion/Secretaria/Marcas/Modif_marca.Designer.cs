namespace CapaPresentacion.Secretaria.Marcas
{
    partial class Modif_marca
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
            IBAgregar = new FontAwesome.Sharp.IconButton();
            TDescMarca = new TextBox();
            LDescripcion = new Label();
            LModifMarca = new Label();
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
            panel1.Controls.Add(IBAgregar);
            panel1.Controls.Add(TDescMarca);
            panel1.Controls.Add(LDescripcion);
            panel1.Controls.Add(LModifMarca);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 124);
            panel1.TabIndex = 1;
            // 
            // IBAgregar
            // 
            IBAgregar.Anchor = AnchorStyles.None;
            IBAgregar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            IBAgregar.IconColor = Color.Black;
            IBAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregar.IconSize = 20;
            IBAgregar.Location = new Point(343, 55);
            IBAgregar.Name = "IBAgregar";
            IBAgregar.Size = new Size(30, 23);
            IBAgregar.TabIndex = 6;
            IBAgregar.UseVisualStyleBackColor = true;
            // 
            // TDescMarca
            // 
            TDescMarca.Location = new Point(152, 43);
            TDescMarca.Name = "TDescMarca";
            TDescMarca.Size = new Size(169, 23);
            TDescMarca.TabIndex = 2;
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcion.Location = new Point(14, 43);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(132, 20);
            LDescripcion.TabIndex = 1;
            LDescripcion.Text = "Nombre de Marca:";
            // 
            // LModifMarca
            // 
            LModifMarca.AutoSize = true;
            LModifMarca.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LModifMarca.Location = new Point(12, 11);
            LModifMarca.Name = "LModifMarca";
            LModifMarca.Size = new Size(134, 23);
            LModifMarca.TabIndex = 0;
            LModifMarca.Text = "Modificar Marca";
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
            IBResDatos.Location = new Point(245, 77);
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
            IBAgregarOS.Location = new Point(286, 77);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // Modif_marca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 148);
            Controls.Add(panel1);
            Name = "Modif_marca";
            Text = "Modif_marca";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBAgregar;
        private TextBox TDescMarca;
        private Label LDescripcion;
        private Label LModifMarca;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
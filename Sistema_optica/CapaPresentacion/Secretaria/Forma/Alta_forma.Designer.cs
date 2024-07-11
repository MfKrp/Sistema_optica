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
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            TDescForma = new TextBox();
            LDescripcionForma = new Label();
            LAgregarForma = new Label();
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 477);
            panel1.TabIndex = 1;
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
            IBResDatos.Location = new Point(645, 277);
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
            IBAgregarOS.Location = new Point(686, 277);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // TDescForma
            // 
            TDescForma.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TDescForma.Location = new Point(613, 228);
            TDescForma.Name = "TDescForma";
            TDescForma.Size = new Size(134, 32);
            TDescForma.TabIndex = 2;
            TDescForma.TextChanged += TDescForma_TextChanged;
            // 
            // LDescripcionForma
            // 
            LDescripcionForma.AutoSize = true;
            LDescripcionForma.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcionForma.ForeColor = Color.White;
            LDescripcionForma.Location = new Point(591, 184);
            LDescripcionForma.Name = "LDescripcionForma";
            LDescripcionForma.Size = new Size(180, 28);
            LDescripcionForma.TabIndex = 1;
            LDescripcionForma.Text = "Nombre de Forma:";
            // 
            // LAgregarForma
            // 
            LAgregarForma.AutoSize = true;
            LAgregarForma.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LAgregarForma.ForeColor = Color.White;
            LAgregarForma.Location = new Point(610, 147);
            LAgregarForma.Name = "LAgregarForma";
            LAgregarForma.Size = new Size(137, 26);
            LAgregarForma.TabIndex = 0;
            LAgregarForma.Text = "Agregar Forma";
            // 
            // Alta_forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(panel1);
            Name = "Alta_forma";
            Text = "Alta_forma";
            Load += Alta_forma_Load;
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
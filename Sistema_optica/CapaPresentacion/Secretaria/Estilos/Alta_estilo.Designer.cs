namespace CapaPresentacion.Secretaria.Estilos
{
    partial class Alta_estilo
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
            TDescEstilo = new TextBox();
            LDescripcionEstilo = new Label();
            LAgregarEstilo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(TDescEstilo);
            panel1.Controls.Add(LDescripcionEstilo);
            panel1.Controls.Add(LAgregarEstilo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 477);
            panel1.TabIndex = 2;
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
            IBResDatos.Location = new Point(651, 279);
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
            IBAgregarOS.Location = new Point(692, 279);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // TDescEstilo
            // 
            TDescEstilo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TDescEstilo.Location = new Point(618, 231);
            TDescEstilo.Name = "TDescEstilo";
            TDescEstilo.Size = new Size(135, 32);
            TDescEstilo.TabIndex = 2;
            TDescEstilo.TextChanged += TDescEstilo_TextChanged;
            // 
            // LDescripcionEstilo
            // 
            LDescripcionEstilo.AutoSize = true;
            LDescripcionEstilo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcionEstilo.ForeColor = Color.White;
            LDescripcionEstilo.Location = new Point(597, 190);
            LDescripcionEstilo.Name = "LDescripcionEstilo";
            LDescripcionEstilo.Size = new Size(174, 28);
            LDescripcionEstilo.TabIndex = 1;
            LDescripcionEstilo.Text = "Nombre de Estilo:";
            // 
            // LAgregarEstilo
            // 
            LAgregarEstilo.AutoSize = true;
            LAgregarEstilo.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LAgregarEstilo.ForeColor = Color.White;
            LAgregarEstilo.Location = new Point(618, 155);
            LAgregarEstilo.Name = "LAgregarEstilo";
            LAgregarEstilo.Size = new Size(132, 26);
            LAgregarEstilo.TabIndex = 0;
            LAgregarEstilo.Text = "Agregar Estilo";
            // 
            // Alta_estilo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(panel1);
            Name = "Alta_estilo";
            Text = "Alta_estilo";
            Load += Alta_estilo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TDescEstilo;
        private Label LDescripcionEstilo;
        private Label LAgregarEstilo;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
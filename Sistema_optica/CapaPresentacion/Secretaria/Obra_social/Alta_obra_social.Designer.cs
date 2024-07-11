namespace CapaPresentacion.Secretaria.Obra_social
{
    partial class Alta_obra_social
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
            TCoberturaCristal = new TextBox();
            LCoberturaCristal = new Label();
            TCoberturaMarco = new TextBox();
            LCoberturaMarcoOS = new Label();
            TNombreOS = new TextBox();
            LNombreOS = new Label();
            LAgregarOS = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(TCoberturaCristal);
            panel1.Controls.Add(LCoberturaCristal);
            panel1.Controls.Add(TCoberturaMarco);
            panel1.Controls.Add(LCoberturaMarcoOS);
            panel1.Controls.Add(TNombreOS);
            panel1.Controls.Add(LNombreOS);
            panel1.Controls.Add(LAgregarOS);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 477);
            panel1.TabIndex = 4;
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
            IBResDatos.Location = new Point(605, 351);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 9;
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
            IBAgregarOS.Location = new Point(646, 351);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 8;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // TCoberturaCristal
            // 
            TCoberturaCristal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TCoberturaCristal.ForeColor = Color.White;
            TCoberturaCristal.Location = new Point(578, 298);
            TCoberturaCristal.Name = "TCoberturaCristal";
            TCoberturaCristal.Size = new Size(124, 32);
            TCoberturaCristal.TabIndex = 6;
            TCoberturaCristal.TextChanged += TCoberturaCristal_TextChanged;
            // 
            // LCoberturaCristal
            // 
            LCoberturaCristal.AutoSize = true;
            LCoberturaCristal.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LCoberturaCristal.ForeColor = Color.White;
            LCoberturaCristal.Location = new Point(485, 258);
            LCoberturaCristal.Name = "LCoberturaCristal";
            LCoberturaCristal.Size = new Size(319, 28);
            LCoberturaCristal.TabIndex = 5;
            LCoberturaCristal.Text = "Porcentaje de cobertura de cristal:";
            // 
            // TCoberturaMarco
            // 
            TCoberturaMarco.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TCoberturaMarco.ForeColor = Color.White;
            TCoberturaMarco.Location = new Point(578, 212);
            TCoberturaMarco.Name = "TCoberturaMarco";
            TCoberturaMarco.Size = new Size(124, 32);
            TCoberturaMarco.TabIndex = 4;
            TCoberturaMarco.TextChanged += TCoberturaMarco_TextChanged;
            // 
            // LCoberturaMarcoOS
            // 
            LCoberturaMarcoOS.AutoSize = true;
            LCoberturaMarcoOS.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LCoberturaMarcoOS.ForeColor = Color.White;
            LCoberturaMarcoOS.Location = new Point(485, 172);
            LCoberturaMarcoOS.Name = "LCoberturaMarcoOS";
            LCoberturaMarcoOS.Size = new Size(319, 28);
            LCoberturaMarcoOS.TabIndex = 3;
            LCoberturaMarcoOS.Text = "Porcentaje de cobertura de marco:";
            // 
            // TNombreOS
            // 
            TNombreOS.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TNombreOS.ForeColor = Color.White;
            TNombreOS.Location = new Point(578, 127);
            TNombreOS.Name = "TNombreOS";
            TNombreOS.Size = new Size(124, 32);
            TNombreOS.TabIndex = 2;
            TNombreOS.TextChanged += TNombreOS_TextChanged;
            // 
            // LNombreOS
            // 
            LNombreOS.AutoSize = true;
            LNombreOS.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreOS.ForeColor = Color.White;
            LNombreOS.Location = new Point(554, 86);
            LNombreOS.Name = "LNombreOS";
            LNombreOS.Size = new Size(168, 28);
            LNombreOS.TabIndex = 1;
            LNombreOS.Text = "Nombre de la OS:";
            // 
            // LAgregarOS
            // 
            LAgregarOS.AutoSize = true;
            LAgregarOS.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LAgregarOS.ForeColor = Color.White;
            LAgregarOS.Location = new Point(541, 42);
            LAgregarOS.Name = "LAgregarOS";
            LAgregarOS.Size = new Size(181, 26);
            LAgregarOS.TabIndex = 0;
            LAgregarOS.Text = "Agregar Obra Social";
            // 
            // Alta_obra_social
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(panel1);
            Name = "Alta_obra_social";
            Text = "Alta_obra_social";
            Load += Alta_obra_social_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TCoberturaMarco;
        private Label LCoberturaMarcoOS;
        private TextBox TNombreOS;
        private Label LNombreOS;
        private Label LAgregarOS;
        private TextBox TCoberturaCristal;
        private Label LCoberturaCristal;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private FontAwesome.Sharp.IconButton IBResDatos;
    }
}
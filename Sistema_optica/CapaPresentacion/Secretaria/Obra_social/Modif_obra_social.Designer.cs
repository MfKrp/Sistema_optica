namespace CapaPresentacion.Secretaria.Obra_social
{
    partial class Modif_obra_social
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
            PTObrasSociales = new Panel();
            BResetearTB = new FontAwesome.Sharp.IconButton();
            IBModificarOS = new FontAwesome.Sharp.IconButton();
            TIdObraSocial = new TextBox();
            LIdObraSocial = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            TCoberturaCristal = new TextBox();
            LCoberturaCristal = new Label();
            TCoberturaMarco = new TextBox();
            LCoberturaMarcoOS = new Label();
            TNombreOS = new TextBox();
            LNombreOS = new Label();
            LModifOS = new Label();
            DTGListaObrasSociales = new DataGridView();
            PNLObrasSociales = new Panel();
            LModifObraSocial = new Label();
            PTObrasSociales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaObrasSociales).BeginInit();
            PNLObrasSociales.SuspendLayout();
            SuspendLayout();
            // 
            // PTObrasSociales
            // 
            PTObrasSociales.BackColor = Color.Thistle;
            PTObrasSociales.Controls.Add(BResetearTB);
            PTObrasSociales.Controls.Add(IBModificarOS);
            PTObrasSociales.Controls.Add(TIdObraSocial);
            PTObrasSociales.Controls.Add(LIdObraSocial);
            PTObrasSociales.Controls.Add(IBResDatos);
            PTObrasSociales.Controls.Add(IBAgregarOS);
            PTObrasSociales.Controls.Add(TCoberturaCristal);
            PTObrasSociales.Controls.Add(LCoberturaCristal);
            PTObrasSociales.Controls.Add(TCoberturaMarco);
            PTObrasSociales.Controls.Add(LCoberturaMarcoOS);
            PTObrasSociales.Controls.Add(TNombreOS);
            PTObrasSociales.Controls.Add(LNombreOS);
            PTObrasSociales.Controls.Add(LModifOS);
            PTObrasSociales.Dock = DockStyle.Left;
            PTObrasSociales.Location = new Point(0, 0);
            PTObrasSociales.Name = "PTObrasSociales";
            PTObrasSociales.Size = new Size(366, 477);
            PTObrasSociales.TabIndex = 5;
            PTObrasSociales.Paint += panel1_Paint;
            // 
            // BResetearTB
            // 
            BResetearTB.Anchor = AnchorStyles.None;
            BResetearTB.BackColor = Color.Transparent;
            BResetearTB.FlatStyle = FlatStyle.Flat;
            BResetearTB.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            BResetearTB.ForeColor = SystemColors.ControlText;
            BResetearTB.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            BResetearTB.IconColor = Color.White;
            BResetearTB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BResetearTB.IconSize = 27;
            BResetearTB.Location = new Point(143, 376);
            BResetearTB.Name = "BResetearTB";
            BResetearTB.Size = new Size(35, 35);
            BResetearTB.TabIndex = 15;
            BResetearTB.UseVisualStyleBackColor = false;
            BResetearTB.Click += BResetearTB_Click;
            // 
            // IBModificarOS
            // 
            IBModificarOS.Anchor = AnchorStyles.None;
            IBModificarOS.BackColor = Color.Transparent;
            IBModificarOS.FlatStyle = FlatStyle.Flat;
            IBModificarOS.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBModificarOS.ForeColor = SystemColors.ControlText;
            IBModificarOS.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBModificarOS.IconColor = Color.White;
            IBModificarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBModificarOS.IconSize = 27;
            IBModificarOS.Location = new Point(184, 376);
            IBModificarOS.Name = "IBModificarOS";
            IBModificarOS.Size = new Size(35, 35);
            IBModificarOS.TabIndex = 14;
            IBModificarOS.UseVisualStyleBackColor = false;
            IBModificarOS.Click += IBModificarOS_Click;
            // 
            // TIdObraSocial
            // 
            TIdObraSocial.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TIdObraSocial.Location = new Point(118, 128);
            TIdObraSocial.Name = "TIdObraSocial";
            TIdObraSocial.ReadOnly = true;
            TIdObraSocial.Size = new Size(124, 32);
            TIdObraSocial.TabIndex = 13;
            TIdObraSocial.TextChanged += TIdObraSocial_TextChanged;
            // 
            // LIdObraSocial
            // 
            LIdObraSocial.AutoSize = true;
            LIdObraSocial.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LIdObraSocial.ForeColor = Color.White;
            LIdObraSocial.Location = new Point(100, 97);
            LIdObraSocial.Name = "LIdObraSocial";
            LIdObraSocial.Size = new Size(168, 28);
            LIdObraSocial.TabIndex = 12;
            LIdObraSocial.Text = "Nombre de la OS:";
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
            IBResDatos.Location = new Point(-250, 354);
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
            IBAgregarOS.IconColor = Color.White;
            IBAgregarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarOS.IconSize = 27;
            IBAgregarOS.Location = new Point(-209, 354);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // TCoberturaCristal
            // 
            TCoberturaCristal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TCoberturaCristal.Location = new Point(118, 338);
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
            LCoberturaCristal.Location = new Point(26, 307);
            LCoberturaCristal.Name = "LCoberturaCristal";
            LCoberturaCristal.Size = new Size(319, 28);
            LCoberturaCristal.TabIndex = 5;
            LCoberturaCristal.Text = "Porcentaje de cobertura de cristal:";
            // 
            // TCoberturaMarco
            // 
            TCoberturaMarco.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TCoberturaMarco.Location = new Point(118, 272);
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
            LCoberturaMarcoOS.Location = new Point(26, 241);
            LCoberturaMarcoOS.Name = "LCoberturaMarcoOS";
            LCoberturaMarcoOS.Size = new Size(319, 28);
            LCoberturaMarcoOS.TabIndex = 3;
            LCoberturaMarcoOS.Text = "Porcentaje de cobertura de marco:";
            // 
            // TNombreOS
            // 
            TNombreOS.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TNombreOS.Location = new Point(118, 204);
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
            LNombreOS.Location = new Point(100, 173);
            LNombreOS.Name = "LNombreOS";
            LNombreOS.Size = new Size(168, 28);
            LNombreOS.TabIndex = 1;
            LNombreOS.Text = "Nombre de la OS:";
            // 
            // LModifOS
            // 
            LModifOS.AutoSize = true;
            LModifOS.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LModifOS.ForeColor = Color.White;
            LModifOS.Location = new Point(87, 50);
            LModifOS.Name = "LModifOS";
            LModifOS.Size = new Size(181, 26);
            LModifOS.TabIndex = 0;
            LModifOS.Text = "Agregar Obra Social";
            // 
            // DTGListaObrasSociales
            // 
            DTGListaObrasSociales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaObrasSociales.Dock = DockStyle.Fill;
            DTGListaObrasSociales.Location = new Point(366, 66);
            DTGListaObrasSociales.Name = "DTGListaObrasSociales";
            DTGListaObrasSociales.RowTemplate.Height = 25;
            DTGListaObrasSociales.Size = new Size(821, 411);
            DTGListaObrasSociales.TabIndex = 6;
            DTGListaObrasSociales.CellContentClick += DTGListaObrasSociales_CellContentClick;
            // 
            // PNLObrasSociales
            // 
            PNLObrasSociales.BackColor = Color.Thistle;
            PNLObrasSociales.Controls.Add(LModifObraSocial);
            PNLObrasSociales.Dock = DockStyle.Top;
            PNLObrasSociales.Location = new Point(366, 0);
            PNLObrasSociales.Name = "PNLObrasSociales";
            PNLObrasSociales.Size = new Size(821, 66);
            PNLObrasSociales.TabIndex = 7;
            PNLObrasSociales.Paint += PNLObrasSociales_Paint;
            // 
            // LModifObraSocial
            // 
            LModifObraSocial.AutoSize = true;
            LModifObraSocial.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LModifObraSocial.ForeColor = Color.White;
            LModifObraSocial.Location = new Point(369, 20);
            LModifObraSocial.Name = "LModifObraSocial";
            LModifObraSocial.Size = new Size(204, 26);
            LModifObraSocial.TabIndex = 1;
            LModifObraSocial.Text = "Lista de Obras Sociales";
            // 
            // Modif_obra_social
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGListaObrasSociales);
            Controls.Add(PNLObrasSociales);
            Controls.Add(PTObrasSociales);
            Name = "Modif_obra_social";
            Text = "Modif_obra_social";
            Load += Modif_obra_social_Load;
            PTObrasSociales.ResumeLayout(false);
            PTObrasSociales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaObrasSociales).EndInit();
            PNLObrasSociales.ResumeLayout(false);
            PNLObrasSociales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PTObrasSociales;
        private TextBox TCoberturaCristal;
        private Label LCoberturaCristal;
        private TextBox TCoberturaMarco;
        private Label LCoberturaMarcoOS;
        private TextBox TNombreOS;
        private Label LNombreOS;
        private Label LModifOS;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private DataGridView DTGListaObrasSociales;
        private Panel PNLObrasSociales;
        private FontAwesome.Sharp.IconButton BResetearTB;
        private FontAwesome.Sharp.IconButton IBModificarOS;
        private TextBox TIdObraSocial;
        private Label LIdObraSocial;
        private Label LModifObraSocial;
    }
}
namespace CapaPresentacion.Vendedor
{
    partial class Alta_cliente
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
            CBObraSocial = new ComboBox();
            LObraSocial = new Label();
            TNroTarjetaCl = new TextBox();
            LTarjetaCl = new Label();
            TEmailCl = new TextBox();
            LEmailCl = new Label();
            TDireccionCl = new TextBox();
            LDireccionCl = new Label();
            TTelefonoCl = new TextBox();
            LTelefonoCl = new Label();
            TDniCl = new TextBox();
            LDniCl = new Label();
            TApellidoCl = new TextBox();
            LApellidoCl = new Label();
            TNombreCl = new TextBox();
            LNombreCl = new Label();
            LAltaCliente = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(CBObraSocial);
            panel1.Controls.Add(LObraSocial);
            panel1.Controls.Add(TNroTarjetaCl);
            panel1.Controls.Add(LTarjetaCl);
            panel1.Controls.Add(TEmailCl);
            panel1.Controls.Add(LEmailCl);
            panel1.Controls.Add(TDireccionCl);
            panel1.Controls.Add(LDireccionCl);
            panel1.Controls.Add(TTelefonoCl);
            panel1.Controls.Add(LTelefonoCl);
            panel1.Controls.Add(TDniCl);
            panel1.Controls.Add(LDniCl);
            panel1.Controls.Add(TApellidoCl);
            panel1.Controls.Add(LApellidoCl);
            panel1.Controls.Add(TNombreCl);
            panel1.Controls.Add(LNombreCl);
            panel1.Controls.Add(LAltaCliente);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 324);
            panel1.TabIndex = 0;
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
            IBResDatos.Location = new Point(115, 283);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 54;
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
            IBAgregarOS.Location = new Point(156, 283);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 53;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // CBObraSocial
            // 
            CBObraSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            CBObraSocial.FormattingEnabled = true;
            CBObraSocial.Location = new Point(157, 254);
            CBObraSocial.Name = "CBObraSocial";
            CBObraSocial.Size = new Size(121, 23);
            CBObraSocial.TabIndex = 16;
            // 
            // LObraSocial
            // 
            LObraSocial.AutoSize = true;
            LObraSocial.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LObraSocial.ForeColor = Color.Black;
            LObraSocial.Location = new Point(15, 254);
            LObraSocial.Name = "LObraSocial";
            LObraSocial.Size = new Size(90, 20);
            LObraSocial.TabIndex = 15;
            LObraSocial.Text = "Obra Social:";
            // 
            // TNroTarjetaCl
            // 
            TNroTarjetaCl.Location = new Point(156, 225);
            TNroTarjetaCl.Name = "TNroTarjetaCl";
            TNroTarjetaCl.Size = new Size(122, 23);
            TNroTarjetaCl.TabIndex = 14;
            TNroTarjetaCl.TextChanged += TNroTarjetaCl_TextChanged;
            // 
            // LTarjetaCl
            // 
            LTarjetaCl.AutoSize = true;
            LTarjetaCl.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LTarjetaCl.ForeColor = Color.Black;
            LTarjetaCl.Location = new Point(15, 225);
            LTarjetaCl.Name = "LTarjetaCl";
            LTarjetaCl.Size = new Size(109, 20);
            LTarjetaCl.TabIndex = 13;
            LTarjetaCl.Text = "Nro de Tarjeta:";
            // 
            // TEmailCl
            // 
            TEmailCl.Location = new Point(156, 196);
            TEmailCl.Name = "TEmailCl";
            TEmailCl.Size = new Size(122, 23);
            TEmailCl.TabIndex = 12;
            // 
            // LEmailCl
            // 
            LEmailCl.AutoSize = true;
            LEmailCl.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LEmailCl.ForeColor = Color.Black;
            LEmailCl.Location = new Point(15, 196);
            LEmailCl.Name = "LEmailCl";
            LEmailCl.Size = new Size(121, 20);
            LEmailCl.TabIndex = 11;
            LEmailCl.Text = "Email de Cliente:";
            // 
            // TDireccionCl
            // 
            TDireccionCl.Location = new Point(156, 166);
            TDireccionCl.Name = "TDireccionCl";
            TDireccionCl.Size = new Size(122, 23);
            TDireccionCl.TabIndex = 10;
            // 
            // LDireccionCl
            // 
            LDireccionCl.AutoSize = true;
            LDireccionCl.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccionCl.ForeColor = Color.Black;
            LDireccionCl.Location = new Point(15, 166);
            LDireccionCl.Name = "LDireccionCl";
            LDireccionCl.Size = new Size(145, 20);
            LDireccionCl.TabIndex = 9;
            LDireccionCl.Text = "Direccion de Cliente:";
            // 
            // TTelefonoCl
            // 
            TTelefonoCl.Location = new Point(156, 137);
            TTelefonoCl.Name = "TTelefonoCl";
            TTelefonoCl.Size = new Size(122, 23);
            TTelefonoCl.TabIndex = 8;
            // 
            // LTelefonoCl
            // 
            LTelefonoCl.AutoSize = true;
            LTelefonoCl.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefonoCl.ForeColor = Color.Black;
            LTelefonoCl.Location = new Point(15, 137);
            LTelefonoCl.Name = "LTelefonoCl";
            LTelefonoCl.Size = new Size(137, 20);
            LTelefonoCl.TabIndex = 7;
            LTelefonoCl.Text = "Telefono de Cliente:";
            // 
            // TDniCl
            // 
            TDniCl.Location = new Point(156, 108);
            TDniCl.Name = "TDniCl";
            TDniCl.Size = new Size(122, 23);
            TDniCl.TabIndex = 6;
            // 
            // LDniCl
            // 
            LDniCl.AutoSize = true;
            LDniCl.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDniCl.ForeColor = Color.Black;
            LDniCl.Location = new Point(15, 108);
            LDniCl.Name = "LDniCl";
            LDniCl.Size = new Size(109, 20);
            LDniCl.TabIndex = 5;
            LDniCl.Text = "Dni del Cliente:";
            // 
            // TApellidoCl
            // 
            TApellidoCl.Location = new Point(156, 79);
            TApellidoCl.Name = "TApellidoCl";
            TApellidoCl.Size = new Size(122, 23);
            TApellidoCl.TabIndex = 4;
            // 
            // LApellidoCl
            // 
            LApellidoCl.AutoSize = true;
            LApellidoCl.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LApellidoCl.ForeColor = Color.Black;
            LApellidoCl.Location = new Point(15, 79);
            LApellidoCl.Name = "LApellidoCl";
            LApellidoCl.Size = new Size(135, 20);
            LApellidoCl.TabIndex = 3;
            LApellidoCl.Text = "Apellido de Cliente:";
            // 
            // TNombreCl
            // 
            TNombreCl.Location = new Point(156, 50);
            TNombreCl.Name = "TNombreCl";
            TNombreCl.Size = new Size(122, 23);
            TNombreCl.TabIndex = 2;
            // 
            // LNombreCl
            // 
            LNombreCl.AutoSize = true;
            LNombreCl.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCl.ForeColor = Color.Black;
            LNombreCl.Location = new Point(15, 50);
            LNombreCl.Name = "LNombreCl";
            LNombreCl.Size = new Size(135, 20);
            LNombreCl.TabIndex = 1;
            LNombreCl.Text = "Nombre de Cliente:";
            // 
            // LAltaCliente
            // 
            LAltaCliente.AutoSize = true;
            LAltaCliente.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LAltaCliente.ForeColor = Color.Purple;
            LAltaCliente.Location = new Point(39, 13);
            LAltaCliente.Name = "LAltaCliente";
            LAltaCliente.Size = new Size(214, 23);
            LAltaCliente.TabIndex = 0;
            LAltaCliente.Text = "Registrar un Nuevo Cliente";
            // 
            // Alta_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(332, 354);
            Controls.Add(panel1);
            Name = "Alta_cliente";
            Text = "a";
            Load += Alta_cliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LNombreCl;
        private Label LAltaCliente;
        private TextBox TEmailCl;
        private Label LEmailCl;
        private TextBox TDireccionCl;
        private Label LDireccionCl;
        private TextBox TTelefonoCl;
        private Label LTelefonoCl;
        private TextBox TDniCl;
        private Label LDniCl;
        private TextBox TApellidoCl;
        private Label LApellidoCl;
        private TextBox TNombreCl;
        private TextBox textBox5;
        private Label LObraSocial;
        private TextBox TNroTarjetaCl;
        private Label LTarjetaCl;
        private ComboBox CBObraSocial;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
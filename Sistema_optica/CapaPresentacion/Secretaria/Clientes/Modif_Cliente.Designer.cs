namespace CapaPresentacion.Secretaria
{
    partial class Modif_ClienteVendedor
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
            label2 = new Label();
            TDireccion = new TextBox();
            TCorreo = new TextBox();
            TTelefono = new TextBox();
            TDni = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LDireccion = new Label();
            LCorreo = new Label();
            LTelefono = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            DTGListaClientes = new DataGridView();
            panel2 = new Panel();
            LListaClientesModif = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TDireccion);
            panel1.Controls.Add(TCorreo);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LDireccion);
            panel1.Controls.Add(LCorreo);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 477);
            panel1.TabIndex = 0;
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
            IBResDatos.Location = new Point(147, 359);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(37, 38);
            IBResDatos.TabIndex = 106;
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
            IBAgregarOS.Location = new Point(188, 359);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(37, 38);
            IBAgregarOS.TabIndex = 105;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 93);
            label2.Name = "label2";
            label2.Size = new Size(200, 26);
            label2.TabIndex = 104;
            label2.Text = "MODIFICAR CLIENTE";
            // 
            // TDireccion
            // 
            TDireccion.Anchor = AnchorStyles.None;
            TDireccion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TDireccion.Location = new Point(244, 323);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(112, 32);
            TDireccion.TabIndex = 102;
            TDireccion.KeyPress += TDireccion_KeyPressEventArgs;
            // 
            // TCorreo
            // 
            TCorreo.Anchor = AnchorStyles.None;
            TCorreo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TCorreo.Location = new Point(244, 285);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(112, 32);
            TCorreo.TabIndex = 101;
            TCorreo.KeyPress += TCorreo_KeyPressEventArgs;
            // 
            // TTelefono
            // 
            TTelefono.Anchor = AnchorStyles.None;
            TTelefono.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TTelefono.Location = new Point(244, 247);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(112, 32);
            TTelefono.TabIndex = 100;
            TTelefono.KeyPress += TTelefono_KeyPressEventArgs;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TDni.Location = new Point(244, 137);
            TDni.Name = "TDni";
            TDni.Size = new Size(112, 32);
            TDni.TabIndex = 99;
            TDni.KeyPress += TDni_KeyPressEventArgs;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.None;
            TNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TNombre.Location = new Point(244, 175);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(112, 32);
            TNombre.TabIndex = 98;
            TNombre.KeyPress += TNombre_KeyPressEventArgs;
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.None;
            TApellido.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TApellido.Location = new Point(244, 211);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(112, 32);
            TApellido.TabIndex = 97;
            TApellido.KeyPress += TApellido_KeyPressEventArgs;
            // 
            // LDireccion
            // 
            LDireccion.Anchor = AnchorStyles.None;
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.White;
            LDireccion.Location = new Point(22, 324);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(216, 28);
            LDireccion.TabIndex = 96;
            LDireccion.Text = "Direccion de Empleado";
            // 
            // LCorreo
            // 
            LCorreo.Anchor = AnchorStyles.None;
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.White;
            LCorreo.Location = new Point(22, 286);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(200, 28);
            LCorreo.TabIndex = 95;
            LCorreo.Text = "Correo de Empleado:";
            // 
            // LTelefono
            // 
            LTelefono.Anchor = AnchorStyles.None;
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.White;
            LTelefono.Location = new Point(22, 251);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(216, 28);
            LTelefono.TabIndex = 94;
            LTelefono.Text = "Telefono de Empleado:";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(22, 141);
            LDni.Name = "LDni";
            LDni.Size = new Size(173, 28);
            LDni.TabIndex = 93;
            LDni.Text = "DNI de Empleado:";
            // 
            // LApellido
            // 
            LApellido.Anchor = AnchorStyles.None;
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.White;
            LApellido.Location = new Point(22, 215);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(211, 28);
            LApellido.TabIndex = 92;
            LApellido.Text = "Apellido de Empleado:";
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.None;
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.White;
            LNombre.Location = new Point(22, 179);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(204, 28);
            LNombre.TabIndex = 91;
            LNombre.Text = "Nombre de Empleado";
            // 
            // DTGListaClientes
            // 
            DTGListaClientes.BackgroundColor = Color.Plum;
            DTGListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaClientes.Dock = DockStyle.Fill;
            DTGListaClientes.Location = new Point(384, 75);
            DTGListaClientes.Name = "DTGListaClientes";
            DTGListaClientes.RowTemplate.Height = 25;
            DTGListaClientes.Size = new Size(803, 402);
            DTGListaClientes.TabIndex = 1;
            DTGListaClientes.CellContentClick += DTGListaClientes_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(LListaClientesModif);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(384, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 75);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // LListaClientesModif
            // 
            LListaClientesModif.AutoSize = true;
            LListaClientesModif.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LListaClientesModif.ForeColor = Color.White;
            LListaClientesModif.Location = new Point(354, 22);
            LListaClientesModif.Name = "LListaClientesModif";
            LListaClientesModif.Size = new Size(168, 28);
            LListaClientesModif.TabIndex = 0;
            LListaClientesModif.Text = "Lista de Clientes";
            // 
            // Modif_ClienteVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGListaClientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Modif_ClienteVendedor";
            Text = "Modificar Cliente";
            Load += Modif_Cliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox TDireccion;
        private TextBox TCorreo;
        private TextBox TTelefono;
        private TextBox TDni;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LDireccion;
        private Label LCorreo;
        private Label LTelefono;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private DataGridView DTGListaClientes;
        private Panel panel2;
        private Label LListaClientesModif;
    }
}
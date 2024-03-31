namespace CapaPresentacion.Vendedor.Clientes
{
    partial class Modificar_cliente
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
            LListaClientesModif = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            TDireccion = new TextBox();
            TCorreo = new TextBox();
            TTelefono = new TextBox();
            TDni = new TextBox();
            TNombre = new TextBox();
            DTGListaClientes = new DataGridView();
            TApellido = new TextBox();
            LCorreo = new Label();
            LTelefono = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            panel2 = new Panel();
            LDireccion = new Label();
            panel1 = new Panel();
            LObraSocial = new Label();
            CBObraSocial = new ComboBox();
            textBox2 = new TextBox();
            LNroTarjeta = new Label();
            textBox1 = new TextBox();
            LEmailCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LListaClientesModif
            // 
            LListaClientesModif.AutoSize = true;
            LListaClientesModif.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LListaClientesModif.ForeColor = Color.Purple;
            LListaClientesModif.Location = new Point(175, 25);
            LListaClientesModif.Name = "LListaClientesModif";
            LListaClientesModif.Size = new Size(144, 23);
            LListaClientesModif.TabIndex = 0;
            LListaClientesModif.Text = "Lista de Clientes";
            // 
            // IBResDatos
            // 
            IBResDatos.Anchor = AnchorStyles.None;
            IBResDatos.BackColor = Color.Transparent;
            IBResDatos.FlatStyle = FlatStyle.Flat;
            IBResDatos.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBResDatos.ForeColor = SystemColors.ControlText;
            IBResDatos.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            IBResDatos.IconColor = Color.Crimson;
            IBResDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBResDatos.IconSize = 27;
            IBResDatos.Location = new Point(129, 337);
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
            IBAgregarOS.IconColor = Color.Purple;
            IBAgregarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarOS.IconSize = 27;
            IBAgregarOS.Location = new Point(170, 337);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(37, 38);
            IBAgregarOS.TabIndex = 105;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(90, 25);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 104;
            label2.Text = "MODIFICAR CLIENTE";
            // 
            // TDireccion
            // 
            TDireccion.Anchor = AnchorStyles.None;
            TDireccion.Location = new Point(196, 210);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(112, 23);
            TDireccion.TabIndex = 102;
            // 
            // TCorreo
            // 
            TCorreo.Anchor = AnchorStyles.None;
            TCorreo.Location = new Point(196, 181);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(112, 23);
            TCorreo.TabIndex = 101;
            // 
            // TTelefono
            // 
            TTelefono.Anchor = AnchorStyles.None;
            TTelefono.Location = new Point(196, 152);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(112, 23);
            TTelefono.TabIndex = 100;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(196, 65);
            TDni.Name = "TDni";
            TDni.Size = new Size(112, 23);
            TDni.TabIndex = 99;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.None;
            TNombre.Location = new Point(196, 94);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(112, 23);
            TNombre.TabIndex = 98;
            // 
            // DTGListaClientes
            // 
            DTGListaClientes.BackgroundColor = Color.Plum;
            DTGListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaClientes.Location = new Point(374, 93);
            DTGListaClientes.Name = "DTGListaClientes";
            DTGListaClientes.RowTemplate.Height = 25;
            DTGListaClientes.Size = new Size(471, 306);
            DTGListaClientes.TabIndex = 4;
            DTGListaClientes.CellContentClick += DTGListaClientes_CellContentClick;
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.None;
            TApellido.Location = new Point(196, 123);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(112, 23);
            TApellido.TabIndex = 97;
            // 
            // LCorreo
            // 
            LCorreo.Anchor = AnchorStyles.None;
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.Black;
            LCorreo.Location = new Point(34, 184);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(126, 20);
            LCorreo.TabIndex = 95;
            LCorreo.Text = "Correo de Cliente:";
            // 
            // LTelefono
            // 
            LTelefono.Anchor = AnchorStyles.None;
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.Black;
            LTelefono.Location = new Point(34, 152);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(137, 20);
            LTelefono.TabIndex = 94;
            LTelefono.Text = "Telefono de Cliente:";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.Black;
            LDni.Location = new Point(34, 65);
            LDni.Name = "LDni";
            LDni.Size = new Size(108, 20);
            LDni.TabIndex = 93;
            LDni.Text = "DNI de Cliente:";
            // 
            // LApellido
            // 
            LApellido.Anchor = AnchorStyles.None;
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.Black;
            LApellido.Location = new Point(33, 126);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(140, 20);
            LApellido.TabIndex = 92;
            LApellido.Text = "Apellido de Cliente::";
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.None;
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.Black;
            LNombre.Location = new Point(34, 97);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(135, 20);
            LNombre.TabIndex = 91;
            LNombre.Text = "Nombre de Cliente:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(LListaClientesModif);
            panel2.Location = new Point(375, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 75);
            panel2.TabIndex = 5;
            // 
            // LDireccion
            // 
            LDireccion.Anchor = AnchorStyles.None;
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.Black;
            LDireccion.Location = new Point(34, 213);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(145, 20);
            LDireccion.TabIndex = 96;
            LDireccion.Text = "Direccion de Cliente:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(LObraSocial);
            panel1.Controls.Add(CBObraSocial);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(LNroTarjeta);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(LEmailCliente);
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 387);
            panel1.TabIndex = 3;
            // 
            // LObraSocial
            // 
            LObraSocial.Anchor = AnchorStyles.None;
            LObraSocial.AutoSize = true;
            LObraSocial.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LObraSocial.ForeColor = Color.Black;
            LObraSocial.Location = new Point(33, 301);
            LObraSocial.Name = "LObraSocial";
            LObraSocial.Size = new Size(90, 20);
            LObraSocial.TabIndex = 112;
            LObraSocial.Text = "Obra Social:";
            // 
            // CBObraSocial
            // 
            CBObraSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            CBObraSocial.FormattingEnabled = true;
            CBObraSocial.Location = new Point(196, 298);
            CBObraSocial.Name = "CBObraSocial";
            CBObraSocial.Size = new Size(112, 23);
            CBObraSocial.TabIndex = 111;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(196, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 110;
            // 
            // LNroTarjeta
            // 
            LNroTarjeta.Anchor = AnchorStyles.None;
            LNroTarjeta.AutoSize = true;
            LNroTarjeta.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LNroTarjeta.ForeColor = Color.Black;
            LNroTarjeta.Location = new Point(34, 272);
            LNroTarjeta.Name = "LNroTarjeta";
            LNroTarjeta.Size = new Size(133, 20);
            LNroTarjeta.TabIndex = 109;
            LNroTarjeta.Text = "Tarjeta del Cliente:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(196, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 108;
            // 
            // LEmailCliente
            // 
            LEmailCliente.Anchor = AnchorStyles.None;
            LEmailCliente.AutoSize = true;
            LEmailCliente.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LEmailCliente.ForeColor = Color.Black;
            LEmailCliente.Location = new Point(34, 242);
            LEmailCliente.Name = "LEmailCliente";
            LEmailCliente.Size = new Size(121, 20);
            LEmailCliente.TabIndex = 107;
            LEmailCliente.Text = "Email de Cliente:";
            // 
            // Modificar_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 411);
            Controls.Add(DTGListaClientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Modificar_cliente";
            Text = "Modificar_cliente";
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LListaClientesModif;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private Label label2;
        private TextBox TDireccion;
        private TextBox TCorreo;
        private TextBox TTelefono;
        private TextBox TDni;
        private TextBox TNombre;
        private DataGridView DTGListaClientes;
        private TextBox TApellido;
        private Label LCorreo;
        private Label LTelefono;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private Panel panel2;
        private Label LDireccion;
        private Panel panel1;
        private Label LObraSocial;
        private ComboBox CBObraSocial;
        private TextBox textBox2;
        private Label LNroTarjeta;
        private TextBox textBox1;
        private Label LEmailCliente;
    }
}
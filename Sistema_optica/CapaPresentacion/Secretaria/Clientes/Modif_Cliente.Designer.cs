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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 292);
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
            IBResDatos.IconColor = Color.Crimson;
            IBResDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBResDatos.IconSize = 27;
            IBResDatos.Location = new Point(134, 239);
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
            IBAgregarOS.Location = new Point(175, 239);
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
            label2.Location = new Point(97, 12);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 104;
            label2.Text = "MODIFICAR CLIENTE";
            // 
            // TDireccion
            // 
            TDireccion.Anchor = AnchorStyles.None;
            TDireccion.Location = new Point(203, 197);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(112, 23);
            TDireccion.TabIndex = 102;
            // 
            // TCorreo
            // 
            TCorreo.Anchor = AnchorStyles.None;
            TCorreo.Location = new Point(203, 168);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(112, 23);
            TCorreo.TabIndex = 101;
            // 
            // TTelefono
            // 
            TTelefono.Anchor = AnchorStyles.None;
            TTelefono.Location = new Point(203, 139);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(112, 23);
            TTelefono.TabIndex = 100;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(203, 52);
            TDni.Name = "TDni";
            TDni.Size = new Size(112, 23);
            TDni.TabIndex = 99;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.None;
            TNombre.Location = new Point(203, 81);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(112, 23);
            TNombre.TabIndex = 98;
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.None;
            TApellido.Location = new Point(203, 110);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(112, 23);
            TApellido.TabIndex = 97;
            // 
            // LDireccion
            // 
            LDireccion.Anchor = AnchorStyles.None;
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.Black;
            LDireccion.Location = new Point(41, 200);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(160, 20);
            LDireccion.TabIndex = 96;
            LDireccion.Text = "Direccion de Empleado";
            // 
            // LCorreo
            // 
            LCorreo.Anchor = AnchorStyles.None;
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.Black;
            LCorreo.Location = new Point(41, 171);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(146, 20);
            LCorreo.TabIndex = 95;
            LCorreo.Text = "Correo de Empleado:";
            // 
            // LTelefono
            // 
            LTelefono.Anchor = AnchorStyles.None;
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.Black;
            LTelefono.Location = new Point(41, 139);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(157, 20);
            LTelefono.TabIndex = 94;
            LTelefono.Text = "Telefono de Empleado:";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.Black;
            LDni.Location = new Point(41, 52);
            LDni.Name = "LDni";
            LDni.Size = new Size(128, 20);
            LDni.TabIndex = 93;
            LDni.Text = "DNI de Empleado:";
            // 
            // LApellido
            // 
            LApellido.Anchor = AnchorStyles.None;
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.Black;
            LApellido.Location = new Point(40, 113);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(155, 20);
            LApellido.TabIndex = 92;
            LApellido.Text = "Apellido de Empleado:";
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.None;
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.Black;
            LNombre.Location = new Point(41, 84);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(150, 20);
            LNombre.TabIndex = 91;
            LNombre.Text = "Nombre de Empleado";
            // 
            // DTGListaClientes
            // 
            DTGListaClientes.BackgroundColor = Color.Plum;
            DTGListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaClientes.Location = new Point(375, 93);
            DTGListaClientes.Name = "DTGListaClientes";
            DTGListaClientes.RowTemplate.Height = 25;
            DTGListaClientes.Size = new Size(356, 211);
            DTGListaClientes.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(LListaClientesModif);
            panel2.Location = new Point(375, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 75);
            panel2.TabIndex = 2;
            // 
            // LListaClientesModif
            // 
            LListaClientesModif.AutoSize = true;
            LListaClientesModif.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LListaClientesModif.ForeColor = Color.Purple;
            LListaClientesModif.Location = new Point(111, 27);
            LListaClientesModif.Name = "LListaClientesModif";
            LListaClientesModif.Size = new Size(144, 23);
            LListaClientesModif.TabIndex = 0;
            LListaClientesModif.Text = "Lista de Clientes";
            // 
            // Modif_ClienteVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(743, 315);
            Controls.Add(panel2);
            Controls.Add(DTGListaClientes);
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
namespace CapaPresentacion.Secretaria
{
    partial class Modif_Cliente
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
            BBorrar = new Button();
            label2 = new Label();
            BGuardar = new Button();
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
            DGVClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVClientes).BeginInit();
            SuspendLayout();
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.BackColor = Color.Red;
            BBorrar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BBorrar.ForeColor = Color.White;
            BBorrar.Location = new Point(196, 393);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(88, 36);
            BBorrar.TabIndex = 89;
            BBorrar.Text = "Borrar";
            BBorrar.UseVisualStyleBackColor = false;
            BBorrar.Click += BBorrar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(186, 9);
            label2.Name = "label2";
            label2.Size = new Size(215, 28);
            label2.TabIndex = 88;
            label2.Text = "MODIFICAR CLIENTE";
            // 
            // BGuardar
            // 
            BGuardar.Anchor = AnchorStyles.None;
            BGuardar.BackColor = Color.Green;
            BGuardar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(302, 393);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 36);
            BGuardar.TabIndex = 87;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // TDireccion
            // 
            TDireccion.Anchor = AnchorStyles.None;
            TDireccion.Location = new Point(117, 119);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(435, 23);
            TDireccion.TabIndex = 86;
            TDireccion.TextChanged += TDireccion_TextChanged;
            // 
            // TCorreo
            // 
            TCorreo.Anchor = AnchorStyles.None;
            TCorreo.Location = new Point(339, 80);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(213, 23);
            TCorreo.TabIndex = 85;
            TCorreo.KeyPress += TTelefono_KeyPressEventArgs;
            // 
            // TTelefono
            // 
            TTelefono.Anchor = AnchorStyles.None;
            TTelefono.Location = new Point(101, 80);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(159, 23);
            TTelefono.TabIndex = 84;
            TTelefono.TextChanged += TTelefono_TextChanged;
            TTelefono.KeyPress += TTelefono_KeyPressEventArgs;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(66, 40);
            TDni.Name = "TDni";
            TDni.Size = new Size(126, 23);
            TDni.TabIndex = 83;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPressEventArgs;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.None;
            TNombre.Location = new Point(273, 40);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(104, 23);
            TNombre.TabIndex = 82;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPressEventArgs;
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.None;
            TApellido.Location = new Point(450, 40);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(102, 23);
            TApellido.TabIndex = 81;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyPress += TApellido_KeyPressEventArgs;
            // 
            // LDireccion
            // 
            LDireccion.Anchor = AnchorStyles.None;
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.FromArgb(0, 64, 64);
            LDireccion.Location = new Point(21, 119);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(81, 23);
            LDireccion.TabIndex = 80;
            LDireccion.Text = "Direccion";
            // 
            // LCorreo
            // 
            LCorreo.Anchor = AnchorStyles.None;
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.FromArgb(0, 64, 64);
            LCorreo.Location = new Point(273, 80);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(60, 23);
            LCorreo.TabIndex = 79;
            LCorreo.Text = "Correo";
            // 
            // LTelefono
            // 
            LTelefono.Anchor = AnchorStyles.None;
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.FromArgb(0, 64, 64);
            LTelefono.Location = new Point(21, 80);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(74, 23);
            LTelefono.TabIndex = 78;
            LTelefono.Text = "Telefono";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.FromArgb(0, 64, 64);
            LDni.Location = new Point(21, 40);
            LDni.Name = "LDni";
            LDni.Size = new Size(39, 23);
            LDni.TabIndex = 77;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.Anchor = AnchorStyles.None;
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.FromArgb(0, 64, 64);
            LApellido.Location = new Point(383, 40);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(70, 23);
            LApellido.TabIndex = 76;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.None;
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.FromArgb(0, 64, 64);
            LNombre.Location = new Point(198, 40);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(69, 23);
            LNombre.TabIndex = 75;
            LNombre.Text = "Nombre";
            // 
            // DGVClientes
            // 
            DGVClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVClientes.Location = new Point(20, 157);
            DGVClientes.MultiSelect = false;
            DGVClientes.Name = "DGVClientes";
            DGVClientes.ReadOnly = true;
            DGVClientes.RowTemplate.Height = 25;
            DGVClientes.Size = new Size(532, 230);
            DGVClientes.TabIndex = 90;
            DGVClientes.CellClick += DGVClientes_CellContentClick;
            DGVClientes.CellContentClick += DGVClientes_CellContentClick;
            // 
            // Modif_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 441);
            Controls.Add(DGVClientes);
            Controls.Add(BBorrar);
            Controls.Add(label2);
            Controls.Add(BGuardar);
            Controls.Add(TDireccion);
            Controls.Add(TCorreo);
            Controls.Add(TTelefono);
            Controls.Add(TDni);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LDireccion);
            Controls.Add(LCorreo);
            Controls.Add(LTelefono);
            Controls.Add(LDni);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Name = "Modif_Cliente";
            Text = "Modificar Cliente";
            Load += Modif_Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)DGVClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BBorrar;
        private Label label2;
        private Button BGuardar;
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
        private DataGridView DGVClientes;
    }
}
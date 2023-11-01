namespace CapaPresentacion.Superadmin
{
    partial class Modif_Empleado
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
            TContrasena = new TextBox();
            TCodigo_emp = new TextBox();
            ComboBox_Perfil = new ComboBox();
            TDireccion = new TextBox();
            TCorreo = new TextBox();
            TTelefono = new TextBox();
            TDni = new TextBox();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LDireccion = new Label();
            LCorreo = new Label();
            LTelefono = new Label();
            LPerfil = new Label();
            LContraseña = new Label();
            LCodigo_tipo_empleado = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            label7 = new Label();
            DGVEmpleadosReg = new DataGridView();
            LEmpleadosRegistrados = new Label();
            TFecha_nac = new TextBox();
            DTPFechaNac = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DGVEmpleadosReg).BeginInit();
            SuspendLayout();
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.BackColor = Color.Red;
            BBorrar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BBorrar.ForeColor = Color.White;
            BBorrar.Location = new Point(296, 490);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(88, 36);
            BBorrar.TabIndex = 49;
            BBorrar.Text = "Borrar";
            BBorrar.UseVisualStyleBackColor = false;
            BBorrar.Click += BBorrar_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(258, 22);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 48;
            label2.Text = "MODIFICAR EMPLEADO";
            // 
            // BGuardar
            // 
            BGuardar.Anchor = AnchorStyles.None;
            BGuardar.BackColor = Color.Green;
            BGuardar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(402, 490);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 36);
            BGuardar.TabIndex = 47;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click_1;
            // 
            // TContrasena
            // 
            TContrasena.Anchor = AnchorStyles.None;
            TContrasena.Location = new Point(445, 199);
            TContrasena.MaxLength = 200;
            TContrasena.Name = "TContrasena";
            TContrasena.Size = new Size(166, 23);
            TContrasena.TabIndex = 45;
            TContrasena.TextChanged += TContrasena_TextChanged_1;
            // 
            // TCodigo_emp
            // 
            TCodigo_emp.Anchor = AnchorStyles.None;
            TCodigo_emp.Location = new Point(647, 68);
            TCodigo_emp.Name = "TCodigo_emp";
            TCodigo_emp.ReadOnly = true;
            TCodigo_emp.Size = new Size(100, 23);
            TCodigo_emp.TabIndex = 44;
            TCodigo_emp.TextChanged += TCodigo_emp_TextChanged_1;
            TCodigo_emp.KeyPress += TCodigo_emp_KeyPress;
            // 
            // ComboBox_Perfil
            // 
            ComboBox_Perfil.Anchor = AnchorStyles.None;
            ComboBox_Perfil.FormattingEnabled = true;
            ComboBox_Perfil.Location = new Point(373, 68);
            ComboBox_Perfil.Name = "ComboBox_Perfil";
            ComboBox_Perfil.Size = new Size(101, 23);
            ComboBox_Perfil.TabIndex = 43;
            ComboBox_Perfil.SelectedIndexChanged += ComboBox_Perfil_SelectedIndexChanged;
            // 
            // TDireccion
            // 
            TDireccion.Anchor = AnchorStyles.None;
            TDireccion.Location = new Point(126, 156);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(200, 23);
            TDireccion.TabIndex = 42;
            TDireccion.TextChanged += TDireccion_TextChanged_1;
            // 
            // TCorreo
            // 
            TCorreo.Anchor = AnchorStyles.None;
            TCorreo.Location = new Point(126, 199);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(200, 23);
            TCorreo.TabIndex = 41;
            TCorreo.TextChanged += TCorreo_TextChanged_1;
            // 
            // TTelefono
            // 
            TTelefono.Anchor = AnchorStyles.None;
            TTelefono.Location = new Point(445, 159);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(166, 23);
            TTelefono.TabIndex = 40;
            TTelefono.TextChanged += TTelefono_TextChanged_1;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(66, 68);
            TDni.Name = "TDni";
            TDni.Size = new Size(139, 23);
            TDni.TabIndex = 38;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.None;
            TNombre.Location = new Point(94, 111);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(137, 23);
            TNombre.TabIndex = 37;
            TNombre.TextChanged += TNombre_TextChanged_1;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.None;
            TApellido.Location = new Point(313, 114);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(137, 23);
            TApellido.TabIndex = 36;
            TApellido.TextChanged += TApellido_TextChanged_1;
            TApellido.KeyPress += TApellido_KeyPress_1;
            // 
            // LDireccion
            // 
            LDireccion.Anchor = AnchorStyles.None;
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.FromArgb(0, 64, 64);
            LDireccion.Location = new Point(39, 156);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(81, 23);
            LDireccion.TabIndex = 35;
            LDireccion.Text = "Direccion";
            // 
            // LCorreo
            // 
            LCorreo.Anchor = AnchorStyles.None;
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.FromArgb(0, 64, 64);
            LCorreo.Location = new Point(42, 199);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(60, 23);
            LCorreo.TabIndex = 34;
            LCorreo.Text = "Correo";
            // 
            // LTelefono
            // 
            LTelefono.Anchor = AnchorStyles.None;
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.FromArgb(0, 64, 64);
            LTelefono.Location = new Point(365, 156);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(74, 23);
            LTelefono.TabIndex = 33;
            LTelefono.Text = "Telefono";
            // 
            // LPerfil
            // 
            LPerfil.Anchor = AnchorStyles.None;
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.ForeColor = Color.FromArgb(0, 64, 64);
            LPerfil.Location = new Point(219, 68);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(148, 23);
            LPerfil.TabIndex = 32;
            LPerfil.Text = "Perfil de empleado";
            // 
            // LContraseña
            // 
            LContraseña.Anchor = AnchorStyles.None;
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LContraseña.ForeColor = Color.FromArgb(0, 64, 64);
            LContraseña.Location = new Point(344, 199);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(95, 23);
            LContraseña.TabIndex = 29;
            LContraseña.Text = "Contraseña";
            // 
            // LCodigo_tipo_empleado
            // 
            LCodigo_tipo_empleado.Anchor = AnchorStyles.None;
            LCodigo_tipo_empleado.AutoSize = true;
            LCodigo_tipo_empleado.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCodigo_tipo_empleado.ForeColor = Color.FromArgb(0, 64, 64);
            LCodigo_tipo_empleado.Location = new Point(482, 68);
            LCodigo_tipo_empleado.Name = "LCodigo_tipo_empleado";
            LCodigo_tipo_empleado.Size = new Size(159, 23);
            LCodigo_tipo_empleado.TabIndex = 28;
            LCodigo_tipo_empleado.Text = "Codigo de empleado";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.FromArgb(0, 64, 64);
            LDni.Location = new Point(19, 65);
            LDni.Name = "LDni";
            LDni.Size = new Size(39, 23);
            LDni.TabIndex = 27;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.Anchor = AnchorStyles.None;
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.FromArgb(0, 64, 64);
            LApellido.Location = new Point(237, 111);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(70, 23);
            LApellido.TabIndex = 26;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.None;
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.FromArgb(0, 64, 64);
            LNombre.Location = new Point(19, 111);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(69, 23);
            LNombre.TabIndex = 25;
            LNombre.Text = "Nombre";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 64, 64);
            label7.Location = new Point(463, 114);
            label7.Name = "label7";
            label7.Size = new Size(165, 23);
            label7.TabIndex = 31;
            label7.Text = "Fecha de nacimiento";
            // 
            // DGVEmpleadosReg
            // 
            DGVEmpleadosReg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVEmpleadosReg.Location = new Point(19, 277);
            DGVEmpleadosReg.MultiSelect = false;
            DGVEmpleadosReg.Name = "DGVEmpleadosReg";
            DGVEmpleadosReg.ReadOnly = true;
            DGVEmpleadosReg.RowTemplate.Height = 25;
            DGVEmpleadosReg.Size = new Size(728, 207);
            DGVEmpleadosReg.TabIndex = 50;
            DGVEmpleadosReg.CellClick += DGVEmpleadosReg_CellContentClick;
            DGVEmpleadosReg.CellContentClick += DGVEmpleadosReg_CellContentClick;
            // 
            // LEmpleadosRegistrados
            // 
            LEmpleadosRegistrados.AutoSize = true;
            LEmpleadosRegistrados.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LEmpleadosRegistrados.Location = new Point(276, 246);
            LEmpleadosRegistrados.Name = "LEmpleadosRegistrados";
            LEmpleadosRegistrados.Size = new Size(233, 28);
            LEmpleadosRegistrados.TabIndex = 51;
            LEmpleadosRegistrados.Text = "Empleados Registrados";
            // 
            // TFecha_nac
            // 
            TFecha_nac.Anchor = AnchorStyles.None;
            TFecha_nac.Location = new Point(634, 114);
            TFecha_nac.Name = "TFecha_nac";
            TFecha_nac.Size = new Size(113, 23);
            TFecha_nac.TabIndex = 39;
            TFecha_nac.TextChanged += TFecha_nac_TextChanged_1;
            // 
            // DTPFechaNac
            // 
            DTPFechaNac.Format = DateTimePickerFormat.Short;
            DTPFechaNac.Location = new Point(634, 153);
            DTPFechaNac.Name = "DTPFechaNac";
            DTPFechaNac.Size = new Size(113, 23);
            DTPFechaNac.TabIndex = 52;
            // 
            // Modif_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 538);
            Controls.Add(DTPFechaNac);
            Controls.Add(LEmpleadosRegistrados);
            Controls.Add(DGVEmpleadosReg);
            Controls.Add(BBorrar);
            Controls.Add(label2);
            Controls.Add(BGuardar);
            Controls.Add(TContrasena);
            Controls.Add(TCodigo_emp);
            Controls.Add(ComboBox_Perfil);
            Controls.Add(TDireccion);
            Controls.Add(TCorreo);
            Controls.Add(TTelefono);
            Controls.Add(TFecha_nac);
            Controls.Add(TDni);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LDireccion);
            Controls.Add(LCorreo);
            Controls.Add(LTelefono);
            Controls.Add(LPerfil);
            Controls.Add(label7);
            Controls.Add(LContraseña);
            Controls.Add(LCodigo_tipo_empleado);
            Controls.Add(LDni);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Name = "Modif_Empleado";
            Text = "Form1";
            Load += Modif_Empleado_Load;
            ((System.ComponentModel.ISupportInitialize)DGVEmpleadosReg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BBorrar;
        private Label label2;
        private Button BGuardar;
        private TextBox TContrasena;
        private TextBox TCodigo_emp;
        private ComboBox ComboBox_Perfil;
        private TextBox TDireccion;
        private TextBox TCorreo;
        private TextBox TTelefono;
        private TextBox TDni;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LDireccion;
        private Label LCorreo;
        private Label LTelefono;
        private Label LPerfil;
        private Label LContraseña;
        private Label LCodigo_tipo_empleado;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private Label label7;
        private DataGridView DGVEmpleadosReg;
        private Label LEmpleadosRegistrados;
        private TextBox TFecha_nac;
        private DateTimePicker DTPFechaNac;
    }
}
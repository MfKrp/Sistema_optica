namespace CapaPresentacion.Superadmin
{
    partial class Carga_empleado
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
            LNombre = new Label();
            LApellido = new Label();
            LDni = new Label();
            LCodigo_tipo_empleado = new Label();
            LContraseña = new Label();
            label6 = new Label();
            label7 = new Label();
            LPerfil = new Label();
            LDireccion = new Label();
            LCorreo = new Label();
            LTelefono = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TDni = new TextBox();
            TTelefono = new TextBox();
            TCorreo = new TextBox();
            TDireccion = new TextBox();
            ComboBox_Perfil = new ComboBox();
            TCodigo_emp = new TextBox();
            TContrasena = new TextBox();
            label1 = new Label();
            BGuardar = new Button();
            label2 = new Label();
            BBorrar = new Button();
            DTPNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.None;
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.FromArgb(0, 64, 64);
            LNombre.Location = new Point(65, 194);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(69, 23);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.Anchor = AnchorStyles.None;
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.FromArgb(0, 64, 64);
            LApellido.Location = new Point(412, 194);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(70, 23);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.FromArgb(0, 64, 64);
            LDni.Location = new Point(27, 66);
            LDni.Name = "LDni";
            LDni.Size = new Size(39, 23);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LCodigo_tipo_empleado
            // 
            LCodigo_tipo_empleado.Anchor = AnchorStyles.None;
            LCodigo_tipo_empleado.AutoSize = true;
            LCodigo_tipo_empleado.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCodigo_tipo_empleado.ForeColor = Color.FromArgb(0, 64, 64);
            LCodigo_tipo_empleado.Location = new Point(456, 125);
            LCodigo_tipo_empleado.Name = "LCodigo_tipo_empleado";
            LCodigo_tipo_empleado.Size = new Size(159, 23);
            LCodigo_tipo_empleado.TabIndex = 3;
            LCodigo_tipo_empleado.Text = "Codigo de empleado";
            // 
            // LContraseña
            // 
            LContraseña.Anchor = AnchorStyles.None;
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LContraseña.ForeColor = Color.FromArgb(0, 64, 64);
            LContraseña.Location = new Point(65, 401);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(95, 23);
            LContraseña.TabIndex = 4;
            LContraseña.Text = "Contraseña";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(273, 288);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 5;
            label6.Text = "(dd/mm/aaaa)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 64, 64);
            label7.Location = new Point(65, 262);
            label7.Name = "label7";
            label7.Size = new Size(165, 23);
            label7.TabIndex = 6;
            label7.Text = "Fecha de nacimiento";
            // 
            // LPerfil
            // 
            LPerfil.Anchor = AnchorStyles.None;
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.ForeColor = Color.FromArgb(0, 64, 64);
            LPerfil.Location = new Point(65, 128);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(148, 23);
            LPerfil.TabIndex = 7;
            LPerfil.Text = "Perfil de empleado";
            // 
            // LDireccion
            // 
            LDireccion.Anchor = AnchorStyles.None;
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.FromArgb(0, 64, 64);
            LDireccion.Location = new Point(65, 331);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(81, 23);
            LDireccion.TabIndex = 10;
            LDireccion.Text = "Direccion";
            // 
            // LCorreo
            // 
            LCorreo.Anchor = AnchorStyles.None;
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.FromArgb(0, 64, 64);
            LCorreo.Location = new Point(445, 331);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(60, 23);
            LCorreo.TabIndex = 9;
            LCorreo.Text = "Correo";
            // 
            // LTelefono
            // 
            LTelefono.Anchor = AnchorStyles.None;
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.FromArgb(0, 64, 64);
            LTelefono.Location = new Point(445, 262);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(74, 23);
            LTelefono.TabIndex = 8;
            LTelefono.Text = "Telefono";
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.None;
            TApellido.Location = new Point(488, 194);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(233, 23);
            TApellido.TabIndex = 11;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.None;
            TNombre.Location = new Point(140, 194);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(233, 23);
            TNombre.TabIndex = 12;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(74, 69);
            TDni.Name = "TDni";
            TDni.Size = new Size(139, 23);
            TDni.TabIndex = 13;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TTelefono
            // 
            TTelefono.Anchor = AnchorStyles.None;
            TTelefono.Location = new Point(535, 262);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(186, 23);
            TTelefono.TabIndex = 15;
            TTelefono.TextChanged += TTelefono_TextChanged;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // TCorreo
            // 
            TCorreo.Anchor = AnchorStyles.None;
            TCorreo.Location = new Point(512, 331);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(209, 23);
            TCorreo.TabIndex = 16;
            TCorreo.TextChanged += TCorreo_TextChanged;
            // 
            // TDireccion
            // 
            TDireccion.Anchor = AnchorStyles.None;
            TDireccion.Location = new Point(152, 331);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(273, 23);
            TDireccion.TabIndex = 17;
            TDireccion.TextChanged += TDireccion_TextChanged;
            // 
            // ComboBox_Perfil
            // 
            ComboBox_Perfil.Anchor = AnchorStyles.None;
            ComboBox_Perfil.FormattingEnabled = true;
            ComboBox_Perfil.Location = new Point(219, 128);
            ComboBox_Perfil.Name = "ComboBox_Perfil";
            ComboBox_Perfil.Size = new Size(196, 23);
            ComboBox_Perfil.TabIndex = 18;
            // 
            // TCodigo_emp
            // 
            TCodigo_emp.Anchor = AnchorStyles.None;
            TCodigo_emp.Location = new Point(621, 125);
            TCodigo_emp.Name = "TCodigo_emp";
            TCodigo_emp.Size = new Size(100, 23);
            TCodigo_emp.TabIndex = 19;
            TCodigo_emp.TextChanged += TCodigo_emp_TextChanged;
            TCodigo_emp.KeyPress += TCodigo_emp_KeyPress;
            // 
            // TContrasena
            // 
            TContrasena.Anchor = AnchorStyles.None;
            TContrasena.Location = new Point(172, 404);
            TContrasena.Name = "TContrasena";
            TContrasena.Size = new Size(207, 23);
            TContrasena.TabIndex = 20;
            TContrasena.TextChanged += TContrasena_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(257, 430);
            label1.Name = "label1";
            label1.Size = new Size(122, 18);
            label1.TabIndex = 21;
            label1.Text = "minimo 5 caracteres";
            // 
            // BGuardar
            // 
            BGuardar.Anchor = AnchorStyles.None;
            BGuardar.BackColor = Color.Green;
            BGuardar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardar.ForeColor = Color.White;
            BGuardar.Location = new Point(633, 473);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(88, 36);
            BGuardar.TabIndex = 22;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(219, 18);
            label2.Name = "label2";
            label2.Size = new Size(345, 28);
            label2.TabIndex = 23;
            label2.Text = "REGISTRAR UN NUEVO EMPLEADO";
            // 
            // BBorrar
            // 
            BBorrar.Anchor = AnchorStyles.None;
            BBorrar.BackColor = Color.Red;
            BBorrar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BBorrar.ForeColor = Color.White;
            BBorrar.Location = new Point(527, 473);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(88, 36);
            BBorrar.TabIndex = 24;
            BBorrar.Text = "Borrar";
            BBorrar.UseVisualStyleBackColor = false;
            // 
            // DTPNacimiento
            // 
            DTPNacimiento.Anchor = AnchorStyles.None;
            DTPNacimiento.Format = DateTimePickerFormat.Short;
            DTPNacimiento.Location = new Point(236, 262);
            DTPNacimiento.Name = "DTPNacimiento";
            DTPNacimiento.Size = new Size(179, 23);
            DTPNacimiento.TabIndex = 25;
            // 
            // Carga_empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 538);
            Controls.Add(DTPNacimiento);
            Controls.Add(BBorrar);
            Controls.Add(label2);
            Controls.Add(BGuardar);
            Controls.Add(label1);
            Controls.Add(TContrasena);
            Controls.Add(TCodigo_emp);
            Controls.Add(ComboBox_Perfil);
            Controls.Add(TDireccion);
            Controls.Add(TCorreo);
            Controls.Add(TTelefono);
            Controls.Add(TDni);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(LDireccion);
            Controls.Add(LCorreo);
            Controls.Add(LTelefono);
            Controls.Add(LPerfil);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(LContraseña);
            Controls.Add(LCodigo_tipo_empleado);
            Controls.Add(LDni);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Name = "Carga_empleado";
            Text = "Carga_empleado";
            Load += Carga_empleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNombre;
        private Label LApellido;
        private Label LDni;
        private Label LCodigo_tipo_empleado;
        private Label LContraseña;
        private Label label6;
        private Label label7;
        private Label LPerfil;
        private Label LDireccion;
        private Label LCorreo;
        private Label LTelefono;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TDni;
        private TextBox TTelefono;
        private TextBox TCorreo;
        private TextBox TDireccion;
        private ComboBox ComboBox_Perfil;
        private TextBox TCodigo_emp;
        private TextBox TContrasena;
        private Label label1;
        private Button BGuardar;
        private Label label2;
        private Button BBorrar;
        private DateTimePicker DTPNacimiento;
    }
}
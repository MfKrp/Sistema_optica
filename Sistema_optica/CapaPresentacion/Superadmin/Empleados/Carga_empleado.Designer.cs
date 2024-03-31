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
            panel1 = new Panel();
            DTPNacimiento = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
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
            LFechaNac = new Label();
            label6 = new Label();
            LContraseña = new Label();
            LCodigo_tipo_empleado = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(DTPNacimiento);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TContrasena);
            panel1.Controls.Add(TCodigo_emp);
            panel1.Controls.Add(ComboBox_Perfil);
            panel1.Controls.Add(TDireccion);
            panel1.Controls.Add(TCorreo);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LDireccion);
            panel1.Controls.Add(LCorreo);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LPerfil);
            panel1.Controls.Add(LFechaNac);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(LContraseña);
            panel1.Controls.Add(LCodigo_tipo_empleado);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 404);
            panel1.TabIndex = 0;
            // 
            // DTPNacimiento
            // 
            DTPNacimiento.Anchor = AnchorStyles.None;
            DTPNacimiento.Format = DateTimePickerFormat.Short;
            DTPNacimiento.Location = new Point(189, 181);
            DTPNacimiento.Name = "DTPNacimiento";
            DTPNacimiento.Size = new Size(139, 23);
            DTPNacimiento.TabIndex = 50;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(22, 10);
            label2.Name = "label2";
            label2.Size = new Size(294, 23);
            label2.TabIndex = 48;
            label2.Text = "REGISTRAR UN NUEVO EMPLEADO";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(204, 310);
            label1.Name = "label1";
            label1.Size = new Size(122, 18);
            label1.TabIndex = 47;
            label1.Text = "minimo 5 caracteres";
            // 
            // TContrasena
            // 
            TContrasena.Anchor = AnchorStyles.None;
            TContrasena.Location = new Point(187, 284);
            TContrasena.Name = "TContrasena";
            TContrasena.Size = new Size(141, 23);
            TContrasena.TabIndex = 46;
            // 
            // TCodigo_emp
            // 
            TCodigo_emp.Anchor = AnchorStyles.None;
            TCodigo_emp.Location = new Point(187, 37);
            TCodigo_emp.Name = "TCodigo_emp";
            TCodigo_emp.Size = new Size(139, 23);
            TCodigo_emp.TabIndex = 45;
            // 
            // ComboBox_Perfil
            // 
            ComboBox_Perfil.Anchor = AnchorStyles.None;
            ComboBox_Perfil.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Perfil.FormattingEnabled = true;
            ComboBox_Perfil.Location = new Point(187, 332);
            ComboBox_Perfil.Name = "ComboBox_Perfil";
            ComboBox_Perfil.Size = new Size(141, 23);
            ComboBox_Perfil.TabIndex = 44;
            // 
            // TDireccion
            // 
            TDireccion.Anchor = AnchorStyles.None;
            TDireccion.Location = new Point(187, 226);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(141, 23);
            TDireccion.TabIndex = 43;
            // 
            // TCorreo
            // 
            TCorreo.Anchor = AnchorStyles.None;
            TCorreo.Location = new Point(187, 255);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(141, 23);
            TCorreo.TabIndex = 42;
            // 
            // TTelefono
            // 
            TTelefono.Anchor = AnchorStyles.None;
            TTelefono.Location = new Point(189, 152);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(139, 23);
            TTelefono.TabIndex = 41;
            // 
            // TDni
            // 
            TDni.Anchor = AnchorStyles.None;
            TDni.Location = new Point(187, 66);
            TDni.Name = "TDni";
            TDni.Size = new Size(139, 23);
            TDni.TabIndex = 40;
            // 
            // TNombre
            // 
            TNombre.Anchor = AnchorStyles.None;
            TNombre.Location = new Point(187, 94);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(139, 23);
            TNombre.TabIndex = 39;
            // 
            // TApellido
            // 
            TApellido.Anchor = AnchorStyles.None;
            TApellido.Location = new Point(187, 123);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(139, 23);
            TApellido.TabIndex = 38;
            // 
            // LDireccion
            // 
            LDireccion.Anchor = AnchorStyles.None;
            LDireccion.AutoSize = true;
            LDireccion.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccion.ForeColor = Color.Black;
            LDireccion.Location = new Point(22, 226);
            LDireccion.Name = "LDireccion";
            LDireccion.Size = new Size(169, 20);
            LDireccion.TabIndex = 37;
            LDireccion.Text = "Direccion del Empleado:";
            // 
            // LCorreo
            // 
            LCorreo.Anchor = AnchorStyles.None;
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LCorreo.ForeColor = Color.Black;
            LCorreo.Location = new Point(22, 255);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(150, 20);
            LCorreo.TabIndex = 36;
            LCorreo.Text = "Correo del Empleado:";
            // 
            // LTelefono
            // 
            LTelefono.Anchor = AnchorStyles.None;
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.ForeColor = Color.Black;
            LTelefono.Location = new Point(19, 152);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(161, 20);
            LTelefono.TabIndex = 35;
            LTelefono.Text = "Telefono del Empleado:";
            // 
            // LPerfil
            // 
            LPerfil.Anchor = AnchorStyles.None;
            LPerfil.AutoSize = true;
            LPerfil.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.ForeColor = Color.Black;
            LPerfil.Location = new Point(19, 332);
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(137, 20);
            LPerfil.TabIndex = 34;
            LPerfil.Text = "Perfil de Empleado:";
            // 
            // LFechaNac
            // 
            LFechaNac.Anchor = AnchorStyles.None;
            LFechaNac.AutoSize = true;
            LFechaNac.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LFechaNac.ForeColor = Color.Black;
            LFechaNac.Location = new Point(22, 181);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(152, 20);
            LFechaNac.TabIndex = 33;
            LFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(223, 207);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 32;
            label6.Text = "(dd/mm/aaaa)";
            // 
            // LContraseña
            // 
            LContraseña.Anchor = AnchorStyles.None;
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LContraseña.ForeColor = Color.Black;
            LContraseña.Location = new Point(22, 284);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(88, 20);
            LContraseña.TabIndex = 31;
            LContraseña.Text = "Contraseña:";
            // 
            // LCodigo_tipo_empleado
            // 
            LCodigo_tipo_empleado.Anchor = AnchorStyles.None;
            LCodigo_tipo_empleado.AutoSize = true;
            LCodigo_tipo_empleado.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LCodigo_tipo_empleado.ForeColor = Color.Black;
            LCodigo_tipo_empleado.Location = new Point(22, 37);
            LCodigo_tipo_empleado.Name = "LCodigo_tipo_empleado";
            LCodigo_tipo_empleado.Size = new Size(141, 20);
            LCodigo_tipo_empleado.TabIndex = 30;
            LCodigo_tipo_empleado.Text = "Codigo de empleado";
            // 
            // LDni
            // 
            LDni.Anchor = AnchorStyles.None;
            LDni.AutoSize = true;
            LDni.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.Black;
            LDni.Location = new Point(22, 66);
            LDni.Name = "LDni";
            LDni.Size = new Size(129, 20);
            LDni.TabIndex = 29;
            LDni.Text = "Dni del Empleado:";
            // 
            // LApellido
            // 
            LApellido.Anchor = AnchorStyles.None;
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.ForeColor = Color.Black;
            LApellido.Location = new Point(22, 123);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(159, 20);
            LApellido.TabIndex = 28;
            LApellido.Text = "Apellido del Empleado:";
            // 
            // LNombre
            // 
            LNombre.Anchor = AnchorStyles.None;
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.ForeColor = Color.Black;
            LNombre.Location = new Point(22, 94);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(159, 20);
            LNombre.TabIndex = 27;
            LNombre.Text = "Nombre del Empleado:";
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
            IBResDatos.Location = new Point(137, 361);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 52;
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
            IBAgregarOS.Location = new Point(178, 361);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 51;
            IBAgregarOS.UseVisualStyleBackColor = false;
            // 
            // Carga_empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 431);
            Controls.Add(panel1);
            Name = "Carga_empleado";
            Text = "Carga_empleado";
            Load += Carga_empleado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker DTPNacimiento;
        private Label label2;
        private Label label1;
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
        private Label LFechaNac;
        private Label label6;
        private Label LContraseña;
        private Label LCodigo_tipo_empleado;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
    }
}
namespace CapaPresentacion.Inicio_sesion
{
    partial class Ver_perfil
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
            MSPerfil = new MenuStrip();
            LPerfil = new ToolStripMenuItem();
            LNombre = new Label();
            LApellido = new Label();
            LTelefono = new Label();
            LEmail = new Label();
            LFecha = new Label();
            LDni = new Label();
            LDirección = new Label();
            LTipoEmpleado = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            TTelefono = new TextBox();
            TEmail = new TextBox();
            TFecha = new TextBox();
            TDni = new TextBox();
            TDireccion = new TextBox();
            TRol = new TextBox();
            MSPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // MSPerfil
            // 
            MSPerfil.AutoSize = false;
            MSPerfil.BackColor = SystemColors.ActiveCaption;
            MSPerfil.Items.AddRange(new ToolStripItem[] { LPerfil });
            MSPerfil.Location = new Point(0, 0);
            MSPerfil.Name = "MSPerfil";
            MSPerfil.Size = new Size(549, 83);
            MSPerfil.TabIndex = 0;
            MSPerfil.Text = "menuStrip1";
            // 
            // LPerfil
            // 
            LPerfil.BackColor = Color.Transparent;
            LPerfil.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LPerfil.ForeColor = Color.White;
            LPerfil.Name = "LPerfil";
            LPerfil.Size = new Size(215, 79);
            LPerfil.Text = "Perfil Empleado";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.FlatStyle = FlatStyle.System;
            LNombre.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.Location = new Point(32, 118);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(158, 23);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre del empleado:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.FlatStyle = FlatStyle.System;
            LApellido.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.Location = new Point(32, 171);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(159, 23);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido del Empleado:";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.FlatStyle = FlatStyle.System;
            LTelefono.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.Location = new Point(32, 225);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(161, 23);
            LTelefono.TabIndex = 3;
            LTelefono.Text = "Telefono del empleado:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.FlatStyle = FlatStyle.System;
            LEmail.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LEmail.Location = new Point(32, 280);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(143, 23);
            LEmail.TabIndex = 4;
            LEmail.Text = "Email del empleado:";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.FlatStyle = FlatStyle.System;
            LFecha.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LFecha.Location = new Point(32, 340);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(148, 23);
            LFecha.TabIndex = 5;
            LFecha.Text = "Fecha de Nacimiento";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.FlatStyle = FlatStyle.System;
            LDni.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.Location = new Point(32, 396);
            LDni.Name = "LDni";
            LDni.Size = new Size(41, 23);
            LDni.TabIndex = 6;
            LDni.Text = "DNI:";
            // 
            // LDirección
            // 
            LDirección.AutoSize = true;
            LDirección.FlatStyle = FlatStyle.System;
            LDirección.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDirección.Location = new Point(308, 121);
            LDirección.Name = "LDirección";
            LDirección.Size = new Size(77, 23);
            LDirección.TabIndex = 7;
            LDirección.Text = "Dirección:";
            // 
            // LTipoEmpleado
            // 
            LTipoEmpleado.AutoSize = true;
            LTipoEmpleado.FlatStyle = FlatStyle.System;
            LTipoEmpleado.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTipoEmpleado.Location = new Point(308, 174);
            LTipoEmpleado.Name = "LTipoEmpleado";
            LTipoEmpleado.Size = new Size(127, 23);
            LTipoEmpleado.TabIndex = 8;
            LTipoEmpleado.Text = "Rol del empleado:";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(196, 121);
            TNombre.Name = "TNombre";
            TNombre.ReadOnly = true;
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 9;
            TNombre.TextChanged += TNombre_TextChanged;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(196, 174);
            TApellido.Name = "TApellido";
            TApellido.ReadOnly = true;
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 10;
            TApellido.TextChanged += TApellido_TextChanged;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(196, 228);
            TTelefono.Name = "TTelefono";
            TTelefono.ReadOnly = true;
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 11;
            TTelefono.TextChanged += TTelefono_TextChanged;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(196, 283);
            TEmail.Name = "TEmail";
            TEmail.ReadOnly = true;
            TEmail.Size = new Size(100, 23);
            TEmail.TabIndex = 12;
            TEmail.TextChanged += TEmail_TextChanged;
            // 
            // TFecha
            // 
            TFecha.Location = new Point(196, 340);
            TFecha.Name = "TFecha";
            TFecha.ReadOnly = true;
            TFecha.Size = new Size(100, 23);
            TFecha.TabIndex = 13;
            TFecha.TextChanged += TFecha_TextChanged;
            // 
            // TDni
            // 
            TDni.Location = new Point(196, 399);
            TDni.Name = "TDni";
            TDni.ReadOnly = true;
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 14;
            TDni.TextChanged += TDni_TextChanged;
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(437, 124);
            TDireccion.Name = "TDireccion";
            TDireccion.ReadOnly = true;
            TDireccion.Size = new Size(100, 23);
            TDireccion.TabIndex = 15;
            TDireccion.TextChanged += TDireccion_TextChanged;
            // 
            // TRol
            // 
            TRol.Location = new Point(437, 174);
            TRol.Name = "TRol";
            TRol.ReadOnly = true;
            TRol.Size = new Size(100, 23);
            TRol.TabIndex = 16;
            TRol.TextChanged += TRol_TextChanged;
            // 
            // Ver_perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(549, 450);
            Controls.Add(TRol);
            Controls.Add(TDireccion);
            Controls.Add(TDni);
            Controls.Add(TFecha);
            Controls.Add(TEmail);
            Controls.Add(TTelefono);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Controls.Add(LTipoEmpleado);
            Controls.Add(LDirección);
            Controls.Add(LDni);
            Controls.Add(LFecha);
            Controls.Add(LEmail);
            Controls.Add(LTelefono);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(MSPerfil);
            MainMenuStrip = MSPerfil;
            Name = "Ver_perfil";
            Text = "Form1";
            Load += Ver_perfil_Load;
            MSPerfil.ResumeLayout(false);
            MSPerfil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MSPerfil;
        private ToolStripMenuItem LPerfil;
        private Label LNombre;
        private Label LApellido;
        private Label LTelefono;
        private Label LEmail;
        private Label LFecha;
        private Label LDni;
        private Label LDirección;
        private Label LTipoEmpleado;
        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TTelefono;
        private TextBox TEmail;
        private TextBox TFecha;
        private TextBox TDni;
        private TextBox TDireccion;
        private TextBox TRol;
    }
}
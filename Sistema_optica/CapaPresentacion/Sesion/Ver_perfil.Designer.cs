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
            LDatoNombre = new Label();
            LDatoApellido = new Label();
            LDatoTelefono = new Label();
            LDatoEmail = new Label();
            LDatoFecha = new Label();
            LDatoDni = new Label();
            LDatoDireccion = new Label();
            LDatoRol = new Label();
            MSPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // MSPerfil
            // 
            MSPerfil.AutoSize = false;
            MSPerfil.BackColor = Color.DarkViolet;
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
            LNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.Location = new Point(32, 118);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(148, 19);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre del empleado:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.Location = new Point(32, 171);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(147, 19);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido del Empleado:";
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefono.Location = new Point(32, 225);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(149, 19);
            LTelefono.TabIndex = 3;
            LTelefono.Text = "Telefono del empleado:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LEmail.Location = new Point(32, 280);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(130, 19);
            LEmail.TabIndex = 4;
            LEmail.Text = "Email del empleado:";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LFecha.Location = new Point(32, 340);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(153, 19);
            LFecha.TabIndex = 5;
            LFecha.Text = "Fecha de incorporación:";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.Location = new Point(32, 396);
            LDni.Name = "LDni";
            LDni.Size = new Size(36, 19);
            LDni.TabIndex = 6;
            LDni.Text = "DNI:";
            // 
            // LDirección
            // 
            LDirección.AutoSize = true;
            LDirección.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LDirección.Location = new Point(291, 118);
            LDirección.Name = "LDirección";
            LDirección.Size = new Size(68, 19);
            LDirección.TabIndex = 7;
            LDirección.Text = "Dirección:";
            // 
            // LTipoEmpleado
            // 
            LTipoEmpleado.AutoSize = true;
            LTipoEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LTipoEmpleado.Location = new Point(291, 171);
            LTipoEmpleado.Name = "LTipoEmpleado";
            LTipoEmpleado.Size = new Size(117, 19);
            LTipoEmpleado.TabIndex = 8;
            LTipoEmpleado.Text = "Rol del empleado:";
            // 
            // LDatoNombre
            // 
            LDatoNombre.AutoSize = true;
            LDatoNombre.Location = new Point(196, 120);
            LDatoNombre.Name = "LDatoNombre";
            LDatoNombre.Size = new Size(49, 15);
            LDatoNombre.TabIndex = 9;
            LDatoNombre.Text = "nombre";
            // 
            // LDatoApellido
            // 
            LDatoApellido.AutoSize = true;
            LDatoApellido.Location = new Point(196, 175);
            LDatoApellido.Name = "LDatoApellido";
            LDatoApellido.Size = new Size(49, 15);
            LDatoApellido.TabIndex = 10;
            LDatoApellido.Text = "apellido";
            // 
            // LDatoTelefono
            // 
            LDatoTelefono.AutoSize = true;
            LDatoTelefono.Location = new Point(196, 229);
            LDatoTelefono.Name = "LDatoTelefono";
            LDatoTelefono.Size = new Size(51, 15);
            LDatoTelefono.TabIndex = 11;
            LDatoTelefono.Text = "telefono";
            // 
            // LDatoEmail
            // 
            LDatoEmail.AutoSize = true;
            LDatoEmail.Location = new Point(196, 284);
            LDatoEmail.Name = "LDatoEmail";
            LDatoEmail.Size = new Size(36, 15);
            LDatoEmail.TabIndex = 12;
            LDatoEmail.Text = "Email";
            // 
            // LDatoFecha
            // 
            LDatoFecha.AutoSize = true;
            LDatoFecha.Location = new Point(196, 344);
            LDatoFecha.Name = "LDatoFecha";
            LDatoFecha.Size = new Size(36, 15);
            LDatoFecha.TabIndex = 13;
            LDatoFecha.Text = "fecha";
            // 
            // LDatoDni
            // 
            LDatoDni.AutoSize = true;
            LDatoDni.Location = new Point(196, 400);
            LDatoDni.Name = "LDatoDni";
            LDatoDni.Size = new Size(24, 15);
            LDatoDni.TabIndex = 14;
            LDatoDni.Text = "dni";
            // 
            // LDatoDireccion
            // 
            LDatoDireccion.AutoSize = true;
            LDatoDireccion.Location = new Point(414, 122);
            LDatoDireccion.Name = "LDatoDireccion";
            LDatoDireccion.Size = new Size(56, 15);
            LDatoDireccion.TabIndex = 15;
            LDatoDireccion.Text = "direccion";
            // 
            // LDatoRol
            // 
            LDatoRol.AutoSize = true;
            LDatoRol.Location = new Point(414, 173);
            LDatoRol.Name = "LDatoRol";
            LDatoRol.Size = new Size(93, 15);
            LDatoRol.TabIndex = 16;
            LDatoRol.Text = "rol de empleado";
            // 
            // Ver_perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(LDatoRol);
            Controls.Add(LDatoDireccion);
            Controls.Add(LDatoDni);
            Controls.Add(LDatoFecha);
            Controls.Add(LDatoEmail);
            Controls.Add(LDatoTelefono);
            Controls.Add(LDatoApellido);
            Controls.Add(LDatoNombre);
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
        private Label LDatoNombre;
        private Label LDatoApellido;
        private Label LDatoTelefono;
        private Label LDatoEmail;
        private Label LDatoFecha;
        private Label LDatoDni;
        private Label LDatoDireccion;
        private Label LDatoRol;
    }
}
namespace CapaPresentacion.Superadmin
{
    partial class Menu_SuperAdmin
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
            menuStrip1 = new MenuStrip();
            MSLMenu = new ToolStripMenuItem();
            MSSuperAdmin = new MenuStrip();
            TSMRegistrarEmpleado = new ToolStripMenuItem();
            TSMBVerEmpleados = new ToolStripMenuItem();
            TSMBVerProductos = new ToolStripMenuItem();
            TSMBVerPerfil = new ToolStripMenuItem();
            MSBCerrarSesion = new ToolStripMenuItem();
            contenedor = new Panel();
            menuStrip1.SuspendLayout();
            MSSuperAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.CadetBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(958, 95);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSLMenu
            // 
            MSLMenu.Font = new Font("Sitka Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            MSLMenu.ForeColor = Color.White;
            MSLMenu.Name = "MSLMenu";
            MSLMenu.Size = new Size(243, 91);
            MSLMenu.Text = "Optica Maribel";
            // 
            // MSSuperAdmin
            // 
            MSSuperAdmin.AutoSize = false;
            MSSuperAdmin.BackColor = Color.CadetBlue;
            MSSuperAdmin.Dock = DockStyle.Left;
            MSSuperAdmin.Items.AddRange(new ToolStripItem[] { TSMRegistrarEmpleado, TSMBVerEmpleados, TSMBVerProductos, TSMBVerPerfil, MSBCerrarSesion });
            MSSuperAdmin.Location = new Point(0, 95);
            MSSuperAdmin.Name = "MSSuperAdmin";
            MSSuperAdmin.Size = new Size(174, 526);
            MSSuperAdmin.TabIndex = 3;
            MSSuperAdmin.Text = "menuStrip2";
            // 
            // TSMRegistrarEmpleado
            // 
            TSMRegistrarEmpleado.BackColor = Color.FromArgb(0, 64, 64);
            TSMRegistrarEmpleado.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMRegistrarEmpleado.ForeColor = Color.White;
            TSMRegistrarEmpleado.Name = "TSMRegistrarEmpleado";
            TSMRegistrarEmpleado.Size = new Size(167, 27);
            TSMRegistrarEmpleado.Text = "Registrar Empleado";
            TSMRegistrarEmpleado.Click += TSMRegistrarEmpleado_Click;
            // 
            // TSMBVerEmpleados
            // 
            TSMBVerEmpleados.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVerEmpleados.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerEmpleados.ForeColor = Color.White;
            TSMBVerEmpleados.Name = "TSMBVerEmpleados";
            TSMBVerEmpleados.Size = new Size(167, 27);
            TSMBVerEmpleados.Text = "Empleados";
            TSMBVerEmpleados.Click += toolStripMenuItem4_Click;
            // 
            // TSMBVerProductos
            // 
            TSMBVerProductos.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVerProductos.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerProductos.ForeColor = Color.White;
            TSMBVerProductos.Name = "TSMBVerProductos";
            TSMBVerProductos.Size = new Size(167, 27);
            TSMBVerProductos.Text = "Productos";
            TSMBVerProductos.Click += TSMBVerProductos_Click;
            // 
            // TSMBVerPerfil
            // 
            TSMBVerPerfil.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVerPerfil.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerPerfil.ForeColor = Color.White;
            TSMBVerPerfil.Name = "TSMBVerPerfil";
            TSMBVerPerfil.Size = new Size(167, 27);
            TSMBVerPerfil.Text = "Ver Perfil";
            // 
            // MSBCerrarSesion
            // 
            MSBCerrarSesion.BackColor = Color.FromArgb(0, 64, 64);
            MSBCerrarSesion.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MSBCerrarSesion.ForeColor = Color.White;
            MSBCerrarSesion.Name = "MSBCerrarSesion";
            MSBCerrarSesion.Size = new Size(167, 27);
            MSBCerrarSesion.Text = "Cerrar Sesión";
            MSBCerrarSesion.Click += MSBCerrarSesion_Click;
            // 
            // contenedor
            // 
            contenedor.Location = new Point(177, 98);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(781, 523);
            contenedor.TabIndex = 4;
            // 
            // Menu_SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 621);
            Controls.Add(contenedor);
            Controls.Add(MSSuperAdmin);
            Controls.Add(menuStrip1);
            Name = "Menu_SuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Menu_SuperAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MSSuperAdmin.ResumeLayout(false);
            MSSuperAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLMenu;
        private MenuStrip MSSuperAdmin;
        private ToolStripMenuItem TSMRegistrarEmpleado;
        private ToolStripMenuItem TSMBVerEmpleados;
        private ToolStripMenuItem TSMBVerProductos;
        private ToolStripMenuItem TSMBVerPerfil;
        private ToolStripMenuItem MSBCerrarSesion;
        private Panel contenedor;
    }
}
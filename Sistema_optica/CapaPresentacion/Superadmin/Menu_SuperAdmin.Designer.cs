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
            TSMIEmpleados = new ToolStripMenuItem();
            TSMIRegistrarEmpleado = new ToolStripMenuItem();
            TSMIVerEmpleados = new ToolStripMenuItem();
            TSMBVerProductos = new ToolStripMenuItem();
            TSMBVerPerfil = new ToolStripMenuItem();
            TSMBBackupBD = new ToolStripMenuItem();
            TSMButtonRestoreBD = new ToolStripMenuItem();
            MSBCerrarSesion = new ToolStripMenuItem();
            contenedor = new Panel();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            MSSuperAdmin.SuspendLayout();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(33, 8, 42);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1194, 95);
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
            MSSuperAdmin.BackColor = Color.FromArgb(223, 54, 12);
            MSSuperAdmin.Dock = DockStyle.Left;
            MSSuperAdmin.Items.AddRange(new ToolStripItem[] { TSMIEmpleados, TSMBVerProductos, TSMBVerPerfil, TSMBBackupBD, TSMButtonRestoreBD, MSBCerrarSesion });
            MSSuperAdmin.Location = new Point(0, 95);
            MSSuperAdmin.Name = "MSSuperAdmin";
            MSSuperAdmin.Size = new Size(174, 578);
            MSSuperAdmin.TabIndex = 3;
            MSSuperAdmin.Text = "menuStrip2";
            MSSuperAdmin.ItemClicked += MSSuperAdmin_ItemClicked;
            // 
            // TSMIEmpleados
            // 
            TSMIEmpleados.AutoSize = false;
            TSMIEmpleados.BackColor = Color.FromArgb(223, 54, 12);
            TSMIEmpleados.DropDownItems.AddRange(new ToolStripItem[] { TSMIRegistrarEmpleado, TSMIVerEmpleados });
            TSMIEmpleados.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMIEmpleados.ForeColor = Color.White;
            TSMIEmpleados.Name = "TSMIEmpleados";
            TSMIEmpleados.Size = new Size(175, 35);
            TSMIEmpleados.Text = "Empleados";
            TSMIEmpleados.Click += TSMRegistrarEmpleado_Click;
            // 
            // TSMIRegistrarEmpleado
            // 
            TSMIRegistrarEmpleado.BackColor = Color.FromArgb(100, 26, 126);
            TSMIRegistrarEmpleado.ForeColor = Color.White;
            TSMIRegistrarEmpleado.Name = "TSMIRegistrarEmpleado";
            TSMIRegistrarEmpleado.Size = new Size(246, 28);
            TSMIRegistrarEmpleado.Text = "Registrar Empleado";
            TSMIRegistrarEmpleado.Click += TSMIRegistrarEmpleado_Click;
            // 
            // TSMIVerEmpleados
            // 
            TSMIVerEmpleados.BackColor = Color.FromArgb(100, 26, 126);
            TSMIVerEmpleados.ForeColor = Color.White;
            TSMIVerEmpleados.Name = "TSMIVerEmpleados";
            TSMIVerEmpleados.Size = new Size(246, 28);
            TSMIVerEmpleados.Text = "Ver lista de empleados";
            TSMIVerEmpleados.Click += TSMIVerEmpleados_Click;
            // 
            // TSMBVerProductos
            // 
            TSMBVerProductos.AutoSize = false;
            TSMBVerProductos.BackColor = Color.FromArgb(223, 54, 12);
            TSMBVerProductos.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerProductos.ForeColor = Color.White;
            TSMBVerProductos.Name = "TSMBVerProductos";
            TSMBVerProductos.Size = new Size(175, 35);
            TSMBVerProductos.Text = "Ver productos";
            TSMBVerProductos.Click += TSMBVerProductos_Click;
            // 
            // TSMBVerPerfil
            // 
            TSMBVerPerfil.AutoSize = false;
            TSMBVerPerfil.BackColor = Color.FromArgb(223, 54, 12);
            TSMBVerPerfil.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerPerfil.ForeColor = Color.White;
            TSMBVerPerfil.Name = "TSMBVerPerfil";
            TSMBVerPerfil.Size = new Size(175, 35);
            TSMBVerPerfil.Text = "Ver Perfil";
            TSMBVerPerfil.Click += TSMBVerPerfil_Click;
            // 
            // TSMBBackupBD
            // 
            TSMBBackupBD.AutoSize = false;
            TSMBBackupBD.BackColor = Color.FromArgb(223, 54, 12);
            TSMBBackupBD.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBBackupBD.ForeColor = Color.White;
            TSMBBackupBD.Name = "TSMBBackupBD";
            TSMBBackupBD.Size = new Size(175, 35);
            TSMBBackupBD.Text = "Backup BD";
            // 
            // TSMButtonRestoreBD
            // 
            TSMButtonRestoreBD.AutoSize = false;
            TSMButtonRestoreBD.BackColor = Color.FromArgb(223, 54, 12);
            TSMButtonRestoreBD.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMButtonRestoreBD.ForeColor = Color.White;
            TSMButtonRestoreBD.Name = "TSMButtonRestoreBD";
            TSMButtonRestoreBD.Size = new Size(175, 35);
            TSMButtonRestoreBD.Text = "Restore BD";
            // 
            // MSBCerrarSesion
            // 
            MSBCerrarSesion.AutoSize = false;
            MSBCerrarSesion.BackColor = Color.FromArgb(223, 54, 12);
            MSBCerrarSesion.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MSBCerrarSesion.ForeColor = Color.White;
            MSBCerrarSesion.Name = "MSBCerrarSesion";
            MSBCerrarSesion.Size = new Size(175, 35);
            MSBCerrarSesion.Text = "Cerrar Sesión";
            MSBCerrarSesion.Click += MSBCerrarSesion_Click;
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.FromArgb(255, 255, 192);
            contenedor.Controls.Add(panel1);
            contenedor.Location = new Point(167, 95);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1027, 578);
            contenedor.TabIndex = 4;
            contenedor.Paint += contenedor_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 213, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 578);
            panel1.TabIndex = 1;
            // 
            // Menu_SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 673);
            Controls.Add(contenedor);
            Controls.Add(MSSuperAdmin);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_SuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Menu_SuperAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MSSuperAdmin.ResumeLayout(false);
            MSSuperAdmin.PerformLayout();
            contenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLMenu;
        private MenuStrip MSSuperAdmin;
        private ToolStripMenuItem TSMIEmpleados;
        private ToolStripMenuItem TSMBVerProductos;
        private ToolStripMenuItem TSMBVerPerfil;
        private ToolStripMenuItem MSBCerrarSesion;
        private Panel contenedor;
        private ToolStripMenuItem TSMBBackupBD;
        private ToolStripMenuItem TSMButtonRestoreBD;
        private ToolStripMenuItem TSMIRegistrarEmpleado;
        private ToolStripMenuItem TSMIVerEmpleados;
        private Panel panel1;
        private ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
    }
}
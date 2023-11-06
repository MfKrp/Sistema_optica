namespace CapaPresentacion.Secretaria
{
    partial class Menu_Secretaria
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
            contenedor = new Panel();
            panel1 = new Panel();
            MSSuperAdmin = new MenuStrip();
            TSMIProductos = new ToolStripMenuItem();
            TSMICargarProducto = new ToolStripMenuItem();
            TSMIVerProductos = new ToolStripMenuItem();
            TSMIVerClientes = new ToolStripMenuItem();
            TSMBVerPerfil = new ToolStripMenuItem();
            MSBCerrarSesion = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            MSLMenu = new ToolStripMenuItem();
            contenedor.SuspendLayout();
            MSSuperAdmin.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.FromArgb(255, 255, 192);
            contenedor.Controls.Add(panel1);
            contenedor.Location = new Point(167, 95);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1027, 578);
            contenedor.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 213, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 578);
            panel1.TabIndex = 1;
            // 
            // MSSuperAdmin
            // 
            MSSuperAdmin.AutoSize = false;
            MSSuperAdmin.BackColor = Color.FromArgb(223, 54, 12);
            MSSuperAdmin.Dock = DockStyle.Left;
            MSSuperAdmin.Items.AddRange(new ToolStripItem[] { TSMIProductos, TSMIVerClientes, TSMBVerPerfil, MSBCerrarSesion });
            MSSuperAdmin.Location = new Point(0, 95);
            MSSuperAdmin.Name = "MSSuperAdmin";
            MSSuperAdmin.Size = new Size(174, 578);
            MSSuperAdmin.TabIndex = 6;
            MSSuperAdmin.Text = "menuStrip2";
            // 
            // TSMIProductos
            // 
            TSMIProductos.AutoSize = false;
            TSMIProductos.BackColor = Color.FromArgb(223, 54, 12);
            TSMIProductos.DropDownItems.AddRange(new ToolStripItem[] { TSMICargarProducto, TSMIVerProductos });
            TSMIProductos.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMIProductos.ForeColor = Color.White;
            TSMIProductos.Name = "TSMIProductos";
            TSMIProductos.Size = new Size(175, 35);
            TSMIProductos.Text = "Productos";
            TSMIProductos.Click += TSMIProductos_Click;
            // 
            // TSMICargarProducto
            // 
            TSMICargarProducto.BackColor = Color.FromArgb(100, 26, 126);
            TSMICargarProducto.ForeColor = Color.White;
            TSMICargarProducto.Name = "TSMICargarProducto";
            TSMICargarProducto.Size = new Size(242, 28);
            TSMICargarProducto.Text = "Cargar un Producto";
            TSMICargarProducto.Click += TSMICargarProducto_Click;
            // 
            // TSMIVerProductos
            // 
            TSMIVerProductos.BackColor = Color.FromArgb(100, 26, 126);
            TSMIVerProductos.ForeColor = Color.White;
            TSMIVerProductos.Name = "TSMIVerProductos";
            TSMIVerProductos.Size = new Size(242, 28);
            TSMIVerProductos.Text = "Ver lista de Productos";
            TSMIVerProductos.Click += TSMIVerProductos_Click;
            // 
            // TSMIVerClientes
            // 
            TSMIVerClientes.AutoSize = false;
            TSMIVerClientes.BackColor = Color.FromArgb(223, 54, 12);
            TSMIVerClientes.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMIVerClientes.ForeColor = Color.White;
            TSMIVerClientes.Name = "TSMIVerClientes";
            TSMIVerClientes.Size = new Size(175, 35);
            TSMIVerClientes.Text = "Ver Clientes";
            TSMIVerClientes.Click += TSMIVerClientes_Click;
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
            TSMBVerPerfil.Click += TSMBVerPerfil_Click_1;
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
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(33, 8, 42);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1194, 95);
            menuStrip1.TabIndex = 5;
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
            // Menu_Secretaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 673);
            Controls.Add(contenedor);
            Controls.Add(MSSuperAdmin);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Secretaria";
            Text = "Menu Secretaria";
            contenedor.ResumeLayout(false);
            MSSuperAdmin.ResumeLayout(false);
            MSSuperAdmin.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel contenedor;
        private Panel panel1;
        private MenuStrip MSSuperAdmin;
        private ToolStripMenuItem TSMIProductos;
        private ToolStripMenuItem TSMICargarProducto;
        private ToolStripMenuItem TSMIVerProductos;
        private ToolStripMenuItem TSMIVerClientes;
        private ToolStripMenuItem TSMBVerPerfil;
        private ToolStripMenuItem MSBCerrarSesion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLMenu;
    }
}
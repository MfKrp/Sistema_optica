namespace CapaPresentacion.Vendedor
{
    partial class Menu_vendedor
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
            TSMClientes = new ToolStripMenuItem();
            TSMIRegistrarCliente = new ToolStripMenuItem();
            TSMBVentas = new ToolStripMenuItem();
            TSMBVerPerfil = new ToolStripMenuItem();
            TSMVerProductos = new ToolStripMenuItem();
            MSBCerrarSesion = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            MSLMenu = new ToolStripMenuItem();
            TSMIRealizarVenta = new ToolStripMenuItem();
            TSMIMisVentas = new ToolStripMenuItem();
            TSMIVerClientes = new ToolStripMenuItem();
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
            MSSuperAdmin.Items.AddRange(new ToolStripItem[] { TSMClientes, TSMBVentas, TSMVerProductos, TSMBVerPerfil, MSBCerrarSesion });
            MSSuperAdmin.Location = new Point(0, 95);
            MSSuperAdmin.Name = "MSSuperAdmin";
            MSSuperAdmin.Size = new Size(174, 578);
            MSSuperAdmin.TabIndex = 6;
            MSSuperAdmin.Text = "menuStrip2";
            // 
            // TSMClientes
            // 
            TSMClientes.AutoSize = false;
            TSMClientes.BackColor = Color.FromArgb(223, 54, 12);
            TSMClientes.DropDownItems.AddRange(new ToolStripItem[] { TSMIRegistrarCliente, TSMIVerClientes });
            TSMClientes.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMClientes.ForeColor = Color.White;
            TSMClientes.Name = "TSMClientes";
            TSMClientes.Size = new Size(175, 35);
            TSMClientes.Text = "Clientes";
            // 
            // TSMIRegistrarCliente
            // 
            TSMIRegistrarCliente.BackColor = Color.FromArgb(100, 26, 126);
            TSMIRegistrarCliente.ForeColor = Color.White;
            TSMIRegistrarCliente.Name = "TSMIRegistrarCliente";
            TSMIRegistrarCliente.Size = new Size(227, 28);
            TSMIRegistrarCliente.Text = "Registrar Cliente";
            // 
            // TSMBVentas
            // 
            TSMBVentas.AutoSize = false;
            TSMBVentas.BackColor = Color.FromArgb(223, 54, 12);
            TSMBVentas.DropDownItems.AddRange(new ToolStripItem[] { TSMIRealizarVenta, TSMIMisVentas });
            TSMBVentas.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVentas.ForeColor = Color.White;
            TSMBVentas.Name = "TSMBVentas";
            TSMBVentas.Size = new Size(175, 35);
            TSMBVentas.Text = "Ventas";
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
            // 
            // TSMVerProductos
            // 
            TSMVerProductos.AutoSize = false;
            TSMVerProductos.BackColor = Color.FromArgb(223, 54, 12);
            TSMVerProductos.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMVerProductos.ForeColor = Color.White;
            TSMVerProductos.Name = "TSMVerProductos";
            TSMVerProductos.Size = new Size(175, 35);
            TSMVerProductos.Text = "Ver Productos";
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
            // TSMIRealizarVenta
            // 
            TSMIRealizarVenta.BackColor = Color.FromArgb(100, 26, 126);
            TSMIRealizarVenta.ForeColor = Color.White;
            TSMIRealizarVenta.Name = "TSMIRealizarVenta";
            TSMIRealizarVenta.Size = new Size(189, 28);
            TSMIRealizarVenta.Text = "Realizar Venta";
            // 
            // TSMIMisVentas
            // 
            TSMIMisVentas.BackColor = Color.FromArgb(100, 26, 126);
            TSMIMisVentas.ForeColor = Color.White;
            TSMIMisVentas.Name = "TSMIMisVentas";
            TSMIMisVentas.Size = new Size(189, 28);
            TSMIMisVentas.Text = "Mis ventas";
            // 
            // TSMIVerClientes
            // 
            TSMIVerClientes.BackColor = Color.FromArgb(100, 26, 126);
            TSMIVerClientes.ForeColor = Color.White;
            TSMIVerClientes.Name = "TSMIVerClientes";
            TSMIVerClientes.Size = new Size(227, 28);
            TSMIVerClientes.Text = "Ver lista de Clientes";
            // 
            // Menu_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 673);
            Controls.Add(contenedor);
            Controls.Add(MSSuperAdmin);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_vendedor";
            Text = "   ";
            Load += Menu_vendedor_Load;
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
        private ToolStripMenuItem TSMClientes;
        private ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private ToolStripMenuItem TSMIRegistrarCliente;
        private ToolStripMenuItem TSMBVentas;
        private ToolStripMenuItem TSMIRealizarVenta;
        private ToolStripMenuItem TSMIMisVentas;
        private ToolStripMenuItem TSMVerProductos;
        private ToolStripMenuItem TSMBVerPerfil;
        private ToolStripMenuItem MSBCerrarSesion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLMenu;
        private ToolStripMenuItem TSMIVerClientes;
    }
}
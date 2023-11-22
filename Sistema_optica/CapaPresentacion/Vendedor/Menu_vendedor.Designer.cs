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
            menuStrip1 = new MenuStrip();
            MSLMenu = new ToolStripMenuItem();
            LBienvenido = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            TSMBRegistrarCliente = new ToolStripMenuItem();
            TSMBGenerarVenta = new ToolStripMenuItem();
            TSMBVerProductos = new ToolStripMenuItem();
            TSMBVerVentas = new ToolStripMenuItem();
            TSMBVerPerfil = new ToolStripMenuItem();
            TSMBCerrarSesion = new ToolStripMenuItem();
            contenedor = new Panel();
            TSMBVer_Clientes = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.CadetBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLMenu, LBienvenido });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1194, 95);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // MSLMenu
            // 
            MSLMenu.Font = new Font("Sitka Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            MSLMenu.ForeColor = Color.White;
            MSLMenu.Name = "MSLMenu";
            MSLMenu.Size = new Size(243, 91);
            MSLMenu.Text = "Optica Maribel";
            // 
            // LBienvenido
            // 
            LBienvenido.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBienvenido.Name = "LBienvenido";
            LBienvenido.Size = new Size(12, 91);
            LBienvenido.Click += LBienvenido_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.CadetBlue;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { TSMBRegistrarCliente, TSMBGenerarVenta, TSMBVerProductos, TSMBVerVentas, TSMBVer_Clientes, TSMBVerPerfil, TSMBCerrarSesion });
            menuStrip2.Location = new Point(0, 95);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(180, 578);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // TSMBRegistrarCliente
            // 
            TSMBRegistrarCliente.BackColor = Color.FromArgb(0, 64, 64);
            TSMBRegistrarCliente.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBRegistrarCliente.ForeColor = Color.White;
            TSMBRegistrarCliente.Name = "TSMBRegistrarCliente";
            TSMBRegistrarCliente.Size = new Size(173, 27);
            TSMBRegistrarCliente.Text = "Registrar Cliente";
            TSMBRegistrarCliente.Click += TSMBRegistrarCliente_Click;
            // 
            // TSMBGenerarVenta
            // 
            TSMBGenerarVenta.BackColor = Color.FromArgb(0, 64, 64);
            TSMBGenerarVenta.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBGenerarVenta.ForeColor = Color.White;
            TSMBGenerarVenta.Name = "TSMBGenerarVenta";
            TSMBGenerarVenta.Size = new Size(173, 27);
            TSMBGenerarVenta.Text = "Generar Venta";
            TSMBGenerarVenta.Click += toolStripMenuItem1_Click;
            // 
            // TSMBVerProductos
            // 
            TSMBVerProductos.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVerProductos.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerProductos.ForeColor = Color.White;
            TSMBVerProductos.Name = "TSMBVerProductos";
            TSMBVerProductos.Size = new Size(173, 27);
            TSMBVerProductos.Text = "Productos";
            TSMBVerProductos.Click += TSMBVerProductos_Click;
            // 
            // TSMBVerVentas
            // 
            TSMBVerVentas.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVerVentas.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerVentas.ForeColor = Color.White;
            TSMBVerVentas.Name = "TSMBVerVentas";
            TSMBVerVentas.Size = new Size(173, 27);
            TSMBVerVentas.Text = "Ventas";
            TSMBVerVentas.Click += TSMBVerVentas_Click;
            // 
            // TSMBVerPerfil
            // 
            TSMBVerPerfil.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVerPerfil.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerPerfil.ForeColor = Color.White;
            TSMBVerPerfil.Name = "TSMBVerPerfil";
            TSMBVerPerfil.Size = new Size(173, 27);
            TSMBVerPerfil.Text = "Ver Perfil";
            TSMBVerPerfil.Click += TSMBVerPerfil_Click;
            // 
            // TSMBCerrarSesion
            // 
            TSMBCerrarSesion.BackColor = Color.FromArgb(0, 64, 64);
            TSMBCerrarSesion.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBCerrarSesion.ForeColor = Color.White;
            TSMBCerrarSesion.Name = "TSMBCerrarSesion";
            TSMBCerrarSesion.Size = new Size(173, 27);
            TSMBCerrarSesion.Text = "Cerrar Sesión";
            TSMBCerrarSesion.Click += TSMBCerrarSesion_Click;
            // 
            // contenedor
            // 
            contenedor.Location = new Point(183, 98);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1005, 571);
            contenedor.TabIndex = 5;
            // 
            // TSMBVer_Clientes
            // 
            TSMBVer_Clientes.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVer_Clientes.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVer_Clientes.ForeColor = Color.White;
            TSMBVer_Clientes.Name = "TSMBVer_Clientes";
            TSMBVer_Clientes.Size = new Size(173, 27);
            TSMBVer_Clientes.Text = "Ver Clientes";
            TSMBVer_Clientes.Click += TSMBVer_Clientes_Click;
            // 
            // Menu_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 673);
            Controls.Add(contenedor);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_vendedor";
            Text = "Form1";
            Load += Menu_vendedor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLMenu;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem TSMBRegistrarCliente;
        private ToolStripMenuItem TSMBGenerarVenta;
        private ToolStripMenuItem TSMBVerProductos;
        private ToolStripMenuItem TSMBVerPerfil;
        private ToolStripMenuItem TSMBVerVentas;
        private ToolStripMenuItem TSMBCerrarSesion;
        private Panel contenedor;
        private ToolStripMenuItem LBienvenido;
        private ToolStripMenuItem TSMBVer_Clientes;
    }
}
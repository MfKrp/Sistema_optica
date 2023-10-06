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
            menuStrip1 = new MenuStrip();
            MSLMenu = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            TSMBAgregarProducto = new ToolStripMenuItem();
            TSMBVerClientes = new ToolStripMenuItem();
            TSMBVerProductos = new ToolStripMenuItem();
            TSMBVerPerfil = new ToolStripMenuItem();
            TSMBCerrarSesion = new ToolStripMenuItem();
            contenedor = new Panel();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.CadetBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1194, 95);
            menuStrip1.TabIndex = 1;
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
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.CadetBlue;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { TSMBAgregarProducto, TSMBVerClientes, TSMBVerProductos, TSMBVerPerfil, TSMBCerrarSesion });
            menuStrip2.Location = new Point(0, 95);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(180, 578);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // TSMBAgregarProducto
            // 
            TSMBAgregarProducto.BackColor = Color.FromArgb(0, 64, 64);
            TSMBAgregarProducto.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBAgregarProducto.ForeColor = Color.White;
            TSMBAgregarProducto.Name = "TSMBAgregarProducto";
            TSMBAgregarProducto.Size = new Size(173, 27);
            TSMBAgregarProducto.Text = "Agregar Producto";
            TSMBAgregarProducto.Click += TSMItem_Click;
            // 
            // TSMBVerClientes
            // 
            TSMBVerClientes.BackColor = Color.FromArgb(0, 64, 64);
            TSMBVerClientes.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMBVerClientes.ForeColor = Color.White;
            TSMBVerClientes.Name = "TSMBVerClientes";
            TSMBVerClientes.Size = new Size(173, 27);
            TSMBVerClientes.Text = "Clientes";
            TSMBVerClientes.Click += TSMBVerClientes_Click;
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
            contenedor.Size = new Size(1011, 575);
            contenedor.TabIndex = 5;
            // 
            // Menu_Secretaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 673);
            Controls.Add(contenedor);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Secretaria";
            Text = "Menu Secretaria";
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
        private ToolStripMenuItem TSMBAgregarProducto;
        private ToolStripMenuItem TSMBVerClientes;
        private ToolStripMenuItem TSMBVerProductos;
        private ToolStripMenuItem TSMBVerPerfil;
        private ToolStripMenuItem TSMBCerrarSesion;
        private Panel contenedor;
    }
}
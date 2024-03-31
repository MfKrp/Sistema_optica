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
            MSOpciones = new MenuStrip();
            MSIClientes = new FontAwesome.Sharp.IconMenuItem();
            verClientesToolStripMenuItem = new ToolStripMenuItem();
            altaDeClienteToolStripMenuItem = new ToolStripMenuItem();
            modificacionDeClienteToolStripMenuItem = new ToolStripMenuItem();
            MSIVerProductos = new FontAwesome.Sharp.IconMenuItem();
            altaAnteojoTerapeuticoToolStripMenuItem = new ToolStripMenuItem();
            verProductosToolStripMenuItem = new ToolStripMenuItem();
            MSIVentasPersonales = new FontAwesome.Sharp.IconMenuItem();
            realizarVentaToolStripMenuItem1 = new ToolStripMenuItem();
            verVentasRealizadasToolStripMenuItem = new ToolStripMenuItem();
            IMVerPerfil = new FontAwesome.Sharp.IconMenuItem();
            MSICerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            verVentasToolStripMenuItem = new ToolStripMenuItem();
            realizarVentaToolStripMenuItem = new ToolStripMenuItem();
            PTitulo = new Panel();
            LEmpleadoLogueado = new Label();
            LOpticaMaribel = new Label();
            pictureBox1 = new PictureBox();
            contenedor.SuspendLayout();
            MSOpciones.SuspendLayout();
            PTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contenedor
            // 
            contenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contenedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedor.BackColor = Color.White;
            contenedor.Controls.Add(pictureBox1);
            contenedor.Location = new Point(0, 141);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1194, 534);
            contenedor.TabIndex = 5;
            contenedor.Paint += contenedor_Paint;
            // 
            // MSOpciones
            // 
            MSOpciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MSOpciones.AutoSize = false;
            MSOpciones.BackColor = Color.Thistle;
            MSOpciones.Dock = DockStyle.None;
            MSOpciones.Items.AddRange(new ToolStripItem[] { MSIClientes, MSIVerProductos, MSIVentasPersonales, IMVerPerfil, MSICerrarSesion });
            MSOpciones.Location = new Point(0, 84);
            MSOpciones.Name = "MSOpciones";
            MSOpciones.Size = new Size(1194, 62);
            MSOpciones.TabIndex = 6;
            MSOpciones.Text = "menuStrip2";
            // 
            // MSIClientes
            // 
            MSIClientes.DropDownItems.AddRange(new ToolStripItem[] { verClientesToolStripMenuItem, altaDeClienteToolStripMenuItem, modificacionDeClienteToolStripMenuItem });
            MSIClientes.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            MSIClientes.IconColor = Color.Black;
            MSIClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIClientes.IconSize = 25;
            MSIClientes.ImageScaling = ToolStripItemImageScaling.None;
            MSIClientes.Name = "MSIClientes";
            MSIClientes.Size = new Size(61, 58);
            MSIClientes.Text = "Clientes";
            MSIClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIClientes.Click += MSIVerClientes_Click;
            // 
            // verClientesToolStripMenuItem
            // 
            verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            verClientesToolStripMenuItem.Size = new Size(200, 22);
            verClientesToolStripMenuItem.Text = "Ver Clientes";
            verClientesToolStripMenuItem.Click += verClientesToolStripMenuItem_Click;
            // 
            // altaDeClienteToolStripMenuItem
            // 
            altaDeClienteToolStripMenuItem.Name = "altaDeClienteToolStripMenuItem";
            altaDeClienteToolStripMenuItem.Size = new Size(200, 22);
            altaDeClienteToolStripMenuItem.Text = "Alta de Cliente";
            altaDeClienteToolStripMenuItem.Click += altaDeClienteToolStripMenuItem_Click;
            // 
            // modificacionDeClienteToolStripMenuItem
            // 
            modificacionDeClienteToolStripMenuItem.Name = "modificacionDeClienteToolStripMenuItem";
            modificacionDeClienteToolStripMenuItem.Size = new Size(200, 22);
            modificacionDeClienteToolStripMenuItem.Text = "Modificacion de Cliente";
            modificacionDeClienteToolStripMenuItem.Click += modificacionDeClienteToolStripMenuItem_Click;
            // 
            // MSIVerProductos
            // 
            MSIVerProductos.DropDownItems.AddRange(new ToolStripItem[] { altaAnteojoTerapeuticoToolStripMenuItem, verProductosToolStripMenuItem });
            MSIVerProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            MSIVerProductos.IconColor = Color.Black;
            MSIVerProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIVerProductos.IconSize = 25;
            MSIVerProductos.ImageScaling = ToolStripItemImageScaling.None;
            MSIVerProductos.Name = "MSIVerProductos";
            MSIVerProductos.Size = new Size(73, 58);
            MSIVerProductos.Text = "Productos";
            MSIVerProductos.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIVerProductos.Click += MSIVerProductos_Click;
            // 
            // altaAnteojoTerapeuticoToolStripMenuItem
            // 
            altaAnteojoTerapeuticoToolStripMenuItem.Name = "altaAnteojoTerapeuticoToolStripMenuItem";
            altaAnteojoTerapeuticoToolStripMenuItem.Size = new Size(204, 22);
            altaAnteojoTerapeuticoToolStripMenuItem.Text = "Alta Anteojo Terapeutico";
            altaAnteojoTerapeuticoToolStripMenuItem.Click += altaAnteojoTerapeuticoToolStripMenuItem_Click;
            // 
            // verProductosToolStripMenuItem
            // 
            verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            verProductosToolStripMenuItem.Size = new Size(204, 22);
            verProductosToolStripMenuItem.Text = "Ver Productos";
            verProductosToolStripMenuItem.Click += verProductosToolStripMenuItem_Click;
            // 
            // MSIVentasPersonales
            // 
            MSIVentasPersonales.DropDownItems.AddRange(new ToolStripItem[] { realizarVentaToolStripMenuItem1, verVentasRealizadasToolStripMenuItem });
            MSIVentasPersonales.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MSIVentasPersonales.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            MSIVentasPersonales.IconColor = Color.Black;
            MSIVentasPersonales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIVentasPersonales.IconSize = 25;
            MSIVentasPersonales.ImageScaling = ToolStripItemImageScaling.None;
            MSIVentasPersonales.Name = "MSIVentasPersonales";
            MSIVentasPersonales.Size = new Size(53, 58);
            MSIVentasPersonales.Text = "Ventas";
            MSIVentasPersonales.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // realizarVentaToolStripMenuItem1
            // 
            realizarVentaToolStripMenuItem1.Name = "realizarVentaToolStripMenuItem1";
            realizarVentaToolStripMenuItem1.Size = new Size(184, 22);
            realizarVentaToolStripMenuItem1.Text = "Realizar Venta";
            realizarVentaToolStripMenuItem1.Click += realizarVentaToolStripMenuItem1_Click;
            // 
            // verVentasRealizadasToolStripMenuItem
            // 
            verVentasRealizadasToolStripMenuItem.Name = "verVentasRealizadasToolStripMenuItem";
            verVentasRealizadasToolStripMenuItem.Size = new Size(184, 22);
            verVentasRealizadasToolStripMenuItem.Text = "Ver Ventas Realizadas";
            verVentasRealizadasToolStripMenuItem.Click += verVentasRealizadasToolStripMenuItem_Click;
            // 
            // IMVerPerfil
            // 
            IMVerPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IMVerPerfil.IconChar = FontAwesome.Sharp.IconChar.Person;
            IMVerPerfil.IconColor = Color.Black;
            IMVerPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IMVerPerfil.IconSize = 25;
            IMVerPerfil.ImageScaling = ToolStripItemImageScaling.None;
            IMVerPerfil.Name = "IMVerPerfil";
            IMVerPerfil.Size = new Size(65, 58);
            IMVerPerfil.Text = "Ver Perfil";
            IMVerPerfil.TextImageRelation = TextImageRelation.ImageAboveText;
            IMVerPerfil.Click += IMVerPerfil_Click;
            // 
            // MSICerrarSesion
            // 
            MSICerrarSesion.IconChar = FontAwesome.Sharp.IconChar.X;
            MSICerrarSesion.IconColor = Color.Black;
            MSICerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSICerrarSesion.IconSize = 25;
            MSICerrarSesion.ImageScaling = ToolStripItemImageScaling.None;
            MSICerrarSesion.Name = "MSICerrarSesion";
            MSICerrarSesion.Size = new Size(88, 58);
            MSICerrarSesion.Text = "Cerrar Sesion";
            MSICerrarSesion.TextImageRelation = TextImageRelation.ImageAboveText;
            MSICerrarSesion.Click += MSICerrarSesion_Click;
            // 
            // verVentasToolStripMenuItem
            // 
            verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            verVentasToolStripMenuItem.Size = new Size(180, 22);
            verVentasToolStripMenuItem.Text = "Ver Ventas";
            // 
            // realizarVentaToolStripMenuItem
            // 
            realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            realizarVentaToolStripMenuItem.Size = new Size(180, 22);
            realizarVentaToolStripMenuItem.Text = "Realizar Venta";
            // 
            // PTitulo
            // 
            PTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PTitulo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PTitulo.BackColor = Color.DarkOrchid;
            PTitulo.Controls.Add(LEmpleadoLogueado);
            PTitulo.Controls.Add(LOpticaMaribel);
            PTitulo.Location = new Point(0, 0);
            PTitulo.Name = "PTitulo";
            PTitulo.Size = new Size(1194, 88);
            PTitulo.TabIndex = 8;
            PTitulo.Paint += PTitulo_Paint;
            // 
            // LEmpleadoLogueado
            // 
            LEmpleadoLogueado.AutoSize = true;
            LEmpleadoLogueado.Font = new Font("Sitka Text", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LEmpleadoLogueado.ForeColor = Color.Black;
            LEmpleadoLogueado.Location = new Point(1005, 14);
            LEmpleadoLogueado.Name = "LEmpleadoLogueado";
            LEmpleadoLogueado.Size = new Size(0, 29);
            LEmpleadoLogueado.TabIndex = 1;
            LEmpleadoLogueado.Click += LEmpleadoLogueado_Click;
            // 
            // LOpticaMaribel
            // 
            LOpticaMaribel.AutoSize = true;
            LOpticaMaribel.Font = new Font("Sitka Text", 25F, FontStyle.Bold, GraphicsUnit.Point);
            LOpticaMaribel.ForeColor = Color.Black;
            LOpticaMaribel.Location = new Point(12, 14);
            LOpticaMaribel.Name = "LOpticaMaribel";
            LOpticaMaribel.Size = new Size(270, 49);
            LOpticaMaribel.TabIndex = 0;
            LOpticaMaribel.Text = "Optica Maribel";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.optica_maribel1;
            pictureBox1.Location = new Point(479, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Menu_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 673);
            Controls.Add(PTitulo);
            Controls.Add(MSOpciones);
            Controls.Add(contenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_vendedor";
            Text = "Form1";
            Load += Menu_vendedor_Load;
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            MSOpciones.ResumeLayout(false);
            MSOpciones.PerformLayout();
            PTitulo.ResumeLayout(false);
            PTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel contenedor;
        private MenuStrip MSOpciones;
        private FontAwesome.Sharp.IconMenuItem IMVerPerfil;
        private FontAwesome.Sharp.IconMenuItem MSIVerVentas;
        private FontAwesome.Sharp.IconMenuItem MSIAltaCliente;
        private FontAwesome.Sharp.IconMenuItem MSIClientes;
        private FontAwesome.Sharp.IconMenuItem MSIAltaVenta;
        private FontAwesome.Sharp.IconMenuItem MSICerrarSesion;
        private FontAwesome.Sharp.IconMenuItem MSIVerProductos;
        private ToolStripMenuItem verClientesToolStripMenuItem;
        private ToolStripMenuItem altaDeClienteToolStripMenuItem;
        private ToolStripMenuItem modificacionDeClienteToolStripMenuItem;
        private ToolStripMenuItem verVentasToolStripMenuItem;
        private ToolStripMenuItem realizarVentaToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MSIVentasPersonales;
        private ToolStripMenuItem realizarVentaToolStripMenuItem1;
        private ToolStripMenuItem verVentasRealizadasToolStripMenuItem;
        private ToolStripMenuItem altaAnteojoTerapeuticoToolStripMenuItem;
        private Panel PTitulo;
        private Label LEmpleadoLogueado;
        private Label LOpticaMaribel;
        private ToolStripMenuItem verProductosToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
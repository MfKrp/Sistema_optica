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
            contenedor = new Panel();
            menuStrip2 = new MenuStrip();
            MSIVerEmpleados = new FontAwesome.Sharp.IconMenuItem();
            altaDeEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            verEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            MSIVentasGenerales = new FontAwesome.Sharp.IconMenuItem();
            MSIVerProductos = new FontAwesome.Sharp.IconMenuItem();
            MSIRestoreBd = new FontAwesome.Sharp.IconMenuItem();
            MSIBackupBd = new FontAwesome.Sharp.IconMenuItem();
            MSIVerPerfil = new FontAwesome.Sharp.IconMenuItem();
            MSICerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            PTitulo = new Panel();
            LEmpleadoLogueado = new Label();
            LOpticaMaribel = new Label();
            PContenido = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip2.SuspendLayout();
            PTitulo.SuspendLayout();
            PContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contenedor
            // 
            contenedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contenedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            contenedor.BackColor = Color.Plum;
            contenedor.Location = new Point(0, 158);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(0, 0);
            contenedor.TabIndex = 4;
            contenedor.Paint += contenedor_Paint;
            // 
            // menuStrip2
            // 
            menuStrip2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.Thistle;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { MSIVerEmpleados, MSIVentasGenerales, MSIVerProductos, MSIRestoreBd, MSIBackupBd, MSIVerPerfil, MSICerrarSesion });
            menuStrip2.Location = new Point(0, 90);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1194, 65);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // MSIVerEmpleados
            // 
            MSIVerEmpleados.DropDownItems.AddRange(new ToolStripItem[] { altaDeEmpleadoToolStripMenuItem, verEmpleadosToolStripMenuItem });
            MSIVerEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            MSIVerEmpleados.IconColor = Color.Black;
            MSIVerEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIVerEmpleados.IconSize = 25;
            MSIVerEmpleados.ImageScaling = ToolStripItemImageScaling.None;
            MSIVerEmpleados.Name = "MSIVerEmpleados";
            MSIVerEmpleados.Size = new Size(77, 61);
            MSIVerEmpleados.Text = "Empleados";
            MSIVerEmpleados.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIVerEmpleados.Click += MSIVerEmpleados_Click;
            // 
            // altaDeEmpleadoToolStripMenuItem
            // 
            altaDeEmpleadoToolStripMenuItem.Name = "altaDeEmpleadoToolStripMenuItem";
            altaDeEmpleadoToolStripMenuItem.Size = new Size(168, 22);
            altaDeEmpleadoToolStripMenuItem.Text = "Alta De Empleado";
            altaDeEmpleadoToolStripMenuItem.Click += altaDeEmpleadoToolStripMenuItem_Click;
            // 
            // verEmpleadosToolStripMenuItem
            // 
            verEmpleadosToolStripMenuItem.Name = "verEmpleadosToolStripMenuItem";
            verEmpleadosToolStripMenuItem.Size = new Size(168, 22);
            verEmpleadosToolStripMenuItem.Text = "Ver Empleados";
            verEmpleadosToolStripMenuItem.Click += verEmpleadosToolStripMenuItem_Click;
            // 
            // MSIVentasGenerales
            // 
            MSIVentasGenerales.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            MSIVentasGenerales.IconColor = Color.Black;
            MSIVentasGenerales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIVentasGenerales.IconSize = 25;
            MSIVentasGenerales.ImageScaling = ToolStripItemImageScaling.None;
            MSIVentasGenerales.Name = "MSIVentasGenerales";
            MSIVentasGenerales.Size = new Size(107, 61);
            MSIVentasGenerales.Text = "Ventas Generales";
            MSIVentasGenerales.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIVentasGenerales.Click += MSIVentasGenerales_Click;
            // 
            // MSIVerProductos
            // 
            MSIVerProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            MSIVerProductos.IconColor = Color.Black;
            MSIVerProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIVerProductos.IconSize = 25;
            MSIVerProductos.ImageScaling = ToolStripItemImageScaling.None;
            MSIVerProductos.Name = "MSIVerProductos";
            MSIVerProductos.Size = new Size(92, 61);
            MSIVerProductos.Text = "Ver Productos";
            MSIVerProductos.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIVerProductos.Click += MSIVerProductos_Click;
            // 
            // MSIRestoreBd
            // 
            MSIRestoreBd.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            MSIRestoreBd.IconColor = Color.Black;
            MSIRestoreBd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIRestoreBd.IconSize = 25;
            MSIRestoreBd.ImageScaling = ToolStripItemImageScaling.None;
            MSIRestoreBd.Name = "MSIRestoreBd";
            MSIRestoreBd.Size = new Size(76, 61);
            MSIRestoreBd.Text = "Restore BD";
            MSIRestoreBd.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIRestoreBd.Click += MSIRestoreBd_Click;
            // 
            // MSIBackupBd
            // 
            MSIBackupBd.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            MSIBackupBd.IconColor = Color.Black;
            MSIBackupBd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIBackupBd.IconSize = 25;
            MSIBackupBd.ImageScaling = ToolStripItemImageScaling.None;
            MSIBackupBd.Name = "MSIBackupBd";
            MSIBackupBd.Size = new Size(76, 61);
            MSIBackupBd.Text = "Backup BD";
            MSIBackupBd.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIBackupBd.Click += MSIBackupBd_Click;
            // 
            // MSIVerPerfil
            // 
            MSIVerPerfil.IconChar = FontAwesome.Sharp.IconChar.Person;
            MSIVerPerfil.IconColor = Color.Black;
            MSIVerPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIVerPerfil.IconSize = 25;
            MSIVerPerfil.ImageScaling = ToolStripItemImageScaling.None;
            MSIVerPerfil.Name = "MSIVerPerfil";
            MSIVerPerfil.Size = new Size(65, 61);
            MSIVerPerfil.Text = "Ver Perfil";
            MSIVerPerfil.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIVerPerfil.Click += MSIVerPerfil_Click;
            // 
            // MSICerrarSesion
            // 
            MSICerrarSesion.IconChar = FontAwesome.Sharp.IconChar.X;
            MSICerrarSesion.IconColor = Color.Black;
            MSICerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSICerrarSesion.IconSize = 25;
            MSICerrarSesion.ImageScaling = ToolStripItemImageScaling.None;
            MSICerrarSesion.Name = "MSICerrarSesion";
            MSICerrarSesion.Size = new Size(88, 61);
            MSICerrarSesion.Text = "Cerrar Sesion";
            MSICerrarSesion.TextImageRelation = TextImageRelation.ImageAboveText;
            MSICerrarSesion.Click += MSICerrarSesion_Click;
            // 
            // PTitulo
            // 
            PTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PTitulo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PTitulo.BackColor = Color.DarkOrchid;
            PTitulo.Controls.Add(LEmpleadoLogueado);
            PTitulo.Controls.Add(LOpticaMaribel);
            PTitulo.Location = new Point(0, -2);
            PTitulo.Name = "PTitulo";
            PTitulo.Size = new Size(1194, 94);
            PTitulo.TabIndex = 8;
            PTitulo.Paint += PTitulo_Paint;
            // 
            // LEmpleadoLogueado
            // 
            LEmpleadoLogueado.AutoSize = true;
            LEmpleadoLogueado.Font = new Font("Sitka Text", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LEmpleadoLogueado.ForeColor = Color.Black;
            LEmpleadoLogueado.Location = new Point(988, 19);
            LEmpleadoLogueado.Name = "LEmpleadoLogueado";
            LEmpleadoLogueado.Size = new Size(0, 29);
            LEmpleadoLogueado.TabIndex = 1;
            // 
            // LOpticaMaribel
            // 
            LOpticaMaribel.AutoSize = true;
            LOpticaMaribel.Font = new Font("Sitka Text", 25F, FontStyle.Bold, GraphicsUnit.Point);
            LOpticaMaribel.ForeColor = Color.Black;
            LOpticaMaribel.Location = new Point(12, 19);
            LOpticaMaribel.Name = "LOpticaMaribel";
            LOpticaMaribel.Size = new Size(270, 49);
            LOpticaMaribel.TabIndex = 0;
            LOpticaMaribel.Text = "Optica Maribel";
            // 
            // PContenido
            // 
            PContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PContenido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PContenido.BackColor = Color.White;
            PContenido.Controls.Add(pictureBox1);
            PContenido.Location = new Point(0, 153);
            PContenido.Name = "PContenido";
            PContenido.Size = new Size(1194, 520);
            PContenido.TabIndex = 9;
            PContenido.Paint += PContenido_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.optica_maribel1;
            pictureBox1.Location = new Point(485, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Menu_SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 673);
            Controls.Add(PContenido);
            Controls.Add(PTitulo);
            Controls.Add(menuStrip2);
            Controls.Add(contenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_SuperAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Menu_SuperAdmin_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            PTitulo.ResumeLayout(false);
            PTitulo.PerformLayout();
            PContenido.ResumeLayout(false);
            PContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel contenedor;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem MSIBackupBd;
        private FontAwesome.Sharp.IconMenuItem MSIRestoreBd;
        private FontAwesome.Sharp.IconMenuItem MSICerrarSesion;
        private FontAwesome.Sharp.IconMenuItem MSIVerPerfil;
        private FontAwesome.Sharp.IconMenuItem MSIVentasGenerales;
        private FontAwesome.Sharp.IconMenuItem MSIVerEmpleados;
        private FontAwesome.Sharp.IconMenuItem MSIVerProductos;
        private ToolStripMenuItem altaDeEmpleadoToolStripMenuItem;
        private ToolStripMenuItem verEmpleadosToolStripMenuItem;
        private Panel PTitulo;
        private Label LEmpleadoLogueado;
        private Label LOpticaMaribel;
        private Panel PContenido;
        private PictureBox pictureBox1;
    }
}
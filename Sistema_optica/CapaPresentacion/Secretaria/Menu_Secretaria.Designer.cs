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
            menuStrip2 = new MenuStrip();
            MSIClientes = new FontAwesome.Sharp.IconMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            obrasSocialesToolStripMenuItem = new ToolStripMenuItem();
            MSIGestorProds = new FontAwesome.Sharp.IconMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            marcasToolStripMenuItem = new ToolStripMenuItem();
            formasToolStripMenuItem = new ToolStripMenuItem();
            estilosToolStripMenuItem = new ToolStripMenuItem();
            cristalesToolStripMenuItem = new ToolStripMenuItem();
            MSIVerPerfil = new FontAwesome.Sharp.IconMenuItem();
            MSICerrarSesion = new FontAwesome.Sharp.IconMenuItem();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            PTitulo = new Panel();
            LEmpleadoLogueado = new Label();
            LOpticaMaribel = new Label();
            pictureBox1 = new PictureBox();
            contenedor.SuspendLayout();
            menuStrip2.SuspendLayout();
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
            contenedor.Location = new Point(0, 159);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1194, 515);
            contenedor.TabIndex = 5;
            contenedor.Paint += contenedor_Paint;
            // 
            // menuStrip2
            // 
            menuStrip2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.Thistle;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { MSIClientes, MSIGestorProds, MSIVerPerfil, MSICerrarSesion });
            menuStrip2.Location = new Point(0, 88);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1194, 77);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // MSIClientes
            // 
            MSIClientes.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, obrasSocialesToolStripMenuItem });
            MSIClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            MSIClientes.IconColor = Color.Black;
            MSIClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIClientes.IconSize = 25;
            MSIClientes.ImageScaling = ToolStripItemImageScaling.None;
            MSIClientes.Name = "MSIClientes";
            MSIClientes.Size = new Size(98, 73);
            MSIClientes.Text = "Gestor Clientes";
            MSIClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MSIClientes.Click += MSIVerClientes_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(150, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // obrasSocialesToolStripMenuItem
            // 
            obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            obrasSocialesToolStripMenuItem.Size = new Size(150, 22);
            obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            obrasSocialesToolStripMenuItem.Click += obrasSocialesToolStripMenuItem_Click;
            // 
            // MSIGestorProds
            // 
            MSIGestorProds.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, marcasToolStripMenuItem, formasToolStripMenuItem, estilosToolStripMenuItem, cristalesToolStripMenuItem });
            MSIGestorProds.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            MSIGestorProds.IconColor = Color.Black;
            MSIGestorProds.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIGestorProds.IconSize = 25;
            MSIGestorProds.ImageScaling = ToolStripItemImageScaling.None;
            MSIGestorProds.Name = "MSIGestorProds";
            MSIGestorProds.Size = new Size(110, 73);
            MSIGestorProds.Text = "Gestor Productos";
            MSIGestorProds.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(128, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(128, 22);
            marcasToolStripMenuItem.Text = "Marcas";
            marcasToolStripMenuItem.Click += marcasToolStripMenuItem_Click;
            // 
            // formasToolStripMenuItem
            // 
            formasToolStripMenuItem.Name = "formasToolStripMenuItem";
            formasToolStripMenuItem.Size = new Size(128, 22);
            formasToolStripMenuItem.Text = "Formas";
            formasToolStripMenuItem.Click += formasToolStripMenuItem_Click;
            // 
            // estilosToolStripMenuItem
            // 
            estilosToolStripMenuItem.Name = "estilosToolStripMenuItem";
            estilosToolStripMenuItem.Size = new Size(128, 22);
            estilosToolStripMenuItem.Text = "Estilos";
            estilosToolStripMenuItem.Click += estilosToolStripMenuItem_Click;
            // 
            // cristalesToolStripMenuItem
            // 
            cristalesToolStripMenuItem.Name = "cristalesToolStripMenuItem";
            cristalesToolStripMenuItem.Size = new Size(128, 22);
            cristalesToolStripMenuItem.Text = "Cristales";
            cristalesToolStripMenuItem.Click += cristalesToolStripMenuItem_Click;
            // 
            // MSIVerPerfil
            // 
            MSIVerPerfil.IconChar = FontAwesome.Sharp.IconChar.Person;
            MSIVerPerfil.IconColor = Color.Black;
            MSIVerPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MSIVerPerfil.IconSize = 25;
            MSIVerPerfil.ImageScaling = ToolStripItemImageScaling.None;
            MSIVerPerfil.Name = "MSIVerPerfil";
            MSIVerPerfil.Size = new Size(65, 73);
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
            MSICerrarSesion.Size = new Size(88, 73);
            MSICerrarSesion.Text = "Cerrar Sesion";
            MSICerrarSesion.TextImageRelation = TextImageRelation.ImageAboveText;
            MSICerrarSesion.Click += MSICerrarSesion_Click;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
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
            PTitulo.Size = new Size(1194, 91);
            PTitulo.TabIndex = 7;
            PTitulo.Paint += PTitulo_Paint;
            // 
            // LEmpleadoLogueado
            // 
            LEmpleadoLogueado.AutoSize = true;
            LEmpleadoLogueado.Font = new Font("Sitka Text", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LEmpleadoLogueado.ForeColor = Color.Black;
            LEmpleadoLogueado.Location = new Point(1006, 19);
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
            LOpticaMaribel.Location = new Point(12, 19);
            LOpticaMaribel.Name = "LOpticaMaribel";
            LOpticaMaribel.Size = new Size(270, 49);
            LOpticaMaribel.TabIndex = 0;
            LOpticaMaribel.Text = "Optica Maribel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.optica_maribel1;
            pictureBox1.Location = new Point(475, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu_Secretaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1194, 673);
            Controls.Add(PTitulo);
            Controls.Add(menuStrip2);
            Controls.Add(contenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Secretaria";
            Text = "Menu Secretaria";
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            PTitulo.ResumeLayout(false);
            PTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel contenedor;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem MSIClientes;
        private FontAwesome.Sharp.IconMenuItem MSIVerPerfil;
        private FontAwesome.Sharp.IconMenuItem MSICerrarSesion;
        private FontAwesome.Sharp.IconMenuItem MSIGestorProds;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem formasToolStripMenuItem;
        private ToolStripMenuItem estilosToolStripMenuItem;
        private ToolStripMenuItem cristalesToolStripMenuItem;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem obrasSocialesToolStripMenuItem;
        private Panel PTitulo;
        private Label LOpticaMaribel;
        private Label LEmpleadoLogueado;
        private PictureBox pictureBox1;
    }
}
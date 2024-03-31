namespace CapaPresentacion.Vendedor
{
    partial class MenuVendedor
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
            PanelTitle = new Panel();
            LEmpLog = new Label();
            panel1 = new Panel();
            BMaximate = new FontAwesome.Sharp.IconButton();
            BMinimize = new FontAwesome.Sharp.IconButton();
            BCerrarForm = new FontAwesome.Sharp.IconButton();
            LTitle = new Label();
            PanelMenuVendedor = new Panel();
            BCerrarSesion = new FontAwesome.Sharp.IconButton();
            BVerPerfil = new FontAwesome.Sharp.IconButton();
            BVerVentas = new FontAwesome.Sharp.IconButton();
            BClientes = new FontAwesome.Sharp.IconButton();
            BProductos = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            LOpticaMaribel = new Label();
            PaneContainer = new Panel();
            pictureBox1 = new PictureBox();
            PanelTitle.SuspendLayout();
            panel1.SuspendLayout();
            PanelMenuVendedor.SuspendLayout();
            PanelLogo.SuspendLayout();
            PaneContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = Color.FromArgb(119, 0, 207);
            PanelTitle.BorderStyle = BorderStyle.FixedSingle;
            PanelTitle.Controls.Add(LEmpLog);
            PanelTitle.Controls.Add(panel1);
            PanelTitle.Controls.Add(BCerrarForm);
            PanelTitle.Controls.Add(LTitle);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(220, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(580, 75);
            PanelTitle.TabIndex = 4;
            // 
            // LEmpLog
            // 
            LEmpLog.Anchor = AnchorStyles.None;
            LEmpLog.AutoSize = true;
            LEmpLog.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LEmpLog.ForeColor = Color.White;
            LEmpLog.Location = new Point(362, 13);
            LEmpLog.Name = "LEmpLog";
            LEmpLog.Size = new Size(0, 17);
            LEmpLog.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(BMaximate);
            panel1.Controls.Add(BMinimize);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(518, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 73);
            panel1.TabIndex = 6;
            // 
            // BMaximate
            // 
            BMaximate.Anchor = AnchorStyles.None;
            BMaximate.FlatAppearance.BorderSize = 0;
            BMaximate.FlatStyle = FlatStyle.Flat;
            BMaximate.IconChar = FontAwesome.Sharp.IconChar.Square;
            BMaximate.IconColor = Color.White;
            BMaximate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BMaximate.IconSize = 25;
            BMaximate.Location = new Point(31, 0);
            BMaximate.Margin = new Padding(0);
            BMaximate.Name = "BMaximate";
            BMaximate.Size = new Size(30, 30);
            BMaximate.TabIndex = 4;
            BMaximate.UseVisualStyleBackColor = true;
            BMaximate.Click += BMaximate_Click;
            // 
            // BMinimize
            // 
            BMinimize.Anchor = AnchorStyles.None;
            BMinimize.FlatAppearance.BorderSize = 0;
            BMinimize.FlatStyle = FlatStyle.Flat;
            BMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            BMinimize.IconColor = Color.White;
            BMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BMinimize.IconSize = 25;
            BMinimize.Location = new Point(1, 0);
            BMinimize.Margin = new Padding(0);
            BMinimize.Name = "BMinimize";
            BMinimize.Size = new Size(30, 30);
            BMinimize.TabIndex = 5;
            BMinimize.UseVisualStyleBackColor = true;
            BMinimize.Click += BMinimize_Click;
            // 
            // BCerrarForm
            // 
            BCerrarForm.Dock = DockStyle.Left;
            BCerrarForm.FlatAppearance.BorderSize = 0;
            BCerrarForm.FlatStyle = FlatStyle.Flat;
            BCerrarForm.IconChar = FontAwesome.Sharp.IconChar.X;
            BCerrarForm.IconColor = Color.White;
            BCerrarForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BCerrarForm.IconSize = 30;
            BCerrarForm.Location = new Point(0, 0);
            BCerrarForm.Name = "BCerrarForm";
            BCerrarForm.Size = new Size(75, 73);
            BCerrarForm.TabIndex = 1;
            BCerrarForm.UseVisualStyleBackColor = true;
            BCerrarForm.Click += BCerrarForm_Click;
            // 
            // LTitle
            // 
            LTitle.Anchor = AnchorStyles.None;
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LTitle.ForeColor = Color.White;
            LTitle.Location = new Point(183, 21);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(72, 25);
            LTitle.TabIndex = 0;
            LTitle.Text = "HOME";
            LTitle.Click += LTitle_Click;
            // 
            // PanelMenuVendedor
            // 
            PanelMenuVendedor.BackColor = Color.Indigo;
            PanelMenuVendedor.Controls.Add(BCerrarSesion);
            PanelMenuVendedor.Controls.Add(BVerPerfil);
            PanelMenuVendedor.Controls.Add(BVerVentas);
            PanelMenuVendedor.Controls.Add(BClientes);
            PanelMenuVendedor.Controls.Add(BProductos);
            PanelMenuVendedor.Controls.Add(PanelLogo);
            PanelMenuVendedor.Dock = DockStyle.Left;
            PanelMenuVendedor.Location = new Point(0, 0);
            PanelMenuVendedor.Name = "PanelMenuVendedor";
            PanelMenuVendedor.Size = new Size(220, 450);
            PanelMenuVendedor.TabIndex = 3;
            // 
            // BCerrarSesion
            // 
            BCerrarSesion.Dock = DockStyle.Top;
            BCerrarSesion.FlatAppearance.BorderSize = 0;
            BCerrarSesion.FlatStyle = FlatStyle.Flat;
            BCerrarSesion.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BCerrarSesion.ForeColor = Color.White;
            BCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.X;
            BCerrarSesion.IconColor = Color.White;
            BCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BCerrarSesion.IconSize = 40;
            BCerrarSesion.Location = new Point(0, 315);
            BCerrarSesion.Name = "BCerrarSesion";
            BCerrarSesion.Size = new Size(220, 60);
            BCerrarSesion.TabIndex = 5;
            BCerrarSesion.Text = "Cerrar Sesion";
            BCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCerrarSesion.UseVisualStyleBackColor = true;
            BCerrarSesion.Click += BCerrarSesion_Click_1;
            // 
            // BVerPerfil
            // 
            BVerPerfil.Dock = DockStyle.Top;
            BVerPerfil.FlatAppearance.BorderSize = 0;
            BVerPerfil.FlatStyle = FlatStyle.Flat;
            BVerPerfil.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BVerPerfil.ForeColor = Color.White;
            BVerPerfil.IconChar = FontAwesome.Sharp.IconChar.Person;
            BVerPerfil.IconColor = Color.White;
            BVerPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BVerPerfil.IconSize = 40;
            BVerPerfil.Location = new Point(0, 255);
            BVerPerfil.Name = "BVerPerfil";
            BVerPerfil.Size = new Size(220, 60);
            BVerPerfil.TabIndex = 4;
            BVerPerfil.Text = "Ver Perfil";
            BVerPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            BVerPerfil.UseVisualStyleBackColor = true;
            BVerPerfil.Click += BVerPerfil_Click;
            // 
            // BVerVentas
            // 
            BVerVentas.Dock = DockStyle.Top;
            BVerVentas.FlatAppearance.BorderSize = 0;
            BVerVentas.FlatStyle = FlatStyle.Flat;
            BVerVentas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BVerVentas.ForeColor = Color.White;
            BVerVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            BVerVentas.IconColor = Color.White;
            BVerVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BVerVentas.IconSize = 40;
            BVerVentas.Location = new Point(0, 195);
            BVerVentas.Name = "BVerVentas";
            BVerVentas.Size = new Size(220, 60);
            BVerVentas.TabIndex = 3;
            BVerVentas.Text = "Ver Ventas";
            BVerVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            BVerVentas.UseVisualStyleBackColor = true;
            BVerVentas.Click += BVerVentas_Click;
            // 
            // BClientes
            // 
            BClientes.Dock = DockStyle.Top;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BClientes.ForeColor = Color.White;
            BClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BClientes.IconColor = Color.White;
            BClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BClientes.IconSize = 40;
            BClientes.Location = new Point(0, 135);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(220, 60);
            BClientes.TabIndex = 2;
            BClientes.Text = "Gestor Clientes";
            BClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BClientes.UseVisualStyleBackColor = true;
            BClientes.Click += BClientes_Click;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.Indigo;
            BProductos.Dock = DockStyle.Top;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BProductos.ForeColor = Color.White;
            BProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            BProductos.IconColor = Color.White;
            BProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BProductos.IconSize = 40;
            BProductos.Location = new Point(0, 75);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(220, 60);
            BProductos.TabIndex = 1;
            BProductos.Text = "Gestor Productos";
            BProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BProductos.UseVisualStyleBackColor = false;
            BProductos.Click += BProductos_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = Color.DarkViolet;
            PanelLogo.Controls.Add(LOpticaMaribel);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(220, 75);
            PanelLogo.TabIndex = 0;
            // 
            // LOpticaMaribel
            // 
            LOpticaMaribel.Anchor = AnchorStyles.None;
            LOpticaMaribel.AutoSize = true;
            LOpticaMaribel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LOpticaMaribel.ForeColor = Color.White;
            LOpticaMaribel.Location = new Point(50, 26);
            LOpticaMaribel.Name = "LOpticaMaribel";
            LOpticaMaribel.Size = new Size(125, 22);
            LOpticaMaribel.TabIndex = 0;
            LOpticaMaribel.Text = "Optica Maribel";
            // 
            // PaneContainer
            // 
            PaneContainer.BackColor = Color.White;
            PaneContainer.Controls.Add(pictureBox1);
            PaneContainer.Dock = DockStyle.Fill;
            PaneContainer.Location = new Point(220, 75);
            PaneContainer.Name = "PaneContainer";
            PaneContainer.Size = new Size(580, 375);
            PaneContainer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.optica_maribel;
            pictureBox1.Location = new Point(184, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MenuVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PaneContainer);
            Controls.Add(PanelTitle);
            Controls.Add(PanelMenuVendedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuVendedor";
            Text = "MenuVendedor";
            Load += MenuVendedor_Load;
            PanelTitle.ResumeLayout(false);
            PanelTitle.PerformLayout();
            panel1.ResumeLayout(false);
            PanelMenuVendedor.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            PaneContainer.ResumeLayout(false);
            PaneContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTitle;
        private FontAwesome.Sharp.IconButton BCerrarForm;
        private Label LTitle;
        private Panel PanelMenuVendedor;
        private FontAwesome.Sharp.IconButton BVerVentas;
        private FontAwesome.Sharp.IconButton BClientes;
        private FontAwesome.Sharp.IconButton BProductos;
        private Panel PanelLogo;
        private Label LOpticaMaribel;
        private Panel PaneContainer;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BMinimize;
        private FontAwesome.Sharp.IconButton BMaximate;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BCerrarSesion;
        private FontAwesome.Sharp.IconButton BVerPerfil;
        private Label LEmpLog;
    }
}
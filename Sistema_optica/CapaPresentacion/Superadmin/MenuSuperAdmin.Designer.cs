namespace CapaPresentacion.Superadmin
{
    partial class MenuSuperAdmin
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
            pictureBox1 = new PictureBox();
            LOpticaMaribel = new Label();
            PaneContainer = new Panel();
            PanelMenuVendedor = new Panel();
            BCerrarSesion = new FontAwesome.Sharp.IconButton();
            BVerPerfil = new FontAwesome.Sharp.IconButton();
            BVerVentas = new FontAwesome.Sharp.IconButton();
            BEmpleados = new FontAwesome.Sharp.IconButton();
            BProductos = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            LTitle = new Label();
            BMaximate = new FontAwesome.Sharp.IconButton();
            BMinimize = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            PanelTitle = new Panel();
            LEmpLog = new Label();
            BCerrarForm = new FontAwesome.Sharp.IconButton();
            BackupBD = new FontAwesome.Sharp.IconButton();
            RestoreBD = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PaneContainer.SuspendLayout();
            PanelMenuVendedor.SuspendLayout();
            PanelLogo.SuspendLayout();
            panel1.SuspendLayout();
            PanelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.optica_maribel;
            pictureBox1.Location = new Point(183, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LOpticaMaribel
            // 
            LOpticaMaribel.Anchor = AnchorStyles.None;
            LOpticaMaribel.AutoSize = true;
            LOpticaMaribel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LOpticaMaribel.ForeColor = Color.White;
            LOpticaMaribel.Location = new Point(42, 24);
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
            PaneContainer.TabIndex = 8;
            // 
            // PanelMenuVendedor
            // 
            PanelMenuVendedor.BackColor = Color.Indigo;
            PanelMenuVendedor.Controls.Add(RestoreBD);
            PanelMenuVendedor.Controls.Add(BackupBD);
            PanelMenuVendedor.Controls.Add(BCerrarSesion);
            PanelMenuVendedor.Controls.Add(BVerPerfil);
            PanelMenuVendedor.Controls.Add(BVerVentas);
            PanelMenuVendedor.Controls.Add(BEmpleados);
            PanelMenuVendedor.Controls.Add(BProductos);
            PanelMenuVendedor.Controls.Add(PanelLogo);
            PanelMenuVendedor.Dock = DockStyle.Left;
            PanelMenuVendedor.Location = new Point(0, 0);
            PanelMenuVendedor.Name = "PanelMenuVendedor";
            PanelMenuVendedor.Size = new Size(220, 450);
            PanelMenuVendedor.TabIndex = 6;
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
            BCerrarSesion.Click += BCerrarSesion_Click;
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
            // BEmpleados
            // 
            BEmpleados.Dock = DockStyle.Top;
            BEmpleados.FlatAppearance.BorderSize = 0;
            BEmpleados.FlatStyle = FlatStyle.Flat;
            BEmpleados.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BEmpleados.ForeColor = Color.White;
            BEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BEmpleados.IconColor = Color.White;
            BEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEmpleados.IconSize = 40;
            BEmpleados.Location = new Point(0, 135);
            BEmpleados.Name = "BEmpleados";
            BEmpleados.Size = new Size(220, 60);
            BEmpleados.TabIndex = 2;
            BEmpleados.Text = "Gestor Empleados";
            BEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEmpleados.UseVisualStyleBackColor = true;
            BEmpleados.Click += BEmpleados_Click;
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
            // LTitle
            // 
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LTitle.ForeColor = Color.White;
            LTitle.Location = new Point(182, 21);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(72, 25);
            LTitle.TabIndex = 0;
            LTitle.Text = "HOME";
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
            BMaximate.Size = new Size(30, 34);
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
            BMinimize.Size = new Size(30, 34);
            BMinimize.TabIndex = 5;
            BMinimize.UseVisualStyleBackColor = true;
            BMinimize.Click += BMinimize_Click;
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
            PanelTitle.TabIndex = 7;
            // 
            // LEmpLog
            // 
            LEmpLog.Anchor = AnchorStyles.None;
            LEmpLog.AutoSize = true;
            LEmpLog.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LEmpLog.ForeColor = Color.White;
            LEmpLog.Location = new Point(327, 8);
            LEmpLog.Name = "LEmpLog";
            LEmpLog.Size = new Size(0, 17);
            LEmpLog.TabIndex = 7;
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
            // BackupBD
            // 
            BackupBD.Dock = DockStyle.Top;
            BackupBD.FlatAppearance.BorderSize = 0;
            BackupBD.FlatStyle = FlatStyle.Flat;
            BackupBD.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BackupBD.ForeColor = Color.White;
            BackupBD.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            BackupBD.IconColor = Color.White;
            BackupBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackupBD.IconSize = 40;
            BackupBD.Location = new Point(0, 375);
            BackupBD.Name = "BackupBD";
            BackupBD.Size = new Size(220, 60);
            BackupBD.TabIndex = 6;
            BackupBD.Text = "Backup BD";
            BackupBD.TextImageRelation = TextImageRelation.ImageBeforeText;
            BackupBD.UseVisualStyleBackColor = true;
            BackupBD.Click += BackupBD_Click;
            // 
            // RestoreBD
            // 
            RestoreBD.Dock = DockStyle.Top;
            RestoreBD.FlatAppearance.BorderSize = 0;
            RestoreBD.FlatStyle = FlatStyle.Flat;
            RestoreBD.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RestoreBD.ForeColor = Color.White;
            RestoreBD.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            RestoreBD.IconColor = Color.White;
            RestoreBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RestoreBD.IconSize = 40;
            RestoreBD.Location = new Point(0, 435);
            RestoreBD.Name = "RestoreBD";
            RestoreBD.Size = new Size(220, 60);
            RestoreBD.TabIndex = 7;
            RestoreBD.Text = "Restaura BD";
            RestoreBD.TextImageRelation = TextImageRelation.ImageBeforeText;
            RestoreBD.UseVisualStyleBackColor = true;
            RestoreBD.Click += RestoreBD_Click;
            // 
            // MenuSuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PaneContainer);
            Controls.Add(PanelTitle);
            Controls.Add(PanelMenuVendedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuSuperAdmin";
            Text = "MenuSuperAdmin";
            Load += MenuSuperAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PaneContainer.ResumeLayout(false);
            PaneContainer.PerformLayout();
            PanelMenuVendedor.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            panel1.ResumeLayout(false);
            PanelTitle.ResumeLayout(false);
            PanelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LOpticaMaribel;
        private Panel PaneContainer;
        private Panel PanelMenuVendedor;
        private FontAwesome.Sharp.IconButton BCerrarSesion;
        private FontAwesome.Sharp.IconButton BVerPerfil;
        private FontAwesome.Sharp.IconButton BVerVentas;
        private FontAwesome.Sharp.IconButton BEmpleados;
        private FontAwesome.Sharp.IconButton BProductos;
        private Panel PanelLogo;
        private Label LTitle;
        private FontAwesome.Sharp.IconButton BMaximate;
        private FontAwesome.Sharp.IconButton BMinimize;
        private Panel panel1;
        private Panel PanelTitle;
        private Label LEmpLog;
        private FontAwesome.Sharp.IconButton BCerrarForm;
        private FontAwesome.Sharp.IconButton RestoreBD;
        private FontAwesome.Sharp.IconButton BackupBD;
    }
}
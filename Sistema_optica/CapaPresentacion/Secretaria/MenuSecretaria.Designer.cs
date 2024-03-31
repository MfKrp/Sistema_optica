namespace CapaPresentacion.Secretaria
{
    partial class MenuSecretaria
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
            panel1 = new Panel();
            BMinimize = new FontAwesome.Sharp.IconButton();
            BMaximate = new FontAwesome.Sharp.IconButton();
            LEmpLog = new Label();
            BCerrarForm = new FontAwesome.Sharp.IconButton();
            LTitle = new Label();
            PaneContainer = new Panel();
            pictureBox1 = new PictureBox();
            PanelLogo = new Panel();
            LOpticaMaribel = new Label();
            BProductos = new FontAwesome.Sharp.IconButton();
            BClientes = new FontAwesome.Sharp.IconButton();
            BVerPerfil = new FontAwesome.Sharp.IconButton();
            BCerrarSesion = new FontAwesome.Sharp.IconButton();
            PanelMenuSecretaria = new Panel();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            PanelTitle.SuspendLayout();
            panel1.SuspendLayout();
            PaneContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelLogo.SuspendLayout();
            PanelMenuSecretaria.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = Color.FromArgb(119, 0, 207);
            PanelTitle.BorderStyle = BorderStyle.FixedSingle;
            PanelTitle.Controls.Add(panel1);
            PanelTitle.Controls.Add(LEmpLog);
            PanelTitle.Controls.Add(BCerrarForm);
            PanelTitle.Controls.Add(LTitle);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(220, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(580, 75);
            PanelTitle.TabIndex = 1;
            PanelTitle.MouseDown += PanelTitle_MouseDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(BMinimize);
            panel1.Controls.Add(BMaximate);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(518, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 73);
            panel1.TabIndex = 8;
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
            BMinimize.Location = new Point(1, 3);
            BMinimize.Margin = new Padding(0);
            BMinimize.Name = "BMinimize";
            BMinimize.Size = new Size(30, 30);
            BMinimize.TabIndex = 7;
            BMinimize.UseVisualStyleBackColor = true;
            BMinimize.Click += BMinimize_Click;
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
            BMaximate.Location = new Point(31, 3);
            BMaximate.Margin = new Padding(0);
            BMaximate.Name = "BMaximate";
            BMaximate.Size = new Size(30, 30);
            BMaximate.TabIndex = 6;
            BMaximate.UseVisualStyleBackColor = true;
            BMaximate.Click += BMaximate_Click;
            // 
            // LEmpLog
            // 
            LEmpLog.Anchor = AnchorStyles.None;
            LEmpLog.AutoSize = true;
            LEmpLog.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LEmpLog.ForeColor = Color.White;
            LEmpLog.Location = new Point(281, 16);
            LEmpLog.Name = "LEmpLog";
            LEmpLog.Size = new Size(0, 17);
            LEmpLog.TabIndex = 2;
            LEmpLog.Click += LEmpLog_Click;
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
            LTitle.Location = new Point(83, 24);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(72, 25);
            LTitle.TabIndex = 0;
            LTitle.Text = "HOME";
            // 
            // PaneContainer
            // 
            PaneContainer.BackColor = Color.White;
            PaneContainer.Controls.Add(pictureBox1);
            PaneContainer.Dock = DockStyle.Fill;
            PaneContainer.Location = new Point(220, 75);
            PaneContainer.Name = "PaneContainer";
            PaneContainer.Size = new Size(580, 375);
            PaneContainer.TabIndex = 2;
            PaneContainer.Paint += PaneContainer_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.optica_maribel;
            pictureBox1.Location = new Point(185, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            LOpticaMaribel.Location = new Point(43, 29);
            LOpticaMaribel.Name = "LOpticaMaribel";
            LOpticaMaribel.Size = new Size(125, 22);
            LOpticaMaribel.TabIndex = 0;
            LOpticaMaribel.Text = "Optica Maribel";
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
            BVerPerfil.Location = new Point(0, 195);
            BVerPerfil.Name = "BVerPerfil";
            BVerPerfil.Size = new Size(220, 60);
            BVerPerfil.TabIndex = 3;
            BVerPerfil.Text = "Ver Perfil";
            BVerPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            BVerPerfil.UseVisualStyleBackColor = true;
            BVerPerfil.Click += BVerPerfil_Click;
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
            BCerrarSesion.Location = new Point(0, 255);
            BCerrarSesion.Name = "BCerrarSesion";
            BCerrarSesion.Size = new Size(220, 60);
            BCerrarSesion.TabIndex = 4;
            BCerrarSesion.Text = "Cerrar Sesión";
            BCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCerrarSesion.UseVisualStyleBackColor = true;
            BCerrarSesion.Click += BCerrarSesion_Click;
            // 
            // PanelMenuSecretaria
            // 
            PanelMenuSecretaria.BackColor = Color.Indigo;
            PanelMenuSecretaria.Controls.Add(BCerrarSesion);
            PanelMenuSecretaria.Controls.Add(BVerPerfil);
            PanelMenuSecretaria.Controls.Add(BClientes);
            PanelMenuSecretaria.Controls.Add(BProductos);
            PanelMenuSecretaria.Controls.Add(PanelLogo);
            PanelMenuSecretaria.Dock = DockStyle.Left;
            PanelMenuSecretaria.Location = new Point(0, 0);
            PanelMenuSecretaria.Name = "PanelMenuSecretaria";
            PanelMenuSecretaria.Size = new Size(220, 450);
            PanelMenuSecretaria.TabIndex = 0;
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
            // MenuSecretaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PaneContainer);
            Controls.Add(PanelTitle);
            Controls.Add(PanelMenuSecretaria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuSecretaria";
            Text = "MenuSecretaria";
            Load += MenuSecretaria_Load;
            PanelTitle.ResumeLayout(false);
            PanelTitle.PerformLayout();
            panel1.ResumeLayout(false);
            PaneContainer.ResumeLayout(false);
            PaneContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelLogo.ResumeLayout(false);
            PanelLogo.PerformLayout();
            PanelMenuSecretaria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelTitle;
        private Label LTitle;
        private Panel PaneContainer;
        private FontAwesome.Sharp.IconButton BCerrarForm;
        private PictureBox pictureBox1;
        private Label LEmpLog;
        private FontAwesome.Sharp.IconButton BMinimize;
        private FontAwesome.Sharp.IconButton BMaximate;
        private Panel panel1;
        private Panel PanelLogo;
        private Label LOpticaMaribel;
        private FontAwesome.Sharp.IconButton BProductos;
        private FontAwesome.Sharp.IconButton BClientes;
        private FontAwesome.Sharp.IconButton BVerPerfil;
        private FontAwesome.Sharp.IconButton BCerrarSesion;
        private Panel PanelMenuSecretaria;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
    }
}
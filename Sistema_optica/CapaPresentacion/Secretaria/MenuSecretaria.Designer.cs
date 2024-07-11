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
            PanelMenuSecretaria = new Panel();
            BCerrarSesion = new FontAwesome.Sharp.IconButton();
            PGestorClientes = new Panel();
            PIBVerClientes = new FontAwesome.Sharp.IconButton();
            PIBModifClientes = new FontAwesome.Sharp.IconButton();
            PanelGestorProductos = new Panel();
            PSPObrasSociales = new Panel();
            SPIBVerObrasSociales = new FontAwesome.Sharp.IconButton();
            SPIBModificarObraSocial = new FontAwesome.Sharp.IconButton();
            SPIBAgregarObraSocial = new FontAwesome.Sharp.IconButton();
            PICBObrasSociales = new FontAwesome.Sharp.IconButton();
            PSPCristales = new Panel();
            SPIBVerCristales = new FontAwesome.Sharp.IconButton();
            SPIBModificarCristal = new FontAwesome.Sharp.IconButton();
            SPIBAgregarCristal = new FontAwesome.Sharp.IconButton();
            PICBCristales = new FontAwesome.Sharp.IconButton();
            PSPEstilos = new Panel();
            SPIBVerEstilos = new FontAwesome.Sharp.IconButton();
            SPIBModificarEstilo = new FontAwesome.Sharp.IconButton();
            SPIBAgregarEstilos = new FontAwesome.Sharp.IconButton();
            PIBEstilosAnteojos = new FontAwesome.Sharp.IconButton();
            PSPFormas = new Panel();
            SPIBVerFormas = new FontAwesome.Sharp.IconButton();
            SPIBModificarForma = new FontAwesome.Sharp.IconButton();
            SPIBAgregarForma = new FontAwesome.Sharp.IconButton();
            PIBFormasAnteojos = new FontAwesome.Sharp.IconButton();
            PSPMarcas = new Panel();
            SPIBVerMarcas = new FontAwesome.Sharp.IconButton();
            SPIBModificarMarca = new FontAwesome.Sharp.IconButton();
            SPIBAgregarMarca = new FontAwesome.Sharp.IconButton();
            PIBMarcasAnteojos = new FontAwesome.Sharp.IconButton();
            PSPAnteojos = new Panel();
            SPIBVerAnteojos = new FontAwesome.Sharp.IconButton();
            SPIBModificarAnteojo = new FontAwesome.Sharp.IconButton();
            SPIBAltaTerapeutico = new FontAwesome.Sharp.IconButton();
            SPIBAltaAccesorio = new FontAwesome.Sharp.IconButton();
            PIBAnteojos = new FontAwesome.Sharp.IconButton();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            PanelTitle.SuspendLayout();
            panel1.SuspendLayout();
            PaneContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelLogo.SuspendLayout();
            PanelMenuSecretaria.SuspendLayout();
            PGestorClientes.SuspendLayout();
            PanelGestorProductos.SuspendLayout();
            PSPObrasSociales.SuspendLayout();
            PSPCristales.SuspendLayout();
            PSPEstilos.SuspendLayout();
            PSPFormas.SuspendLayout();
            PSPMarcas.SuspendLayout();
            PSPAnteojos.SuspendLayout();
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
            LEmpLog.Location = new Point(171, 16);
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
            LTitle.Location = new Point(-27, 24);
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
            PaneContainer.Size = new Size(580, 539);
            PaneContainer.TabIndex = 2;
            PaneContainer.Paint += PaneContainer_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.optica_maribel;
            pictureBox1.Location = new Point(172, 142);
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
            PanelLogo.Size = new Size(203, 75);
            PanelLogo.TabIndex = 0;
            // 
            // LOpticaMaribel
            // 
            LOpticaMaribel.Anchor = AnchorStyles.None;
            LOpticaMaribel.AutoSize = true;
            LOpticaMaribel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LOpticaMaribel.ForeColor = Color.White;
            LOpticaMaribel.Location = new Point(34, 29);
            LOpticaMaribel.Name = "LOpticaMaribel";
            LOpticaMaribel.Size = new Size(125, 22);
            LOpticaMaribel.TabIndex = 0;
            LOpticaMaribel.Text = "Optica Maribel";
            // 
            // BProductos
            // 
            BProductos.AllowDrop = true;
            BProductos.BackColor = Color.Indigo;
            BProductos.Dock = DockStyle.Top;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BProductos.ForeColor = Color.White;
            BProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            BProductos.IconColor = Color.White;
            BProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BProductos.IconSize = 40;
            BProductos.Location = new Point(0, 75);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(203, 60);
            BProductos.TabIndex = 1;
            BProductos.Text = "Gestor Productos";
            BProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BProductos.UseVisualStyleBackColor = false;
            BProductos.ContextMenuStripChanged += BProductos_ContextMenuStripChanged;
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
            BClientes.Location = new Point(0, 1376);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(203, 60);
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
            BVerPerfil.Location = new Point(0, 1535);
            BVerPerfil.Name = "BVerPerfil";
            BVerPerfil.Size = new Size(203, 60);
            BVerPerfil.TabIndex = 3;
            BVerPerfil.Text = "Ver Perfil";
            BVerPerfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            BVerPerfil.UseVisualStyleBackColor = true;
            BVerPerfil.Click += BVerPerfil_Click;
            // 
            // PanelMenuSecretaria
            // 
            PanelMenuSecretaria.AutoScroll = true;
            PanelMenuSecretaria.BackColor = Color.Indigo;
            PanelMenuSecretaria.Controls.Add(BCerrarSesion);
            PanelMenuSecretaria.Controls.Add(BVerPerfil);
            PanelMenuSecretaria.Controls.Add(PGestorClientes);
            PanelMenuSecretaria.Controls.Add(BClientes);
            PanelMenuSecretaria.Controls.Add(PanelGestorProductos);
            PanelMenuSecretaria.Controls.Add(BProductos);
            PanelMenuSecretaria.Controls.Add(PanelLogo);
            PanelMenuSecretaria.Dock = DockStyle.Left;
            PanelMenuSecretaria.Location = new Point(0, 0);
            PanelMenuSecretaria.Name = "PanelMenuSecretaria";
            PanelMenuSecretaria.Size = new Size(220, 614);
            PanelMenuSecretaria.TabIndex = 0;
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
            BCerrarSesion.Location = new Point(0, 1595);
            BCerrarSesion.Name = "BCerrarSesion";
            BCerrarSesion.Size = new Size(203, 60);
            BCerrarSesion.TabIndex = 4;
            BCerrarSesion.Text = "Cerrar Sesión";
            BCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCerrarSesion.UseVisualStyleBackColor = true;
            BCerrarSesion.Click += BCerrarSesion_Click;
            // 
            // PGestorClientes
            // 
            PGestorClientes.Controls.Add(PIBVerClientes);
            PGestorClientes.Controls.Add(PIBModifClientes);
            PGestorClientes.Dock = DockStyle.Top;
            PGestorClientes.Location = new Point(0, 1436);
            PGestorClientes.Name = "PGestorClientes";
            PGestorClientes.Size = new Size(203, 99);
            PGestorClientes.TabIndex = 6;
            PGestorClientes.Paint += PGestorClientes_Paint;
            // 
            // PIBVerClientes
            // 
            PIBVerClientes.AllowDrop = true;
            PIBVerClientes.BackColor = Color.FromArgb(30, 0, 50);
            PIBVerClientes.Dock = DockStyle.Top;
            PIBVerClientes.FlatAppearance.BorderSize = 0;
            PIBVerClientes.FlatStyle = FlatStyle.Flat;
            PIBVerClientes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PIBVerClientes.ForeColor = Color.White;
            PIBVerClientes.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            PIBVerClientes.IconColor = Color.White;
            PIBVerClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PIBVerClientes.IconSize = 25;
            PIBVerClientes.Location = new Point(0, 48);
            PIBVerClientes.Name = "PIBVerClientes";
            PIBVerClientes.Size = new Size(203, 48);
            PIBVerClientes.TabIndex = 11;
            PIBVerClientes.Text = "Ver Clientes";
            PIBVerClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            PIBVerClientes.UseVisualStyleBackColor = false;
            PIBVerClientes.Click += PIBVerClientes_Click;
            // 
            // PIBModifClientes
            // 
            PIBModifClientes.AllowDrop = true;
            PIBModifClientes.BackColor = Color.FromArgb(30, 0, 50);
            PIBModifClientes.Dock = DockStyle.Top;
            PIBModifClientes.FlatAppearance.BorderSize = 0;
            PIBModifClientes.FlatStyle = FlatStyle.Flat;
            PIBModifClientes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PIBModifClientes.ForeColor = Color.White;
            PIBModifClientes.IconChar = FontAwesome.Sharp.IconChar.Brush;
            PIBModifClientes.IconColor = Color.White;
            PIBModifClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PIBModifClientes.IconSize = 25;
            PIBModifClientes.Location = new Point(0, 0);
            PIBModifClientes.Name = "PIBModifClientes";
            PIBModifClientes.Size = new Size(203, 48);
            PIBModifClientes.TabIndex = 12;
            PIBModifClientes.Text = "Modificar Clientes";
            PIBModifClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            PIBModifClientes.UseVisualStyleBackColor = false;
            PIBModifClientes.Click += PIBModifClientes_Click;
            // 
            // PanelGestorProductos
            // 
            PanelGestorProductos.Controls.Add(PSPObrasSociales);
            PanelGestorProductos.Controls.Add(PICBObrasSociales);
            PanelGestorProductos.Controls.Add(PSPCristales);
            PanelGestorProductos.Controls.Add(PICBCristales);
            PanelGestorProductos.Controls.Add(PSPEstilos);
            PanelGestorProductos.Controls.Add(PIBEstilosAnteojos);
            PanelGestorProductos.Controls.Add(PSPFormas);
            PanelGestorProductos.Controls.Add(PIBFormasAnteojos);
            PanelGestorProductos.Controls.Add(PSPMarcas);
            PanelGestorProductos.Controls.Add(PIBMarcasAnteojos);
            PanelGestorProductos.Controls.Add(PSPAnteojos);
            PanelGestorProductos.Controls.Add(PIBAnteojos);
            PanelGestorProductos.Dock = DockStyle.Top;
            PanelGestorProductos.Location = new Point(0, 135);
            PanelGestorProductos.Name = "PanelGestorProductos";
            PanelGestorProductos.Size = new Size(203, 1241);
            PanelGestorProductos.TabIndex = 5;
            PanelGestorProductos.Paint += PanelGestorProductos_Paint;
            // 
            // PSPObrasSociales
            // 
            PSPObrasSociales.Controls.Add(SPIBVerObrasSociales);
            PSPObrasSociales.Controls.Add(SPIBModificarObraSocial);
            PSPObrasSociales.Controls.Add(SPIBAgregarObraSocial);
            PSPObrasSociales.Dock = DockStyle.Top;
            PSPObrasSociales.Location = new Point(0, 1084);
            PSPObrasSociales.Name = "PSPObrasSociales";
            PSPObrasSociales.Size = new Size(203, 150);
            PSPObrasSociales.TabIndex = 20;
            // 
            // SPIBVerObrasSociales
            // 
            SPIBVerObrasSociales.AllowDrop = true;
            SPIBVerObrasSociales.BackColor = Color.FromArgb(90, 0, 200);
            SPIBVerObrasSociales.Dock = DockStyle.Top;
            SPIBVerObrasSociales.FlatAppearance.BorderSize = 0;
            SPIBVerObrasSociales.FlatStyle = FlatStyle.Flat;
            SPIBVerObrasSociales.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBVerObrasSociales.ForeColor = Color.White;
            SPIBVerObrasSociales.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SPIBVerObrasSociales.IconColor = Color.White;
            SPIBVerObrasSociales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBVerObrasSociales.IconSize = 25;
            SPIBVerObrasSociales.Location = new Point(0, 96);
            SPIBVerObrasSociales.Name = "SPIBVerObrasSociales";
            SPIBVerObrasSociales.Size = new Size(203, 48);
            SPIBVerObrasSociales.TabIndex = 13;
            SPIBVerObrasSociales.Text = "Ver Obras Sociales";
            SPIBVerObrasSociales.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBVerObrasSociales.UseVisualStyleBackColor = false;
            SPIBVerObrasSociales.Click += SPIBVerObrasSociales_Click;
            // 
            // SPIBModificarObraSocial
            // 
            SPIBModificarObraSocial.AllowDrop = true;
            SPIBModificarObraSocial.BackColor = Color.FromArgb(90, 0, 200);
            SPIBModificarObraSocial.Dock = DockStyle.Top;
            SPIBModificarObraSocial.FlatAppearance.BorderSize = 0;
            SPIBModificarObraSocial.FlatStyle = FlatStyle.Flat;
            SPIBModificarObraSocial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBModificarObraSocial.ForeColor = Color.White;
            SPIBModificarObraSocial.IconChar = FontAwesome.Sharp.IconChar.Brush;
            SPIBModificarObraSocial.IconColor = Color.White;
            SPIBModificarObraSocial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBModificarObraSocial.IconSize = 25;
            SPIBModificarObraSocial.Location = new Point(0, 48);
            SPIBModificarObraSocial.Name = "SPIBModificarObraSocial";
            SPIBModificarObraSocial.Size = new Size(203, 48);
            SPIBModificarObraSocial.TabIndex = 11;
            SPIBModificarObraSocial.Text = "Modificar Obra Social";
            SPIBModificarObraSocial.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBModificarObraSocial.UseVisualStyleBackColor = false;
            SPIBModificarObraSocial.Click += SPIBModificarObraSocial_Click;
            // 
            // SPIBAgregarObraSocial
            // 
            SPIBAgregarObraSocial.AllowDrop = true;
            SPIBAgregarObraSocial.BackColor = Color.FromArgb(90, 0, 200);
            SPIBAgregarObraSocial.Dock = DockStyle.Top;
            SPIBAgregarObraSocial.FlatAppearance.BorderSize = 0;
            SPIBAgregarObraSocial.FlatStyle = FlatStyle.Flat;
            SPIBAgregarObraSocial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBAgregarObraSocial.ForeColor = Color.White;
            SPIBAgregarObraSocial.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            SPIBAgregarObraSocial.IconColor = Color.White;
            SPIBAgregarObraSocial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBAgregarObraSocial.IconSize = 25;
            SPIBAgregarObraSocial.Location = new Point(0, 0);
            SPIBAgregarObraSocial.Name = "SPIBAgregarObraSocial";
            SPIBAgregarObraSocial.Size = new Size(203, 48);
            SPIBAgregarObraSocial.TabIndex = 12;
            SPIBAgregarObraSocial.Text = "Agregar Obra Social";
            SPIBAgregarObraSocial.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBAgregarObraSocial.UseVisualStyleBackColor = false;
            SPIBAgregarObraSocial.Click += SPIBAgregarObraSocial_Click;
            // 
            // PICBObrasSociales
            // 
            PICBObrasSociales.AllowDrop = true;
            PICBObrasSociales.BackColor = Color.FromArgb(30, 0, 50);
            PICBObrasSociales.Dock = DockStyle.Top;
            PICBObrasSociales.FlatAppearance.BorderSize = 0;
            PICBObrasSociales.FlatStyle = FlatStyle.Flat;
            PICBObrasSociales.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICBObrasSociales.ForeColor = Color.White;
            PICBObrasSociales.IconChar = FontAwesome.Sharp.IconChar.PeoplePulling;
            PICBObrasSociales.IconColor = Color.White;
            PICBObrasSociales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PICBObrasSociales.IconSize = 25;
            PICBObrasSociales.Location = new Point(0, 1036);
            PICBObrasSociales.Name = "PICBObrasSociales";
            PICBObrasSociales.Size = new Size(203, 48);
            PICBObrasSociales.TabIndex = 19;
            PICBObrasSociales.Text = "Obras Sociales";
            PICBObrasSociales.TextImageRelation = TextImageRelation.ImageBeforeText;
            PICBObrasSociales.UseVisualStyleBackColor = false;
            PICBObrasSociales.Click += PICBObrasSociales_Click;
            // 
            // PSPCristales
            // 
            PSPCristales.Controls.Add(SPIBVerCristales);
            PSPCristales.Controls.Add(SPIBModificarCristal);
            PSPCristales.Controls.Add(SPIBAgregarCristal);
            PSPCristales.Dock = DockStyle.Top;
            PSPCristales.Location = new Point(0, 886);
            PSPCristales.Name = "PSPCristales";
            PSPCristales.Size = new Size(203, 150);
            PSPCristales.TabIndex = 18;
            // 
            // SPIBVerCristales
            // 
            SPIBVerCristales.AllowDrop = true;
            SPIBVerCristales.BackColor = Color.FromArgb(90, 0, 200);
            SPIBVerCristales.Dock = DockStyle.Top;
            SPIBVerCristales.FlatAppearance.BorderSize = 0;
            SPIBVerCristales.FlatStyle = FlatStyle.Flat;
            SPIBVerCristales.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBVerCristales.ForeColor = Color.White;
            SPIBVerCristales.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SPIBVerCristales.IconColor = Color.White;
            SPIBVerCristales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBVerCristales.IconSize = 25;
            SPIBVerCristales.Location = new Point(0, 96);
            SPIBVerCristales.Name = "SPIBVerCristales";
            SPIBVerCristales.Size = new Size(203, 48);
            SPIBVerCristales.TabIndex = 13;
            SPIBVerCristales.Text = "Ver Cristales";
            SPIBVerCristales.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBVerCristales.UseVisualStyleBackColor = false;
            SPIBVerCristales.Click += SPIBVerCristales_Click;
            // 
            // SPIBModificarCristal
            // 
            SPIBModificarCristal.AllowDrop = true;
            SPIBModificarCristal.BackColor = Color.FromArgb(90, 0, 200);
            SPIBModificarCristal.Dock = DockStyle.Top;
            SPIBModificarCristal.FlatAppearance.BorderSize = 0;
            SPIBModificarCristal.FlatStyle = FlatStyle.Flat;
            SPIBModificarCristal.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBModificarCristal.ForeColor = Color.White;
            SPIBModificarCristal.IconChar = FontAwesome.Sharp.IconChar.Brush;
            SPIBModificarCristal.IconColor = Color.White;
            SPIBModificarCristal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBModificarCristal.IconSize = 25;
            SPIBModificarCristal.Location = new Point(0, 48);
            SPIBModificarCristal.Name = "SPIBModificarCristal";
            SPIBModificarCristal.Size = new Size(203, 48);
            SPIBModificarCristal.TabIndex = 11;
            SPIBModificarCristal.Text = "Modificar Cristal";
            SPIBModificarCristal.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBModificarCristal.UseVisualStyleBackColor = false;
            SPIBModificarCristal.Click += SPIBModificarCristal_Click;
            // 
            // SPIBAgregarCristal
            // 
            SPIBAgregarCristal.AllowDrop = true;
            SPIBAgregarCristal.BackColor = Color.FromArgb(90, 0, 200);
            SPIBAgregarCristal.Dock = DockStyle.Top;
            SPIBAgregarCristal.FlatAppearance.BorderSize = 0;
            SPIBAgregarCristal.FlatStyle = FlatStyle.Flat;
            SPIBAgregarCristal.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBAgregarCristal.ForeColor = Color.White;
            SPIBAgregarCristal.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            SPIBAgregarCristal.IconColor = Color.White;
            SPIBAgregarCristal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBAgregarCristal.IconSize = 25;
            SPIBAgregarCristal.Location = new Point(0, 0);
            SPIBAgregarCristal.Name = "SPIBAgregarCristal";
            SPIBAgregarCristal.Size = new Size(203, 48);
            SPIBAgregarCristal.TabIndex = 12;
            SPIBAgregarCristal.Text = "Agregar Cristal";
            SPIBAgregarCristal.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBAgregarCristal.UseVisualStyleBackColor = false;
            SPIBAgregarCristal.Click += SPIBAgregarCristal_Click;
            // 
            // PICBCristales
            // 
            PICBCristales.AllowDrop = true;
            PICBCristales.BackColor = Color.FromArgb(30, 0, 50);
            PICBCristales.Dock = DockStyle.Top;
            PICBCristales.FlatAppearance.BorderSize = 0;
            PICBCristales.FlatStyle = FlatStyle.Flat;
            PICBCristales.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICBCristales.ForeColor = Color.White;
            PICBCristales.IconChar = FontAwesome.Sharp.IconChar.Gem;
            PICBCristales.IconColor = Color.White;
            PICBCristales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PICBCristales.IconSize = 25;
            PICBCristales.Location = new Point(0, 838);
            PICBCristales.Name = "PICBCristales";
            PICBCristales.Size = new Size(203, 48);
            PICBCristales.TabIndex = 17;
            PICBCristales.Text = "Cristales";
            PICBCristales.TextImageRelation = TextImageRelation.ImageBeforeText;
            PICBCristales.UseVisualStyleBackColor = false;
            PICBCristales.Click += PICBCristales_Click;
            // 
            // PSPEstilos
            // 
            PSPEstilos.Controls.Add(SPIBVerEstilos);
            PSPEstilos.Controls.Add(SPIBModificarEstilo);
            PSPEstilos.Controls.Add(SPIBAgregarEstilos);
            PSPEstilos.Dock = DockStyle.Top;
            PSPEstilos.Location = new Point(0, 688);
            PSPEstilos.Name = "PSPEstilos";
            PSPEstilos.Size = new Size(203, 150);
            PSPEstilos.TabIndex = 13;
            // 
            // SPIBVerEstilos
            // 
            SPIBVerEstilos.AllowDrop = true;
            SPIBVerEstilos.BackColor = Color.FromArgb(90, 0, 200);
            SPIBVerEstilos.Dock = DockStyle.Top;
            SPIBVerEstilos.FlatAppearance.BorderSize = 0;
            SPIBVerEstilos.FlatStyle = FlatStyle.Flat;
            SPIBVerEstilos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBVerEstilos.ForeColor = Color.White;
            SPIBVerEstilos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SPIBVerEstilos.IconColor = Color.White;
            SPIBVerEstilos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBVerEstilos.IconSize = 25;
            SPIBVerEstilos.Location = new Point(0, 96);
            SPIBVerEstilos.Name = "SPIBVerEstilos";
            SPIBVerEstilos.Size = new Size(203, 48);
            SPIBVerEstilos.TabIndex = 13;
            SPIBVerEstilos.Text = "Ver Estilos";
            SPIBVerEstilos.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBVerEstilos.UseVisualStyleBackColor = false;
            SPIBVerEstilos.Click += SPIBVerEstilos_Click;
            // 
            // SPIBModificarEstilo
            // 
            SPIBModificarEstilo.AllowDrop = true;
            SPIBModificarEstilo.BackColor = Color.FromArgb(90, 0, 200);
            SPIBModificarEstilo.Dock = DockStyle.Top;
            SPIBModificarEstilo.FlatAppearance.BorderSize = 0;
            SPIBModificarEstilo.FlatStyle = FlatStyle.Flat;
            SPIBModificarEstilo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBModificarEstilo.ForeColor = Color.White;
            SPIBModificarEstilo.IconChar = FontAwesome.Sharp.IconChar.Brush;
            SPIBModificarEstilo.IconColor = Color.White;
            SPIBModificarEstilo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBModificarEstilo.IconSize = 25;
            SPIBModificarEstilo.Location = new Point(0, 48);
            SPIBModificarEstilo.Name = "SPIBModificarEstilo";
            SPIBModificarEstilo.Size = new Size(203, 48);
            SPIBModificarEstilo.TabIndex = 11;
            SPIBModificarEstilo.Text = "Modificar Estilo";
            SPIBModificarEstilo.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBModificarEstilo.UseVisualStyleBackColor = false;
            SPIBModificarEstilo.Click += SPIBModificarEstilo_Click;
            // 
            // SPIBAgregarEstilos
            // 
            SPIBAgregarEstilos.AllowDrop = true;
            SPIBAgregarEstilos.BackColor = Color.FromArgb(90, 0, 200);
            SPIBAgregarEstilos.Dock = DockStyle.Top;
            SPIBAgregarEstilos.FlatAppearance.BorderSize = 0;
            SPIBAgregarEstilos.FlatStyle = FlatStyle.Flat;
            SPIBAgregarEstilos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBAgregarEstilos.ForeColor = Color.White;
            SPIBAgregarEstilos.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            SPIBAgregarEstilos.IconColor = Color.White;
            SPIBAgregarEstilos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBAgregarEstilos.IconSize = 25;
            SPIBAgregarEstilos.Location = new Point(0, 0);
            SPIBAgregarEstilos.Name = "SPIBAgregarEstilos";
            SPIBAgregarEstilos.Size = new Size(203, 48);
            SPIBAgregarEstilos.TabIndex = 12;
            SPIBAgregarEstilos.Text = "Agregar Estilo";
            SPIBAgregarEstilos.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBAgregarEstilos.UseVisualStyleBackColor = false;
            SPIBAgregarEstilos.Click += SPIBAgregarEstilos_Click;
            // 
            // PIBEstilosAnteojos
            // 
            PIBEstilosAnteojos.AllowDrop = true;
            PIBEstilosAnteojos.BackColor = Color.FromArgb(30, 0, 50);
            PIBEstilosAnteojos.Dock = DockStyle.Top;
            PIBEstilosAnteojos.FlatAppearance.BorderSize = 0;
            PIBEstilosAnteojos.FlatStyle = FlatStyle.Flat;
            PIBEstilosAnteojos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PIBEstilosAnteojos.ForeColor = Color.White;
            PIBEstilosAnteojos.IconChar = FontAwesome.Sharp.IconChar.PersonHalfDress;
            PIBEstilosAnteojos.IconColor = Color.White;
            PIBEstilosAnteojos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PIBEstilosAnteojos.IconSize = 25;
            PIBEstilosAnteojos.Location = new Point(0, 640);
            PIBEstilosAnteojos.Name = "PIBEstilosAnteojos";
            PIBEstilosAnteojos.Size = new Size(203, 48);
            PIBEstilosAnteojos.TabIndex = 10;
            PIBEstilosAnteojos.Text = "Estilos Anteojos";
            PIBEstilosAnteojos.TextImageRelation = TextImageRelation.ImageBeforeText;
            PIBEstilosAnteojos.UseVisualStyleBackColor = false;
            PIBEstilosAnteojos.Click += PIBEstilosAnteojos_Click;
            // 
            // PSPFormas
            // 
            PSPFormas.Controls.Add(SPIBVerFormas);
            PSPFormas.Controls.Add(SPIBModificarForma);
            PSPFormas.Controls.Add(SPIBAgregarForma);
            PSPFormas.Dock = DockStyle.Top;
            PSPFormas.Location = new Point(0, 491);
            PSPFormas.Name = "PSPFormas";
            PSPFormas.Size = new Size(203, 149);
            PSPFormas.TabIndex = 15;
            // 
            // SPIBVerFormas
            // 
            SPIBVerFormas.AllowDrop = true;
            SPIBVerFormas.BackColor = Color.FromArgb(90, 0, 200);
            SPIBVerFormas.Dock = DockStyle.Top;
            SPIBVerFormas.FlatAppearance.BorderSize = 0;
            SPIBVerFormas.FlatStyle = FlatStyle.Flat;
            SPIBVerFormas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBVerFormas.ForeColor = Color.White;
            SPIBVerFormas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SPIBVerFormas.IconColor = Color.White;
            SPIBVerFormas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBVerFormas.IconSize = 25;
            SPIBVerFormas.Location = new Point(0, 96);
            SPIBVerFormas.Name = "SPIBVerFormas";
            SPIBVerFormas.Size = new Size(203, 48);
            SPIBVerFormas.TabIndex = 13;
            SPIBVerFormas.Text = "Ver Formas";
            SPIBVerFormas.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBVerFormas.UseVisualStyleBackColor = false;
            SPIBVerFormas.Click += SPIBVerFormas_Click;
            // 
            // SPIBModificarForma
            // 
            SPIBModificarForma.AllowDrop = true;
            SPIBModificarForma.BackColor = Color.FromArgb(90, 0, 200);
            SPIBModificarForma.Dock = DockStyle.Top;
            SPIBModificarForma.FlatAppearance.BorderSize = 0;
            SPIBModificarForma.FlatStyle = FlatStyle.Flat;
            SPIBModificarForma.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBModificarForma.ForeColor = Color.White;
            SPIBModificarForma.IconChar = FontAwesome.Sharp.IconChar.Brush;
            SPIBModificarForma.IconColor = Color.White;
            SPIBModificarForma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBModificarForma.IconSize = 25;
            SPIBModificarForma.Location = new Point(0, 48);
            SPIBModificarForma.Name = "SPIBModificarForma";
            SPIBModificarForma.Size = new Size(203, 48);
            SPIBModificarForma.TabIndex = 11;
            SPIBModificarForma.Text = "Modificar Forma";
            SPIBModificarForma.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBModificarForma.UseVisualStyleBackColor = false;
            SPIBModificarForma.Click += SPIBModificarForma_Click;
            // 
            // SPIBAgregarForma
            // 
            SPIBAgregarForma.AllowDrop = true;
            SPIBAgregarForma.BackColor = Color.FromArgb(90, 0, 200);
            SPIBAgregarForma.Dock = DockStyle.Top;
            SPIBAgregarForma.FlatAppearance.BorderSize = 0;
            SPIBAgregarForma.FlatStyle = FlatStyle.Flat;
            SPIBAgregarForma.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBAgregarForma.ForeColor = Color.White;
            SPIBAgregarForma.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            SPIBAgregarForma.IconColor = Color.White;
            SPIBAgregarForma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBAgregarForma.IconSize = 25;
            SPIBAgregarForma.Location = new Point(0, 0);
            SPIBAgregarForma.Name = "SPIBAgregarForma";
            SPIBAgregarForma.Size = new Size(203, 48);
            SPIBAgregarForma.TabIndex = 12;
            SPIBAgregarForma.Text = "Agregar Forma";
            SPIBAgregarForma.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBAgregarForma.UseVisualStyleBackColor = false;
            SPIBAgregarForma.Click += SPIBAgregarForma_Click;
            // 
            // PIBFormasAnteojos
            // 
            PIBFormasAnteojos.AllowDrop = true;
            PIBFormasAnteojos.BackColor = Color.FromArgb(30, 0, 50);
            PIBFormasAnteojos.Dock = DockStyle.Top;
            PIBFormasAnteojos.FlatAppearance.BorderSize = 0;
            PIBFormasAnteojos.FlatStyle = FlatStyle.Flat;
            PIBFormasAnteojos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PIBFormasAnteojos.ForeColor = Color.White;
            PIBFormasAnteojos.IconChar = FontAwesome.Sharp.IconChar.Square;
            PIBFormasAnteojos.IconColor = Color.White;
            PIBFormasAnteojos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PIBFormasAnteojos.IconSize = 25;
            PIBFormasAnteojos.Location = new Point(0, 443);
            PIBFormasAnteojos.Name = "PIBFormasAnteojos";
            PIBFormasAnteojos.Size = new Size(203, 48);
            PIBFormasAnteojos.TabIndex = 11;
            PIBFormasAnteojos.Text = "Formas Anteojos";
            PIBFormasAnteojos.TextImageRelation = TextImageRelation.ImageBeforeText;
            PIBFormasAnteojos.UseVisualStyleBackColor = false;
            PIBFormasAnteojos.Click += PIBFormasAnteojos_Click;
            // 
            // PSPMarcas
            // 
            PSPMarcas.Controls.Add(SPIBVerMarcas);
            PSPMarcas.Controls.Add(SPIBModificarMarca);
            PSPMarcas.Controls.Add(SPIBAgregarMarca);
            PSPMarcas.Dock = DockStyle.Top;
            PSPMarcas.Location = new Point(0, 293);
            PSPMarcas.Name = "PSPMarcas";
            PSPMarcas.Size = new Size(203, 150);
            PSPMarcas.TabIndex = 14;
            // 
            // SPIBVerMarcas
            // 
            SPIBVerMarcas.AllowDrop = true;
            SPIBVerMarcas.BackColor = Color.FromArgb(90, 0, 200);
            SPIBVerMarcas.Dock = DockStyle.Top;
            SPIBVerMarcas.FlatAppearance.BorderSize = 0;
            SPIBVerMarcas.FlatStyle = FlatStyle.Flat;
            SPIBVerMarcas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBVerMarcas.ForeColor = Color.White;
            SPIBVerMarcas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SPIBVerMarcas.IconColor = Color.White;
            SPIBVerMarcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBVerMarcas.IconSize = 25;
            SPIBVerMarcas.Location = new Point(0, 96);
            SPIBVerMarcas.Name = "SPIBVerMarcas";
            SPIBVerMarcas.Size = new Size(203, 48);
            SPIBVerMarcas.TabIndex = 13;
            SPIBVerMarcas.Text = "Ver Marcas";
            SPIBVerMarcas.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBVerMarcas.UseVisualStyleBackColor = false;
            SPIBVerMarcas.Click += SPIBVerMarcas_Click;
            // 
            // SPIBModificarMarca
            // 
            SPIBModificarMarca.AllowDrop = true;
            SPIBModificarMarca.BackColor = Color.FromArgb(90, 0, 200);
            SPIBModificarMarca.Dock = DockStyle.Top;
            SPIBModificarMarca.FlatAppearance.BorderSize = 0;
            SPIBModificarMarca.FlatStyle = FlatStyle.Flat;
            SPIBModificarMarca.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBModificarMarca.ForeColor = Color.White;
            SPIBModificarMarca.IconChar = FontAwesome.Sharp.IconChar.Brush;
            SPIBModificarMarca.IconColor = Color.White;
            SPIBModificarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBModificarMarca.IconSize = 25;
            SPIBModificarMarca.Location = new Point(0, 48);
            SPIBModificarMarca.Name = "SPIBModificarMarca";
            SPIBModificarMarca.Size = new Size(203, 48);
            SPIBModificarMarca.TabIndex = 11;
            SPIBModificarMarca.Text = "Modificar Marca";
            SPIBModificarMarca.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBModificarMarca.UseVisualStyleBackColor = false;
            SPIBModificarMarca.Click += SPIBModificarMarca_Click;
            // 
            // SPIBAgregarMarca
            // 
            SPIBAgregarMarca.AllowDrop = true;
            SPIBAgregarMarca.BackColor = Color.FromArgb(90, 0, 200);
            SPIBAgregarMarca.Dock = DockStyle.Top;
            SPIBAgregarMarca.FlatAppearance.BorderSize = 0;
            SPIBAgregarMarca.FlatStyle = FlatStyle.Flat;
            SPIBAgregarMarca.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBAgregarMarca.ForeColor = Color.White;
            SPIBAgregarMarca.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            SPIBAgregarMarca.IconColor = Color.White;
            SPIBAgregarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBAgregarMarca.IconSize = 25;
            SPIBAgregarMarca.Location = new Point(0, 0);
            SPIBAgregarMarca.Name = "SPIBAgregarMarca";
            SPIBAgregarMarca.Size = new Size(203, 48);
            SPIBAgregarMarca.TabIndex = 12;
            SPIBAgregarMarca.Text = "Agregar Marca";
            SPIBAgregarMarca.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBAgregarMarca.UseVisualStyleBackColor = false;
            SPIBAgregarMarca.Click += SPIBAgregarMarca_Click;
            // 
            // PIBMarcasAnteojos
            // 
            PIBMarcasAnteojos.AllowDrop = true;
            PIBMarcasAnteojos.BackColor = Color.FromArgb(30, 0, 50);
            PIBMarcasAnteojos.Dock = DockStyle.Top;
            PIBMarcasAnteojos.FlatAppearance.BorderSize = 0;
            PIBMarcasAnteojos.FlatStyle = FlatStyle.Flat;
            PIBMarcasAnteojos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PIBMarcasAnteojos.ForeColor = Color.White;
            PIBMarcasAnteojos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            PIBMarcasAnteojos.IconColor = Color.White;
            PIBMarcasAnteojos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PIBMarcasAnteojos.IconSize = 25;
            PIBMarcasAnteojos.Location = new Point(0, 245);
            PIBMarcasAnteojos.Name = "PIBMarcasAnteojos";
            PIBMarcasAnteojos.Size = new Size(203, 48);
            PIBMarcasAnteojos.TabIndex = 12;
            PIBMarcasAnteojos.Text = "Marcas Anteojos";
            PIBMarcasAnteojos.TextImageRelation = TextImageRelation.ImageBeforeText;
            PIBMarcasAnteojos.UseVisualStyleBackColor = false;
            PIBMarcasAnteojos.Click += PIBMarcasAnteojos_Click;
            // 
            // PSPAnteojos
            // 
            PSPAnteojos.Controls.Add(SPIBVerAnteojos);
            PSPAnteojos.Controls.Add(SPIBModificarAnteojo);
            PSPAnteojos.Controls.Add(SPIBAltaTerapeutico);
            PSPAnteojos.Controls.Add(SPIBAltaAccesorio);
            PSPAnteojos.Dock = DockStyle.Top;
            PSPAnteojos.Location = new Point(0, 48);
            PSPAnteojos.Name = "PSPAnteojos";
            PSPAnteojos.Size = new Size(203, 197);
            PSPAnteojos.TabIndex = 16;
            PSPAnteojos.Paint += PSPAnteojos_Paint;
            // 
            // SPIBVerAnteojos
            // 
            SPIBVerAnteojos.AllowDrop = true;
            SPIBVerAnteojos.BackColor = Color.FromArgb(90, 0, 200);
            SPIBVerAnteojos.Dock = DockStyle.Top;
            SPIBVerAnteojos.FlatAppearance.BorderSize = 0;
            SPIBVerAnteojos.FlatStyle = FlatStyle.Flat;
            SPIBVerAnteojos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBVerAnteojos.ForeColor = Color.White;
            SPIBVerAnteojos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SPIBVerAnteojos.IconColor = Color.White;
            SPIBVerAnteojos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBVerAnteojos.IconSize = 25;
            SPIBVerAnteojos.Location = new Point(0, 144);
            SPIBVerAnteojos.Name = "SPIBVerAnteojos";
            SPIBVerAnteojos.Size = new Size(203, 48);
            SPIBVerAnteojos.TabIndex = 14;
            SPIBVerAnteojos.Text = "Ver Anteojos";
            SPIBVerAnteojos.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBVerAnteojos.UseVisualStyleBackColor = false;
            SPIBVerAnteojos.Click += SPIBVerAnteojos_Click;
            // 
            // SPIBModificarAnteojo
            // 
            SPIBModificarAnteojo.AllowDrop = true;
            SPIBModificarAnteojo.BackColor = Color.FromArgb(90, 0, 200);
            SPIBModificarAnteojo.Dock = DockStyle.Top;
            SPIBModificarAnteojo.FlatAppearance.BorderSize = 0;
            SPIBModificarAnteojo.FlatStyle = FlatStyle.Flat;
            SPIBModificarAnteojo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBModificarAnteojo.ForeColor = Color.White;
            SPIBModificarAnteojo.IconChar = FontAwesome.Sharp.IconChar.Brush;
            SPIBModificarAnteojo.IconColor = Color.White;
            SPIBModificarAnteojo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBModificarAnteojo.IconSize = 25;
            SPIBModificarAnteojo.Location = new Point(0, 96);
            SPIBModificarAnteojo.Name = "SPIBModificarAnteojo";
            SPIBModificarAnteojo.Size = new Size(203, 48);
            SPIBModificarAnteojo.TabIndex = 13;
            SPIBModificarAnteojo.Text = "Modificar Anteojo";
            SPIBModificarAnteojo.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBModificarAnteojo.UseVisualStyleBackColor = false;
            SPIBModificarAnteojo.Click += SPIBModificarAnteojo_Click;
            // 
            // SPIBAltaTerapeutico
            // 
            SPIBAltaTerapeutico.AllowDrop = true;
            SPIBAltaTerapeutico.BackColor = Color.FromArgb(90, 0, 200);
            SPIBAltaTerapeutico.Dock = DockStyle.Top;
            SPIBAltaTerapeutico.FlatAppearance.BorderSize = 0;
            SPIBAltaTerapeutico.FlatStyle = FlatStyle.Flat;
            SPIBAltaTerapeutico.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBAltaTerapeutico.ForeColor = Color.White;
            SPIBAltaTerapeutico.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            SPIBAltaTerapeutico.IconColor = Color.White;
            SPIBAltaTerapeutico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBAltaTerapeutico.IconSize = 25;
            SPIBAltaTerapeutico.Location = new Point(0, 48);
            SPIBAltaTerapeutico.Name = "SPIBAltaTerapeutico";
            SPIBAltaTerapeutico.Size = new Size(203, 48);
            SPIBAltaTerapeutico.TabIndex = 11;
            SPIBAltaTerapeutico.Text = "Alta Anteojo Terapeutico";
            SPIBAltaTerapeutico.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBAltaTerapeutico.UseVisualStyleBackColor = false;
            SPIBAltaTerapeutico.Click += SPIBAltaTerapeutico_Click;
            // 
            // SPIBAltaAccesorio
            // 
            SPIBAltaAccesorio.AllowDrop = true;
            SPIBAltaAccesorio.BackColor = Color.FromArgb(90, 0, 200);
            SPIBAltaAccesorio.Dock = DockStyle.Top;
            SPIBAltaAccesorio.FlatAppearance.BorderSize = 0;
            SPIBAltaAccesorio.FlatStyle = FlatStyle.Flat;
            SPIBAltaAccesorio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SPIBAltaAccesorio.ForeColor = Color.White;
            SPIBAltaAccesorio.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            SPIBAltaAccesorio.IconColor = Color.White;
            SPIBAltaAccesorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SPIBAltaAccesorio.IconSize = 25;
            SPIBAltaAccesorio.Location = new Point(0, 0);
            SPIBAltaAccesorio.Name = "SPIBAltaAccesorio";
            SPIBAltaAccesorio.Size = new Size(203, 48);
            SPIBAltaAccesorio.TabIndex = 12;
            SPIBAltaAccesorio.Text = "Alta Anteojo Accesorio";
            SPIBAltaAccesorio.TextImageRelation = TextImageRelation.ImageBeforeText;
            SPIBAltaAccesorio.UseVisualStyleBackColor = false;
            SPIBAltaAccesorio.Click += SPIBAltaAccesorio_Click;
            // 
            // PIBAnteojos
            // 
            PIBAnteojos.AllowDrop = true;
            PIBAnteojos.BackColor = Color.FromArgb(30, 0, 50);
            PIBAnteojos.Dock = DockStyle.Top;
            PIBAnteojos.FlatAppearance.BorderSize = 0;
            PIBAnteojos.FlatStyle = FlatStyle.Flat;
            PIBAnteojos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PIBAnteojos.ForeColor = Color.White;
            PIBAnteojos.IconChar = FontAwesome.Sharp.IconChar.Glasses;
            PIBAnteojos.IconColor = Color.White;
            PIBAnteojos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PIBAnteojos.IconSize = 25;
            PIBAnteojos.Location = new Point(0, 0);
            PIBAnteojos.Name = "PIBAnteojos";
            PIBAnteojos.Size = new Size(203, 48);
            PIBAnteojos.TabIndex = 7;
            PIBAnteojos.Text = "Anteojos";
            PIBAnteojos.TextImageRelation = TextImageRelation.ImageBeforeText;
            PIBAnteojos.UseVisualStyleBackColor = false;
            PIBAnteojos.Click += PIBAnteojos_Click;
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
            AutoScroll = true;
            ClientSize = new Size(800, 614);
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
            PGestorClientes.ResumeLayout(false);
            PanelGestorProductos.ResumeLayout(false);
            PSPObrasSociales.ResumeLayout(false);
            PSPCristales.ResumeLayout(false);
            PSPEstilos.ResumeLayout(false);
            PSPFormas.ResumeLayout(false);
            PSPMarcas.ResumeLayout(false);
            PSPAnteojos.ResumeLayout(false);
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
        private Panel PanelMenuSecretaria;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Panel PanelGestorProductos;
        private FontAwesome.Sharp.IconButton PIBAnteojos;
        private FontAwesome.Sharp.IconButton PIBEstilosAnteojos;
        private FontAwesome.Sharp.IconButton PIBFormasAnteojos;
        private FontAwesome.Sharp.IconButton PIBMarcasAnteojos;
        private Panel PGestorClientes;
        private FontAwesome.Sharp.IconButton PIBVerClientes;
        private FontAwesome.Sharp.IconButton PIBModifClientes;
        private Panel PSPEstilos;
        private FontAwesome.Sharp.IconButton SPIBModificarEstilo;
        private FontAwesome.Sharp.IconButton SPIBAgregarEstilos;
        private Panel PSPMarcas;
        private FontAwesome.Sharp.IconButton SPIBModificarMarca;
        private FontAwesome.Sharp.IconButton SPIBAgregarMarca;
        private Panel PSPFormas;
        private FontAwesome.Sharp.IconButton SPIBModificarForma;
        private FontAwesome.Sharp.IconButton SPIBAgregarForma;
        private Panel PSPAnteojos;
        private FontAwesome.Sharp.IconButton SPIBAltaTerapeutico;
        private FontAwesome.Sharp.IconButton SPIBAltaAccesorio;
        private FontAwesome.Sharp.IconButton SPIBVerAnteojos;
        private FontAwesome.Sharp.IconButton SPIBModificarAnteojo;
        private FontAwesome.Sharp.IconButton SPIBVerMarcas;
        private FontAwesome.Sharp.IconButton BCerrarSesion;
        private FontAwesome.Sharp.IconButton SPIBVerFormas;
        private FontAwesome.Sharp.IconButton SPIBVerEstilos;
        private Panel PSPObrasSociales;
        private FontAwesome.Sharp.IconButton SPIBVerObrasSociales;
        private FontAwesome.Sharp.IconButton SPIBModificarObraSocial;
        private FontAwesome.Sharp.IconButton SPIBAgregarObraSocial;
        private FontAwesome.Sharp.IconButton PICBObrasSociales;
        private Panel PSPCristales;
        private FontAwesome.Sharp.IconButton SPIBVerCristales;
        private FontAwesome.Sharp.IconButton SPIBModificarCristal;
        private FontAwesome.Sharp.IconButton SPIBAgregarCristal;
        private FontAwesome.Sharp.IconButton PICBCristales;
    }
}
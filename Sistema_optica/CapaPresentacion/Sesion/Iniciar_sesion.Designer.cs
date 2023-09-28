namespace CapaPresentacion.Sesion
{
    partial class Iniciar_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar_sesion));
            LCodigoUsuario = new Label();
            TCodigo_empleado_sesion = new TextBox();
            TContraseña_sesion = new TextBox();
            LContrasena = new Label();
            menuStrip1 = new MenuStrip();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            BSalir = new FontAwesome.Sharp.IconButton();
            BIngresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LCodigoUsuario
            // 
            LCodigoUsuario.AutoSize = true;
            LCodigoUsuario.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LCodigoUsuario.ForeColor = Color.White;
            LCodigoUsuario.Location = new Point(19, 80);
            LCodigoUsuario.Name = "LCodigoUsuario";
            LCodigoUsuario.Size = new Size(200, 23);
            LCodigoUsuario.TabIndex = 1;
            LCodigoUsuario.Text = "CODIGO DE EMPLEADO";
            // 
            // TCodigo_empleado_sesion
            // 
            TCodigo_empleado_sesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TCodigo_empleado_sesion.Location = new Point(19, 106);
            TCodigo_empleado_sesion.Name = "TCodigo_empleado_sesion";
            TCodigo_empleado_sesion.Size = new Size(200, 25);
            TCodigo_empleado_sesion.TabIndex = 2;
            TCodigo_empleado_sesion.TextChanged += TCodigo_empleado_sesion_TextChanged;
            // 
            // TContraseña_sesion
            // 
            TContraseña_sesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TContraseña_sesion.Location = new Point(19, 206);
            TContraseña_sesion.Name = "TContraseña_sesion";
            TContraseña_sesion.Size = new Size(200, 25);
            TContraseña_sesion.TabIndex = 3;
            TContraseña_sesion.TextChanged += TContraseña_sesion_TextChanged;
            TContraseña_sesion.KeyPress += TContraseña_sesion_KeyPress;
            // 
            // LContrasena
            // 
            LContrasena.AutoSize = true;
            LContrasena.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LContrasena.ForeColor = Color.White;
            LContrasena.Location = new Point(19, 180);
            LContrasena.Name = "LContrasena";
            LContrasena.Size = new Size(121, 23);
            LContrasena.TabIndex = 4;
            LContrasena.Text = "CONTRASEÑA";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.White;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(217, 369);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(BSalir);
            panel1.Controls.Add(BIngresar);
            panel1.Controls.Add(LCodigoUsuario);
            panel1.Controls.Add(TCodigo_empleado_sesion);
            panel1.Controls.Add(LContrasena);
            panel1.Controls.Add(TContraseña_sesion);
            panel1.Location = new Point(246, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 311);
            panel1.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.Red;
            BSalir.FlatStyle = FlatStyle.Popup;
            BSalir.ForeColor = Color.White;
            BSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            BSalir.IconColor = Color.Black;
            BSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BSalir.Location = new Point(19, 264);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(96, 29);
            BSalir.TabIndex = 7;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += BSalir_Click;
            // 
            // BIngresar
            // 
            BIngresar.BackColor = Color.ForestGreen;
            BIngresar.FlatStyle = FlatStyle.Popup;
            BIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            BIngresar.IconColor = Color.Black;
            BIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BIngresar.Location = new Point(131, 264);
            BIngresar.Name = "BIngresar";
            BIngresar.Size = new Size(88, 29);
            BIngresar.TabIndex = 6;
            BIngresar.Text = "Ingresar";
            BIngresar.UseVisualStyleBackColor = false;
            BIngresar.Click += BIngresar_Click;
            // 
            // Iniciar_sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(515, 369);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Iniciar_sesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar_sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LCodigoUsuario;
        private TextBox TCodigo_empleado_sesion;
        private TextBox TContraseña_sesion;
        private Label LContrasena;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BSalir;
        private FontAwesome.Sharp.IconButton BIngresar;
    }
}
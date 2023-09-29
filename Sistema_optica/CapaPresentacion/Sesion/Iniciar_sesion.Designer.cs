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
            menuStrip1 = new MenuStrip();
            pictureBox1 = new PictureBox();
            BSalir = new FontAwesome.Sharp.IconButton();
            BIngresar = new FontAwesome.Sharp.IconButton();
            LCodigoUsuario = new Label();
            TCodigo_empleado_sesion = new TextBox();
            LContrasena = new Label();
            TContraseña_sesion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(0, 64, 64);
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(233, 369);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.Red;
            BSalir.FlatStyle = FlatStyle.Popup;
            BSalir.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BSalir.ForeColor = Color.White;
            BSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            BSalir.IconColor = Color.Black;
            BSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BSalir.Location = new Point(278, 265);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(88, 34);
            BSalir.TabIndex = 13;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += BSalir_Click_1;
            // 
            // BIngresar
            // 
            BIngresar.BackColor = Color.ForestGreen;
            BIngresar.FlatStyle = FlatStyle.Popup;
            BIngresar.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            BIngresar.ForeColor = Color.White;
            BIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            BIngresar.IconColor = Color.Black;
            BIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BIngresar.Location = new Point(390, 265);
            BIngresar.Name = "BIngresar";
            BIngresar.Size = new Size(88, 34);
            BIngresar.TabIndex = 12;
            BIngresar.Text = "Ingresar";
            BIngresar.UseVisualStyleBackColor = false;
            BIngresar.Click += BIngresar_Click_1;
            // 
            // LCodigoUsuario
            // 
            LCodigoUsuario.AutoSize = true;
            LCodigoUsuario.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LCodigoUsuario.ForeColor = Color.FromArgb(0, 64, 64);
            LCodigoUsuario.Location = new Point(278, 81);
            LCodigoUsuario.Name = "LCodigoUsuario";
            LCodigoUsuario.Size = new Size(200, 23);
            LCodigoUsuario.TabIndex = 8;
            LCodigoUsuario.Text = "CODIGO DE EMPLEADO";
            // 
            // TCodigo_empleado_sesion
            // 
            TCodigo_empleado_sesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TCodigo_empleado_sesion.Location = new Point(278, 107);
            TCodigo_empleado_sesion.Name = "TCodigo_empleado_sesion";
            TCodigo_empleado_sesion.Size = new Size(200, 25);
            TCodigo_empleado_sesion.TabIndex = 9;
            // 
            // LContrasena
            // 
            LContrasena.AutoSize = true;
            LContrasena.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LContrasena.ForeColor = Color.FromArgb(0, 64, 64);
            LContrasena.Location = new Point(278, 181);
            LContrasena.Name = "LContrasena";
            LContrasena.Size = new Size(121, 23);
            LContrasena.TabIndex = 11;
            LContrasena.Text = "CONTRASEÑA";
            // 
            // TContraseña_sesion
            // 
            TContraseña_sesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TContraseña_sesion.Location = new Point(278, 207);
            TContraseña_sesion.Name = "TContraseña_sesion";
            TContraseña_sesion.Size = new Size(200, 25);
            TContraseña_sesion.TabIndex = 10;
            // 
            // Iniciar_sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(515, 369);
            Controls.Add(BSalir);
            Controls.Add(BIngresar);
            Controls.Add(LCodigoUsuario);
            Controls.Add(TCodigo_empleado_sesion);
            Controls.Add(LContrasena);
            Controls.Add(TContraseña_sesion);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Iniciar_sesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar_sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BSalir;
        private FontAwesome.Sharp.IconButton BIngresar;
        private Label LCodigoUsuario;
        private TextBox TCodigo_empleado_sesion;
        private Label LContrasena;
        private TextBox TContraseña_sesion;
    }
}
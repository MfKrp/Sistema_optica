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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LContrasena = new Label();
            menuStrip1 = new MenuStrip();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(19, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(19, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 25);
            textBox2.TabIndex = 3;
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
            panel1.Controls.Add(LCodigoUsuario);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(LContrasena);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(246, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 311);
            panel1.TabIndex = 6;
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
            MainMenuStrip = menuStrip1;
            Name = "Iniciar_sesion";
            Text = "Iniciar_sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LCodigoUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LContrasena;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
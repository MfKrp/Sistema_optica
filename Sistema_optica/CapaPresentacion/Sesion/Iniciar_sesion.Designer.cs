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
            pictureBox1 = new PictureBox();
            LCodigoUsuario = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LContrasena = new Label();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.optica_maribel;
            pictureBox1.Location = new Point(122, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LCodigoUsuario
            // 
            LCodigoUsuario.AutoSize = true;
            LCodigoUsuario.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LCodigoUsuario.Location = new Point(106, 197);
            LCodigoUsuario.Name = "LCodigoUsuario";
            LCodigoUsuario.Size = new Size(181, 25);
            LCodigoUsuario.TabIndex = 1;
            LCodigoUsuario.Text = "Codigo de empleado";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(122, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 25);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(122, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 25);
            textBox2.TabIndex = 3;
            // 
            // LContrasena
            // 
            LContrasena.AutoSize = true;
            LContrasena.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LContrasena.Location = new Point(144, 294);
            LContrasena.Name = "LContrasena";
            LContrasena.Size = new Size(101, 25);
            LContrasena.TabIndex = 4;
            LContrasena.Text = "Contraseña";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.BlueViolet;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(402, 171);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // Iniciar_sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 395);
            Controls.Add(LContrasena);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LCodigoUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Iniciar_sesion";
            Text = "Iniciar_sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LCodigoUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LContrasena;
        private MenuStrip menuStrip1;
    }
}
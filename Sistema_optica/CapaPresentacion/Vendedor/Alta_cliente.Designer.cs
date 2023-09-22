namespace CapaPresentacion.Vendedor
{
    partial class Alta_cliente
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
            MSAltaCliente = new MenuStrip();
            LAltaCliente = new ToolStripMenuItem();
            LNombreCliente = new Label();
            LApellidoCliente = new Label();
            LDireccionCliente = new Label();
            LTelefonoCliente = new Label();
            LEmailCliente = new Label();
            LDniCliente = new Label();
            LIdCliente = new Label();
            TIdCliente = new TextBox();
            TNombreCliente = new TextBox();
            TDireccionCliente = new TextBox();
            TDniCliente = new TextBox();
            TTelefonoCliente = new TextBox();
            TApellidoCliente = new TextBox();
            TCorreoCliente = new TextBox();
            BRegistrarCliente = new Button();
            BReiniciar = new Button();
            MSAltaCliente.SuspendLayout();
            SuspendLayout();
            // 
            // MSAltaCliente
            // 
            MSAltaCliente.AutoSize = false;
            MSAltaCliente.BackColor = Color.BlueViolet;
            MSAltaCliente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MSAltaCliente.Items.AddRange(new ToolStripItem[] { LAltaCliente });
            MSAltaCliente.Location = new Point(0, 0);
            MSAltaCliente.Name = "MSAltaCliente";
            MSAltaCliente.Size = new Size(800, 89);
            MSAltaCliente.TabIndex = 0;
            MSAltaCliente.Text = "menuStrip1";
            // 
            // LAltaCliente
            // 
            LAltaCliente.ForeColor = Color.White;
            LAltaCliente.Name = "LAltaCliente";
            LAltaCliente.Size = new Size(203, 85);
            LAltaCliente.Text = "Alta de Cliente";
            // 
            // LNombreCliente
            // 
            LNombreCliente.AutoSize = true;
            LNombreCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCliente.Location = new Point(314, 124);
            LNombreCliente.Name = "LNombreCliente";
            LNombreCliente.Size = new Size(89, 28);
            LNombreCliente.TabIndex = 1;
            LNombreCliente.Text = "Nombre:";
            // 
            // LApellidoCliente
            // 
            LApellidoCliente.AutoSize = true;
            LApellidoCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LApellidoCliente.Location = new Point(314, 227);
            LApellidoCliente.Name = "LApellidoCliente";
            LApellidoCliente.Size = new Size(90, 28);
            LApellidoCliente.TabIndex = 2;
            LApellidoCliente.Text = "Apellido:";
            // 
            // LDireccionCliente
            // 
            LDireccionCliente.AutoSize = true;
            LDireccionCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LDireccionCliente.Location = new Point(580, 124);
            LDireccionCliente.Name = "LDireccionCliente";
            LDireccionCliente.Size = new Size(98, 28);
            LDireccionCliente.TabIndex = 3;
            LDireccionCliente.Text = "Direccion:";
            // 
            // LTelefonoCliente
            // 
            LTelefonoCliente.AutoSize = true;
            LTelefonoCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LTelefonoCliente.Location = new Point(314, 331);
            LTelefonoCliente.Name = "LTelefonoCliente";
            LTelefonoCliente.Size = new Size(90, 28);
            LTelefonoCliente.TabIndex = 4;
            LTelefonoCliente.Text = "Telefono:";
            // 
            // LEmailCliente
            // 
            LEmailCliente.AutoSize = true;
            LEmailCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LEmailCliente.Location = new Point(580, 227);
            LEmailCliente.Name = "LEmailCliente";
            LEmailCliente.Size = new Size(178, 28);
            LEmailCliente.TabIndex = 5;
            LEmailCliente.Text = "Correo Electronico:";
            // 
            // LDniCliente
            // 
            LDniCliente.AutoSize = true;
            LDniCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LDniCliente.Location = new Point(580, 331);
            LDniCliente.Name = "LDniCliente";
            LDniCliente.Size = new Size(110, 28);
            LDniCliente.TabIndex = 6;
            LDniCliente.Text = "Nro de dni:";
            // 
            // LIdCliente
            // 
            LIdCliente.AutoSize = true;
            LIdCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LIdCliente.Location = new Point(40, 124);
            LIdCliente.Name = "LIdCliente";
            LIdCliente.Size = new Size(215, 28);
            LIdCliente.TabIndex = 7;
            LIdCliente.Text = "Id que tendra el cliente:";
            // 
            // TIdCliente
            // 
            TIdCliente.Location = new Point(40, 173);
            TIdCliente.Name = "TIdCliente";
            TIdCliente.Size = new Size(215, 23);
            TIdCliente.TabIndex = 8;
            // 
            // TNombreCliente
            // 
            TNombreCliente.Location = new Point(314, 173);
            TNombreCliente.Name = "TNombreCliente";
            TNombreCliente.Size = new Size(185, 23);
            TNombreCliente.TabIndex = 9;
            // 
            // TDireccionCliente
            // 
            TDireccionCliente.Location = new Point(580, 173);
            TDireccionCliente.Name = "TDireccionCliente";
            TDireccionCliente.Size = new Size(178, 23);
            TDireccionCliente.TabIndex = 10;
            // 
            // TDniCliente
            // 
            TDniCliente.Location = new Point(580, 376);
            TDniCliente.Name = "TDniCliente";
            TDniCliente.Size = new Size(178, 23);
            TDniCliente.TabIndex = 11;
            // 
            // TTelefonoCliente
            // 
            TTelefonoCliente.Location = new Point(314, 376);
            TTelefonoCliente.Name = "TTelefonoCliente";
            TTelefonoCliente.Size = new Size(185, 23);
            TTelefonoCliente.TabIndex = 12;
            // 
            // TApellidoCliente
            // 
            TApellidoCliente.Location = new Point(314, 271);
            TApellidoCliente.Name = "TApellidoCliente";
            TApellidoCliente.Size = new Size(185, 23);
            TApellidoCliente.TabIndex = 13;
            // 
            // TCorreoCliente
            // 
            TCorreoCliente.Location = new Point(580, 271);
            TCorreoCliente.Name = "TCorreoCliente";
            TCorreoCliente.Size = new Size(178, 23);
            TCorreoCliente.TabIndex = 14;
            // 
            // BRegistrarCliente
            // 
            BRegistrarCliente.BackColor = Color.LimeGreen;
            BRegistrarCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarCliente.ForeColor = Color.White;
            BRegistrarCliente.Location = new Point(40, 354);
            BRegistrarCliente.Name = "BRegistrarCliente";
            BRegistrarCliente.Size = new Size(104, 45);
            BRegistrarCliente.TabIndex = 15;
            BRegistrarCliente.Text = "Registrar";
            BRegistrarCliente.UseVisualStyleBackColor = false;
            // 
            // BReiniciar
            // 
            BReiniciar.BackColor = Color.Red;
            BReiniciar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BReiniciar.ForeColor = Color.White;
            BReiniciar.Location = new Point(156, 354);
            BReiniciar.Name = "BReiniciar";
            BReiniciar.Size = new Size(99, 45);
            BReiniciar.TabIndex = 16;
            BReiniciar.Text = "Reiniciar";
            BReiniciar.UseVisualStyleBackColor = false;
            // 
            // Alta_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(BReiniciar);
            Controls.Add(BRegistrarCliente);
            Controls.Add(TCorreoCliente);
            Controls.Add(TApellidoCliente);
            Controls.Add(TTelefonoCliente);
            Controls.Add(TDniCliente);
            Controls.Add(TDireccionCliente);
            Controls.Add(TNombreCliente);
            Controls.Add(TIdCliente);
            Controls.Add(LIdCliente);
            Controls.Add(LDniCliente);
            Controls.Add(LEmailCliente);
            Controls.Add(LTelefonoCliente);
            Controls.Add(LDireccionCliente);
            Controls.Add(LApellidoCliente);
            Controls.Add(LNombreCliente);
            Controls.Add(MSAltaCliente);
            MainMenuStrip = MSAltaCliente;
            Name = "Alta_cliente";
            Text = "Alta de cliente";
            MSAltaCliente.ResumeLayout(false);
            MSAltaCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MSAltaCliente;
        private ToolStripMenuItem LAltaCliente;
        private Label LNombreCliente;
        private Label LApellidoCliente;
        private Label LDireccionCliente;
        private Label LTelefonoCliente;
        private Label LEmailCliente;
        private Label LDniCliente;
        private Label LIdCliente;
        private TextBox TIdCliente;
        private TextBox TNombreCliente;
        private TextBox TDireccionCliente;
        private TextBox TDniCliente;
        private TextBox TTelefonoCliente;
        private TextBox TApellidoCliente;
        private TextBox TCorreoCliente;
        private Button BRegistrarCliente;
        private Button BReiniciar;
    }
}
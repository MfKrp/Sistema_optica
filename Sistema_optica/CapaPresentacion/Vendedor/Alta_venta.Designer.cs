namespace CapaPresentacion.Vendedor
{
    partial class Alta_venta
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
            menuStrip1 = new MenuStrip();
            MSLRegistrarVenta = new ToolStripMenuItem();
            LVendedorActual = new Label();
            LCliente = new Label();
            LFechaVta = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.Highlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLRegistrarVenta });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 60);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSLRegistrarVenta
            // 
            MSLRegistrarVenta.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MSLRegistrarVenta.ForeColor = Color.White;
            MSLRegistrarVenta.Name = "MSLRegistrarVenta";
            MSLRegistrarVenta.Size = new Size(207, 56);
            MSLRegistrarVenta.Text = "Registrar Venta";
            // 
            // LVendedorActual
            // 
            LVendedorActual.AutoSize = true;
            LVendedorActual.Location = new Point(12, 79);
            LVendedorActual.Name = "LVendedorActual";
            LVendedorActual.Size = new Size(99, 15);
            LVendedorActual.TabIndex = 1;
            LVendedorActual.Text = "Vendedor a cargo";
            // 
            // LCliente
            // 
            LCliente.AutoSize = true;
            LCliente.Location = new Point(294, 79);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(78, 15);
            LCliente.TabIndex = 2;
            LCliente.Text = "Cliente titular";
            // 
            // LFechaVta
            // 
            LFechaVta.AutoSize = true;
            LFechaVta.Location = new Point(540, 79);
            LFechaVta.Name = "LFechaVta";
            LFechaVta.Size = new Size(89, 15);
            LFechaVta.TabIndex = 3;
            LFechaVta.Text = "Fecha de venta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(378, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(644, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 143);
            panel1.TabIndex = 10;
            // 
            // Alta_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LFechaVta);
            Controls.Add(LCliente);
            Controls.Add(LVendedorActual);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Alta_venta";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLRegistrarVenta;
        private Label LVendedorActual;
        private Label LCliente;
        private Label LFechaVta;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
    }
}
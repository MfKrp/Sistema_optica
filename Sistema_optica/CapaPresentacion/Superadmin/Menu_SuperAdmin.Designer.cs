namespace CapaPresentacion.Superadmin
{
    partial class Menu_SuperAdmin
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
            MSLMenu = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            TSMItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            generarVentaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.CadetBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 95);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSLMenu
            // 
            MSLMenu.Font = new Font("Sitka Text", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            MSLMenu.ForeColor = Color.White;
            MSLMenu.Name = "MSLMenu";
            MSLMenu.Size = new Size(243, 91);
            MSLMenu.Text = "Optica Maribel";
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.CadetBlue;
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { TSMItem, toolStripMenuItem4, generarVentaToolStripMenuItem, toolStripMenuItem2 });
            menuStrip2.Location = new Point(0, 95);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(180, 355);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // TSMItem
            // 
            TSMItem.BackColor = Color.FromArgb(0, 64, 64);
            TSMItem.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TSMItem.ForeColor = Color.White;
            TSMItem.Name = "TSMItem";
            TSMItem.Size = new Size(173, 27);
            TSMItem.Text = "Registrar Empleado";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.FromArgb(0, 64, 64);
            toolStripMenuItem4.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem4.ForeColor = Color.White;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(173, 27);
            toolStripMenuItem4.Text = "Empleados";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // generarVentaToolStripMenuItem
            // 
            generarVentaToolStripMenuItem.BackColor = Color.FromArgb(0, 64, 64);
            generarVentaToolStripMenuItem.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generarVentaToolStripMenuItem.ForeColor = Color.White;
            generarVentaToolStripMenuItem.Name = "generarVentaToolStripMenuItem";
            generarVentaToolStripMenuItem.Size = new Size(173, 27);
            generarVentaToolStripMenuItem.Text = "Productos";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem2.ForeColor = Color.White;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(173, 23);
            toolStripMenuItem2.Text = "VER PERFIL";
            // 
            // Menu_SuperAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            Name = "Menu_SuperAdmin";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLMenu;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem TSMItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem generarVentaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}
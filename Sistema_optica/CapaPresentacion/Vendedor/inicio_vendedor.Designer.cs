namespace CapaPresentacion
{
    partial class inicio_vendedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            MSLMenu = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            TSMItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DarkViolet;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MSLMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 71);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MSLMenu
            // 
            MSLMenu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MSLMenu.ForeColor = Color.White;
            MSLMenu.Name = "MSLMenu";
            MSLMenu.Size = new Size(205, 67);
            MSLMenu.Text = "Optica Maribel";
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = Color.DarkViolet;
            menuStrip2.Items.AddRange(new ToolStripItem[] { TSMItem });
            menuStrip2.Location = new Point(0, 71);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(584, 61);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // TSMItem
            // 
            TSMItem.BackColor = Color.DarkBlue;
            TSMItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TSMItem.ForeColor = Color.White;
            TSMItem.Name = "TSMItem";
            TSMItem.Size = new Size(116, 57);
            TSMItem.Text = "Generar Cliente";
            // 
            // inicio_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            Name = "inicio_vendedor";
            Text = "Menu Vendedor";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MSLMenu;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem TSMItem;
    }
}
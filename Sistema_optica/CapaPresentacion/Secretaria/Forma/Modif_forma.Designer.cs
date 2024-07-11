namespace CapaPresentacion.Secretaria.Forma
{
    partial class Modif_forma
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
            LModifForma = new Label();
            LDescripcionForma = new Label();
            TDescForma = new TextBox();
            panel1 = new Panel();
            LIdFor = new TextBox();
            LIdForma = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label1 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            DTGListaFormas = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaFormas).BeginInit();
            SuspendLayout();
            // 
            // LModifForma
            // 
            LModifForma.AutoSize = true;
            LModifForma.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LModifForma.ForeColor = Color.White;
            LModifForma.Location = new Point(80, 120);
            LModifForma.Name = "LModifForma";
            LModifForma.Size = new Size(152, 26);
            LModifForma.TabIndex = 0;
            LModifForma.Text = "Modificar Forma";
            // 
            // LDescripcionForma
            // 
            LDescripcionForma.AutoSize = true;
            LDescripcionForma.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcionForma.ForeColor = Color.White;
            LDescripcionForma.Location = new Point(66, 244);
            LDescripcionForma.Name = "LDescripcionForma";
            LDescripcionForma.Size = new Size(180, 28);
            LDescripcionForma.TabIndex = 1;
            LDescripcionForma.Text = "Nombre de Forma:";
            // 
            // TDescForma
            // 
            TDescForma.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TDescForma.Location = new Point(83, 285);
            TDescForma.Name = "TDescForma";
            TDescForma.Size = new Size(135, 32);
            TDescForma.TabIndex = 2;
            TDescForma.TextChanged += TDescForma_TextChanged;
            TDescForma.KeyPress += TDescForma_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(LIdFor);
            panel1.Controls.Add(LIdForma);
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(TDescForma);
            panel1.Controls.Add(LDescripcionForma);
            panel1.Controls.Add(LModifForma);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 478);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // LIdFor
            // 
            LIdFor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LIdFor.Location = new Point(83, 209);
            LIdFor.Name = "LIdFor";
            LIdFor.ReadOnly = true;
            LIdFor.Size = new Size(135, 32);
            LIdFor.TabIndex = 13;
            LIdFor.TextChanged += LIdFor_TextChanged;
            LIdFor.KeyPress += LIdFor_KeyPress;
            // 
            // LIdForma
            // 
            LIdForma.AutoSize = true;
            LIdForma.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LIdForma.ForeColor = Color.White;
            LIdForma.Location = new Point(90, 163);
            LIdForma.Name = "LIdForma";
            LIdForma.Size = new Size(127, 28);
            LIdForma.TabIndex = 12;
            LIdForma.Text = "ID de Forma:";
            // 
            // IBResDatos
            // 
            IBResDatos.Anchor = AnchorStyles.None;
            IBResDatos.BackColor = Color.Transparent;
            IBResDatos.FlatStyle = FlatStyle.Flat;
            IBResDatos.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBResDatos.ForeColor = SystemColors.ControlText;
            IBResDatos.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            IBResDatos.IconColor = Color.White;
            IBResDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBResDatos.IconSize = 27;
            IBResDatos.Location = new Point(115, 324);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 11;
            IBResDatos.UseVisualStyleBackColor = false;
            IBResDatos.Click += IBResDatos_Click;
            // 
            // IBAgregarOS
            // 
            IBAgregarOS.Anchor = AnchorStyles.None;
            IBAgregarOS.BackColor = Color.Transparent;
            IBAgregarOS.FlatStyle = FlatStyle.Flat;
            IBAgregarOS.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarOS.ForeColor = SystemColors.ControlText;
            IBAgregarOS.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarOS.IconColor = Color.White;
            IBAgregarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarOS.IconSize = 27;
            IBAgregarOS.Location = new Point(156, 324);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 10;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconButton2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(298, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 58);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(354, 18);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 11;
            label1.Text = "Lista de Formas";
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.ForeColor = SystemColors.ControlText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton2.IconColor = Color.Purple;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 27;
            iconButton2.Location = new Point(597, 51);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(35, 35);
            iconButton2.TabIndex = 10;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // DTGListaFormas
            // 
            DTGListaFormas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaFormas.Dock = DockStyle.Fill;
            DTGListaFormas.Location = new Point(298, 58);
            DTGListaFormas.Name = "DTGListaFormas";
            DTGListaFormas.RowTemplate.Height = 25;
            DTGListaFormas.Size = new Size(889, 420);
            DTGListaFormas.TabIndex = 4;
            DTGListaFormas.CellContentClick += DTGListaFormas_CellContentClick;
            // 
            // Modif_forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 478);
            Controls.Add(DTGListaFormas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Modif_forma";
            Text = "Modif_forma";
            Load += Modif_forma_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaFormas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LModifForma;
        private Label LDescripcionForma;
        private TextBox TDescForma;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridView DTGListaFormas;
        private TextBox LIdFor;
        private Label LIdForma;
    }
}
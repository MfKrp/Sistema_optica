namespace CapaPresentacion.Secretaria.Estilos
{
    partial class Modif_estilo
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
            TDescEstilo = new TextBox();
            LDescripcionEstilo = new Label();
            LModifEstilo = new Label();
            panel1 = new Panel();
            TIdEstilo = new TextBox();
            LIdEstilo = new Label();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBModificarEstilo = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            LDTGEstilo = new Label();
            DTGListaEstilos = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaEstilos).BeginInit();
            SuspendLayout();
            // 
            // TDescEstilo
            // 
            TDescEstilo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TDescEstilo.Location = new Point(85, 285);
            TDescEstilo.Name = "TDescEstilo";
            TDescEstilo.Size = new Size(133, 32);
            TDescEstilo.TabIndex = 2;
            TDescEstilo.TextChanged += TDescEstilo_TextChanged;
            // 
            // LDescripcionEstilo
            // 
            LDescripcionEstilo.AutoSize = true;
            LDescripcionEstilo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcionEstilo.ForeColor = Color.White;
            LDescripcionEstilo.Location = new Point(61, 254);
            LDescripcionEstilo.Name = "LDescripcionEstilo";
            LDescripcionEstilo.Size = new Size(174, 28);
            LDescripcionEstilo.TabIndex = 1;
            LDescripcionEstilo.Text = "Nombre de Estilo:";
            // 
            // LModifEstilo
            // 
            LModifEstilo.AutoSize = true;
            LModifEstilo.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LModifEstilo.ForeColor = Color.White;
            LModifEstilo.Location = new Point(76, 122);
            LModifEstilo.Name = "LModifEstilo";
            LModifEstilo.Size = new Size(147, 26);
            LModifEstilo.TabIndex = 0;
            LModifEstilo.Text = "Modificar Estilo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(TIdEstilo);
            panel1.Controls.Add(LIdEstilo);
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBModificarEstilo);
            panel1.Controls.Add(TDescEstilo);
            panel1.Controls.Add(LDescripcionEstilo);
            panel1.Controls.Add(LModifEstilo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 477);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // TIdEstilo
            // 
            TIdEstilo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TIdEstilo.Location = new Point(85, 203);
            TIdEstilo.Name = "TIdEstilo";
            TIdEstilo.ReadOnly = true;
            TIdEstilo.Size = new Size(133, 32);
            TIdEstilo.TabIndex = 13;
            TIdEstilo.TextChanged += TIdEstilo_TextChanged;
            // 
            // LIdEstilo
            // 
            LIdEstilo.AutoSize = true;
            LIdEstilo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LIdEstilo.ForeColor = Color.White;
            LIdEstilo.Location = new Point(85, 160);
            LIdEstilo.Name = "LIdEstilo";
            LIdEstilo.Size = new Size(121, 28);
            LIdEstilo.TabIndex = 12;
            LIdEstilo.Text = "ID de Estilo:";
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
            IBResDatos.Location = new Point(117, 332);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 11;
            IBResDatos.UseVisualStyleBackColor = false;
            IBResDatos.Click += IBResDatos_Click;
            // 
            // IBModificarEstilo
            // 
            IBModificarEstilo.Anchor = AnchorStyles.None;
            IBModificarEstilo.BackColor = Color.Transparent;
            IBModificarEstilo.FlatStyle = FlatStyle.Flat;
            IBModificarEstilo.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBModificarEstilo.ForeColor = SystemColors.ControlText;
            IBModificarEstilo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBModificarEstilo.IconColor = Color.White;
            IBModificarEstilo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBModificarEstilo.IconSize = 27;
            IBModificarEstilo.Location = new Point(158, 332);
            IBModificarEstilo.Name = "IBModificarEstilo";
            IBModificarEstilo.Size = new Size(35, 35);
            IBModificarEstilo.TabIndex = 10;
            IBModificarEstilo.UseVisualStyleBackColor = false;
            IBModificarEstilo.Click += IBModificarEstilo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(LDTGEstilo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(298, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(889, 72);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // LDTGEstilo
            // 
            LDTGEstilo.AutoSize = true;
            LDTGEstilo.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LDTGEstilo.ForeColor = Color.White;
            LDTGEstilo.Location = new Point(368, 23);
            LDTGEstilo.Name = "LDTGEstilo";
            LDTGEstilo.Size = new Size(147, 26);
            LDTGEstilo.TabIndex = 1;
            LDTGEstilo.Text = "Modificar Estilo";
            // 
            // DTGListaEstilos
            // 
            DTGListaEstilos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaEstilos.Dock = DockStyle.Fill;
            DTGListaEstilos.Location = new Point(298, 72);
            DTGListaEstilos.Name = "DTGListaEstilos";
            DTGListaEstilos.RowTemplate.Height = 25;
            DTGListaEstilos.Size = new Size(889, 405);
            DTGListaEstilos.TabIndex = 5;
            DTGListaEstilos.CellContentClick += DTGListaEstilos_CellContentClick;
            // 
            // Modif_estilo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGListaEstilos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Modif_estilo";
            Text = "Modif_estilo";
            Load += Modif_estilo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaEstilos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TDescEstilo;
        private Label LDescripcionEstilo;
        private Label LModifEstilo;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBModificarEstilo;
        private Panel panel2;
        private Label LDTGEstilo;
        private DataGridView DTGListaEstilos;
        private TextBox TIdEstilo;
        private Label LIdEstilo;
    }
}
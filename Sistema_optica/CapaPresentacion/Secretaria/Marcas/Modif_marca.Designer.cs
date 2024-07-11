namespace CapaPresentacion.Secretaria.Marcas
{
    partial class Modif_marca
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
            panel1 = new Panel();
            DTGListaMarcas = new DataGridView();
            panel2 = new Panel();
            LListaMarcas = new Label();
            panel3 = new Panel();
            LIdMarca = new Label();
            TIdMarca = new TextBox();
            LModifMarca = new Label();
            LDescripcion = new Label();
            TDescMarca = new TextBox();
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarMarca = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaMarcas).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(DTGListaMarcas);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 477);
            panel1.TabIndex = 1;
            // 
            // DTGListaMarcas
            // 
            DTGListaMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaMarcas.Dock = DockStyle.Fill;
            DTGListaMarcas.Location = new Point(337, 55);
            DTGListaMarcas.Name = "DTGListaMarcas";
            DTGListaMarcas.RowTemplate.Height = 25;
            DTGListaMarcas.Size = new Size(850, 422);
            DTGListaMarcas.TabIndex = 12;
            DTGListaMarcas.CellContentClick += DTGListaMarcas_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(LListaMarcas);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(337, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 55);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // LListaMarcas
            // 
            LListaMarcas.AutoSize = true;
            LListaMarcas.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LListaMarcas.ForeColor = Color.White;
            LListaMarcas.Location = new Point(400, 9);
            LListaMarcas.Name = "LListaMarcas";
            LListaMarcas.Size = new Size(143, 26);
            LListaMarcas.TabIndex = 1;
            LListaMarcas.Text = "Lista de Marcas";
            // 
            // panel3
            // 
            panel3.Controls.Add(LIdMarca);
            panel3.Controls.Add(TIdMarca);
            panel3.Controls.Add(LModifMarca);
            panel3.Controls.Add(LDescripcion);
            panel3.Controls.Add(TDescMarca);
            panel3.Controls.Add(IBResDatos);
            panel3.Controls.Add(IBAgregarMarca);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 477);
            panel3.TabIndex = 14;
            panel3.Paint += panel3_Paint;
            // 
            // LIdMarca
            // 
            LIdMarca.AutoSize = true;
            LIdMarca.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LIdMarca.ForeColor = Color.White;
            LIdMarca.Location = new Point(84, 164);
            LIdMarca.Name = "LIdMarca";
            LIdMarca.Size = new Size(146, 28);
            LIdMarca.TabIndex = 12;
            LIdMarca.Text = "ID de la Marca:";
            // 
            // TIdMarca
            // 
            TIdMarca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TIdMarca.Location = new Point(78, 195);
            TIdMarca.Name = "TIdMarca";
            TIdMarca.ReadOnly = true;
            TIdMarca.Size = new Size(169, 32);
            TIdMarca.TabIndex = 13;
            TIdMarca.TextChanged += TIdMarca_TextChanged;
            // 
            // LModifMarca
            // 
            LModifMarca.AutoSize = true;
            LModifMarca.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LModifMarca.ForeColor = Color.White;
            LModifMarca.Location = new Point(84, 101);
            LModifMarca.Name = "LModifMarca";
            LModifMarca.Size = new Size(152, 26);
            LModifMarca.TabIndex = 0;
            LModifMarca.Text = "Modificar Marca";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LDescripcion.ForeColor = Color.White;
            LDescripcion.Location = new Point(78, 257);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(178, 28);
            LDescripcion.TabIndex = 1;
            LDescripcion.Text = "Nombre de Marca:";
            // 
            // TDescMarca
            // 
            TDescMarca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TDescMarca.Location = new Point(78, 288);
            TDescMarca.Name = "TDescMarca";
            TDescMarca.Size = new Size(169, 32);
            TDescMarca.TabIndex = 2;
            TDescMarca.TextChanged += TDescMarca_TextChanged;
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
            IBResDatos.Location = new Point(128, 339);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 11;
            IBResDatos.UseVisualStyleBackColor = false;
            IBResDatos.Click += IBResDatos_Click;
            // 
            // IBAgregarMarca
            // 
            IBAgregarMarca.Anchor = AnchorStyles.None;
            IBAgregarMarca.BackColor = Color.Transparent;
            IBAgregarMarca.FlatStyle = FlatStyle.Flat;
            IBAgregarMarca.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarMarca.ForeColor = SystemColors.ControlText;
            IBAgregarMarca.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarMarca.IconColor = Color.White;
            IBAgregarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarMarca.IconSize = 27;
            IBAgregarMarca.Location = new Point(169, 339);
            IBAgregarMarca.Name = "IBAgregarMarca";
            IBAgregarMarca.Size = new Size(35, 35);
            IBAgregarMarca.TabIndex = 10;
            IBAgregarMarca.UseVisualStyleBackColor = false;
            IBAgregarMarca.Click += IBAgregarOS_Click;
            // 
            // Modif_marca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(panel1);
            Name = "Modif_marca";
            Text = "Modif_marca";
            Load += Modif_marca_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGListaMarcas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TDescMarca;
        private Label LDescripcion;
        private Label LModifMarca;
        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarMarca;
        private Panel panel2;
        private Label LListaMarcas;
        private DataGridView DTGListaMarcas;
        private Panel panel3;
        private Label LIdMarca;
        private TextBox TIdMarca;
    }
}
namespace CapaPresentacion.Vendedor.Productos
{
    partial class Ver_productos_vendedor
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
            PVerProductos = new Panel();
            CBOpcionesProd = new ComboBox();
            LBuscar = new Label();
            TBuscarProd = new TextBox();
            LTProductos = new Label();
            DTGListaProductos = new DataGridView();
            PVerProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaProductos).BeginInit();
            SuspendLayout();
            // 
            // PVerProductos
            // 
            PVerProductos.BackColor = Color.Plum;
            PVerProductos.Controls.Add(CBOpcionesProd);
            PVerProductos.Controls.Add(LBuscar);
            PVerProductos.Controls.Add(TBuscarProd);
            PVerProductos.Controls.Add(LTProductos);
            PVerProductos.Dock = DockStyle.Top;
            PVerProductos.Location = new Point(0, 0);
            PVerProductos.Name = "PVerProductos";
            PVerProductos.Size = new Size(907, 83);
            PVerProductos.TabIndex = 88;
            PVerProductos.Paint += PVerProductos_Paint;
            // 
            // CBOpcionesProd
            // 
            CBOpcionesProd.AllowDrop = true;
            CBOpcionesProd.Anchor = AnchorStyles.None;
            CBOpcionesProd.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesProd.FormattingEnabled = true;
            CBOpcionesProd.Location = new Point(650, 33);
            CBOpcionesProd.Name = "CBOpcionesProd";
            CBOpcionesProd.Size = new Size(100, 23);
            CBOpcionesProd.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(481, 29);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(173, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Productos:";
            // 
            // TBuscarProd
            // 
            TBuscarProd.Anchor = AnchorStyles.None;
            TBuscarProd.Location = new Point(756, 33);
            TBuscarProd.Name = "TBuscarProd";
            TBuscarProd.Size = new Size(100, 23);
            TBuscarProd.TabIndex = 1;
            // 
            // LTProductos
            // 
            LTProductos.Anchor = AnchorStyles.None;
            LTProductos.AutoSize = true;
            LTProductos.BackColor = Color.Transparent;
            LTProductos.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LTProductos.ForeColor = Color.White;
            LTProductos.Location = new Point(31, 28);
            LTProductos.Name = "LTProductos";
            LTProductos.Size = new Size(186, 28);
            LTProductos.TabIndex = 0;
            LTProductos.Text = "Lista de Productos";
            // 
            // DTGListaProductos
            // 
            DTGListaProductos.AllowUserToAddRows = false;
            DTGListaProductos.AllowUserToResizeColumns = false;
            DTGListaProductos.AllowUserToResizeRows = false;
            DTGListaProductos.BackgroundColor = Color.Thistle;
            DTGListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaProductos.Dock = DockStyle.Fill;
            DTGListaProductos.Location = new Point(0, 83);
            DTGListaProductos.MultiSelect = false;
            DTGListaProductos.Name = "DTGListaProductos";
            DTGListaProductos.ReadOnly = true;
            DTGListaProductos.RowTemplate.Height = 25;
            DTGListaProductos.Size = new Size(907, 367);
            DTGListaProductos.TabIndex = 87;
            DTGListaProductos.CellContentClick += DTGListaProductos_CellContentClick;
            // 
            // Ver_productos_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(DTGListaProductos);
            Controls.Add(PVerProductos);
            Name = "Ver_productos_vendedor";
            Text = "Lista de Productos";
            Load += Ver_productos_vendedor_Load;
            PVerProductos.ResumeLayout(false);
            PVerProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerProductos;
        private ComboBox CBOpcionesProd;
        private Label LBuscar;
        private TextBox TBuscarProd;
        private Label LTProductos;
        private DataGridView DTGListaProductos;
    }
}
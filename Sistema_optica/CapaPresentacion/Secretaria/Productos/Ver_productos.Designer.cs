namespace CapaPresentacion.Secretaria
{
    partial class Ver_productosSuper
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
            LVerOtros = new Label();
            CBOpcionVistaPro = new ComboBox();
            panel1 = new Panel();
            IBRehabilitarProd = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBEliminarProdc = new FontAwesome.Sharp.IconButton();
            IBAgregarProducto = new FontAwesome.Sharp.IconButton();
            CBOpcionesProd = new ComboBox();
            LBuscar = new Label();
            TBuscarProd = new TextBox();
            LTProductos = new Label();
            DTGListaProductos = new DataGridView();
            PVerProductos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaProductos).BeginInit();
            SuspendLayout();
            // 
            // PVerProductos
            // 
            PVerProductos.BackColor = Color.FromArgb(0, 175, 176);
            PVerProductos.Controls.Add(LVerOtros);
            PVerProductos.Controls.Add(CBOpcionVistaPro);
            PVerProductos.Controls.Add(panel1);
            PVerProductos.Controls.Add(CBOpcionesProd);
            PVerProductos.Controls.Add(LBuscar);
            PVerProductos.Controls.Add(TBuscarProd);
            PVerProductos.Controls.Add(LTProductos);
            PVerProductos.Dock = DockStyle.Top;
            PVerProductos.Location = new Point(0, 0);
            PVerProductos.Name = "PVerProductos";
            PVerProductos.Size = new Size(939, 88);
            PVerProductos.TabIndex = 84;
            PVerProductos.Paint += PVerProductos_Paint;
            // 
            // LVerOtros
            // 
            LVerOtros.Anchor = AnchorStyles.None;
            LVerOtros.AutoSize = true;
            LVerOtros.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LVerOtros.ForeColor = Color.White;
            LVerOtros.Location = new Point(559, 12);
            LVerOtros.Name = "LVerOtros";
            LVerOtros.Size = new Size(94, 26);
            LVerOtros.TabIndex = 12;
            LVerOtros.Text = "Ver otros:";
            // 
            // CBOpcionVistaPro
            // 
            CBOpcionVistaPro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionVistaPro.FormattingEnabled = true;
            CBOpcionVistaPro.Items.AddRange(new object[] { "Cristales", "Estilos", "Formas", "Marcas", "Obras Sociales", "Anteojos" });
            CBOpcionVistaPro.Location = new Point(676, 15);
            CBOpcionVistaPro.Name = "CBOpcionVistaPro";
            CBOpcionVistaPro.Size = new Size(121, 23);
            CBOpcionVistaPro.TabIndex = 11;
            CBOpcionVistaPro.SelectedIndexChanged += CBOpcionVistaPro_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(IBRehabilitarProd);
            panel1.Controls.Add(IBEditar);
            panel1.Controls.Add(IBEliminarProdc);
            panel1.Controls.Add(IBAgregarProducto);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(856, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(83, 88);
            panel1.TabIndex = 10;
            // 
            // IBRehabilitarProd
            // 
            IBRehabilitarProd.FlatStyle = FlatStyle.Flat;
            IBRehabilitarProd.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBRehabilitarProd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            IBRehabilitarProd.IconColor = Color.Crimson;
            IBRehabilitarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBRehabilitarProd.IconSize = 20;
            IBRehabilitarProd.Location = new Point(3, 3);
            IBRehabilitarProd.Name = "IBRehabilitarProd";
            IBRehabilitarProd.Size = new Size(35, 35);
            IBRehabilitarProd.TabIndex = 9;
            IBRehabilitarProd.UseVisualStyleBackColor = true;
            // 
            // IBEditar
            // 
            IBEditar.BackColor = Color.Transparent;
            IBEditar.FlatStyle = FlatStyle.Flat;
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.MediumSlateBlue;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(44, 3);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(35, 35);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = false;
            // 
            // IBEliminarProdc
            // 
            IBEliminarProdc.Anchor = AnchorStyles.None;
            IBEliminarProdc.FlatStyle = FlatStyle.Flat;
            IBEliminarProdc.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarProdc.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarProdc.IconColor = Color.Red;
            IBEliminarProdc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarProdc.IconSize = 20;
            IBEliminarProdc.Location = new Point(44, 48);
            IBEliminarProdc.Name = "IBEliminarProdc";
            IBEliminarProdc.Size = new Size(35, 35);
            IBEliminarProdc.TabIndex = 8;
            IBEliminarProdc.UseVisualStyleBackColor = true;
            // 
            // IBAgregarProducto
            // 
            IBAgregarProducto.Anchor = AnchorStyles.None;
            IBAgregarProducto.FlatStyle = FlatStyle.Flat;
            IBAgregarProducto.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarProducto.IconColor = Color.Purple;
            IBAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarProducto.IconSize = 20;
            IBAgregarProducto.Location = new Point(3, 48);
            IBAgregarProducto.Name = "IBAgregarProducto";
            IBAgregarProducto.Size = new Size(35, 35);
            IBAgregarProducto.TabIndex = 7;
            IBAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // CBOpcionesProd
            // 
            CBOpcionesProd.AllowDrop = true;
            CBOpcionesProd.Anchor = AnchorStyles.None;
            CBOpcionesProd.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesProd.FormattingEnabled = true;
            CBOpcionesProd.Location = new Point(626, 48);
            CBOpcionesProd.Name = "CBOpcionesProd";
            CBOpcionesProd.Size = new Size(100, 23);
            CBOpcionesProd.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(457, 45);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(163, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Productos:";
            // 
            // TBuscarProd
            // 
            TBuscarProd.Anchor = AnchorStyles.None;
            TBuscarProd.Location = new Point(732, 48);
            TBuscarProd.Name = "TBuscarProd";
            TBuscarProd.Size = new Size(100, 23);
            TBuscarProd.TabIndex = 1;
            // 
            // LTProductos
            // 
            LTProductos.Anchor = AnchorStyles.None;
            LTProductos.AutoSize = true;
            LTProductos.BackColor = Color.Transparent;
            LTProductos.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LTProductos.ForeColor = Color.White;
            LTProductos.Location = new Point(25, 30);
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
            DTGListaProductos.BackgroundColor = Color.FromArgb(0, 220, 176);
            DTGListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaProductos.Dock = DockStyle.Fill;
            DTGListaProductos.Location = new Point(0, 88);
            DTGListaProductos.MultiSelect = false;
            DTGListaProductos.Name = "DTGListaProductos";
            DTGListaProductos.ReadOnly = true;
            DTGListaProductos.RowTemplate.Height = 25;
            DTGListaProductos.Size = new Size(939, 353);
            DTGListaProductos.TabIndex = 83;
            DTGListaProductos.CellContentClick += DTGListaProductos_CellContentClick;
            // 
            // Ver_productosSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(DTGListaProductos);
            Controls.Add(PVerProductos);
            Name = "Ver_productosSuper";
            Text = "Visualizar Productos";
            Load += Ver_productosSuper_Load;
            PVerProductos.ResumeLayout(false);
            PVerProductos.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGListaProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel PVerProductos;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBRehabilitarProd;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBEliminarProdc;
        private FontAwesome.Sharp.IconButton IBAgregarProducto;
        private ComboBox CBOpcionesProd;
        private Label LBuscar;
        private TextBox TBuscarProd;
        private Label LTProductos;
        private DataGridView DTGListaProductos;
        private Label LVerOtros;
        private ComboBox CBOpcionVistaPro;
    }
}
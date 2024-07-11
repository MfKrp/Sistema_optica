namespace CapaPresentacion.Secretaria.Obra_social
{
    partial class Ver_obras_sociales
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
            PVerObrasSociales = new Panel();
            panel1 = new Panel();
            IBRehabilitarCliente = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBAgregarCliente = new FontAwesome.Sharp.IconButton();
            IBEliminarCliente = new FontAwesome.Sharp.IconButton();
            CBOpcionesOS = new ComboBox();
            LBuscar = new Label();
            TBuscarOS = new TextBox();
            LTObrasSociales = new Label();
            DTGVObrasSociales = new DataGridView();
            PVerObrasSociales.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVObrasSociales).BeginInit();
            SuspendLayout();
            // 
            // PVerObrasSociales
            // 
            PVerObrasSociales.BackColor = Color.Plum;
            PVerObrasSociales.Controls.Add(panel1);
            PVerObrasSociales.Controls.Add(CBOpcionesOS);
            PVerObrasSociales.Controls.Add(LBuscar);
            PVerObrasSociales.Controls.Add(TBuscarOS);
            PVerObrasSociales.Controls.Add(LTObrasSociales);
            PVerObrasSociales.Dock = DockStyle.Top;
            PVerObrasSociales.Location = new Point(0, 0);
            PVerObrasSociales.Name = "PVerObrasSociales";
            PVerObrasSociales.Size = new Size(1187, 101);
            PVerObrasSociales.TabIndex = 11;
            PVerObrasSociales.Paint += PVerObrasSociales_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(IBRehabilitarCliente);
            panel1.Controls.Add(IBEditar);
            panel1.Controls.Add(IBAgregarCliente);
            panel1.Controls.Add(IBEliminarCliente);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1092, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 101);
            panel1.TabIndex = 14;
            // 
            // IBRehabilitarCliente
            // 
            IBRehabilitarCliente.Anchor = AnchorStyles.None;
            IBRehabilitarCliente.FlatStyle = FlatStyle.Flat;
            IBRehabilitarCliente.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBRehabilitarCliente.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            IBRehabilitarCliente.IconColor = Color.White;
            IBRehabilitarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBRehabilitarCliente.IconSize = 20;
            IBRehabilitarCliente.Location = new Point(3, 3);
            IBRehabilitarCliente.Name = "IBRehabilitarCliente";
            IBRehabilitarCliente.Size = new Size(35, 35);
            IBRehabilitarCliente.TabIndex = 9;
            IBRehabilitarCliente.UseVisualStyleBackColor = true;
            // 
            // IBEditar
            // 
            IBEditar.BackColor = Color.Transparent;
            IBEditar.FlatStyle = FlatStyle.Flat;
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.White;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(57, 3);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(35, 35);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = false;
            // 
            // IBAgregarCliente
            // 
            IBAgregarCliente.Anchor = AnchorStyles.None;
            IBAgregarCliente.FlatStyle = FlatStyle.Flat;
            IBAgregarCliente.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarCliente.IconColor = Color.White;
            IBAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarCliente.IconSize = 20;
            IBAgregarCliente.Location = new Point(3, 63);
            IBAgregarCliente.Name = "IBAgregarCliente";
            IBAgregarCliente.Size = new Size(35, 35);
            IBAgregarCliente.TabIndex = 7;
            IBAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // IBEliminarCliente
            // 
            IBEliminarCliente.Anchor = AnchorStyles.None;
            IBEliminarCliente.FlatStyle = FlatStyle.Flat;
            IBEliminarCliente.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarCliente.IconColor = Color.White;
            IBEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarCliente.IconSize = 20;
            IBEliminarCliente.Location = new Point(57, 63);
            IBEliminarCliente.Name = "IBEliminarCliente";
            IBEliminarCliente.Size = new Size(35, 35);
            IBEliminarCliente.TabIndex = 8;
            IBEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // CBOpcionesOS
            // 
            CBOpcionesOS.AllowDrop = true;
            CBOpcionesOS.Anchor = AnchorStyles.None;
            CBOpcionesOS.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesOS.FormattingEnabled = true;
            CBOpcionesOS.Location = new Point(626, 44);
            CBOpcionesOS.Name = "CBOpcionesOS";
            CBOpcionesOS.Size = new Size(76, 23);
            CBOpcionesOS.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(442, 40);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(103, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar OS:";
            // 
            // TBuscarOS
            // 
            TBuscarOS.Anchor = AnchorStyles.None;
            TBuscarOS.Location = new Point(551, 44);
            TBuscarOS.Name = "TBuscarOS";
            TBuscarOS.Size = new Size(69, 23);
            TBuscarOS.TabIndex = 1;
            // 
            // LTObrasSociales
            // 
            LTObrasSociales.Anchor = AnchorStyles.None;
            LTObrasSociales.AutoSize = true;
            LTObrasSociales.BackColor = Color.Transparent;
            LTObrasSociales.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LTObrasSociales.ForeColor = Color.White;
            LTObrasSociales.Location = new Point(44, 38);
            LTObrasSociales.Name = "LTObrasSociales";
            LTObrasSociales.Size = new Size(229, 28);
            LTObrasSociales.TabIndex = 0;
            LTObrasSociales.Text = "Lista de Obras Sociales";
            // 
            // DTGVObrasSociales
            // 
            DTGVObrasSociales.BackgroundColor = Color.Thistle;
            DTGVObrasSociales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVObrasSociales.Dock = DockStyle.Fill;
            DTGVObrasSociales.Location = new Point(0, 101);
            DTGVObrasSociales.Name = "DTGVObrasSociales";
            DTGVObrasSociales.RowTemplate.Height = 25;
            DTGVObrasSociales.Size = new Size(1187, 376);
            DTGVObrasSociales.TabIndex = 10;
            DTGVObrasSociales.CellContentClick += DTGVObrasSociales_CellContentClick;
            // 
            // Ver_obras_sociales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGVObrasSociales);
            Controls.Add(PVerObrasSociales);
            Name = "Ver_obras_sociales";
            Text = "Ver_obras_sociales";
            Load += Ver_obras_sociales_Load;
            PVerObrasSociales.ResumeLayout(false);
            PVerObrasSociales.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGVObrasSociales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerObrasSociales;
        private ComboBox CBOpcionesOS;
        private Label LBuscar;
        private TextBox TBuscarOS;
        private Label LTObrasSociales;
        private DataGridView DTGVObrasSociales;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBRehabilitarCliente;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBAgregarCliente;
        private FontAwesome.Sharp.IconButton IBEliminarCliente;
    }
}
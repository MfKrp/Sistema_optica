namespace CapaPresentacion.Secretaria
{
    partial class Ver_clientes
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
            DTGListaClientes = new DataGridView();
            PVerClientes = new Panel();
            panel1 = new Panel();
            IBRehabilitarCliente = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBEliminarCliente = new FontAwesome.Sharp.IconButton();
            IBAgregarCliente = new FontAwesome.Sharp.IconButton();
            CBOpcionesClientes = new ComboBox();
            LBuscar = new Label();
            TBuscarCliente = new TextBox();
            LTClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).BeginInit();
            PVerClientes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DTGListaClientes
            // 
            DTGListaClientes.AllowUserToAddRows = false;
            DTGListaClientes.AllowUserToResizeColumns = false;
            DTGListaClientes.AllowUserToResizeRows = false;
            DTGListaClientes.BackgroundColor = Color.FromArgb(0, 220, 176);
            DTGListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaClientes.Dock = DockStyle.Fill;
            DTGListaClientes.Location = new Point(0, 101);
            DTGListaClientes.MultiSelect = false;
            DTGListaClientes.Name = "DTGListaClientes";
            DTGListaClientes.ReadOnly = true;
            DTGListaClientes.RowTemplate.Height = 25;
            DTGListaClientes.Size = new Size(1187, 376);
            DTGListaClientes.TabIndex = 0;
            DTGListaClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PVerClientes
            // 
            PVerClientes.BackColor = Color.FromArgb(0, 175, 176);
            PVerClientes.BorderStyle = BorderStyle.FixedSingle;
            PVerClientes.Controls.Add(panel1);
            PVerClientes.Controls.Add(CBOpcionesClientes);
            PVerClientes.Controls.Add(LBuscar);
            PVerClientes.Controls.Add(TBuscarCliente);
            PVerClientes.Controls.Add(LTClientes);
            PVerClientes.Dock = DockStyle.Top;
            PVerClientes.Location = new Point(0, 0);
            PVerClientes.Name = "PVerClientes";
            PVerClientes.Size = new Size(1187, 101);
            PVerClientes.TabIndex = 82;
            // 
            // panel1
            // 
            panel1.Controls.Add(IBRehabilitarCliente);
            panel1.Controls.Add(IBEditar);
            panel1.Controls.Add(IBEliminarCliente);
            panel1.Controls.Add(IBAgregarCliente);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1090, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 99);
            panel1.TabIndex = 10;
            // 
            // IBRehabilitarCliente
            // 
            IBRehabilitarCliente.Anchor = AnchorStyles.None;
            IBRehabilitarCliente.FlatStyle = FlatStyle.Flat;
            IBRehabilitarCliente.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBRehabilitarCliente.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            IBRehabilitarCliente.IconColor = Color.Crimson;
            IBRehabilitarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBRehabilitarCliente.IconSize = 20;
            IBRehabilitarCliente.Location = new Point(3, 5);
            IBRehabilitarCliente.Name = "IBRehabilitarCliente";
            IBRehabilitarCliente.Size = new Size(35, 35);
            IBRehabilitarCliente.TabIndex = 9;
            IBRehabilitarCliente.UseVisualStyleBackColor = true;
            IBRehabilitarCliente.Click += IBRehabilitarCliente_Click;
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
            IBEditar.Location = new Point(57, 3);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(35, 35);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = false;
            IBEditar.Click += IBEditar_Click;
            // 
            // IBEliminarCliente
            // 
            IBEliminarCliente.Anchor = AnchorStyles.None;
            IBEliminarCliente.FlatStyle = FlatStyle.Flat;
            IBEliminarCliente.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarCliente.IconColor = Color.Red;
            IBEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarCliente.IconSize = 20;
            IBEliminarCliente.Location = new Point(57, 59);
            IBEliminarCliente.Name = "IBEliminarCliente";
            IBEliminarCliente.Size = new Size(35, 35);
            IBEliminarCliente.TabIndex = 8;
            IBEliminarCliente.UseVisualStyleBackColor = true;
            IBEliminarCliente.Click += IBEliminarCliente_Click;
            // 
            // IBAgregarCliente
            // 
            IBAgregarCliente.Anchor = AnchorStyles.None;
            IBAgregarCliente.FlatStyle = FlatStyle.Flat;
            IBAgregarCliente.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarCliente.IconColor = Color.Purple;
            IBAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarCliente.IconSize = 20;
            IBAgregarCliente.Location = new Point(3, 59);
            IBAgregarCliente.Name = "IBAgregarCliente";
            IBAgregarCliente.Size = new Size(35, 35);
            IBAgregarCliente.TabIndex = 7;
            IBAgregarCliente.UseVisualStyleBackColor = true;
            IBAgregarCliente.Click += IBAgregarCliente_Click;
            // 
            // CBOpcionesClientes
            // 
            CBOpcionesClientes.AllowDrop = true;
            CBOpcionesClientes.Anchor = AnchorStyles.None;
            CBOpcionesClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesClientes.FormattingEnabled = true;
            CBOpcionesClientes.Location = new Point(616, 39);
            CBOpcionesClientes.Name = "CBOpcionesClientes";
            CBOpcionesClientes.Size = new Size(100, 23);
            CBOpcionesClientes.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(471, 38);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(139, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Cliente:";
            // 
            // TBuscarCliente
            // 
            TBuscarCliente.Anchor = AnchorStyles.None;
            TBuscarCliente.Location = new Point(722, 39);
            TBuscarCliente.Name = "TBuscarCliente";
            TBuscarCliente.Size = new Size(100, 23);
            TBuscarCliente.TabIndex = 1;
            // 
            // LTClientes
            // 
            LTClientes.Anchor = AnchorStyles.None;
            LTClientes.AutoSize = true;
            LTClientes.BackColor = Color.Transparent;
            LTClientes.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LTClientes.ForeColor = Color.White;
            LTClientes.Location = new Point(48, 39);
            LTClientes.Name = "LTClientes";
            LTClientes.Size = new Size(168, 28);
            LTClientes.TabIndex = 0;
            LTClientes.Text = "Lista de Clientes";
            // 
            // Ver_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGListaClientes);
            Controls.Add(PVerClientes);
            Name = "Ver_clientes";
            Text = "Lista de Clientes";
            Load += Ver_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).EndInit();
            PVerClientes.ResumeLayout(false);
            PVerClientes.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DTGListaClientes;
        private Panel PVerClientes;
        private FontAwesome.Sharp.IconButton IBEliminarCliente;
        private FontAwesome.Sharp.IconButton IBAgregarCliente;
        private FontAwesome.Sharp.IconButton IBEditar;
        private ComboBox CBOpcionesClientes;
        private Label LBuscar;
        private TextBox TBuscarCliente;
        private Label LTClientes;
        private FontAwesome.Sharp.IconButton IBRehabilitarCliente;
        private Panel panel1;
    }
}
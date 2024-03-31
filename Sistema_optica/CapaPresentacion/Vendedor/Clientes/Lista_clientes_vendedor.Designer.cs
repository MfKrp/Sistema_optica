namespace CapaPresentacion.Vendedor
{
    partial class Lista_clientes_vendedor
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
            LListaClientes = new Label();
            panel2 = new Panel();
            IBRehabilitarCliente = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBAgregarCliente = new FontAwesome.Sharp.IconButton();
            IBEliminarCliente = new FontAwesome.Sharp.IconButton();
            PListaClientes = new Panel();
            TBuscarCliente = new TextBox();
            CBOpCl = new ComboBox();
            LBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).BeginInit();
            panel2.SuspendLayout();
            PListaClientes.SuspendLayout();
            SuspendLayout();
            // 
            // DTGListaClientes
            // 
            DTGListaClientes.AllowUserToAddRows = false;
            DTGListaClientes.AllowUserToDeleteRows = false;
            DTGListaClientes.AllowUserToResizeColumns = false;
            DTGListaClientes.AllowUserToResizeRows = false;
            DTGListaClientes.BackgroundColor = Color.Thistle;
            DTGListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaClientes.Dock = DockStyle.Fill;
            DTGListaClientes.Location = new Point(0, 83);
            DTGListaClientes.MultiSelect = false;
            DTGListaClientes.Name = "DTGListaClientes";
            DTGListaClientes.ReadOnly = true;
            DTGListaClientes.RowTemplate.Height = 25;
            DTGListaClientes.Size = new Size(877, 358);
            DTGListaClientes.TabIndex = 1;
            DTGListaClientes.CellContentClick += dataGridView1_CellContentClick;
            DTGListaClientes.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // LListaClientes
            // 
            LListaClientes.Anchor = AnchorStyles.None;
            LListaClientes.AutoSize = true;
            LListaClientes.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LListaClientes.ForeColor = Color.White;
            LListaClientes.Location = new Point(36, 29);
            LListaClientes.Name = "LListaClientes";
            LListaClientes.Size = new Size(175, 28);
            LListaClientes.TabIndex = 0;
            LListaClientes.Text = "Lista de Clientes:";
            // 
            // panel2
            // 
            panel2.Controls.Add(IBRehabilitarCliente);
            panel2.Controls.Add(IBEditar);
            panel2.Controls.Add(IBAgregarCliente);
            panel2.Controls.Add(IBEliminarCliente);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(794, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(83, 83);
            panel2.TabIndex = 4;
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
            IBRehabilitarCliente.Location = new Point(3, 3);
            IBRehabilitarCliente.Name = "IBRehabilitarCliente";
            IBRehabilitarCliente.Size = new Size(35, 35);
            IBRehabilitarCliente.TabIndex = 13;
            IBRehabilitarCliente.UseVisualStyleBackColor = true;
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
            IBEditar.TabIndex = 10;
            IBEditar.UseVisualStyleBackColor = false;
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
            IBAgregarCliente.Location = new Point(3, 47);
            IBAgregarCliente.Name = "IBAgregarCliente";
            IBAgregarCliente.Size = new Size(35, 35);
            IBAgregarCliente.TabIndex = 11;
            IBAgregarCliente.UseVisualStyleBackColor = true;
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
            IBEliminarCliente.Location = new Point(44, 47);
            IBEliminarCliente.Name = "IBEliminarCliente";
            IBEliminarCliente.Size = new Size(35, 35);
            IBEliminarCliente.TabIndex = 12;
            IBEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // PListaClientes
            // 
            PListaClientes.BackColor = Color.Plum;
            PListaClientes.Controls.Add(panel2);
            PListaClientes.Controls.Add(TBuscarCliente);
            PListaClientes.Controls.Add(CBOpCl);
            PListaClientes.Controls.Add(LBuscar);
            PListaClientes.Controls.Add(LListaClientes);
            PListaClientes.Dock = DockStyle.Top;
            PListaClientes.Location = new Point(0, 0);
            PListaClientes.Name = "PListaClientes";
            PListaClientes.Size = new Size(877, 83);
            PListaClientes.TabIndex = 0;
            PListaClientes.Paint += PListaClientes_Paint;
            // 
            // TBuscarCliente
            // 
            TBuscarCliente.Anchor = AnchorStyles.None;
            TBuscarCliente.Location = new Point(689, 34);
            TBuscarCliente.Name = "TBuscarCliente";
            TBuscarCliente.Size = new Size(73, 23);
            TBuscarCliente.TabIndex = 3;
            TBuscarCliente.TextChanged += textBox1_TextChanged;
            // 
            // CBOpCl
            // 
            CBOpCl.Anchor = AnchorStyles.None;
            CBOpCl.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpCl.FormattingEnabled = true;
            CBOpCl.Items.AddRange(new object[] { "DNI", "Nombre" });
            CBOpCl.Location = new Point(594, 34);
            CBOpCl.Name = "CBOpCl";
            CBOpCl.Size = new Size(89, 23);
            CBOpCl.TabIndex = 2;
            CBOpCl.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(406, 30);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(182, 26);
            LBuscar.TabIndex = 1;
            LBuscar.Text = "Buscar Cliente por:";
            // 
            // Lista_clientes_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 441);
            Controls.Add(DTGListaClientes);
            Controls.Add(PListaClientes);
            Name = "Lista_clientes_vendedor";
            Text = "Lista de Clientes";
            Load += Lista_clientes_vendedor_Load;
            ((System.ComponentModel.ISupportInitialize)DTGListaClientes).EndInit();
            panel2.ResumeLayout(false);
            PListaClientes.ResumeLayout(false);
            PListaClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DTGListaClientes;
        private Label LListaClientes;
        private Panel panel2;
        private Panel PListaClientes;
        private TextBox TBuscarCliente;
        private ComboBox CBOpCl;
        private Label LBuscar;
        private FontAwesome.Sharp.IconButton IBRehabilitarCliente;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBAgregarCliente;
        private FontAwesome.Sharp.IconButton IBEliminarCliente;
        private Button BBuscar;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button BBorrar;
    }
}
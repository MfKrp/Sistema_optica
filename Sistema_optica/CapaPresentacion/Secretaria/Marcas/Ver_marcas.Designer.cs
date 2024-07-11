namespace CapaPresentacion.Secretaria
{
    partial class Ver_marcas
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
            DTGVMarcas = new DataGridView();
            PVerMarcas = new Panel();
            panel1 = new Panel();
            IBRehabilitarCliente = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBEliminarCliente = new FontAwesome.Sharp.IconButton();
            IBAgregarCliente = new FontAwesome.Sharp.IconButton();
            CBOpciones = new ComboBox();
            LBuscar = new Label();
            textBox1 = new TextBox();
            LTMarcas = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGVMarcas).BeginInit();
            PVerMarcas.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DTGVMarcas
            // 
            DTGVMarcas.BackgroundColor = Color.Thistle;
            DTGVMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVMarcas.Dock = DockStyle.Fill;
            DTGVMarcas.Location = new Point(0, 101);
            DTGVMarcas.Name = "DTGVMarcas";
            DTGVMarcas.RowTemplate.Height = 25;
            DTGVMarcas.Size = new Size(1187, 376);
            DTGVMarcas.TabIndex = 2;
            DTGVMarcas.CellContentClick += DTGVMarcas_CellContentClick;
            // 
            // PVerMarcas
            // 
            PVerMarcas.BackColor = Color.Plum;
            PVerMarcas.Controls.Add(panel1);
            PVerMarcas.Controls.Add(CBOpciones);
            PVerMarcas.Controls.Add(LBuscar);
            PVerMarcas.Controls.Add(textBox1);
            PVerMarcas.Controls.Add(LTMarcas);
            PVerMarcas.Dock = DockStyle.Top;
            PVerMarcas.Location = new Point(0, 0);
            PVerMarcas.Name = "PVerMarcas";
            PVerMarcas.Size = new Size(1187, 101);
            PVerMarcas.TabIndex = 3;
            PVerMarcas.Paint += PVerMarcas_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(IBRehabilitarCliente);
            panel1.Controls.Add(IBEditar);
            panel1.Controls.Add(IBEliminarCliente);
            panel1.Controls.Add(IBAgregarCliente);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1092, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 101);
            panel1.TabIndex = 13;
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
            // CBOpciones
            // 
            CBOpciones.AllowDrop = true;
            CBOpciones.Anchor = AnchorStyles.None;
            CBOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpciones.FormattingEnabled = true;
            CBOpciones.Location = new Point(626, 44);
            CBOpciones.Name = "CBOpciones";
            CBOpciones.Size = new Size(81, 23);
            CBOpciones.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(407, 40);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(133, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Marca:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(546, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 1;
            // 
            // LTMarcas
            // 
            LTMarcas.Anchor = AnchorStyles.None;
            LTMarcas.AutoSize = true;
            LTMarcas.BackColor = Color.Transparent;
            LTMarcas.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LTMarcas.ForeColor = Color.White;
            LTMarcas.Location = new Point(33, 37);
            LTMarcas.Name = "LTMarcas";
            LTMarcas.Size = new Size(160, 28);
            LTMarcas.TabIndex = 0;
            LTMarcas.Text = "Lista de Marcas";
            // 
            // Ver_marcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGVMarcas);
            Controls.Add(PVerMarcas);
            Name = "Ver_marcas";
            Text = "Ver_marcas";
            Load += Ver_marcas_Load;
            ((System.ComponentModel.ISupportInitialize)DTGVMarcas).EndInit();
            PVerMarcas.ResumeLayout(false);
            PVerMarcas.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DTGVMarcas;
        private Panel PVerMarcas;
        private Label LTMarcas;
        private Label LBuscar;
        private TextBox textBox1;
        private ComboBox CBOpciones;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBRehabilitarCliente;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBEliminarCliente;
        private FontAwesome.Sharp.IconButton IBAgregarCliente;
    }
}
namespace CapaPresentacion.Secretaria.Estilos
{
    partial class Ver_estilos
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
            PVerEstilos = new Panel();
            panel1 = new Panel();
            IBRehabilitarCliente = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBEliminarCliente = new FontAwesome.Sharp.IconButton();
            IBAgregarCliente = new FontAwesome.Sharp.IconButton();
            CBOpcionesEstilos = new ComboBox();
            LBuscar = new Label();
            TBuscarEstilo = new TextBox();
            LTEstilos = new Label();
            DTGVEstilos = new DataGridView();
            PVerEstilos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVEstilos).BeginInit();
            SuspendLayout();
            // 
            // PVerEstilos
            // 
            PVerEstilos.BackColor = Color.Plum;
            PVerEstilos.Controls.Add(panel1);
            PVerEstilos.Controls.Add(CBOpcionesEstilos);
            PVerEstilos.Controls.Add(LBuscar);
            PVerEstilos.Controls.Add(TBuscarEstilo);
            PVerEstilos.Controls.Add(LTEstilos);
            PVerEstilos.Dock = DockStyle.Top;
            PVerEstilos.Location = new Point(0, 0);
            PVerEstilos.Name = "PVerEstilos";
            PVerEstilos.Size = new Size(1190, 101);
            PVerEstilos.TabIndex = 7;
            PVerEstilos.Paint += PVerEstilos_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(IBRehabilitarCliente);
            panel1.Controls.Add(IBEditar);
            panel1.Controls.Add(IBEliminarCliente);
            panel1.Controls.Add(IBAgregarCliente);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1095, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 101);
            panel1.TabIndex = 11;
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
            // CBOpcionesEstilos
            // 
            CBOpcionesEstilos.AllowDrop = true;
            CBOpcionesEstilos.Anchor = AnchorStyles.None;
            CBOpcionesEstilos.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesEstilos.FormattingEnabled = true;
            CBOpcionesEstilos.Location = new Point(625, 46);
            CBOpcionesEstilos.Name = "CBOpcionesEstilos";
            CBOpcionesEstilos.Size = new Size(76, 23);
            CBOpcionesEstilos.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(500, 43);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(128, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Estilo:";
            // 
            // TBuscarEstilo
            // 
            TBuscarEstilo.Anchor = AnchorStyles.None;
            TBuscarEstilo.Location = new Point(707, 47);
            TBuscarEstilo.Name = "TBuscarEstilo";
            TBuscarEstilo.Size = new Size(69, 23);
            TBuscarEstilo.TabIndex = 1;
            // 
            // LTEstilos
            // 
            LTEstilos.Anchor = AnchorStyles.None;
            LTEstilos.AutoSize = true;
            LTEstilos.BackColor = Color.Transparent;
            LTEstilos.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LTEstilos.ForeColor = Color.White;
            LTEstilos.Location = new Point(45, 38);
            LTEstilos.Name = "LTEstilos";
            LTEstilos.Size = new Size(158, 28);
            LTEstilos.TabIndex = 0;
            LTEstilos.Text = "Lista de Estilos";
            // 
            // DTGVEstilos
            // 
            DTGVEstilos.BackgroundColor = Color.Thistle;
            DTGVEstilos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVEstilos.Dock = DockStyle.Fill;
            DTGVEstilos.Location = new Point(0, 101);
            DTGVEstilos.Name = "DTGVEstilos";
            DTGVEstilos.RowTemplate.Height = 25;
            DTGVEstilos.Size = new Size(1190, 376);
            DTGVEstilos.TabIndex = 6;
            DTGVEstilos.CellContentClick += DTGVEstilos_CellContentClick;
            // 
            // Ver_estilos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 477);
            Controls.Add(DTGVEstilos);
            Controls.Add(PVerEstilos);
            Name = "Ver_estilos";
            Text = "Ver_estilos";
            Load += Ver_estilos_Load;
            PVerEstilos.ResumeLayout(false);
            PVerEstilos.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGVEstilos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerEstilos;
        private ComboBox CBOpcionesEstilos;
        private Label LBuscar;
        private TextBox TBuscarEstilo;
        private Label LTEstilos;
        private DataGridView DTGVEstilos;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBRehabilitarCliente;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBEliminarCliente;
        private FontAwesome.Sharp.IconButton IBAgregarCliente;
    }
}
namespace CapaPresentacion.Secretaria
{
    partial class Ver_cristales
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
            PVerCristales = new Panel();
            PBEdicionClientes = new Panel();
            IBRehabilitarCliente = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBEliminarCliente = new FontAwesome.Sharp.IconButton();
            IBAgregarCliente = new FontAwesome.Sharp.IconButton();
            CBOpcionesCristales = new ComboBox();
            LBuscar = new Label();
            TBuscarCristal = new TextBox();
            LTCristales = new Label();
            DTGVCristales = new DataGridView();
            PVerCristales.SuspendLayout();
            PBEdicionClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVCristales).BeginInit();
            SuspendLayout();
            // 
            // PVerCristales
            // 
            PVerCristales.BackColor = Color.Plum;
            PVerCristales.Controls.Add(PBEdicionClientes);
            PVerCristales.Controls.Add(CBOpcionesCristales);
            PVerCristales.Controls.Add(LBuscar);
            PVerCristales.Controls.Add(TBuscarCristal);
            PVerCristales.Controls.Add(LTCristales);
            PVerCristales.Dock = DockStyle.Top;
            PVerCristales.Location = new Point(0, 0);
            PVerCristales.Name = "PVerCristales";
            PVerCristales.Size = new Size(1187, 101);
            PVerCristales.TabIndex = 9;
            PVerCristales.Paint += PVerCristales_Paint;
            // 
            // PBEdicionClientes
            // 
            PBEdicionClientes.Controls.Add(IBRehabilitarCliente);
            PBEdicionClientes.Controls.Add(IBEditar);
            PBEdicionClientes.Controls.Add(IBEliminarCliente);
            PBEdicionClientes.Controls.Add(IBAgregarCliente);
            PBEdicionClientes.Dock = DockStyle.Right;
            PBEdicionClientes.Location = new Point(1092, 0);
            PBEdicionClientes.Name = "PBEdicionClientes";
            PBEdicionClientes.Size = new Size(95, 101);
            PBEdicionClientes.TabIndex = 11;
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
            // CBOpcionesCristales
            // 
            CBOpcionesCristales.AllowDrop = true;
            CBOpcionesCristales.Anchor = AnchorStyles.None;
            CBOpcionesCristales.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesCristales.FormattingEnabled = true;
            CBOpcionesCristales.Location = new Point(634, 43);
            CBOpcionesCristales.Name = "CBOpcionesCristales";
            CBOpcionesCristales.Size = new Size(76, 23);
            CBOpcionesCristales.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(502, 39);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(136, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Cristal:";
            // 
            // TBuscarCristal
            // 
            TBuscarCristal.Anchor = AnchorStyles.None;
            TBuscarCristal.Location = new Point(716, 43);
            TBuscarCristal.Name = "TBuscarCristal";
            TBuscarCristal.Size = new Size(81, 23);
            TBuscarCristal.TabIndex = 1;
            // 
            // LTCristales
            // 
            LTCristales.Anchor = AnchorStyles.None;
            LTCristales.AutoSize = true;
            LTCristales.BackColor = Color.Transparent;
            LTCristales.Font = new Font("Sitka Text", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LTCristales.ForeColor = Color.White;
            LTCristales.Location = new Point(44, 38);
            LTCristales.Name = "LTCristales";
            LTCristales.Size = new Size(163, 26);
            LTCristales.TabIndex = 0;
            LTCristales.Text = "Lista de Cristales";
            // 
            // DTGVCristales
            // 
            DTGVCristales.BackgroundColor = Color.Thistle;
            DTGVCristales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVCristales.Dock = DockStyle.Fill;
            DTGVCristales.Location = new Point(0, 101);
            DTGVCristales.Name = "DTGVCristales";
            DTGVCristales.RowTemplate.Height = 25;
            DTGVCristales.Size = new Size(1187, 376);
            DTGVCristales.TabIndex = 8;
            DTGVCristales.CellContentClick += DTGVCristales_CellContentClick;
            // 
            // Ver_cristales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 477);
            Controls.Add(DTGVCristales);
            Controls.Add(PVerCristales);
            Name = "Ver_cristales";
            Text = "Cristales";
            Load += Ver_cristales_Load;
            PVerCristales.ResumeLayout(false);
            PVerCristales.PerformLayout();
            PBEdicionClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGVCristales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerCristales;
        private ComboBox CBOpcionesCristales;
        private Label LBuscar;
        private TextBox TBuscarCristal;
        private Label LTCristales;
        private DataGridView DTGVCristales;
        private Panel PBEdicionClientes;
        private FontAwesome.Sharp.IconButton IBRehabilitarCliente;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBEliminarCliente;
        private FontAwesome.Sharp.IconButton IBAgregarCliente;
    }
}
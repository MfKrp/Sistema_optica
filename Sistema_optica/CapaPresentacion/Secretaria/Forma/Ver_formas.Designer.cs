﻿namespace CapaPresentacion.Secretaria.Forma
{
    partial class Ver_formas
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
            PVerMarcas = new Panel();
            panel1 = new Panel();
            IBRehabilitarCliente = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBEliminarCliente = new FontAwesome.Sharp.IconButton();
            IBAgregarCliente = new FontAwesome.Sharp.IconButton();
            CBOpcionesFormas = new ComboBox();
            LBuscar = new Label();
            TBuscarForma = new TextBox();
            LTFormas = new Label();
            DTGVFormas = new DataGridView();
            PVerMarcas.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVFormas).BeginInit();
            SuspendLayout();
            // 
            // PVerMarcas
            // 
            PVerMarcas.BackColor = Color.Plum;
            PVerMarcas.Controls.Add(panel1);
            PVerMarcas.Controls.Add(CBOpcionesFormas);
            PVerMarcas.Controls.Add(LBuscar);
            PVerMarcas.Controls.Add(TBuscarForma);
            PVerMarcas.Controls.Add(LTFormas);
            PVerMarcas.Dock = DockStyle.Top;
            PVerMarcas.Location = new Point(0, 0);
            PVerMarcas.Name = "PVerMarcas";
            PVerMarcas.Size = new Size(1191, 101);
            PVerMarcas.TabIndex = 5;
            PVerMarcas.Paint += PVerMarcas_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(IBRehabilitarCliente);
            panel1.Controls.Add(IBEditar);
            panel1.Controls.Add(IBEliminarCliente);
            panel1.Controls.Add(IBAgregarCliente);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1096, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(95, 101);
            panel1.TabIndex = 12;
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
            IBEliminarCliente.Location = new Point(60, 63);
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
            // CBOpcionesFormas
            // 
            CBOpcionesFormas.AllowDrop = true;
            CBOpcionesFormas.Anchor = AnchorStyles.None;
            CBOpcionesFormas.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesFormas.FormattingEnabled = true;
            CBOpcionesFormas.Location = new Point(702, 43);
            CBOpcionesFormas.Name = "CBOpcionesFormas";
            CBOpcionesFormas.Size = new Size(81, 23);
            CBOpcionesFormas.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(483, 39);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(133, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Forma:";
            // 
            // TBuscarForma
            // 
            TBuscarForma.Anchor = AnchorStyles.None;
            TBuscarForma.Location = new Point(622, 43);
            TBuscarForma.Name = "TBuscarForma";
            TBuscarForma.Size = new Size(74, 23);
            TBuscarForma.TabIndex = 1;
            // 
            // LTFormas
            // 
            LTFormas.Anchor = AnchorStyles.None;
            LTFormas.AutoSize = true;
            LTFormas.BackColor = Color.Transparent;
            LTFormas.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LTFormas.ForeColor = Color.White;
            LTFormas.Location = new Point(33, 37);
            LTFormas.Name = "LTFormas";
            LTFormas.Size = new Size(162, 28);
            LTFormas.TabIndex = 0;
            LTFormas.Text = "Lista de Formas";
            // 
            // DTGVFormas
            // 
            DTGVFormas.BackgroundColor = Color.Thistle;
            DTGVFormas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVFormas.Dock = DockStyle.Fill;
            DTGVFormas.Location = new Point(0, 101);
            DTGVFormas.Name = "DTGVFormas";
            DTGVFormas.RowTemplate.Height = 25;
            DTGVFormas.Size = new Size(1191, 376);
            DTGVFormas.TabIndex = 4;
            DTGVFormas.CellContentClick += DTGVFormas_CellContentClick;
            // 
            // Ver_formas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 477);
            Controls.Add(DTGVFormas);
            Controls.Add(PVerMarcas);
            Name = "Ver_formas";
            Text = "Ver_formas";
            Load += Ver_formas_Load;
            PVerMarcas.ResumeLayout(false);
            PVerMarcas.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGVFormas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerMarcas;
        private ComboBox CBOpcionesFormas;
        private Label LBuscar;
        private TextBox TBuscarForma;
        private Label LTFormas;
        private DataGridView DTGVFormas;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBRehabilitarCliente;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBEliminarCliente;
        private FontAwesome.Sharp.IconButton IBAgregarCliente;
    }
}
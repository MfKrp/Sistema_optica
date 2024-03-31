namespace CapaPresentacion.Secretaria.Forma
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
            IBEditar = new FontAwesome.Sharp.IconButton();
            CBOpcionesFormas = new ComboBox();
            LBuscar = new Label();
            TBuscarForma = new TextBox();
            LTFormas = new Label();
            DTGVFormas = new DataGridView();
            IBEliminarForma = new FontAwesome.Sharp.IconButton();
            IBAgregarForma = new FontAwesome.Sharp.IconButton();
            PVerMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVFormas).BeginInit();
            SuspendLayout();
            // 
            // PVerMarcas
            // 
            PVerMarcas.Anchor = AnchorStyles.None;
            PVerMarcas.BackColor = Color.Plum;
            PVerMarcas.Controls.Add(IBEliminarForma);
            PVerMarcas.Controls.Add(IBAgregarForma);
            PVerMarcas.Controls.Add(IBEditar);
            PVerMarcas.Controls.Add(CBOpcionesFormas);
            PVerMarcas.Controls.Add(LBuscar);
            PVerMarcas.Controls.Add(TBuscarForma);
            PVerMarcas.Controls.Add(LTFormas);
            PVerMarcas.Location = new Point(12, 11);
            PVerMarcas.Name = "PVerMarcas";
            PVerMarcas.Size = new Size(594, 83);
            PVerMarcas.TabIndex = 5;
            // 
            // IBEditar
            // 
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.Black;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(482, 36);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(32, 23);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = true;
            // 
            // CBOpcionesFormas
            // 
            CBOpcionesFormas.AllowDrop = true;
            CBOpcionesFormas.Anchor = AnchorStyles.None;
            CBOpcionesFormas.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesFormas.FormattingEnabled = true;
            CBOpcionesFormas.Location = new Point(316, 36);
            CBOpcionesFormas.Name = "CBOpcionesFormas";
            CBOpcionesFormas.Size = new Size(81, 23);
            CBOpcionesFormas.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.Location = new Point(204, 36);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(106, 20);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Forma:";
            // 
            // TBuscarForma
            // 
            TBuscarForma.Location = new Point(402, 36);
            TBuscarForma.Name = "TBuscarForma";
            TBuscarForma.Size = new Size(74, 23);
            TBuscarForma.TabIndex = 1;
            // 
            // LTFormas
            // 
            LTFormas.Anchor = AnchorStyles.None;
            LTFormas.AutoSize = true;
            LTFormas.BackColor = Color.Transparent;
            LTFormas.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LTFormas.ForeColor = Color.Black;
            LTFormas.Location = new Point(13, 31);
            LTFormas.Name = "LTFormas";
            LTFormas.Size = new Size(162, 28);
            LTFormas.TabIndex = 0;
            LTFormas.Text = "Lista de Formas";
            // 
            // DTGVFormas
            // 
            DTGVFormas.BackgroundColor = Color.Thistle;
            DTGVFormas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVFormas.Location = new Point(12, 100);
            DTGVFormas.Name = "DTGVFormas";
            DTGVFormas.RowTemplate.Height = 25;
            DTGVFormas.Size = new Size(594, 339);
            DTGVFormas.TabIndex = 4;
            // 
            // IBEliminarForma
            // 
            IBEliminarForma.Anchor = AnchorStyles.None;
            IBEliminarForma.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarForma.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarForma.IconColor = Color.Black;
            IBEliminarForma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarForma.IconSize = 20;
            IBEliminarForma.Location = new Point(556, 36);
            IBEliminarForma.Name = "IBEliminarForma";
            IBEliminarForma.Size = new Size(29, 23);
            IBEliminarForma.TabIndex = 8;
            IBEliminarForma.UseVisualStyleBackColor = true;
            // 
            // IBAgregarForma
            // 
            IBAgregarForma.Anchor = AnchorStyles.None;
            IBAgregarForma.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarForma.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarForma.IconColor = Color.Black;
            IBAgregarForma.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarForma.IconSize = 20;
            IBAgregarForma.Location = new Point(520, 36);
            IBAgregarForma.Name = "IBAgregarForma";
            IBAgregarForma.Size = new Size(30, 23);
            IBAgregarForma.TabIndex = 7;
            IBAgregarForma.UseVisualStyleBackColor = true;
            // 
            // Ver_formas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(PVerMarcas);
            Controls.Add(DTGVFormas);
            Name = "Ver_formas";
            Text = "Ver_formas";
            PVerMarcas.ResumeLayout(false);
            PVerMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVFormas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerMarcas;
        private FontAwesome.Sharp.IconButton IBEditar;
        private ComboBox CBOpcionesFormas;
        private Label LBuscar;
        private TextBox TBuscarForma;
        private Label LTFormas;
        private DataGridView DTGVFormas;
        private FontAwesome.Sharp.IconButton IBEliminarForma;
        private FontAwesome.Sharp.IconButton IBAgregarForma;
    }
}
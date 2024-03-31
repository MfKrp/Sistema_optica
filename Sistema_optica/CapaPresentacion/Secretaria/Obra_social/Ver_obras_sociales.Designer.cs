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
            IBEliminarOS = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            CBOpcionesOS = new ComboBox();
            LBuscar = new Label();
            TBuscarOS = new TextBox();
            LTObrasSociales = new Label();
            DTGVObrasSociales = new DataGridView();
            PVerObrasSociales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVObrasSociales).BeginInit();
            SuspendLayout();
            // 
            // PVerObrasSociales
            // 
            PVerObrasSociales.Anchor = AnchorStyles.None;
            PVerObrasSociales.BackColor = Color.Plum;
            PVerObrasSociales.Controls.Add(IBEliminarOS);
            PVerObrasSociales.Controls.Add(IBAgregarOS);
            PVerObrasSociales.Controls.Add(IBEditar);
            PVerObrasSociales.Controls.Add(CBOpcionesOS);
            PVerObrasSociales.Controls.Add(LBuscar);
            PVerObrasSociales.Controls.Add(TBuscarOS);
            PVerObrasSociales.Controls.Add(LTObrasSociales);
            PVerObrasSociales.Location = new Point(12, 12);
            PVerObrasSociales.Name = "PVerObrasSociales";
            PVerObrasSociales.Size = new Size(619, 83);
            PVerObrasSociales.TabIndex = 11;
            // 
            // IBEliminarOS
            // 
            IBEliminarOS.Anchor = AnchorStyles.None;
            IBEliminarOS.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarOS.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarOS.IconColor = Color.Black;
            IBEliminarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarOS.IconSize = 20;
            IBEliminarOS.Location = new Point(582, 36);
            IBEliminarOS.Name = "IBEliminarOS";
            IBEliminarOS.Size = new Size(24, 24);
            IBEliminarOS.TabIndex = 8;
            IBEliminarOS.UseVisualStyleBackColor = true;
            // 
            // IBAgregarOS
            // 
            IBAgregarOS.Anchor = AnchorStyles.None;
            IBAgregarOS.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarOS.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarOS.IconColor = Color.Black;
            IBAgregarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarOS.IconSize = 20;
            IBAgregarOS.Location = new Point(551, 36);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(25, 24);
            IBAgregarOS.TabIndex = 7;
            IBAgregarOS.UseVisualStyleBackColor = true;
            // 
            // IBEditar
            // 
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.Black;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(518, 36);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(27, 24);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = true;
            // 
            // CBOpcionesOS
            // 
            CBOpcionesOS.AllowDrop = true;
            CBOpcionesOS.Anchor = AnchorStyles.None;
            CBOpcionesOS.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesOS.FormattingEnabled = true;
            CBOpcionesOS.Location = new Point(364, 36);
            CBOpcionesOS.Name = "CBOpcionesOS";
            CBOpcionesOS.Size = new Size(76, 23);
            CBOpcionesOS.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.Location = new Point(277, 36);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(81, 20);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar OS:";
            // 
            // TBuscarOS
            // 
            TBuscarOS.Location = new Point(446, 36);
            TBuscarOS.Name = "TBuscarOS";
            TBuscarOS.Size = new Size(69, 23);
            TBuscarOS.TabIndex = 1;
            // 
            // LTObrasSociales
            // 
            LTObrasSociales.Anchor = AnchorStyles.None;
            LTObrasSociales.AutoSize = true;
            LTObrasSociales.BackColor = Color.Transparent;
            LTObrasSociales.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LTObrasSociales.ForeColor = Color.Black;
            LTObrasSociales.Location = new Point(16, 31);
            LTObrasSociales.Name = "LTObrasSociales";
            LTObrasSociales.Size = new Size(229, 28);
            LTObrasSociales.TabIndex = 0;
            LTObrasSociales.Text = "Lista de Obras Sociales";
            // 
            // DTGVObrasSociales
            // 
            DTGVObrasSociales.BackgroundColor = Color.Thistle;
            DTGVObrasSociales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVObrasSociales.Location = new Point(12, 101);
            DTGVObrasSociales.Name = "DTGVObrasSociales";
            DTGVObrasSociales.RowTemplate.Height = 25;
            DTGVObrasSociales.Size = new Size(619, 339);
            DTGVObrasSociales.TabIndex = 10;
            // 
            // Ver_obras_sociales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 450);
            Controls.Add(PVerObrasSociales);
            Controls.Add(DTGVObrasSociales);
            Name = "Ver_obras_sociales";
            Text = "Ver_obras_sociales";
            PVerObrasSociales.ResumeLayout(false);
            PVerObrasSociales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVObrasSociales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerObrasSociales;
        private FontAwesome.Sharp.IconButton IBEliminarOS;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private FontAwesome.Sharp.IconButton IBEditar;
        private ComboBox CBOpcionesOS;
        private Label LBuscar;
        private TextBox TBuscarOS;
        private Label LTObrasSociales;
        private DataGridView DTGVObrasSociales;
    }
}
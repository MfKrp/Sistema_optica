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
            IBEliminarEstilo = new FontAwesome.Sharp.IconButton();
            IBAgregarEstilo = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            CBOpcionesEstilos = new ComboBox();
            LBuscar = new Label();
            TBuscarEstilo = new TextBox();
            LTEstilos = new Label();
            DTGVEstilos = new DataGridView();
            PVerEstilos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVEstilos).BeginInit();
            SuspendLayout();
            // 
            // PVerEstilos
            // 
            PVerEstilos.Anchor = AnchorStyles.None;
            PVerEstilos.BackColor = Color.Plum;
            PVerEstilos.Controls.Add(IBEliminarEstilo);
            PVerEstilos.Controls.Add(IBAgregarEstilo);
            PVerEstilos.Controls.Add(IBEditar);
            PVerEstilos.Controls.Add(CBOpcionesEstilos);
            PVerEstilos.Controls.Add(LBuscar);
            PVerEstilos.Controls.Add(TBuscarEstilo);
            PVerEstilos.Controls.Add(LTEstilos);
            PVerEstilos.Location = new Point(14, 12);
            PVerEstilos.Name = "PVerEstilos";
            PVerEstilos.Size = new Size(589, 83);
            PVerEstilos.TabIndex = 7;
            // 
            // IBEliminarEstilo
            // 
            IBEliminarEstilo.Anchor = AnchorStyles.None;
            IBEliminarEstilo.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarEstilo.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarEstilo.IconColor = Color.Black;
            IBEliminarEstilo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarEstilo.IconSize = 20;
            IBEliminarEstilo.Location = new Point(536, 36);
            IBEliminarEstilo.Name = "IBEliminarEstilo";
            IBEliminarEstilo.Size = new Size(24, 24);
            IBEliminarEstilo.TabIndex = 8;
            IBEliminarEstilo.UseVisualStyleBackColor = true;
            // 
            // IBAgregarEstilo
            // 
            IBAgregarEstilo.Anchor = AnchorStyles.None;
            IBAgregarEstilo.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarEstilo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarEstilo.IconColor = Color.Black;
            IBAgregarEstilo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarEstilo.IconSize = 20;
            IBAgregarEstilo.Location = new Point(505, 36);
            IBAgregarEstilo.Name = "IBAgregarEstilo";
            IBAgregarEstilo.Size = new Size(25, 24);
            IBAgregarEstilo.TabIndex = 7;
            IBAgregarEstilo.UseVisualStyleBackColor = true;
            // 
            // IBEditar
            // 
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.Black;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(472, 36);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(27, 24);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = true;
            // 
            // CBOpcionesEstilos
            // 
            CBOpcionesEstilos.AllowDrop = true;
            CBOpcionesEstilos.Anchor = AnchorStyles.None;
            CBOpcionesEstilos.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesEstilos.FormattingEnabled = true;
            CBOpcionesEstilos.Location = new Point(315, 36);
            CBOpcionesEstilos.Name = "CBOpcionesEstilos";
            CBOpcionesEstilos.Size = new Size(76, 23);
            CBOpcionesEstilos.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.Location = new Point(203, 36);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(101, 20);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Estilo:";
            // 
            // TBuscarEstilo
            // 
            TBuscarEstilo.Location = new Point(397, 36);
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
            LTEstilos.ForeColor = Color.Black;
            LTEstilos.Location = new Point(17, 29);
            LTEstilos.Name = "LTEstilos";
            LTEstilos.Size = new Size(158, 28);
            LTEstilos.TabIndex = 0;
            LTEstilos.Text = "Lista de Estilos";
            // 
            // DTGVEstilos
            // 
            DTGVEstilos.BackgroundColor = Color.Thistle;
            DTGVEstilos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVEstilos.Location = new Point(12, 101);
            DTGVEstilos.Name = "DTGVEstilos";
            DTGVEstilos.RowTemplate.Height = 25;
            DTGVEstilos.Size = new Size(589, 339);
            DTGVEstilos.TabIndex = 6;
            // 
            // Ver_estilos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(PVerEstilos);
            Controls.Add(DTGVEstilos);
            Name = "Ver_estilos";
            Text = "Ver_estilos";
            PVerEstilos.ResumeLayout(false);
            PVerEstilos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVEstilos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerEstilos;
        private FontAwesome.Sharp.IconButton IBEliminarEstilo;
        private FontAwesome.Sharp.IconButton IBAgregarEstilo;
        private FontAwesome.Sharp.IconButton IBEditar;
        private ComboBox CBOpcionesEstilos;
        private Label LBuscar;
        private TextBox TBuscarEstilo;
        private Label LTEstilos;
        private DataGridView DTGVEstilos;
    }
}
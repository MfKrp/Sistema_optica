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
            IBAgregar = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            CBOpciones = new ComboBox();
            LBuscar = new Label();
            textBox1 = new TextBox();
            LTMarcas = new Label();
            IBEliminarMarca = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DTGVMarcas).BeginInit();
            PVerMarcas.SuspendLayout();
            SuspendLayout();
            // 
            // DTGVMarcas
            // 
            DTGVMarcas.BackgroundColor = Color.Thistle;
            DTGVMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVMarcas.Location = new Point(12, 99);
            DTGVMarcas.Name = "DTGVMarcas";
            DTGVMarcas.RowTemplate.Height = 25;
            DTGVMarcas.Size = new Size(545, 339);
            DTGVMarcas.TabIndex = 2;
            // 
            // PVerMarcas
            // 
            PVerMarcas.Anchor = AnchorStyles.None;
            PVerMarcas.BackColor = Color.Plum;
            PVerMarcas.Controls.Add(IBEliminarMarca);
            PVerMarcas.Controls.Add(IBAgregar);
            PVerMarcas.Controls.Add(IBEditar);
            PVerMarcas.Controls.Add(CBOpciones);
            PVerMarcas.Controls.Add(LBuscar);
            PVerMarcas.Controls.Add(textBox1);
            PVerMarcas.Controls.Add(LTMarcas);
            PVerMarcas.Location = new Point(12, 10);
            PVerMarcas.Name = "PVerMarcas";
            PVerMarcas.Size = new Size(545, 83);
            PVerMarcas.TabIndex = 3;
            // 
            // IBAgregar
            // 
            IBAgregar.Anchor = AnchorStyles.None;
            IBAgregar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregar.IconColor = Color.Black;
            IBAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregar.IconSize = 20;
            IBAgregar.Location = new Point(482, 32);
            IBAgregar.Name = "IBAgregar";
            IBAgregar.Size = new Size(30, 25);
            IBAgregar.TabIndex = 5;
            IBAgregar.UseVisualStyleBackColor = true;
            // 
            // IBEditar
            // 
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.Black;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(450, 32);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(32, 25);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = true;
            // 
            // CBOpciones
            // 
            CBOpciones.AllowDrop = true;
            CBOpciones.Anchor = AnchorStyles.None;
            CBOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpciones.FormattingEnabled = true;
            CBOpciones.Location = new Point(288, 33);
            CBOpciones.Name = "CBOpciones";
            CBOpciones.Size = new Size(81, 23);
            CBOpciones.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.Location = new Point(186, 32);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(105, 20);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Marca:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 1;
            // 
            // LTMarcas
            // 
            LTMarcas.Anchor = AnchorStyles.None;
            LTMarcas.AutoSize = true;
            LTMarcas.BackColor = Color.Transparent;
            LTMarcas.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LTMarcas.ForeColor = Color.Black;
            LTMarcas.Location = new Point(12, 28);
            LTMarcas.Name = "LTMarcas";
            LTMarcas.Size = new Size(160, 28);
            LTMarcas.TabIndex = 0;
            LTMarcas.Text = "Lista de Marcas";
            // 
            // IBEliminarMarca
            // 
            IBEliminarMarca.Anchor = AnchorStyles.None;
            IBEliminarMarca.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarMarca.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarMarca.IconColor = Color.Black;
            IBEliminarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarMarca.IconSize = 20;
            IBEliminarMarca.Location = new Point(513, 32);
            IBEliminarMarca.Name = "IBEliminarMarca";
            IBEliminarMarca.Size = new Size(29, 25);
            IBEliminarMarca.TabIndex = 6;
            IBEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // Ver_marcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(PVerMarcas);
            Controls.Add(DTGVMarcas);
            Name = "Ver_marcas";
            Text = "Ver_marcas";
            ((System.ComponentModel.ISupportInitialize)DTGVMarcas).EndInit();
            PVerMarcas.ResumeLayout(false);
            PVerMarcas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DTGVMarcas;
        private Panel PVerMarcas;
        private Label LTMarcas;
        private Label LBuscar;
        private TextBox textBox1;
        private ComboBox CBOpciones;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBAgregar;
        private FontAwesome.Sharp.IconButton IBEliminarMarca;
    }
}
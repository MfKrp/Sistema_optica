namespace CapaPresentacion.Superadmin
{
    partial class Ver_productos
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
            label2 = new Label();
            DGV_ListaProd = new DataGridView();
            LBuscar = new Label();
            TBuscar = new TextBox();
            CId = new DataGridViewTextBoxColumn();
            DGVButtonEliminar = new DataGridViewTextBoxColumn();
            DGVButton = new DataGridViewTextBoxColumn();
            CTipo = new DataGridViewTextBoxColumn();
            CMarca = new DataGridViewTextBoxColumn();
            CEstilo = new DataGridViewTextBoxColumn();
            CColor = new DataGridViewTextBoxColumn();
            CGenero = new DataGridViewTextBoxColumn();
            CTalle = new DataGridViewTextBoxColumn();
            CPrecio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV_ListaProd).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(360, 31);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
            label2.TabIndex = 76;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // DGV_ListaProd
            // 
            DGV_ListaProd.Anchor = AnchorStyles.None;
            DGV_ListaProd.BackgroundColor = Color.CadetBlue;
            DGV_ListaProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ListaProd.Columns.AddRange(new DataGridViewColumn[] { CId, DGVButtonEliminar, DGVButton, CTipo, CMarca, CEstilo, CColor, CGenero, CTalle, CPrecio });
            DGV_ListaProd.Location = new Point(26, 77);
            DGV_ListaProd.Name = "DGV_ListaProd";
            DGV_ListaProd.RowTemplate.Height = 25;
            DGV_ListaProd.Size = new Size(882, 337);
            DGV_ListaProd.TabIndex = 77;
            // 
            // LBuscar
            // 
            LBuscar.AutoSize = true;
            LBuscar.Location = new Point(25, 41);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(42, 15);
            LBuscar.TabIndex = 80;
            LBuscar.Text = "Buscar";
            // 
            // TBuscar
            // 
            TBuscar.Location = new Point(85, 38);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(100, 23);
            TBuscar.TabIndex = 79;
            // 
            // CId
            // 
            CId.HeaderText = "ID";
            CId.Name = "CId";
            // 
            // DGVButtonEliminar
            // 
            DGVButtonEliminar.HeaderText = "Eliminar";
            DGVButtonEliminar.Name = "DGVButtonEliminar";
            // 
            // DGVButton
            // 
            DGVButton.HeaderText = "Modificar";
            DGVButton.Name = "DGVButton";
            // 
            // CTipo
            // 
            CTipo.HeaderText = "Tipo";
            CTipo.Name = "CTipo";
            // 
            // CMarca
            // 
            CMarca.HeaderText = "Marca";
            CMarca.Name = "CMarca";
            // 
            // CEstilo
            // 
            CEstilo.HeaderText = "Estilo";
            CEstilo.Name = "CEstilo";
            // 
            // CColor
            // 
            CColor.HeaderText = "Color";
            CColor.Name = "CColor";
            // 
            // CGenero
            // 
            CGenero.HeaderText = "Genero";
            CGenero.Name = "CGenero";
            // 
            // CTalle
            // 
            CTalle.HeaderText = "Talle";
            CTalle.Name = "CTalle";
            // 
            // CPrecio
            // 
            CPrecio.HeaderText = "Precio";
            CPrecio.Name = "CPrecio";
            // 
            // Ver_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(LBuscar);
            Controls.Add(TBuscar);
            Controls.Add(DGV_ListaProd);
            Controls.Add(label2);
            Name = "Ver_productos";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_ListaProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView DGV_ListaProd;
        private Label LBuscar;
        private TextBox TBuscar;
        private DataGridViewTextBoxColumn CId;
        private DataGridViewTextBoxColumn DGVButtonEliminar;
        private DataGridViewTextBoxColumn DGVButton;
        private DataGridViewTextBoxColumn CTipo;
        private DataGridViewTextBoxColumn CMarca;
        private DataGridViewTextBoxColumn CEstilo;
        private DataGridViewTextBoxColumn CColor;
        private DataGridViewTextBoxColumn CGenero;
        private DataGridViewTextBoxColumn CTalle;
        private DataGridViewTextBoxColumn CPrecio;
    }
}
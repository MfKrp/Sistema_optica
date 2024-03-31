namespace CapaPresentacion.Vendedor
{
    partial class Ver_ventas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            LVentasPersonales = new Label();
            DTGVentasPersonales = new DataGridView();
            PVentasRealizadas = new Panel();
            IBVerDetalle = new FontAwesome.Sharp.IconButton();
            TBuscarVenta = new TextBox();
            CBOpVenta = new ComboBox();
            LBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGVentasPersonales).BeginInit();
            PVentasRealizadas.SuspendLayout();
            SuspendLayout();
            // 
            // LVentasPersonales
            // 
            LVentasPersonales.Anchor = AnchorStyles.None;
            LVentasPersonales.AutoSize = true;
            LVentasPersonales.BackColor = Color.Transparent;
            LVentasPersonales.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LVentasPersonales.ForeColor = Color.White;
            LVentasPersonales.Location = new Point(22, 35);
            LVentasPersonales.Name = "LVentasPersonales";
            LVentasPersonales.Size = new Size(369, 28);
            LVentasPersonales.TabIndex = 75;
            LVentasPersonales.Text = "Lista de Ventas Personales Realizadas";
            // 
            // DTGVentasPersonales
            // 
            DTGVentasPersonales.AllowUserToAddRows = false;
            DTGVentasPersonales.AllowUserToDeleteRows = false;
            DTGVentasPersonales.AllowUserToResizeColumns = false;
            DTGVentasPersonales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            DTGVentasPersonales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DTGVentasPersonales.BackgroundColor = Color.Thistle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DTGVentasPersonales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DTGVentasPersonales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVentasPersonales.Dock = DockStyle.Fill;
            DTGVentasPersonales.Location = new Point(0, 96);
            DTGVentasPersonales.Name = "DTGVentasPersonales";
            DTGVentasPersonales.ReadOnly = true;
            DTGVentasPersonales.RowTemplate.Height = 25;
            DTGVentasPersonales.Size = new Size(939, 345);
            DTGVentasPersonales.TabIndex = 76;
            DTGVentasPersonales.CellContentClick += DTGDatosCompra_CellContentClick;
            // 
            // PVentasRealizadas
            // 
            PVentasRealizadas.BackColor = Color.Plum;
            PVentasRealizadas.Controls.Add(IBVerDetalle);
            PVentasRealizadas.Controls.Add(TBuscarVenta);
            PVentasRealizadas.Controls.Add(CBOpVenta);
            PVentasRealizadas.Controls.Add(LBuscar);
            PVentasRealizadas.Controls.Add(LVentasPersonales);
            PVentasRealizadas.Dock = DockStyle.Top;
            PVentasRealizadas.Location = new Point(0, 0);
            PVentasRealizadas.Name = "PVentasRealizadas";
            PVentasRealizadas.Size = new Size(939, 96);
            PVentasRealizadas.TabIndex = 77;
            PVentasRealizadas.Paint += PVentasRealizadas_Paint;
            // 
            // IBVerDetalle
            // 
            IBVerDetalle.Anchor = AnchorStyles.None;
            IBVerDetalle.BackColor = Color.DarkOrchid;
            IBVerDetalle.FlatAppearance.BorderSize = 0;
            IBVerDetalle.FlatStyle = FlatStyle.Flat;
            IBVerDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IBVerDetalle.ForeColor = Color.White;
            IBVerDetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            IBVerDetalle.IconColor = Color.Black;
            IBVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBVerDetalle.Location = new Point(847, 40);
            IBVerDetalle.Name = "IBVerDetalle";
            IBVerDetalle.Size = new Size(75, 23);
            IBVerDetalle.TabIndex = 80;
            IBVerDetalle.Text = "Ver Detalle";
            IBVerDetalle.UseVisualStyleBackColor = false;
            IBVerDetalle.Click += IBVerDetalle_Click;
            // 
            // TBuscarVenta
            // 
            TBuscarVenta.Anchor = AnchorStyles.None;
            TBuscarVenta.Location = new Point(736, 40);
            TBuscarVenta.Name = "TBuscarVenta";
            TBuscarVenta.Size = new Size(106, 23);
            TBuscarVenta.TabIndex = 79;
            // 
            // CBOpVenta
            // 
            CBOpVenta.Anchor = AnchorStyles.None;
            CBOpVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpVenta.FormattingEnabled = true;
            CBOpVenta.Location = new Point(635, 40);
            CBOpVenta.Name = "CBOpVenta";
            CBOpVenta.Size = new Size(95, 23);
            CBOpVenta.TabIndex = 78;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.BackColor = Color.Transparent;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(495, 36);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(134, 26);
            LBuscar.TabIndex = 77;
            LBuscar.Text = "Buscar Venta:";
            // 
            // Ver_ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(DTGVentasPersonales);
            Controls.Add(PVentasRealizadas);
            Name = "Ver_ventas";
            Text = "Ver Ventas Realizadas";
            Load += Ver_ventas_Load;
            ((System.ComponentModel.ISupportInitialize)DTGVentasPersonales).EndInit();
            PVentasRealizadas.ResumeLayout(false);
            PVentasRealizadas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label LVentasPersonales;
        private DataGridView DTGVentasPersonales;
        private Panel PVentasRealizadas;
        private TextBox TBuscarVenta;
        private ComboBox CBOpVenta;
        private Label LBuscar;
        private FontAwesome.Sharp.IconButton IBVerDetalle;
    }
}
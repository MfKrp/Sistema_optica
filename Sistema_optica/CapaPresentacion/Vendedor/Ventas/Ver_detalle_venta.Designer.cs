namespace CapaPresentacion.Vendedor.Ventas
{
    partial class Ver_detalle_venta
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
            PDetalleVenta = new Panel();
            TBuscarProdDetalle = new TextBox();
            CBOpcDetalle = new ComboBox();
            LBuscarProdDetalle = new Label();
            LDetalleVenta = new Label();
            DTGDetalleVenta = new DataGridView();
            PDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // PDetalleVenta
            // 
            PDetalleVenta.BackColor = Color.Plum;
            PDetalleVenta.Controls.Add(TBuscarProdDetalle);
            PDetalleVenta.Controls.Add(CBOpcDetalle);
            PDetalleVenta.Controls.Add(LBuscarProdDetalle);
            PDetalleVenta.Controls.Add(LDetalleVenta);
            PDetalleVenta.Location = new Point(12, 12);
            PDetalleVenta.Name = "PDetalleVenta";
            PDetalleVenta.Size = new Size(776, 100);
            PDetalleVenta.TabIndex = 0;
            // 
            // TBuscarProdDetalle
            // 
            TBuscarProdDetalle.Location = new Point(675, 42);
            TBuscarProdDetalle.Name = "TBuscarProdDetalle";
            TBuscarProdDetalle.Size = new Size(78, 23);
            TBuscarProdDetalle.TabIndex = 3;
            // 
            // CBOpcDetalle
            // 
            CBOpcDetalle.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcDetalle.FormattingEnabled = true;
            CBOpcDetalle.Location = new Point(593, 42);
            CBOpcDetalle.Name = "CBOpcDetalle";
            CBOpcDetalle.Size = new Size(76, 23);
            CBOpcDetalle.TabIndex = 2;
            // 
            // LBuscarProdDetalle
            // 
            LBuscarProdDetalle.AutoSize = true;
            LBuscarProdDetalle.Font = new Font("Sitka Text", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LBuscarProdDetalle.ForeColor = Color.Purple;
            LBuscarProdDetalle.Location = new Point(385, 42);
            LBuscarProdDetalle.Name = "LBuscarProdDetalle";
            LBuscarProdDetalle.Size = new Size(202, 20);
            LBuscarProdDetalle.TabIndex = 1;
            LBuscarProdDetalle.Text = "Buscar Producto en detalle:";
            // 
            // LDetalleVenta
            // 
            LDetalleVenta.AutoSize = true;
            LDetalleVenta.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LDetalleVenta.ForeColor = Color.Purple;
            LDetalleVenta.Location = new Point(20, 35);
            LDetalleVenta.Name = "LDetalleVenta";
            LDetalleVenta.Size = new Size(226, 28);
            LDetalleVenta.TabIndex = 0;
            LDetalleVenta.Text = "Detalle de la venta Nro";
            // 
            // DTGDetalleVenta
            // 
            DTGDetalleVenta.BackgroundColor = Color.Thistle;
            DTGDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDetalleVenta.Location = new Point(12, 118);
            DTGDetalleVenta.Name = "DTGDetalleVenta";
            DTGDetalleVenta.RowTemplate.Height = 25;
            DTGDetalleVenta.Size = new Size(776, 320);
            DTGDetalleVenta.TabIndex = 1;
            DTGDetalleVenta.CellContentClick += DTGDetalleVenta_CellContentClick;
            // 
            // Ver_detalle_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DTGDetalleVenta);
            Controls.Add(PDetalleVenta);
            Name = "Ver_detalle_venta";
            Text = "Ver_detalle_venta";
            PDetalleVenta.ResumeLayout(false);
            PDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalleVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PDetalleVenta;
        private Label LDetalleVenta;
        private DataGridView DTGDetalleVenta;
        private TextBox TBuscarProdDetalle;
        private ComboBox CBOpcDetalle;
        private Label LBuscarProdDetalle;
    }
}
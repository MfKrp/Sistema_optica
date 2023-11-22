namespace CapaPresentacion.Superadmin
{
    partial class ventas_generales
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
            DGVListaVentas = new DataGridView();
            LVentas = new Label();
            DGVentasDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVListaVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVentasDetalles).BeginInit();
            SuspendLayout();
            // 
            // DGVListaVentas
            // 
            DGVListaVentas.Anchor = AnchorStyles.None;
            DGVListaVentas.BackgroundColor = Color.CadetBlue;
            DGVListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListaVentas.Location = new Point(12, 61);
            DGVListaVentas.MultiSelect = false;
            DGVListaVentas.Name = "DGVListaVentas";
            DGVListaVentas.ReadOnly = true;
            DGVListaVentas.RowTemplate.Height = 25;
            DGVListaVentas.Size = new Size(380, 377);
            DGVListaVentas.TabIndex = 79;
            DGVListaVentas.CellContentClick += DGVListaVentas_CellContentClick;
            // 
            // LVentas
            // 
            LVentas.Anchor = AnchorStyles.None;
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LVentas.ForeColor = Color.FromArgb(0, 64, 64);
            LVentas.Location = new Point(297, 21);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(222, 28);
            LVentas.TabIndex = 78;
            LVentas.Text = "LISTA DE PRODUCTOS";
            // 
            // DGVentasDetalles
            // 
            DGVentasDetalles.Anchor = AnchorStyles.None;
            DGVentasDetalles.BackgroundColor = Color.CadetBlue;
            DGVentasDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVentasDetalles.Location = new Point(408, 61);
            DGVentasDetalles.MultiSelect = false;
            DGVentasDetalles.Name = "DGVentasDetalles";
            DGVentasDetalles.ReadOnly = true;
            DGVentasDetalles.RowTemplate.Height = 25;
            DGVentasDetalles.Size = new Size(380, 377);
            DGVentasDetalles.TabIndex = 80;
            DGVentasDetalles.CellContentClick += DGVentasDetalles_CellContentClick;
            // 
            // ventas_generales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGVentasDetalles);
            Controls.Add(DGVListaVentas);
            Controls.Add(LVentas);
            Name = "ventas_generales";
            Text = "ventas_generales";
            Load += ventas_generales_Load;
            ((System.ComponentModel.ISupportInitialize)DGVListaVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVentasDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVListaVentas;
        private Label LVentas;
        private DataGridView DGVentasDetalles;
    }
}
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
            PTituloVentas = new Panel();
            DGVentasDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVListaVentas).BeginInit();
            PTituloVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVentasDetalles).BeginInit();
            SuspendLayout();
            // 
            // DGVListaVentas
            // 
            DGVListaVentas.BackgroundColor = Color.FromArgb(0, 220, 176);
            DGVListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListaVentas.Dock = DockStyle.Fill;
            DGVListaVentas.Location = new Point(0, 100);
            DGVListaVentas.MultiSelect = false;
            DGVListaVentas.Name = "DGVListaVentas";
            DGVListaVentas.ReadOnly = true;
            DGVListaVentas.RowTemplate.Height = 25;
            DGVListaVentas.Size = new Size(800, 165);
            DGVListaVentas.TabIndex = 79;
            DGVListaVentas.CellContentClick += DGVListaVentas_CellContentClick;
            // 
            // LVentas
            // 
            LVentas.Anchor = AnchorStyles.None;
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LVentas.ForeColor = Color.White;
            LVentas.Location = new Point(293, 33);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(191, 28);
            LVentas.TabIndex = 78;
            LVentas.Text = "Facturas y Detalles";
            // 
            // PTituloVentas
            // 
            PTituloVentas.BackColor = Color.FromArgb(0, 175, 176);
            PTituloVentas.Controls.Add(LVentas);
            PTituloVentas.Dock = DockStyle.Top;
            PTituloVentas.Location = new Point(0, 0);
            PTituloVentas.Name = "PTituloVentas";
            PTituloVentas.Size = new Size(800, 100);
            PTituloVentas.TabIndex = 81;
            // 
            // DGVentasDetalles
            // 
            DGVentasDetalles.BackgroundColor = Color.CadetBlue;
            DGVentasDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVentasDetalles.Dock = DockStyle.Bottom;
            DGVentasDetalles.Location = new Point(0, 265);
            DGVentasDetalles.MultiSelect = false;
            DGVentasDetalles.Name = "DGVentasDetalles";
            DGVentasDetalles.ReadOnly = true;
            DGVentasDetalles.RowTemplate.Height = 25;
            DGVentasDetalles.Size = new Size(800, 185);
            DGVentasDetalles.TabIndex = 80;
            DGVentasDetalles.CellContentClick += DGVentasDetalles_CellContentClick;
            // 
            // ventas_generales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGVListaVentas);
            Controls.Add(DGVentasDetalles);
            Controls.Add(PTituloVentas);
            Name = "ventas_generales";
            Text = "Lista de Ventas Realizadas";
            Load += ventas_generales_Load;
            ((System.ComponentModel.ISupportInitialize)DGVListaVentas).EndInit();
            PTituloVentas.ResumeLayout(false);
            PTituloVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVentasDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVListaVentas;
        private Label LVentas;
        private Panel PTituloVentas;
        private DataGridView DGVentasDetalles;
    }
}
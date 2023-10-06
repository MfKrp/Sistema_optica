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
            label2 = new Label();
            DTGDatosCompra = new DataGridView();
            DGCId_Producto = new DataGridViewTextBoxColumn();
            DGCNombreProd = new DataGridViewTextBoxColumn();
            DTCVendedorCargo = new DataGridViewTextBoxColumn();
            DGCCliente = new DataGridViewTextBoxColumn();
            DTCFecha = new DataGridViewTextBoxColumn();
            DTGCCantidad = new DataGridViewTextBoxColumn();
            DTCPrecioUnitario = new DataGridViewTextBoxColumn();
            DTGCEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(381, 29);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 75;
            label2.Text = "LISTA DE VENTAS";
            // 
            // DTGDatosCompra
            // 
            DTGDatosCompra.AllowUserToAddRows = false;
            DTGDatosCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            DTGDatosCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DTGDatosCompra.Anchor = AnchorStyles.None;
            DTGDatosCompra.BackgroundColor = Color.CadetBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DTGDatosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DTGDatosCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDatosCompra.Columns.AddRange(new DataGridViewColumn[] { DGCId_Producto, DGCNombreProd, DTCVendedorCargo, DGCCliente, DTCFecha, DTGCCantidad, DTCPrecioUnitario, DTGCEliminar });
            DTGDatosCompra.Location = new Point(29, 76);
            DTGDatosCompra.Name = "DTGDatosCompra";
            DTGDatosCompra.RowTemplate.Height = 25;
            DTGDatosCompra.Size = new Size(882, 337);
            DTGDatosCompra.TabIndex = 76;
            // 
            // DGCId_Producto
            // 
            DGCId_Producto.HeaderText = "ID Producto";
            DGCId_Producto.Name = "DGCId_Producto";
            // 
            // DGCNombreProd
            // 
            DGCNombreProd.HeaderText = "Nombre";
            DGCNombreProd.Name = "DGCNombreProd";
            // 
            // DTCVendedorCargo
            // 
            DTCVendedorCargo.HeaderText = "Vendedor";
            DTCVendedorCargo.Name = "DTCVendedorCargo";
            // 
            // DGCCliente
            // 
            DGCCliente.HeaderText = "Cliente";
            DGCCliente.Name = "DGCCliente";
            // 
            // DTCFecha
            // 
            DTCFecha.HeaderText = "Fecha";
            DTCFecha.Name = "DTCFecha";
            // 
            // DTGCCantidad
            // 
            DTGCCantidad.HeaderText = "Cantidad";
            DTGCCantidad.Name = "DTGCCantidad";
            // 
            // DTCPrecioUnitario
            // 
            DTCPrecioUnitario.HeaderText = "Precio Unitario";
            DTCPrecioUnitario.Name = "DTCPrecioUnitario";
            // 
            // DTGCEliminar
            // 
            DTGCEliminar.HeaderText = "Acción";
            DTGCEliminar.Name = "DTGCEliminar";
            // 
            // Ver_ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(DTGDatosCompra);
            Controls.Add(label2);
            Name = "Ver_ventas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView DTGDatosCompra;
        private DataGridViewTextBoxColumn DGCId_Producto;
        private DataGridViewTextBoxColumn DGCNombreProd;
        private DataGridViewTextBoxColumn DTCVendedorCargo;
        private DataGridViewTextBoxColumn DGCCliente;
        private DataGridViewTextBoxColumn DTCFecha;
        private DataGridViewTextBoxColumn DTGCCantidad;
        private DataGridViewTextBoxColumn DTCPrecioUnitario;
        private DataGridViewButtonColumn DTGCEliminar;
    }
}
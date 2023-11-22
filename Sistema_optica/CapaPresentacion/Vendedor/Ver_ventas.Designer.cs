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
            DTGDatosCompra.AllowUserToResizeColumns = false;
            DTGDatosCompra.AllowUserToResizeRows = false;
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
            DTGDatosCompra.Location = new Point(29, 76);
            DTGDatosCompra.Name = "DTGDatosCompra";
            DTGDatosCompra.ReadOnly = true;
            DTGDatosCompra.RowTemplate.Height = 25;
            DTGDatosCompra.Size = new Size(882, 337);
            DTGDatosCompra.TabIndex = 76;
            DTGDatosCompra.CellContentClick += DTGDatosCompra_CellContentClick;
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
            Load += Ver_ventas_Load;
            ((System.ComponentModel.ISupportInitialize)DTGDatosCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView DTGDatosCompra;
    }
}
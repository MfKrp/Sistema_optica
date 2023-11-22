namespace CapaPresentacion.Secretaria
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
            BVerProductos = new Button();
            BModificar = new Button();
            BEliminar = new Button();
            BRestaurar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_ListaProd).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(263, 31);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
            label2.TabIndex = 76;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // DGV_ListaProd
            // 
            DGV_ListaProd.AllowUserToAddRows = false;
            DGV_ListaProd.AllowUserToDeleteRows = false;
            DGV_ListaProd.AllowUserToResizeColumns = false;
            DGV_ListaProd.AllowUserToResizeRows = false;
            DGV_ListaProd.Anchor = AnchorStyles.None;
            DGV_ListaProd.BackgroundColor = Color.CadetBlue;
            DGV_ListaProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_ListaProd.Location = new Point(31, 79);
            DGV_ListaProd.MultiSelect = false;
            DGV_ListaProd.Name = "DGV_ListaProd";
            DGV_ListaProd.ReadOnly = true;
            DGV_ListaProd.RowTemplate.Height = 25;
            DGV_ListaProd.Size = new Size(882, 337);
            DGV_ListaProd.TabIndex = 77;
            DGV_ListaProd.CellContentClick += DGV_ListaProd_CellContentClick;
            // 
            // BVerProductos
            // 
            BVerProductos.Anchor = AnchorStyles.None;
            BVerProductos.BackColor = Color.LimeGreen;
            BVerProductos.FlatStyle = FlatStyle.Flat;
            BVerProductos.Location = new Point(795, 38);
            BVerProductos.Name = "BVerProductos";
            BVerProductos.Size = new Size(109, 23);
            BVerProductos.TabIndex = 81;
            BVerProductos.Text = "Ver Productos";
            BVerProductos.UseVisualStyleBackColor = false;
            BVerProductos.Click += BVerProductos_Click;
            // 
            // BModificar
            // 
            BModificar.Anchor = AnchorStyles.None;
            BModificar.BackColor = Color.DodgerBlue;
            BModificar.FlatStyle = FlatStyle.Flat;
            BModificar.Location = new Point(714, 38);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(75, 23);
            BModificar.TabIndex = 82;
            BModificar.Text = "Modificar";
            BModificar.UseVisualStyleBackColor = false;
            BModificar.Click += BModificar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Anchor = AnchorStyles.None;
            BEliminar.BackColor = Color.Red;
            BEliminar.FlatStyle = FlatStyle.Flat;
            BEliminar.Location = new Point(630, 38);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 83;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // BRestaurar
            // 
            BRestaurar.Anchor = AnchorStyles.None;
            BRestaurar.BackColor = Color.Orange;
            BRestaurar.FlatStyle = FlatStyle.Flat;
            BRestaurar.Location = new Point(549, 38);
            BRestaurar.Name = "BRestaurar";
            BRestaurar.Size = new Size(75, 23);
            BRestaurar.TabIndex = 84;
            BRestaurar.Text = "Restaurar";
            BRestaurar.UseVisualStyleBackColor = false;
            BRestaurar.Click += BRestaurar_Click;
            // 
            // Ver_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(BRestaurar);
            Controls.Add(BEliminar);
            Controls.Add(BModificar);
            Controls.Add(BVerProductos);
            Controls.Add(DGV_ListaProd);
            Controls.Add(label2);
            Name = "Ver_productos";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_ListaProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView DGV_ListaProd;
        private Button BVerProductos;
        private Button BModificar;
        private Button BEliminar;
        private Button BRestaurar;
    }
}
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
            BVerRegistros = new Button();
            BModificar = new Button();
            BEliminar = new Button();
            BHabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_ListaProd).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(291, 34);
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
            DGV_ListaProd.Location = new Point(26, 77);
            DGV_ListaProd.MultiSelect = false;
            DGV_ListaProd.Name = "DGV_ListaProd";
            DGV_ListaProd.ReadOnly = true;
            DGV_ListaProd.RowTemplate.Height = 25;
            DGV_ListaProd.Size = new Size(882, 337);
            DGV_ListaProd.TabIndex = 77;
            DGV_ListaProd.CellContentClick += DGV_ListaProd_CellContentClick;
            // 
            // BVerRegistros
            // 
            BVerRegistros.Anchor = AnchorStyles.None;
            BVerRegistros.BackColor = Color.LimeGreen;
            BVerRegistros.FlatStyle = FlatStyle.Flat;
            BVerRegistros.Location = new Point(811, 39);
            BVerRegistros.Name = "BVerRegistros";
            BVerRegistros.Size = new Size(97, 23);
            BVerRegistros.TabIndex = 82;
            BVerRegistros.Text = "Ver Productos";
            BVerRegistros.UseVisualStyleBackColor = false;
            BVerRegistros.Click += BVerRegistros_Click;
            // 
            // BModificar
            // 
            BModificar.Anchor = AnchorStyles.None;
            BModificar.BackColor = Color.DodgerBlue;
            BModificar.FlatStyle = FlatStyle.Flat;
            BModificar.Location = new Point(730, 39);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(75, 23);
            BModificar.TabIndex = 83;
            BModificar.Text = "Modificar";
            BModificar.UseVisualStyleBackColor = false;
            BModificar.Click += BModificar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Anchor = AnchorStyles.None;
            BEliminar.BackColor = Color.Red;
            BEliminar.FlatStyle = FlatStyle.Flat;
            BEliminar.Location = new Point(649, 39);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 84;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // BHabilitar
            // 
            BHabilitar.Anchor = AnchorStyles.None;
            BHabilitar.BackColor = Color.Orange;
            BHabilitar.FlatStyle = FlatStyle.Flat;
            BHabilitar.Location = new Point(568, 39);
            BHabilitar.Name = "BHabilitar";
            BHabilitar.Size = new Size(75, 23);
            BHabilitar.TabIndex = 85;
            BHabilitar.Text = "Habilitar";
            BHabilitar.UseVisualStyleBackColor = false;
            BHabilitar.Click += BHabilitar_Click;
            // 
            // Ver_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(BHabilitar);
            Controls.Add(BEliminar);
            Controls.Add(BModificar);
            Controls.Add(BVerRegistros);
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
        private Button BVerRegistros;
        private Button BModificar;
        private Button BEliminar;
        private Button BHabilitar;
    }
}
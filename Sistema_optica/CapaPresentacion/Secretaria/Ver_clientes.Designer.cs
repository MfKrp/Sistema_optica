namespace CapaPresentacion.Secretaria
{
    partial class Ver_clientes
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ViewDataButton = new Button();
            BModificar = new Button();
            BEliminar = new Button();
            BRestaurar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 69);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(882, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(287, 35);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 75;
            label2.Text = "LISTA DE CLIENTES";
            // 
            // ViewDataButton
            // 
            ViewDataButton.BackColor = Color.LimeGreen;
            ViewDataButton.FlatStyle = FlatStyle.Flat;
            ViewDataButton.Location = new Point(830, 39);
            ViewDataButton.Name = "ViewDataButton";
            ViewDataButton.Size = new Size(80, 23);
            ViewDataButton.TabIndex = 76;
            ViewDataButton.Text = "Ver Clientes";
            ViewDataButton.UseVisualStyleBackColor = false;
            ViewDataButton.Click += ViewDataButton_Click;
            // 
            // BModificar
            // 
            BModificar.BackColor = Color.DodgerBlue;
            BModificar.FlatStyle = FlatStyle.Flat;
            BModificar.Location = new Point(749, 39);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(75, 23);
            BModificar.TabIndex = 79;
            BModificar.Text = "Modificar";
            BModificar.UseVisualStyleBackColor = false;
            BModificar.Click += BModificar_Click;
            // 
            // BEliminar
            // 
            BEliminar.BackColor = Color.Red;
            BEliminar.FlatStyle = FlatStyle.Flat;
            BEliminar.Location = new Point(668, 39);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 80;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = false;
            BEliminar.Click += BEliminar_Click;
            // 
            // BRestaurar
            // 
            BRestaurar.BackColor = Color.Orange;
            BRestaurar.FlatStyle = FlatStyle.Flat;
            BRestaurar.Location = new Point(587, 39);
            BRestaurar.Name = "BRestaurar";
            BRestaurar.Size = new Size(75, 23);
            BRestaurar.TabIndex = 81;
            BRestaurar.Text = "Habilitar";
            BRestaurar.UseVisualStyleBackColor = false;
            BRestaurar.Click += BRestaurar_Click;
            // 
            // Ver_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(BRestaurar);
            Controls.Add(BEliminar);
            Controls.Add(BModificar);
            Controls.Add(ViewDataButton);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Ver_clientes";
            Text = "Form1";
            Load += Ver_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button ViewDataButton;
        private Button BModificar;
        private Button BEliminar;
        private Button BRestaurar;
    }
}
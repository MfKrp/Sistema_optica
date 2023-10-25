namespace CapaPresentacion.Superadmin
{
    partial class Ver_empleados
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
            dataGridView1 = new DataGridView();
            LBuscar = new Label();
            TBuscar = new TextBox();
            BVerEmpleados = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(393, 29);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 77;
            label2.Text = "EMPLEADOS";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(882, 337);
            dataGridView1.TabIndex = 78;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Location = new Point(28, 39);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(42, 15);
            LBuscar.TabIndex = 80;
            LBuscar.Text = "Buscar";
            // 
            // TBuscar
            // 
            TBuscar.Anchor = AnchorStyles.None;
            TBuscar.Location = new Point(88, 36);
            TBuscar.Name = "TBuscar";
            TBuscar.Size = new Size(100, 23);
            TBuscar.TabIndex = 79;
            // 
            // BVerEmpleados
            // 
            BVerEmpleados.Anchor = AnchorStyles.None;
            BVerEmpleados.Location = new Point(816, 36);
            BVerEmpleados.Name = "BVerEmpleados";
            BVerEmpleados.Size = new Size(95, 23);
            BVerEmpleados.TabIndex = 81;
            BVerEmpleados.Text = "Ver Empleados";
            BVerEmpleados.UseVisualStyleBackColor = true;
            BVerEmpleados.Click += BVerEmpleados_Click;
            // 
            // Ver_empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(BVerEmpleados);
            Controls.Add(LBuscar);
            Controls.Add(TBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "Ver_empleados";
            Text = "Form1";
            Load += Ver_empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Label LBuscar;
        private TextBox TBuscar;
        private Button BVerEmpleados;
    }
}
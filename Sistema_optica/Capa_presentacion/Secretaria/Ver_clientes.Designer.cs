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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            DTGVButtonborrar = new DataGridViewButtonColumn();
            label2 = new Label();
            ViewDataButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DTGVButtonborrar });
            dataGridView1.Location = new Point(28, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(882, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DTGVButtonborrar
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DTGVButtonborrar.DefaultCellStyle = dataGridViewCellStyle1;
            DTGVButtonborrar.HeaderText = "Eliminar";
            DTGVButtonborrar.Name = "DTGVButtonborrar";
            DTGVButtonborrar.Text = "Eliminar";
            DTGVButtonborrar.ToolTipText = "Eliminar";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(365, 36);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 75;
            label2.Text = "CLIENTES";
            // 
            // ViewDataButton
            // 
            ViewDataButton.Anchor = AnchorStyles.Right;
            ViewDataButton.Location = new Point(548, 36);
            ViewDataButton.Name = "ViewDataButton";
            ViewDataButton.Size = new Size(127, 28);
            ViewDataButton.TabIndex = 76;
            ViewDataButton.Text = "Ver Clientes";
            ViewDataButton.UseVisualStyleBackColor = true;
            ViewDataButton.Click += ViewDataButton_Click;
            // 
            // Ver_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
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
        private DataGridViewButtonColumn DTGVButtonborrar;
    }
}
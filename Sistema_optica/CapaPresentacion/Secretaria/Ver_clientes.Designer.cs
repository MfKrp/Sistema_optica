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
            C_id = new DataGridViewTextBoxColumn();
            C_nombre = new DataGridViewTextBoxColumn();
            C_apellido = new DataGridViewTextBoxColumn();
            C_tel = new DataGridViewTextBoxColumn();
            C_direccion = new DataGridViewTextBoxColumn();
            C_correo = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { C_id, C_nombre, C_apellido, C_tel, C_direccion, C_correo });
            dataGridView1.Location = new Point(28, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(882, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // C_id
            // 
            C_id.HeaderText = "DNI";
            C_id.Name = "C_id";
            // 
            // C_nombre
            // 
            C_nombre.HeaderText = "NOMBRE";
            C_nombre.Name = "C_nombre";
            C_nombre.Width = 150;
            // 
            // C_apellido
            // 
            C_apellido.HeaderText = "APELLIDO";
            C_apellido.Name = "C_apellido";
            C_apellido.Width = 150;
            // 
            // C_tel
            // 
            C_tel.HeaderText = "TELEFONO";
            C_tel.Name = "C_tel";
            // 
            // C_direccion
            // 
            C_direccion.HeaderText = "DIRECCION";
            C_direccion.Name = "C_direccion";
            C_direccion.Width = 180;
            // 
            // C_correo
            // 
            C_correo.HeaderText = "CORREO";
            C_correo.Name = "C_correo";
            C_correo.Width = 165;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(414, 29);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 75;
            label2.Text = "CLIENTES";
            // 
            // Ver_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Ver_clientes";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn C_id;
        private DataGridViewTextBoxColumn C_nombre;
        private DataGridViewTextBoxColumn C_apellido;
        private DataGridViewTextBoxColumn C_tel;
        private DataGridViewTextBoxColumn C_direccion;
        private DataGridViewTextBoxColumn C_correo;
        private Label label2;
    }
}
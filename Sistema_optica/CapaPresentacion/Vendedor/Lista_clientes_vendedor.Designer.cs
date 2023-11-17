namespace CapaPresentacion.Vendedor
{
    partial class Lista_clientes_vendedor
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
            panel1 = new Panel();
            BBorrar = new Button();
            BBuscar = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            LBuscar = new Label();
            LListaClientes = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BBorrar);
            panel1.Controls.Add(BBuscar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(LBuscar);
            panel1.Controls.Add(LListaClientes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 98);
            panel1.TabIndex = 0;
            // 
            // BBorrar
            // 
            BBorrar.Location = new Point(271, 68);
            BBorrar.Name = "BBorrar";
            BBorrar.Size = new Size(54, 23);
            BBorrar.TabIndex = 5;
            BBorrar.Text = "Borrar";
            BBorrar.UseVisualStyleBackColor = true;
            BBorrar.Click += BBorrar_Click;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(271, 39);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(54, 23);
            BBuscar.TabIndex = 4;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DNI", "Nombre" });
            comboBox1.Location = new Point(97, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(89, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LBuscar
            // 
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.Location = new Point(9, 59);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(82, 20);
            LBuscar.TabIndex = 1;
            LBuscar.Text = "Buscar por:";
            // 
            // LListaClientes
            // 
            LListaClientes.AutoSize = true;
            LListaClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LListaClientes.Location = new Point(13, 10);
            LListaClientes.Name = "LListaClientes";
            LListaClientes.Size = new Size(125, 21);
            LListaClientes.TabIndex = 0;
            LListaClientes.Text = "Lista de Clientes:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 125);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(364, 261);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Lista_clientes_vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 398);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Lista_clientes_vendedor";
            Text = "Lista_clientes_vendedor";
            Load += Lista_clientes_vendedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LListaClientes;
        private DataGridView dataGridView1;
        private Button BBuscar;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label LBuscar;
        private Button BBorrar;
    }
}
﻿namespace CapaPresentacion.Superadmin
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
            BVerEmpleados = new Button();
            BEliminarReg = new Button();
            BModificarReg = new Button();
            BHabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(364, 30);
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
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(882, 337);
            dataGridView1.TabIndex = 78;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BVerEmpleados
            // 
            BVerEmpleados.Anchor = AnchorStyles.None;
            BVerEmpleados.BackColor = Color.LimeGreen;
            BVerEmpleados.FlatStyle = FlatStyle.Flat;
            BVerEmpleados.Location = new Point(816, 36);
            BVerEmpleados.Name = "BVerEmpleados";
            BVerEmpleados.Size = new Size(95, 23);
            BVerEmpleados.TabIndex = 81;
            BVerEmpleados.Text = "Ver Empleados";
            BVerEmpleados.UseVisualStyleBackColor = false;
            BVerEmpleados.Click += BVerEmpleados_Click;
            // 
            // BEliminarReg
            // 
            BEliminarReg.Anchor = AnchorStyles.None;
            BEliminarReg.BackColor = Color.Red;
            BEliminarReg.FlatStyle = FlatStyle.Flat;
            BEliminarReg.ForeColor = Color.Black;
            BEliminarReg.Location = new Point(654, 36);
            BEliminarReg.Name = "BEliminarReg";
            BEliminarReg.Size = new Size(75, 23);
            BEliminarReg.TabIndex = 82;
            BEliminarReg.Text = "Eliminar";
            BEliminarReg.UseVisualStyleBackColor = false;
            BEliminarReg.Click += BEliminarReg_Click;
            // 
            // BModificarReg
            // 
            BModificarReg.Anchor = AnchorStyles.None;
            BModificarReg.BackColor = Color.DodgerBlue;
            BModificarReg.FlatStyle = FlatStyle.Flat;
            BModificarReg.Location = new Point(735, 36);
            BModificarReg.Name = "BModificarReg";
            BModificarReg.Size = new Size(75, 23);
            BModificarReg.TabIndex = 83;
            BModificarReg.Text = "Modificar";
            BModificarReg.UseVisualStyleBackColor = false;
            BModificarReg.Click += BModificarReg_Click;
            // 
            // BHabilitar
            // 
            BHabilitar.Anchor = AnchorStyles.None;
            BHabilitar.BackColor = Color.Orange;
            BHabilitar.FlatStyle = FlatStyle.Flat;
            BHabilitar.Location = new Point(573, 36);
            BHabilitar.Name = "BHabilitar";
            BHabilitar.Size = new Size(75, 23);
            BHabilitar.TabIndex = 84;
            BHabilitar.Text = "Habilitar";
            BHabilitar.UseVisualStyleBackColor = false;
            BHabilitar.Click += BHabilitar_Click;
            // 
            // Ver_empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 441);
            Controls.Add(BHabilitar);
            Controls.Add(BModificarReg);
            Controls.Add(BEliminarReg);
            Controls.Add(BVerEmpleados);
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
        private Button BVerEmpleados;
        private Button BEliminarReg;
        private Button BModificarReg;
        private Button BHabilitar;
    }
}
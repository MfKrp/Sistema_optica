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
            PVerEmpleados = new Panel();
            panel1 = new Panel();
            IBRehabilitarEmpleado = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            IBAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            IBEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            CBOpcionesCristales = new ComboBox();
            LBuscar = new Label();
            TBuscarCristal = new TextBox();
            LTEmpleados = new Label();
            DTGListaEmpleado = new DataGridView();
            PVerEmpleados.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGListaEmpleado).BeginInit();
            SuspendLayout();
            // 
            // PVerEmpleados
            // 
            PVerEmpleados.BackColor = Color.FromArgb(0, 175, 176);
            PVerEmpleados.Controls.Add(panel1);
            PVerEmpleados.Controls.Add(CBOpcionesCristales);
            PVerEmpleados.Controls.Add(LBuscar);
            PVerEmpleados.Controls.Add(TBuscarCristal);
            PVerEmpleados.Controls.Add(LTEmpleados);
            PVerEmpleados.Dock = DockStyle.Top;
            PVerEmpleados.Location = new Point(0, 0);
            PVerEmpleados.Name = "PVerEmpleados";
            PVerEmpleados.Size = new Size(877, 83);
            PVerEmpleados.TabIndex = 84;
            // 
            // panel1
            // 
            panel1.Controls.Add(IBRehabilitarEmpleado);
            panel1.Controls.Add(IBEditar);
            panel1.Controls.Add(IBAgregarEmpleado);
            panel1.Controls.Add(IBEliminarEmpleado);
            panel1.Location = new Point(791, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(83, 77);
            panel1.TabIndex = 10;
            // 
            // IBRehabilitarEmpleado
            // 
            IBRehabilitarEmpleado.Anchor = AnchorStyles.None;
            IBRehabilitarEmpleado.FlatStyle = FlatStyle.Flat;
            IBRehabilitarEmpleado.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBRehabilitarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            IBRehabilitarEmpleado.IconColor = Color.Crimson;
            IBRehabilitarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBRehabilitarEmpleado.IconSize = 20;
            IBRehabilitarEmpleado.Location = new Point(4, 3);
            IBRehabilitarEmpleado.Name = "IBRehabilitarEmpleado";
            IBRehabilitarEmpleado.Size = new Size(35, 35);
            IBRehabilitarEmpleado.TabIndex = 9;
            IBRehabilitarEmpleado.UseVisualStyleBackColor = true;
            // 
            // IBEditar
            // 
            IBEditar.BackColor = Color.Transparent;
            IBEditar.FlatStyle = FlatStyle.Flat;
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.MediumSlateBlue;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(45, 3);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(35, 35);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = false;
            // 
            // IBAgregarEmpleado
            // 
            IBAgregarEmpleado.Anchor = AnchorStyles.None;
            IBAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            IBAgregarEmpleado.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarEmpleado.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarEmpleado.IconColor = Color.Purple;
            IBAgregarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarEmpleado.IconSize = 20;
            IBAgregarEmpleado.Location = new Point(4, 39);
            IBAgregarEmpleado.Name = "IBAgregarEmpleado";
            IBAgregarEmpleado.Size = new Size(35, 35);
            IBAgregarEmpleado.TabIndex = 7;
            IBAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // IBEliminarEmpleado
            // 
            IBEliminarEmpleado.Anchor = AnchorStyles.None;
            IBEliminarEmpleado.FlatStyle = FlatStyle.Flat;
            IBEliminarEmpleado.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarEmpleado.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarEmpleado.IconColor = Color.Red;
            IBEliminarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarEmpleado.IconSize = 20;
            IBEliminarEmpleado.Location = new Point(45, 39);
            IBEliminarEmpleado.Name = "IBEliminarEmpleado";
            IBEliminarEmpleado.Size = new Size(35, 35);
            IBEliminarEmpleado.TabIndex = 8;
            IBEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // CBOpcionesCristales
            // 
            CBOpcionesCristales.AllowDrop = true;
            CBOpcionesCristales.Anchor = AnchorStyles.None;
            CBOpcionesCristales.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesCristales.FormattingEnabled = true;
            CBOpcionesCristales.Location = new Point(566, 34);
            CBOpcionesCristales.Name = "CBOpcionesCristales";
            CBOpcionesCristales.Size = new Size(100, 23);
            CBOpcionesCristales.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.ForeColor = Color.White;
            LBuscar.Location = new Point(398, 31);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(163, 26);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Empleado:";
            // 
            // TBuscarCristal
            // 
            TBuscarCristal.Location = new Point(672, 34);
            TBuscarCristal.Name = "TBuscarCristal";
            TBuscarCristal.Size = new Size(100, 23);
            TBuscarCristal.TabIndex = 1;
            // 
            // LTEmpleados
            // 
            LTEmpleados.Anchor = AnchorStyles.None;
            LTEmpleados.AutoSize = true;
            LTEmpleados.BackColor = Color.Transparent;
            LTEmpleados.Font = new Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LTEmpleados.ForeColor = Color.White;
            LTEmpleados.Location = new Point(28, 28);
            LTEmpleados.Name = "LTEmpleados";
            LTEmpleados.Size = new Size(196, 28);
            LTEmpleados.TabIndex = 0;
            LTEmpleados.Text = "Lista de Empleados";
            // 
            // DTGListaEmpleado
            // 
            DTGListaEmpleado.AllowUserToAddRows = false;
            DTGListaEmpleado.AllowUserToResizeColumns = false;
            DTGListaEmpleado.AllowUserToResizeRows = false;
            DTGListaEmpleado.BackgroundColor = Color.FromArgb(0, 220, 176);
            DTGListaEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGListaEmpleado.Dock = DockStyle.Fill;
            DTGListaEmpleado.Location = new Point(0, 83);
            DTGListaEmpleado.MultiSelect = false;
            DTGListaEmpleado.Name = "DTGListaEmpleado";
            DTGListaEmpleado.ReadOnly = true;
            DTGListaEmpleado.RowTemplate.Height = 25;
            DTGListaEmpleado.Size = new Size(877, 358);
            DTGListaEmpleado.TabIndex = 83;
            DTGListaEmpleado.CellContentClick += DTGListaEmpleado_CellContentClick;
            // 
            // Ver_empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 441);
            Controls.Add(DTGListaEmpleado);
            Controls.Add(PVerEmpleados);
            Name = "Ver_empleados";
            Text = "Lista de Empleados";
            Load += Ver_empleados_Load;
            PVerEmpleados.ResumeLayout(false);
            PVerEmpleados.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGListaEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerEmpleados;
        private FontAwesome.Sharp.IconButton IBRehabilitarEmpleado;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton IBEditar;
        private FontAwesome.Sharp.IconButton IBAgregarEmpleado;
        private FontAwesome.Sharp.IconButton IBEliminarEmpleado;
        private ComboBox CBOpcionesCristales;
        private Label LBuscar;
        private TextBox TBuscarCristal;
        private Label LTEmpleados;
        private DataGridView DTGListaEmpleado;
    }
}
namespace CapaPresentacion.Secretaria
{
    partial class Ver_cristales
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
            PVerCristales = new Panel();
            IBEliminarCristal = new FontAwesome.Sharp.IconButton();
            IBAgregarCristal = new FontAwesome.Sharp.IconButton();
            IBEditar = new FontAwesome.Sharp.IconButton();
            CBOpcionesCristales = new ComboBox();
            LBuscar = new Label();
            TBuscarCristal = new TextBox();
            LTCristales = new Label();
            DTGVCristales = new DataGridView();
            PVerCristales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVCristales).BeginInit();
            SuspendLayout();
            // 
            // PVerCristales
            // 
            PVerCristales.Anchor = AnchorStyles.None;
            PVerCristales.BackColor = Color.Plum;
            PVerCristales.Controls.Add(IBEliminarCristal);
            PVerCristales.Controls.Add(IBAgregarCristal);
            PVerCristales.Controls.Add(IBEditar);
            PVerCristales.Controls.Add(CBOpcionesCristales);
            PVerCristales.Controls.Add(LBuscar);
            PVerCristales.Controls.Add(TBuscarCristal);
            PVerCristales.Controls.Add(LTCristales);
            PVerCristales.Location = new Point(12, 11);
            PVerCristales.Name = "PVerCristales";
            PVerCristales.Size = new Size(589, 83);
            PVerCristales.TabIndex = 9;
            // 
            // IBEliminarCristal
            // 
            IBEliminarCristal.Anchor = AnchorStyles.None;
            IBEliminarCristal.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEliminarCristal.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            IBEliminarCristal.IconColor = Color.Black;
            IBEliminarCristal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEliminarCristal.IconSize = 20;
            IBEliminarCristal.Location = new Point(532, 38);
            IBEliminarCristal.Name = "IBEliminarCristal";
            IBEliminarCristal.Size = new Size(24, 24);
            IBEliminarCristal.TabIndex = 8;
            IBEliminarCristal.UseVisualStyleBackColor = true;
            // 
            // IBAgregarCristal
            // 
            IBAgregarCristal.Anchor = AnchorStyles.None;
            IBAgregarCristal.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarCristal.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarCristal.IconColor = Color.Black;
            IBAgregarCristal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarCristal.IconSize = 20;
            IBAgregarCristal.Location = new Point(501, 38);
            IBAgregarCristal.Name = "IBAgregarCristal";
            IBAgregarCristal.Size = new Size(25, 24);
            IBAgregarCristal.TabIndex = 7;
            IBAgregarCristal.UseVisualStyleBackColor = true;
            // 
            // IBEditar
            // 
            IBEditar.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBEditar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            IBEditar.IconColor = Color.Black;
            IBEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBEditar.IconSize = 20;
            IBEditar.Location = new Point(468, 38);
            IBEditar.Name = "IBEditar";
            IBEditar.Size = new Size(27, 24);
            IBEditar.TabIndex = 4;
            IBEditar.UseVisualStyleBackColor = true;
            // 
            // CBOpcionesCristales
            // 
            CBOpcionesCristales.AllowDrop = true;
            CBOpcionesCristales.Anchor = AnchorStyles.None;
            CBOpcionesCristales.DropDownStyle = ComboBoxStyle.DropDownList;
            CBOpcionesCristales.FormattingEnabled = true;
            CBOpcionesCristales.Location = new Point(311, 39);
            CBOpcionesCristales.Name = "CBOpcionesCristales";
            CBOpcionesCristales.Size = new Size(76, 23);
            CBOpcionesCristales.TabIndex = 3;
            // 
            // LBuscar
            // 
            LBuscar.Anchor = AnchorStyles.None;
            LBuscar.AutoSize = true;
            LBuscar.Font = new Font("Sitka Text", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LBuscar.Location = new Point(203, 39);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(107, 20);
            LBuscar.TabIndex = 2;
            LBuscar.Text = "Buscar Cristal:";
            // 
            // TBuscarCristal
            // 
            TBuscarCristal.Location = new Point(393, 39);
            TBuscarCristal.Name = "TBuscarCristal";
            TBuscarCristal.Size = new Size(69, 23);
            TBuscarCristal.TabIndex = 1;
            // 
            // LTCristales
            // 
            LTCristales.Anchor = AnchorStyles.None;
            LTCristales.AutoSize = true;
            LTCristales.BackColor = Color.Transparent;
            LTCristales.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            LTCristales.ForeColor = Color.Black;
            LTCristales.Location = new Point(17, 32);
            LTCristales.Name = "LTCristales";
            LTCristales.Size = new Size(176, 28);
            LTCristales.TabIndex = 0;
            LTCristales.Text = "Lista de Cristales";
            // 
            // DTGVCristales
            // 
            DTGVCristales.BackgroundColor = Color.Thistle;
            DTGVCristales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGVCristales.Location = new Point(12, 100);
            DTGVCristales.Name = "DTGVCristales";
            DTGVCristales.RowTemplate.Height = 25;
            DTGVCristales.Size = new Size(589, 339);
            DTGVCristales.TabIndex = 8;
            // 
            // Ver_cristales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(PVerCristales);
            Controls.Add(DTGVCristales);
            Name = "Ver_cristales";
            Text = "Cristales";
            PVerCristales.ResumeLayout(false);
            PVerCristales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGVCristales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PVerCristales;
        private FontAwesome.Sharp.IconButton IBEliminarCristal;
        private FontAwesome.Sharp.IconButton IBAgregarCristal;
        private FontAwesome.Sharp.IconButton IBEditar;
        private ComboBox CBOpcionesCristales;
        private Label LBuscar;
        private TextBox TBuscarCristal;
        private Label LTCristales;
        private DataGridView DTGVCristales;
    }
}
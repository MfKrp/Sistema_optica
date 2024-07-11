namespace CapaPresentacion.Secretaria
{
    partial class Alta_productoTerapeutico
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
            IBResDatos = new FontAwesome.Sharp.IconButton();
            IBAgregarOS = new FontAwesome.Sharp.IconButton();
            CBGeneroAnteojo = new ComboBox();
            LGeneroAnteojo = new Label();
            CBColorAnteojo = new ComboBox();
            LColorAnteojo = new Label();
            CBCristalAnteojo = new ComboBox();
            LCristalAnteojo = new Label();
            LFormaAnteojo = new Label();
            panel1 = new Panel();
            TGradDer = new TextBox();
            LGraduacionDerecha = new Label();
            TGradIzq = new TextBox();
            LGraduacionIzq = new Label();
            CBFormaAnteojo = new ComboBox();
            TStock = new TextBox();
            LStock = new Label();
            LCargarAnteojo = new Label();
            LMarca = new Label();
            ComboBox_Marca = new ComboBox();
            ComboBox_Estilo = new ComboBox();
            TPrecio = new TextBox();
            LEstilo = new Label();
            LPrecio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // IBResDatos
            // 
            IBResDatos.Anchor = AnchorStyles.None;
            IBResDatos.BackColor = Color.Transparent;
            IBResDatos.FlatStyle = FlatStyle.Flat;
            IBResDatos.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBResDatos.ForeColor = SystemColors.ControlText;
            IBResDatos.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            IBResDatos.IconColor = Color.White;
            IBResDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBResDatos.IconSize = 27;
            IBResDatos.Location = new Point(551, 430);
            IBResDatos.Name = "IBResDatos";
            IBResDatos.Size = new Size(35, 35);
            IBResDatos.TabIndex = 81;
            IBResDatos.UseVisualStyleBackColor = false;
            IBResDatos.Click += IBResDatos_Click;
            // 
            // IBAgregarOS
            // 
            IBAgregarOS.Anchor = AnchorStyles.None;
            IBAgregarOS.BackColor = Color.Transparent;
            IBAgregarOS.FlatStyle = FlatStyle.Flat;
            IBAgregarOS.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            IBAgregarOS.ForeColor = SystemColors.ControlText;
            IBAgregarOS.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            IBAgregarOS.IconColor = Color.White;
            IBAgregarOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBAgregarOS.IconSize = 27;
            IBAgregarOS.Location = new Point(592, 430);
            IBAgregarOS.Name = "IBAgregarOS";
            IBAgregarOS.Size = new Size(35, 35);
            IBAgregarOS.TabIndex = 80;
            IBAgregarOS.UseVisualStyleBackColor = false;
            IBAgregarOS.Click += IBAgregarOS_Click;
            // 
            // CBGeneroAnteojo
            // 
            CBGeneroAnteojo.Anchor = AnchorStyles.None;
            CBGeneroAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGeneroAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBGeneroAnteojo.FormattingEnabled = true;
            CBGeneroAnteojo.Items.AddRange(new object[] { "M", "F" });
            CBGeneroAnteojo.Location = new Point(639, 389);
            CBGeneroAnteojo.Name = "CBGeneroAnteojo";
            CBGeneroAnteojo.Size = new Size(121, 33);
            CBGeneroAnteojo.TabIndex = 79;
            // 
            // LGeneroAnteojo
            // 
            LGeneroAnteojo.Anchor = AnchorStyles.None;
            LGeneroAnteojo.AutoSize = true;
            LGeneroAnteojo.BackColor = Color.Transparent;
            LGeneroAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LGeneroAnteojo.ForeColor = Color.White;
            LGeneroAnteojo.Location = new Point(391, 394);
            LGeneroAnteojo.Name = "LGeneroAnteojo";
            LGeneroAnteojo.Size = new Size(190, 28);
            LGeneroAnteojo.TabIndex = 78;
            LGeneroAnteojo.Text = "Genero del Anteojo:";
            // 
            // CBColorAnteojo
            // 
            CBColorAnteojo.Anchor = AnchorStyles.None;
            CBColorAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBColorAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBColorAnteojo.FormattingEnabled = true;
            CBColorAnteojo.Items.AddRange(new object[] { "Rojo", "Azul", "Verde", "Rosa", "Amarillo", "Negro", "Blanco" });
            CBColorAnteojo.Location = new Point(639, 350);
            CBColorAnteojo.Name = "CBColorAnteojo";
            CBColorAnteojo.Size = new Size(121, 33);
            CBColorAnteojo.TabIndex = 77;
            // 
            // LColorAnteojo
            // 
            LColorAnteojo.Anchor = AnchorStyles.None;
            LColorAnteojo.AutoSize = true;
            LColorAnteojo.BackColor = Color.Transparent;
            LColorAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LColorAnteojo.ForeColor = Color.White;
            LColorAnteojo.Location = new Point(391, 355);
            LColorAnteojo.Name = "LColorAnteojo";
            LColorAnteojo.Size = new Size(174, 28);
            LColorAnteojo.TabIndex = 76;
            LColorAnteojo.Text = "Color del Anteojo:";
            // 
            // CBCristalAnteojo
            // 
            CBCristalAnteojo.Anchor = AnchorStyles.None;
            CBCristalAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCristalAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBCristalAnteojo.FormattingEnabled = true;
            CBCristalAnteojo.Location = new Point(639, 235);
            CBCristalAnteojo.Name = "CBCristalAnteojo";
            CBCristalAnteojo.Size = new Size(121, 33);
            CBCristalAnteojo.TabIndex = 75;
            // 
            // LCristalAnteojo
            // 
            LCristalAnteojo.Anchor = AnchorStyles.None;
            LCristalAnteojo.AutoSize = true;
            LCristalAnteojo.BackColor = Color.Transparent;
            LCristalAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LCristalAnteojo.ForeColor = Color.White;
            LCristalAnteojo.Location = new Point(391, 236);
            LCristalAnteojo.Name = "LCristalAnteojo";
            LCristalAnteojo.Size = new Size(184, 28);
            LCristalAnteojo.TabIndex = 74;
            LCristalAnteojo.Text = "Cristal del Anteojo:";
            // 
            // LFormaAnteojo
            // 
            LFormaAnteojo.Anchor = AnchorStyles.None;
            LFormaAnteojo.AutoSize = true;
            LFormaAnteojo.BackColor = Color.Transparent;
            LFormaAnteojo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LFormaAnteojo.ForeColor = Color.White;
            LFormaAnteojo.Location = new Point(391, 201);
            LFormaAnteojo.Name = "LFormaAnteojo";
            LFormaAnteojo.Size = new Size(182, 28);
            LFormaAnteojo.TabIndex = 72;
            LFormaAnteojo.Text = "Forma del Anteojo:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(TGradDer);
            panel1.Controls.Add(LGraduacionDerecha);
            panel1.Controls.Add(TGradIzq);
            panel1.Controls.Add(LGraduacionIzq);
            panel1.Controls.Add(IBResDatos);
            panel1.Controls.Add(IBAgregarOS);
            panel1.Controls.Add(CBGeneroAnteojo);
            panel1.Controls.Add(LGeneroAnteojo);
            panel1.Controls.Add(CBColorAnteojo);
            panel1.Controls.Add(LColorAnteojo);
            panel1.Controls.Add(CBCristalAnteojo);
            panel1.Controls.Add(LCristalAnteojo);
            panel1.Controls.Add(CBFormaAnteojo);
            panel1.Controls.Add(TStock);
            panel1.Controls.Add(LFormaAnteojo);
            panel1.Controls.Add(LStock);
            panel1.Controls.Add(LCargarAnteojo);
            panel1.Controls.Add(LMarca);
            panel1.Controls.Add(ComboBox_Marca);
            panel1.Controls.Add(ComboBox_Estilo);
            panel1.Controls.Add(TPrecio);
            panel1.Controls.Add(LEstilo);
            panel1.Controls.Add(LPrecio);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 477);
            panel1.TabIndex = 77;
            // 
            // TGradDer
            // 
            TGradDer.Anchor = AnchorStyles.None;
            TGradDer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TGradDer.Location = new Point(639, 80);
            TGradDer.Name = "TGradDer";
            TGradDer.Size = new Size(121, 32);
            TGradDer.TabIndex = 85;
            // 
            // LGraduacionDerecha
            // 
            LGraduacionDerecha.Anchor = AnchorStyles.None;
            LGraduacionDerecha.AutoSize = true;
            LGraduacionDerecha.BackColor = Color.Transparent;
            LGraduacionDerecha.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LGraduacionDerecha.ForeColor = Color.White;
            LGraduacionDerecha.Location = new Point(391, 80);
            LGraduacionDerecha.Name = "LGraduacionDerecha";
            LGraduacionDerecha.Size = new Size(198, 28);
            LGraduacionDerecha.TabIndex = 84;
            LGraduacionDerecha.Text = "Graduacion Derecha:";
            // 
            // TGradIzq
            // 
            TGradIzq.Anchor = AnchorStyles.None;
            TGradIzq.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TGradIzq.Location = new Point(639, 42);
            TGradIzq.Name = "TGradIzq";
            TGradIzq.Size = new Size(121, 32);
            TGradIzq.TabIndex = 83;
            // 
            // LGraduacionIzq
            // 
            LGraduacionIzq.Anchor = AnchorStyles.None;
            LGraduacionIzq.AutoSize = true;
            LGraduacionIzq.BackColor = Color.Transparent;
            LGraduacionIzq.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LGraduacionIzq.ForeColor = Color.White;
            LGraduacionIzq.Location = new Point(391, 43);
            LGraduacionIzq.Name = "LGraduacionIzq";
            LGraduacionIzq.Size = new Size(210, 28);
            LGraduacionIzq.TabIndex = 82;
            LGraduacionIzq.Text = "Graduacion Izquierda:";
            // 
            // CBFormaAnteojo
            // 
            CBFormaAnteojo.Anchor = AnchorStyles.None;
            CBFormaAnteojo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBFormaAnteojo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CBFormaAnteojo.FormattingEnabled = true;
            CBFormaAnteojo.Location = new Point(639, 196);
            CBFormaAnteojo.Name = "CBFormaAnteojo";
            CBFormaAnteojo.Size = new Size(121, 33);
            CBFormaAnteojo.TabIndex = 73;
            // 
            // TStock
            // 
            TStock.Anchor = AnchorStyles.None;
            TStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TStock.Location = new Point(639, 312);
            TStock.Name = "TStock";
            TStock.Size = new Size(121, 32);
            TStock.TabIndex = 73;
            // 
            // LStock
            // 
            LStock.Anchor = AnchorStyles.None;
            LStock.AutoSize = true;
            LStock.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LStock.ForeColor = Color.White;
            LStock.Location = new Point(391, 316);
            LStock.Name = "LStock";
            LStock.Size = new Size(174, 28);
            LStock.TabIndex = 72;
            LStock.Text = "Stock del Anteojo:";
            // 
            // LCargarAnteojo
            // 
            LCargarAnteojo.Anchor = AnchorStyles.None;
            LCargarAnteojo.AutoSize = true;
            LCargarAnteojo.Font = new Font("Sitka Text", 13F, FontStyle.Bold, GraphicsUnit.Point);
            LCargarAnteojo.ForeColor = Color.White;
            LCargarAnteojo.Location = new Point(461, 9);
            LCargarAnteojo.Name = "LCargarAnteojo";
            LCargarAnteojo.Size = new Size(283, 26);
            LCargarAnteojo.TabIndex = 71;
            LCargarAnteojo.Text = "Cargar un Anteojo Terapeutico";
            // 
            // LMarca
            // 
            LMarca.Anchor = AnchorStyles.None;
            LMarca.AutoSize = true;
            LMarca.BackColor = Color.Transparent;
            LMarca.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.White;
            LMarca.Location = new Point(391, 119);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(180, 28);
            LMarca.TabIndex = 61;
            LMarca.Text = "Marca del Anteojo:";
            // 
            // ComboBox_Marca
            // 
            ComboBox_Marca.Anchor = AnchorStyles.None;
            ComboBox_Marca.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Marca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_Marca.FormattingEnabled = true;
            ComboBox_Marca.Location = new Point(639, 118);
            ComboBox_Marca.Name = "ComboBox_Marca";
            ComboBox_Marca.Size = new Size(121, 33);
            ComboBox_Marca.TabIndex = 64;
            // 
            // ComboBox_Estilo
            // 
            ComboBox_Estilo.Anchor = AnchorStyles.None;
            ComboBox_Estilo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Estilo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_Estilo.FormattingEnabled = true;
            ComboBox_Estilo.Location = new Point(639, 157);
            ComboBox_Estilo.Name = "ComboBox_Estilo";
            ComboBox_Estilo.Size = new Size(121, 33);
            ComboBox_Estilo.TabIndex = 65;
            // 
            // TPrecio
            // 
            TPrecio.Anchor = AnchorStyles.None;
            TPrecio.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TPrecio.Location = new Point(639, 274);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(121, 32);
            TPrecio.TabIndex = 68;
            // 
            // LEstilo
            // 
            LEstilo.Anchor = AnchorStyles.None;
            LEstilo.AutoSize = true;
            LEstilo.BackColor = Color.Transparent;
            LEstilo.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LEstilo.ForeColor = Color.White;
            LEstilo.Location = new Point(391, 162);
            LEstilo.Name = "LEstilo";
            LEstilo.Size = new Size(176, 28);
            LEstilo.TabIndex = 62;
            LEstilo.Text = "Estilo del Anteojo:";
            // 
            // LPrecio
            // 
            LPrecio.Anchor = AnchorStyles.None;
            LPrecio.AutoSize = true;
            LPrecio.BackColor = Color.Transparent;
            LPrecio.Font = new Font("Sitka Text", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LPrecio.ForeColor = Color.White;
            LPrecio.Location = new Point(391, 275);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(181, 28);
            LPrecio.TabIndex = 63;
            LPrecio.Text = "Precio del Anteojo:";
            // 
            // Alta_productoTerapeutico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1187, 477);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Alta_productoTerapeutico";
            Text = "Alta_producto";
            Load += Alta_producto_Load;
            KeyPress += TId_prod_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton IBResDatos;
        private FontAwesome.Sharp.IconButton IBAgregarOS;
        private ComboBox CBGeneroAnteojo;
        private Label LGeneroAnteojo;
        private ComboBox CBColorAnteojo;
        private Label LColorAnteojo;
        private ComboBox CBCristalAnteojo;
        private Label LCristalAnteojo;
        private Label LFormaAnteojo;
        private Panel panel1;
        private TextBox TGradDer;
        private Label LGraduacionDerecha;
        private TextBox TGradIzq;
        private Label LGraduacionIzq;
        private ComboBox CBFormaAnteojo;
        private TextBox TStock;
        private Label LStock;
        private Label LCargarAnteojo;
        private Label LMarca;
        private ComboBox ComboBox_Marca;
        private ComboBox ComboBox_Estilo;
        private TextBox TPrecio;
        private Label LEstilo;
        private Label LPrecio;
    }
}
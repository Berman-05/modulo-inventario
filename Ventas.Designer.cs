namespace modulo_inventario
{
    partial class Ventas
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
            button2 = new Button();
            txtCodigo = new TextBox();
            button1 = new Button();
            btnComprar = new Button();
            dgvProductos = new DataGridView();
            nudCantidad = new NumericUpDown();
            LblCantidad = new Label();
            lblCodigo = new Label();
            panel2 = new Panel();
            btnInicio = new Button();
            LblTitulo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnComprar);
            panel1.Controls.Add(dgvProductos);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(LblCantidad);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);

            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 720);

            panel1.TabIndex = 0;
           
            // 
            // button2
            // 
            button2.Location = new Point(930, 622);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 54;
            button2.Text = "Factura";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCodigo
            // 

            txtCodigo.Location = new Point(277, 173);
            txtCodigo.Margin = new Padding(4, 3, 4, 3);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(260, 31);

            txtCodigo.TabIndex = 53;
            // 
            // button1
            // 

            button1.Location = new Point(924, 232);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);

            button1.TabIndex = 52;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            
            // 
            // btnComprar
            // 
            btnComprar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComprar.BackColor = Color.Gold;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);

            btnComprar.Location = new Point(51, 277);
            btnComprar.Margin = new Padding(4, 5, 4, 5);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(990, 43);

            btnComprar.TabIndex = 50;
            btnComprar.Text = "Ventas";
            btnComprar.UseVisualStyleBackColor = false;
            
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvProductos.Location = new Point(51, 332);
            dgvProductos.Margin = new Padding(4, 5, 4, 5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(990, 257);

            dgvProductos.TabIndex = 49;
            
            // 
            // nudCantidad
            // 

            nudCantidad.Location = new Point(733, 170);
            nudCantidad.Margin = new Padding(4, 5, 4, 5);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(309, 31);

            nudCantidad.TabIndex = 47;
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

            LblCantidad.Location = new Point(633, 172);
            LblCantidad.Margin = new Padding(4, 0, 4, 0);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(94, 21);

            LblCantidad.TabIndex = 45;
            LblCantidad.Text = "Cantidad";
            LblCantidad.Click += LblCantidad_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

            lblCodigo.Location = new Point(60, 173);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(76, 21);

            lblCodigo.TabIndex = 42;
            lblCodigo.Text = "Código";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(60, 100, 220);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(LblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);

            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1099, 75);

            panel2.TabIndex = 40;
            // 
            // btnInicio
            // 
            btnInicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInicio.Dock = DockStyle.Left;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(0, 0);

            btnInicio.Margin = new Padding(4, 3, 4, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(119, 75);

            btnInicio.TabIndex = 5;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);

            LblTitulo.Location = new Point(377, 15);
            LblTitulo.Margin = new Padding(4, 0, 4, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(296, 34);

            LblTitulo.TabIndex = 24;
            LblTitulo.Text = "Ventas de productos";
            
            // 
            // Ventas
            // 

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 720);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);

            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            Load += Ventas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnComprar;
        private DataGridView dgvProductos;
        private NumericUpDown nudCantidad;
        private Label LblCantidad;
        private Label lblCodigo;
        private Panel panel2;
        private Button btnInicio;
        private Label LblTitulo;
        private Button button1;
        private TextBox txtCodigo;
        private Button button2;
    }
}
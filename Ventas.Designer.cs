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
            comboBox1 = new ComboBox();
            btnComprar = new Button();
            dgvProductos = new DataGridView();
            nudCantidad = new NumericUpDown();
            LblCantidad = new Label();
            LblNombre = new Label();
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
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnComprar);
            panel1.Controls.Add(dgvProductos);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(LblCantidad);
            panel1.Controls.Add(LblNombre);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 432);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pollo Rey", "Pierna de pollo", "Medallones", "Alas de pollo", "Toledo", "Xelac" });
            comboBox1.Location = new Point(184, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 25);
            comboBox1.TabIndex = 51;
            // 
            // btnComprar
            // 
            btnComprar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComprar.BackColor = Color.Gold;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(36, 166);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(693, 26);
            btnComprar.TabIndex = 50;
            btnComprar.Text = "Ventas";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(36, 198);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(693, 154);
            dgvProductos.TabIndex = 49;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(513, 102);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(216, 23);
            nudCantidad.TabIndex = 47;
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCantidad.Location = new Point(443, 103);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(64, 17);
            LblCantidad.TabIndex = 45;
            LblCantidad.Text = "Cantidad";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(42, 104);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(137, 17);
            LblNombre.TabIndex = 42;
            LblNombre.Text = "Nombre del producto";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(60, 100, 220);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(LblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 45);
            panel2.TabIndex = 40;
            // 
            // btnInicio
            // 
            btnInicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInicio.Dock = DockStyle.Left;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(83, 45);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(264, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(201, 23);
            LblTitulo.TabIndex = 24;
            LblTitulo.Text = "Ventas de productos";
            LblTitulo.Click += LblTitulo_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 432);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
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
        private Label LblNombre;
        private Panel panel2;
        private Button btnInicio;
        private Label LblTitulo;
        private ComboBox comboBox1;
    }
}
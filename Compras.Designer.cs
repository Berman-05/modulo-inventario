namespace modulo_inventario
{
    partial class Compras
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
            btnComprar = new Button();
            dgvProductos = new DataGridView();
            cbProveedores = new ComboBox();
            nudCantidad = new NumericUpDown();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            LblCantidad = new Label();
            LblProveedor = new Label();
            LblNombre = new Label();
            txtNombre = new TextBox();
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
            panel1.Controls.Add(btnComprar);
            panel1.Controls.Add(dgvProductos);
            panel1.Controls.Add(cbProveedores);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(LblCantidad);
            panel1.Controls.Add(LblProveedor);
            panel1.Controls.Add(LblNombre);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 576);
            panel1.TabIndex = 0;
            // 
            // btnComprar
            // 
            btnComprar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComprar.BackColor = Color.Gold;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(722, 129);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(82, 75);
            btnComprar.TabIndex = 39;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(82, 249);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(696, 205);
            dgvProductos.TabIndex = 38;
            // 
            // cbProveedores
            // 
            cbProveedores.FormattingEnabled = true;
            cbProveedores.Items.AddRange(new object[] { "Pollo Rey", "Toledo", "Xelac" });
            cbProveedores.Location = new Point(517, 128);
            cbProveedores.Margin = new Padding(3, 4, 3, 4);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Size = new Size(188, 28);
            cbProveedores.TabIndex = 37;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(203, 172);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(99, 27);
            nudCantidad.TabIndex = 36;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(401, 172);
            lblPrecio.Margin = new Padding(3, 4, 3, 4);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(116, 20);
            lblPrecio.TabIndex = 35;
            lblPrecio.Text = "Precio Unitario";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(517, 172);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(187, 26);
            txtPrecio.TabIndex = 33;
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCantidad.Location = new Point(123, 173);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(78, 20);
            LblCantidad.TabIndex = 34;
            LblCantidad.Text = "Cantidad";
            // 
            // LblProveedor
            // 
            LblProveedor.AutoSize = true;
            LblProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProveedor.Location = new Point(429, 128);
            LblProveedor.Margin = new Padding(3, 4, 3, 4);
            LblProveedor.Name = "LblProveedor";
            LblProveedor.Size = new Size(88, 20);
            LblProveedor.TabIndex = 32;
            LblProveedor.Text = "Proveedor";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(33, 129);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(168, 20);
            LblNombre.TabIndex = 31;
            LblNombre.Text = "Nombre del producto";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(203, 127);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 26);
            txtNombre.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(60, 100, 220);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(LblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 60);
            panel2.TabIndex = 29;
            // 
            // btnInicio
            // 
            btnInicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInicio.Dock = DockStyle.Left;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(95, 60);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click_1;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(302, 12);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(259, 27);
            LblTitulo.TabIndex = 24;
            LblTitulo.Text = "Compra de productos";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 576);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            Load += Compras_Load;
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
        private ComboBox cbProveedores;
        private NumericUpDown nudCantidad;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label LblCantidad;
        private Label LblProveedor;
        private Label LblNombre;
        private TextBox txtNombre;
        private Panel panel2;
        private Button btnInicio;
        private Label LblTitulo;
    }
}
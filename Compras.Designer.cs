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
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 369);
            panel1.TabIndex = 0;
            // 
            // btnComprar
            // 
            btnComprar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComprar.BackColor = Color.Gold;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(632, 97);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(72, 56);
            btnComprar.TabIndex = 39;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(72, 187);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(609, 154);
            dgvProductos.TabIndex = 38;
            // 
            // cbProveedores
            // 
            cbProveedores.FormattingEnabled = true;
            cbProveedores.Items.AddRange(new object[] { "Pollo Rey", "Toledo", "Xelac" });
            cbProveedores.Location = new Point(452, 96);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Size = new Size(165, 23);
            cbProveedores.TabIndex = 37;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(178, 129);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(87, 23);
            nudCantidad.TabIndex = 36;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(351, 129);
            lblPrecio.Margin = new Padding(3);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(95, 17);
            lblPrecio.TabIndex = 35;
            lblPrecio.Text = "Precio Unitario";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(452, 129);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 22);
            txtPrecio.TabIndex = 33;
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCantidad.Location = new Point(108, 130);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(64, 17);
            LblCantidad.TabIndex = 34;
            LblCantidad.Text = "Cantidad";
            // 
            // LblProveedor
            // 
            LblProveedor.AutoSize = true;
            LblProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProveedor.Location = new Point(375, 96);
            LblProveedor.Margin = new Padding(3);
            LblProveedor.Name = "LblProveedor";
            LblProveedor.Size = new Size(71, 17);
            LblProveedor.TabIndex = 32;
            LblProveedor.Text = "Proveedor";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(36, 96);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(137, 17);
            LblNombre.TabIndex = 31;
            LblNombre.Text = "Nombre del producto";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(178, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 22);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 45);
            panel2.TabIndex = 29;
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
            btnInicio.Click += btnInicio_Click_1;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(264, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(215, 23);
            LblTitulo.TabIndex = 24;
            LblTitulo.Text = "Compra de productos";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 369);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
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
            btnSalir = new Button();
            btnInicio = new Button();
            LblTitulo = new Label();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            LblCantidad = new Label();
            LblProveedor = new Label();
            LblNombre = new Label();
            txtNombre = new TextBox();
            nudCantidad = new NumericUpDown();
            cbProveedores = new ComboBox();
            dgvProductos = new DataGridView();
            btnComprar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(60, 100, 220);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(LblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 45);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnSalir
            // 
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(644, 0);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(83, 45);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
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
            btnInicio.Click += btnInicio_Click;
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
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(351, 102);
            lblPrecio.Margin = new Padding(3);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(95, 17);
            lblPrecio.TabIndex = 23;
            lblPrecio.Text = "Precio Unitario";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(452, 102);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 22);
            txtPrecio.TabIndex = 21;
            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCantidad.Location = new Point(108, 103);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(64, 17);
            LblCantidad.TabIndex = 22;
            LblCantidad.Text = "Cantidad";
            // 
            // LblProveedor
            // 
            LblProveedor.AutoSize = true;
            LblProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblProveedor.Location = new Point(375, 69);
            LblProveedor.Margin = new Padding(3);
            LblProveedor.Name = "LblProveedor";
            LblProveedor.Size = new Size(71, 17);
            LblProveedor.TabIndex = 20;
            LblProveedor.Text = "Proveedor";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(36, 69);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(137, 17);
            LblNombre.TabIndex = 17;
            LblNombre.Text = "Nombre del producto";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(178, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 22);
            txtNombre.TabIndex = 16;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(178, 102);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(87, 23);
            nudCantidad.TabIndex = 25;
            // 
            // cbProveedores
            // 
            cbProveedores.FormattingEnabled = true;
            cbProveedores.Items.AddRange(new object[] { "Pollo Rey", "Toledo", "Xelac" });
            cbProveedores.Location = new Point(452, 69);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Size = new Size(165, 23);
            cbProveedores.TabIndex = 26;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(72, 160);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(609, 154);
            dgvProductos.TabIndex = 27;
            // 
            // btnComprar
            // 
            btnComprar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComprar.BackColor = Color.Gold;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(632, 70);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(72, 56);
            btnComprar.TabIndex = 28;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 369);
            Controls.Add(btnComprar);
            Controls.Add(dgvProductos);
            Controls.Add(cbProveedores);
            Controls.Add(nudCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(LblCantidad);
            Controls.Add(LblProveedor);
            Controls.Add(LblNombre);
            Controls.Add(txtNombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            Load += Compras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private Button btnInicio;
        private Label LblTitulo;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label LblCantidad;
        private Label LblProveedor;
        private Label LblNombre;
        private TextBox txtNombre;
        private NumericUpDown nudCantidad;
        private ComboBox cbProveedores;
        private DataGridView dgvProductos;
        private Button btnComprar;
    }
}
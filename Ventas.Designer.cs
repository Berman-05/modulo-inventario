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

        private void InitializeComponent()
        {
            panel1 = new Panel();
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
            buttonGenerarFactura = new Button(); // Nuevo botón agregado

            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();

            // 
            // panel1
            // 
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnComprar);
            panel1.Controls.Add(dgvProductos);
            panel1.Controls.Add(nudCantidad);
            panel1.Controls.Add(LblCantidad);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonGenerarFactura); // Añadido aquí
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 576);
            panel1.TabIndex = 0;

            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(222, 139);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(209, 27);
            txtCodigo.TabIndex = 53;

            // 
            // button1
            // 
            button1.Location = new Point(739, 185);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 52;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // 
            // btnComprar
            // 
            btnComprar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComprar.BackColor = Color.Gold;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Location = new Point(41, 221);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(792, 35);
            btnComprar.TabIndex = 50;
            btnComprar.Text = "Ventas";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;

            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(41, 264);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(792, 205);
            dgvProductos.TabIndex = 49;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;

            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(586, 136);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(247, 27);
            nudCantidad.TabIndex = 47;

            // 
            // LblCantidad
            // 
            LblCantidad.AutoSize = true;
            LblCantidad.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblCantidad.Location = new Point(502, 138);
            LblCantidad.Name = "LblCantidad";
            LblCantidad.Size = new Size(78, 20);
            LblCantidad.TabIndex = 45;
            LblCantidad.Text = "Cantidad";

            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigo.Location = new Point(48, 139);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(64, 20);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 60);
            panel2.TabIndex = 40;

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
            btnInicio.Click += btnInicio_Click;

            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LblTitulo.Location = new Point(302, 12);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(244, 27);
            LblTitulo.TabIndex = 24;
            LblTitulo.Text = "Ventas de productos";

            // 
            // buttonGenerarFactura
            // 
            buttonGenerarFactura.Location = new Point(739, 480); // Ubicación ajustable
            buttonGenerarFactura.Name = "buttonGenerarFactura";
            buttonGenerarFactura.Size = new Size(94, 29);
            buttonGenerarFactura.TabIndex = 54;
            buttonGenerarFactura.Text = "Factura";
            buttonGenerarFactura.UseVisualStyleBackColor = true;
            buttonGenerarFactura.Click += buttonGenerarFactura_Click;

            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 576);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button buttonGenerarFactura; // Declaración del nuevo botón
    }
}

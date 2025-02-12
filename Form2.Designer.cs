namespace modulo_inventario
{
    partial class Form2
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
            dgvInventario = new DataGridView();
            txtBusqueda = new TextBox();
            panel2 = new Panel();
            LblTitulo = new Label();
            btnInicio = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvInventario);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 432);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dgvInventario
            // 
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(68, 155);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(609, 162);
            dgvInventario.TabIndex = 39;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(255, 255, 128);
            txtBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtBusqueda.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(105, 82);
            txtBusqueda.Multiline = true;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar...";
            txtBusqueda.Size = new Size(527, 34);
            txtBusqueda.TabIndex = 30;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 100, 220);
            panel2.Controls.Add(LblTitulo);
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 45);
            panel2.TabIndex = 29;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(245, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(230, 23);
            LblTitulo.TabIndex = 36;
            LblTitulo.Text = "Inventario de productos";
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Left;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.Location = new Point(0, 0);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(57, 45);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 432);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvInventario;
        private Label LblTitulo;
        private TextBox txtBusqueda;
        private Panel panel2;
        private Button btnInicio;
    }
}
namespace modulo_inventario
{
    partial class RecursosHumanos
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
            button1 = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtBonificacion = new TextBox();
            lblBonificaciones = new Label();
            txtSalarioBase = new TextBox();
            lblSalario = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            dgvEmpleados = new DataGridView();
            lblNombre = new Label();
            panel2 = new Panel();
            btnInicio = new Button();
            lblTitulo = new Label();
            btnCambiarSalario = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCambiarSalario);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtBonificacion);
            panel1.Controls.Add(lblBonificaciones);
            panel1.Controls.Add(txtSalarioBase);
            panel1.Controls.Add(lblSalario);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(lblContrasena);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(dgvEmpleados);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 393);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(568, 139);
            button1.Name = "button1";
            button1.Size = new Size(81, 52);
            button1.TabIndex = 74;
            button1.Text = "Cambiar Estado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnToggleEstado_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(661, 71);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 52);
            btnEditar.TabIndex = 73;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditarEmpleado_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(568, 71);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(80, 52);
            btnAgregar.TabIndex = 72;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBonificacion
            // 
            txtBonificacion.Location = new Point(376, 168);
            txtBonificacion.Margin = new Padding(3, 2, 3, 2);
            txtBonificacion.Name = "txtBonificacion";
            txtBonificacion.Size = new Size(183, 23);
            txtBonificacion.TabIndex = 71;
            // 
            // lblBonificaciones
            // 
            lblBonificaciones.AutoSize = true;
            lblBonificaciones.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBonificaciones.Location = new Point(283, 169);
            lblBonificaciones.Name = "lblBonificaciones";
            lblBonificaciones.Size = new Size(95, 17);
            lblBonificaciones.TabIndex = 70;
            lblBonificaciones.Text = "Bonificaciones";
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Location = new Point(378, 117);
            txtSalarioBase.Margin = new Padding(3, 2, 3, 2);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(183, 23);
            txtSalarioBase.TabIndex = 69;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalario.Location = new Point(316, 120);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(49, 17);
            lblSalario.TabIndex = 68;
            lblSalario.Text = "Salario";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(378, 69);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(183, 23);
            txtTelefono.TabIndex = 67;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(313, 71);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 17);
            lblTelefono.TabIndex = 66;
            lblTelefono.Text = "Teléfono";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(94, 167);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(183, 23);
            txtContrasena.TabIndex = 65;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(15, 164);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(77, 17);
            lblContrasena.TabIndex = 64;
            lblContrasena.Text = "Contraseña";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 117);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 63;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(34, 115);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 17);
            lblApellido.TabIndex = 62;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 68);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 61;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(15, 210);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(726, 171);
            dgvEmpleados.TabIndex = 58;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(34, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 17);
            lblNombre.TabIndex = 55;
            lblNombre.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(60, 100, 220);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 45);
            panel2.TabIndex = 54;
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(264, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(181, 23);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "Recursos Humanos";
            // 
            // btnCambiarSalario
            // 
            btnCambiarSalario.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarSalario.Location = new Point(660, 139);
            btnCambiarSalario.Name = "btnCambiarSalario";
            btnCambiarSalario.Size = new Size(81, 52);
            btnCambiarSalario.TabIndex = 75;
            btnCambiarSalario.Text = "Cambiar Salarios";
            btnCambiarSalario.UseVisualStyleBackColor = true;
            btnCambiarSalario.Click += btnCambiarSalario_Click;
            // 
            // RecursosHumanos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 393);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecursosHumanos";
            Text = "RecursosHumanos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private DataGridView dgvEmpleados;
        private Label lblNombre;
        private Panel panel2;
        private Button btnInicio;
        private Label lblTitulo;
        private TextBox txtBonificacion;
        private Label lblBonificaciones;
        private TextBox txtSalarioBase;
        private Label lblSalario;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Button btnAgregar;
        private Button button1;
        private Button btnEditar;
        private Button btnCambiarSalario;
    }
}
namespace modulo_inventario
{
    partial class Menú
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
            btnVentas = new Button();
            btnRH = new Button();
            btnCompras = new Button();
            btnInventario = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnRH);
            panel1.Controls.Add(btnCompras);
            panel1.Controls.Add(btnInventario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 349);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button2.Location = new Point(359, 184);
            button2.Margin = new Padding(17, 20, 17, 20);
            button2.Name = "button2";
            button2.Size = new Size(121, 119);
            button2.TabIndex = 6;
            button2.Text = "Finanzas";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnVentas
            // 
            btnVentas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVentas.BackColor = Color.Gold;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnVentas.Location = new Point(623, 45);
            btnVentas.Margin = new Padding(17, 20, 17, 20);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(121, 119);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Ventas";
            btnVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnRH
            // 
            btnRH.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRH.BackColor = Color.Gold;
            btnRH.FlatStyle = FlatStyle.Flat;
            btnRH.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnRH.Location = new Point(446, 45);
            btnRH.Margin = new Padding(17, 20, 17, 20);
            btnRH.Name = "btnRH";
            btnRH.Size = new Size(121, 119);
            btnRH.TabIndex = 2;
            btnRH.Text = "Recursos Humanos";
            btnRH.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRH.UseVisualStyleBackColor = false;
            btnRH.Click += btnRH_Click;
            // 
            // btnCompras
            // 
            btnCompras.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCompras.BackColor = Color.Gold;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnCompras.Location = new Point(270, 45);
            btnCompras.Margin = new Padding(17, 20, 17, 20);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(121, 119);
            btnCompras.TabIndex = 1;
            btnCompras.Text = "Compras";
            btnCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnInventario
            // 
            btnInventario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInventario.BackColor = Color.Gold;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnInventario.Location = new Point(93, 45);
            btnInventario.Margin = new Padding(17, 20, 17, 20);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(121, 119);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Inventario";
            btnInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += Inventario_Click;
            // 
            // Menú
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 349);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menú";
            Text = "Menú";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCompras;
        private Button btnInventario;
        private Button btnRH;
        private Button btnVentas;
        private Button button2;
    }
}
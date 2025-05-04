namespace modulo_inventario
{
    partial class Reporte
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
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            egresosDgv = new DataGridView();
            ingresosDgv = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)egresosDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingresosDgv).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(egresosDgv);
            panel1.Controls.Add(ingresosDgv);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 429);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(623, 373);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 376);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 8;
            label5.Text = "Después de impuestos:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 373);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 376);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Ganancias:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label3.Location = new Point(623, 112);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 5;
            label3.Text = "Egresos";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label2.Location = new Point(161, 112);
            label2.Name = "label2";
            label2.Size = new Size(104, 27);
            label2.TabIndex = 4;
            label2.Text = "Ingresos";
            label2.Click += label2_Click;
            // 
            // egresosDgv
            // 
            egresosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            egresosDgv.Location = new Point(456, 153);
            egresosDgv.Name = "egresosDgv";
            egresosDgv.RowHeadersWidth = 51;
            egresosDgv.Size = new Size(393, 188);
            egresosDgv.TabIndex = 3;
            // 
            // ingresosDgv
            // 
            ingresosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingresosDgv.Location = new Point(12, 153);
            ingresosDgv.Name = "ingresosDgv";
            ingresosDgv.RowHeadersWidth = 51;
            ingresosDgv.Size = new Size(400, 188);
            ingresosDgv.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 100, 220);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 96);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 90);
            button1.TabIndex = 1;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label1.Location = new Point(328, 32);
            label1.Name = "label1";
            label1.Size = new Size(192, 27);
            label1.TabIndex = 0;
            label1.Text = "Reporte general";
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 429);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reporte";
            Text = "Reporte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)egresosDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingresosDgv).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView egresosDgv;
        private DataGridView ingresosDgv;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
    }
}
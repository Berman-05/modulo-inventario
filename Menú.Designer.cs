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
            button3 = new Button();
            button2 = new Button();
            Inventario = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Inventario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 350);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(304, 128);
            button3.Name = "button3";
            button3.Size = new Size(186, 61);
            button3.TabIndex = 2;
            button3.Text = "Ventas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(509, 128);
            button2.Name = "button2";
            button2.Size = new Size(186, 61);
            button2.TabIndex = 1;
            button2.Text = "Recursos humanos";
            button2.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            Inventario.Location = new Point(100, 128);
            Inventario.Name = "Inventario";
            Inventario.Size = new Size(186, 61);
            Inventario.TabIndex = 0;
            Inventario.Text = "Inventario";
            Inventario.UseVisualStyleBackColor = true;
            Inventario.Click += Inventario_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Menú
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menú";
            Text = "Menú";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button Inventario;
        private Button button3;
        private Button button1;
    }
}
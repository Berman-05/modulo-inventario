namespace modulo_inventario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pContainer = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            userBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pContainer.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 100, 220);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 75);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(739, 2);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(27, 25);
            button2.TabIndex = 1;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-23, -24);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pContainer
            // 
            pContainer.BackColor = SystemColors.ControlLightLight;
            pContainer.Controls.Add(panel2);
            pContainer.Dock = DockStyle.Fill;
            pContainer.Location = new Point(0, 75);
            pContainer.Margin = new Padding(3, 2, 3, 2);
            pContainer.Name = "pContainer";
            pContainer.Size = new Size(769, 357);
            pContainer.TabIndex = 1;
            pContainer.Paint += pContainer_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(userBox);
            panel2.Location = new Point(236, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 262);
            panel2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(34, 149);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Contraseña";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 12;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 17);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 8;
            label1.Text = "Inicio de sesión";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(120, 213);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 11;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // userBox
            // 
            userBox.Cursor = Cursors.IBeam;
            userBox.Location = new Point(34, 71);
            userBox.Margin = new Padding(3, 2, 3, 2);
            userBox.Name = "userBox";
            userBox.PlaceholderText = "Usuario";
            userBox.Size = new Size(243, 23);
            userBox.TabIndex = 9;
            userBox.TextChanged += userBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 432);
            Controls.Add(pContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel pContainer;
        private Button button2;
        private Button button1;
        private TextBox userBox;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
    }
}

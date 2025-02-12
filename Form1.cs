using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace modulo_inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        public void ChangeMenu(object menu)
        {
            if (this.pContainer.Controls.Count > 0)
            {
                this.pContainer.Controls.Clear();
            }
            Form display = menu as Form;
            display.TopLevel = false;
            display.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(display);
            this.pContainer.Tag = display;
            display.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string password = textBox1.Text;
            if (user == "Usuario1" && password == "123")
            {
                MessageBox.Show("Sesi�n iniciada     .");
                ChangeMenu(new Men�());
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

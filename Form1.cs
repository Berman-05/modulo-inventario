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
            string password = passwordBox.Text;
            if (user == "Usuario1" && password == "123")
            {
                MessageBox.Show("Sesión iniciada     .");
                ChangeMenu(new Menú());
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}

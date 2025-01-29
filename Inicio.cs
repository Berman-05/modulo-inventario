using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modulo_inventario
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string user = userBox.Text;
                string password = passwordBox.Text;
                if (user == "Usuario1" && password == "123")
                {
                    MessageBox.Show("Sesión iniciada.     ");
                    ChangeMenu(new Menú());
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            
        }
        public void ChangeMenu(object menu)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.Clear();
            }
            Form display = menu as Form;
            display.TopLevel = false;
            display.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(display);
            this.panel1.Tag = display;
            display.Show();
        }
    }
}

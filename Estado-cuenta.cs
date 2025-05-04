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
    public partial class Estado_cuenta : Form
    {
        public Estado_cuenta()
        {
            InitializeComponent();
            Estado_cuenta_Load(null, null);
        }
        decimal mostrarDinero = Finanzas.dinero;
        private void Estado_cuenta_Load(object sender, EventArgs e)
        {
            textBox1.Text = mostrarDinero.ToString("F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal deposito = decimal.Parse(textBox2.Text);
            Finanzas.dinero += deposito;
            textBox1.Text = Finanzas.dinero.ToString("F2");
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
        private void button2_Click(object sender, EventArgs e)
        {
            ChangeMenu(new Finanzas());
        }
    }
}

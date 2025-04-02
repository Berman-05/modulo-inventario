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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
            Estado_cuenta_Load(null, null);
            CargarEgresos();
            Cargaringresos();
        }

        decimal mostrarDinero = Finanzas.dinero;
        public static decimal ganancias = 0;
        private void Estado_cuenta_Load(object sender, EventArgs e)
        {
            textBox1.Text = mostrarDinero.ToString();
            textBox2.Text = (ganancias-((ganancias/1.12m)*0.17m)).ToString("F2");
        }
        public static List<Productos> ingresos = new List<Productos>();
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
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeMenu(new Finanzas());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void CargarEgresos()
        {
            // Crear una lista anónima con los atributos deseados
            var productosFiltrados = Productos.ComprasRealizadas
                .Select(p => new
                {
                    p.Nombre,
                    p.Cantidad,
                    p.Precio
                }).ToList();

            // Asignar la lista filtrada al DataGridView
            egresosDgv.DataSource = productosFiltrados;
        }
        private void Cargaringresos()
        {
            // Crear una lista anónima con los atributos deseados
            var productosFiltrados = Reporte.ingresos
                .Select(p => new
                {
                    p.Nombre,
                    p.Cantidad,
                    p.PrecioVenta
                }).ToList();

            // Asignar la lista filtrada al DataGridView
            ingresosDgv.DataSource = productosFiltrados;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeMenu(new Finanzas());
        }
    }
}

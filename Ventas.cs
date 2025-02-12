using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modulo_inventario
{
    public partial class Ventas : Form
    {

        public Ventas()
        {
            InitializeComponent();

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
           
            dgvProductos.ColumnCount = 4;
            dgvProductos.Columns[0].Name = "Nombre";
            dgvProductos.Columns[1].Name = "proveedor";
            dgvProductos.Columns[2].Name = "Cantidad";
            dgvProductos.Columns[3].Name = "precio";


        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
           

            DialogResult result = MessageBox.Show("¿Desea realizar el pago con tarjeta?\nSeleccione una opción:",
                                                              "Método de Pago",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question,
                                                              MessageBoxDefaultButton.Button1);

            // Evaluamos la opción seleccionada
            if (result == DialogResult.Yes)
            {
                // Opción de pago con tarjeta
                MessageBox.Show("Ha seleccionado pagar con tarjeta.\n¡Compra realizada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                // Opción de pago en efectivo
                MessageBox.Show("Ha seleccionado pagar en efectivo.\n¡Compra realizada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Total", "Total");
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            ChangeMenu(new Menú());
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            Productos buscar = Compras.existencias.Find(p => p.Nombre == nombre);
            if (buscar != null)
            {
                CargarProductos();
                dgvProductos.Rows.Add(textBox1.Text, buscar.Proveedor, nudCantidad.Text, buscar.Precio); // Agregar fila
                textBox1.Clear();
                textBox1.Clear();
                MessageBox.Show("añadido al pedido.");
            }
            else { MessageBox.Show("Sin existencias."); }

        }
            void CargarProductos()
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(nudCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

           

             }
        }
}

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
    public partial class Compras : Form
    {
        public static List<Productos> existencias = new List<Productos>();
        public Compras()
        {
            InitializeComponent();

            btnInicio.MouseEnter += btnInicio_MouseEnter;
            btnInicio.MouseLeave += btnInicio_MouseLeave;
            btnComprar.MouseEnter += btnComprar_MouseEnter;
            btnComprar.MouseLeave += btnComprar_MouseLeave;
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(173, 216, 230); // LightBlue en RGB
        }

        // Evento para cuando el cursor sale del botón Comprar
        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(60, 100, 220);
        }
        private void btnComprar_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.Yellow; // LightBlue en RGB
        }

        // Evento para cuando el cursor sale del botón Comprar
        private void btnComprar_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.Gold;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombre.Text; // TextBox para el nombre del producto
            string proveedor = cbProveedores.SelectedItem.ToString(); // ComboBox para el proveedor
            int cantidadComprada = (int)nudCantidad.Value; // NumericUpDown para la cantidad
            decimal precio = decimal.Parse(txtPrecio.Text); // Precio del producto
            decimal precioVenta = precio + (precio * 0.5m); // Precio de venta del producto
            int codigo = int.Parse(txtCodigo.Text); // Código del producto

            // Verificar si ya existe el producto en el inventario
            Productos productoExistente = existencias.FirstOrDefault(p => p.Nombre == nombreProducto);
            Productos codigoExistente = existencias.FirstOrDefault(p => p.Codigo == codigo);

            if (codigoExistente != null && productoExistente != null)
            {
                // Si el producto existe, actualizar la cantidad y el precio
                if (codigoExistente.Codigo == codigo)
                {
                    productoExistente.Cantidad += cantidadComprada;
                }
                else
                {
                    MessageBox.Show("El producto ya existe en el inventario");
                }

            }
            else if (codigoExistente == null)
            {
                // Si el producto no existe, agregarlo al inventario con el precio
                Productos nuevoProducto = new Productos(codigo, nombreProducto, proveedor, precio, precioVenta, cantidadComprada);
                existencias.Add(nuevoProducto);
            }

            // Agregar el producto a la lista de compras realizadas (con el precio correcto)
            Productos.ComprasRealizadas.Add(new Productos(codigo, nombreProducto, proveedor, precio, precioVenta, cantidadComprada));

            // Actualizar el DataGridView con la lista de productos actualizada
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = existencias;

            MessageBox.Show("Compra realizada con éxito");
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
        private void btnInicio_Click(object sender, EventArgs e)
        {
            ChangeMenu(new Menú());
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            ChangeMenu(new Menú());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}

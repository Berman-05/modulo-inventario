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

            dgvProductos.ColumnCount = 5;
            dgvProductos.Columns[0].Name = "Codigo";
            dgvProductos.Columns[1].Name = "Nombre";
            dgvProductos.Columns[2].Name = "Proveedor";
            dgvProductos.Columns[3].Name = "Cantidad";
            dgvProductos.Columns[4].Name = "Precio";


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
            dgvProductos.Columns.Add("Codigo", "Codigo");
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
            int codigo = int.Parse(txtCodigo.Text);
            Productos buscar = Compras.existencias.Find(p => p.Codigo == codigo);
            if (buscar != null)
            {
                buscar.Cantidad -= int.Parse(nudCantidad.Text);
                CargarProductos();
                dgvProductos.Rows.Add(txtCodigo.Text, buscar.Nombre, buscar.Proveedor, nudCantidad.Text, buscar.PrecioVenta); // Agregar fila
                txtCodigo.Clear();
                txtCodigo.Clear();
                Finanzas.dinero += buscar.PrecioVenta * int.Parse(nudCantidad.Text);
                Reporte.ganancias += buscar.PrecioVenta-((buscar.PrecioVenta/1.12m*0.17m)) *int.Parse(nudCantidad.Text);
                Reporte.ingresos.Add(buscar);
                MessageBox.Show("añadido al pedido.");
            }
            else { MessageBox.Show("Sin existencias."); }

        }
        void CargarProductos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(nudCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblCantidad_Click(object sender, EventArgs e)
        {

        }
    }
}

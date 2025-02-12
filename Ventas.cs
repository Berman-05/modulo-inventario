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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

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
            AgregarDatos();
        }
        private void AgregarDatos()
        {
            // Agregar primera fila (Piernas de Pollo)
            int cantidad1 = 3;
            decimal precio1 = 12;
            decimal total1 = cantidad1 * precio1;
            dgvProductos.Rows.Add("Piernas de Pollo", cantidad1, precio1, total1);

            // Agregar segunda fila (Medallones)
            int cantidad2 = 6;
            decimal precio2 = 6;
            decimal total2 = cantidad2 * precio2;
            dgvProductos.Rows.Add("Medallones", cantidad2, precio2, total2);
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.Columns.Add("NombreProducto", "Nombre del Producto");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Total", "Total");
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CargarCompras();
            btnInicio.MouseEnter += btnInicio_MouseEnter;
            btnInicio.MouseLeave += btnInicio_MouseLeave;
        }
        private void CargarCompras()
        {
            // Asignar la lista de productos comprados al DataGridView
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = Productos.ComprasRealizadas;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBusqueda.Text.ToLower(); // Obtener el texto en minúsculas

            // Filtrar las compras realizadas según el nombre del producto o proveedor
            var productosFiltrados = Productos.ComprasRealizadas.Where(p =>
                p.Nombre.ToLower().Contains(searchTerm) || // Filtrar por nombre
                p.Proveedor.ToLower().Contains(searchTerm)  // Filtrar por proveedor
            ).ToList();

            // Actualizar el DataGridView con los productos filtrados
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = productosFiltrados;
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

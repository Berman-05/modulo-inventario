using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.IO;
using Microsoft.VisualBasic; // <-- Necesario para InputBox

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
            dgvProductos.ColumnCount = 7;
            dgvProductos.Columns[0].Name = "Codigo";
            dgvProductos.Columns[1].Name = "Nombre";
            dgvProductos.Columns[2].Name = "Proveedor";
            dgvProductos.Columns[3].Name = "Cantidad";
            dgvProductos.Columns[4].Name = "Precio";
            dgvProductos.Columns[5].Name = "NIT";
            dgvProductos.Columns[6].Name = "NombreCliente";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea realizar el pago con tarjeta?\nSeleccione una opción:",
                                                              "Método de Pago",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question,
                                                              MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ha seleccionado pagar con tarjeta.\n¡Compra realizada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ha seleccionado pagar en efectivo.\n¡Compra realizada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar Factura";
                saveFileDialog.FileName = "Factura.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GenerarFacturaPDF(saveFileDialog.FileName);
                    MessageBox.Show("Factura generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GenerarFacturaPDF(string ruta)
        {
            using (FileStream fs = new FileStream(ruta, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                Font empresaFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24);

                // Logo
                try
                {
                    string logoPath = "C:\\Users\\monte\\Source\\Repos\\modulo-inventario\\logo.png";
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(100f, 100f);
                    logo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(logo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el logo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Empresa
                Paragraph empresa = new Paragraph("La Casa del Pollo", empresaFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(empresa);

                Paragraph direccion = new Paragraph("12 ave. 7-17 zona 3 \nQuetzaltenango", normalFont) { Alignment = Element.ALIGN_CENTER };
                doc.Add(direccion);

                doc.Add(new Paragraph("Factura de Venta", tituloFont));
                doc.Add(new Paragraph("\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n", normalFont));

                // Cliente
                string nitCliente = dgvProductos.Rows[0].Cells[5].Value?.ToString() ?? "N/A";
                string nombreCliente = dgvProductos.Rows[0].Cells[6].Value?.ToString() ?? "N/A";

                doc.Add(new Paragraph("Datos del Cliente:", tituloFont));
                doc.Add(new Paragraph("NIT: " + nitCliente, normalFont));
                doc.Add(new Paragraph("Nombre: " + nombreCliente, normalFont));
                doc.Add(new Paragraph("\n"));

                // Tabla productos
                PdfPTable tabla = new PdfPTable(5); // Solo columnas de producto

                for (int i = 0; i <= 4; i++)
                {
                    tabla.AddCell(new Phrase(dgvProductos.Columns[i].HeaderText, normalFont));
                }

                decimal total = 0;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i <= 4; i++)
                        {
                            tabla.AddCell(new Phrase(row.Cells[i].Value?.ToString() ?? "", normalFont));
                        }

                        int cantidad = Convert.ToInt32(row.Cells[3].Value);
                        decimal precio = Convert.ToDecimal(row.Cells[4].Value);
                        total += cantidad * precio;
                    }
                }

                doc.Add(tabla);
                doc.Add(new Paragraph("\nTotal: Q" + total.ToString("0.00"), tituloFont));
                doc.Close();
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este evento no se necesita para columnas
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

        public static decimal transaccion = 0;
        public static decimal neto = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            Productos buscar = Compras.existencias.Find(p => p.Codigo == codigo);
            if (buscar != null)
            {
                buscar.Cantidad -= int.Parse(nudCantidad.Text);
                CargarProductos();

                string nitCliente = Interaction.InputBox("Ingrese el NIT del cliente:", "NIT", "C/F");
                string nombreCliente = Interaction.InputBox("Ingrese el nombre del cliente:", "Nombre", "Consumidor Final");

                dgvProductos.Rows.Add(txtCodigo.Text, buscar.Nombre, buscar.Proveedor, nudCantidad.Text, buscar.PrecioVenta, nitCliente, nombreCliente);

                txtCodigo.Clear();
                transaccion += buscar.PrecioVenta * int.Parse(nudCantidad.Text);
                Finanzas.dinero += transaccion - ((transaccion / 1.12m * 0.17m));
                Reporte.ganancias += transaccion - ((transaccion / 1.12m * 0.17m));
                Reporte.ingresos.Add(buscar);
                neto += buscar.PrecioVenta * int.Parse(nudCantidad.Text);
                MessageBox.Show("añadido al pedido.");
            }
            else
            {
                MessageBox.Show("Sin existencias.");
            }
        }

        void CargarProductos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(nudCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

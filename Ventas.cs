using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.Drawing.Imaging;

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
            dgvProductos.Columns[5].Name = "NIT Cliente";
            dgvProductos.Columns[6].Name = "Nombre Cliente";
        }

        private void button2_Click(object sender, EventArgs e)
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

                // Intentamos agregar el logo
                try
                {
                    // Usamos la ruta completa donde está el archivo logo.png
                    string rutaLogo = @"C:\Users\monte\Source\Repos\modulo-inventario\bin\Debug\net8.0-windows\logo.png";

                    // Verificamos si el archivo existe
                    if (File.Exists(rutaLogo))
                    {
                        // Si existe, agregamos el logo al PDF
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                        logo.ScaleToFit(120f, 120f);
                        logo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(logo);
                    }
                    // Si no existe el logo, no hacemos nada y seguimos sin mostrar mensaje de error
                }
                catch (Exception)
                {
                    // No hacer nada si ocurre un error al intentar agregar el logo
                    // Simplemente ignoramos el error sin mostrar mensaje alguno.
                }

                // Información de la empresa
                Paragraph empresa = new Paragraph("La Casa del Pollo", empresaFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(empresa);

                Paragraph direccion = new Paragraph("12 ave. 7-17 zona 3 \nQuetzaltenango", normalFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(direccion);

                doc.Add(new Paragraph("Factura de Venta", tituloFont));
                doc.Add(new Paragraph("\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n", normalFont));

                string nitCliente = dgvProductos.Rows[0].Cells[5].Value?.ToString() ?? "N/A";
                string nombreCliente = dgvProductos.Rows[0].Cells[6].Value?.ToString() ?? "N/A";

                doc.Add(new Paragraph("Datos del Cliente:", tituloFont));
                doc.Add(new Paragraph("NIT: " + nitCliente, normalFont));
                doc.Add(new Paragraph("Nombre: " + nombreCliente, normalFont));
                doc.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(dgvProductos.ColumnCount - 2);

                for (int i = 0; i < dgvProductos.ColumnCount - 2; i++)
                {
                    tabla.AddCell(new Phrase(dgvProductos.Columns[i].HeaderText, normalFont));
                }

                decimal total = 0;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dgvProductos.ColumnCount - 2; i++)
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
    }
}

using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.Reflection;

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
                Font empresaFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24); // Fuente más grande para el nombre de la empresa

                // Agregar logo desde una ruta local
                try
                {
                    string imagePath = @"C:\Users\monte\Source\Repos\modulo-inventario\Resources\Imagen.png";

                    if (File.Exists(imagePath))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
                        logo.ScaleToFit(100f, 100f);
                        logo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(logo);
                    }
                    else
                    {
                        MessageBox.Show("La imagen no fue encontrada en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la imagen del logo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Agregar el nombre de la empresa (La Casa del Pollo)
                Paragraph empresa = new Paragraph("La Casa del Pollo", empresaFont);
                empresa.Alignment = Element.ALIGN_CENTER;
                doc.Add(empresa);

                // Agregar la dirección debajo del nombre de la empresa
                Paragraph direccion = new Paragraph("12 ave. 7-17 zona 3 \nQuetzaltenango", normalFont);
                direccion.Alignment = Element.ALIGN_CENTER;
                doc.Add(direccion);

                // Información de la factura
                doc.Add(new Paragraph("Factura de Venta", tituloFont));
                doc.Add(new Paragraph("\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n", normalFont));

                // Obtener los datos del cliente (NIT y Nombre)
                string nitCliente = dgvProductos.Rows[0].Cells[5].Value?.ToString() ?? "N/A";
                string nombreCliente = dgvProductos.Rows[0].Cells[6].Value?.ToString() ?? "N/A";

                // Agregar los datos del cliente antes de la tabla
                doc.Add(new Paragraph("Datos del Cliente:", tituloFont));
                doc.Add(new Paragraph("NIT: " + nitCliente, normalFont));
                doc.Add(new Paragraph("Nombre: " + nombreCliente, normalFont));
                doc.Add(new Paragraph("\n"));

                // Crear la tabla de productos, excluyendo NIT Cliente y Nombre Cliente
                PdfPTable tabla = new PdfPTable(dgvProductos.ColumnCount - 2); // Quitamos dos columnas (NIT y Nombre Cliente)

                // Añadir encabezados de las columnas, excluyendo "NIT Cliente" y "Nombre Cliente"
                for (int i = 0; i < dgvProductos.ColumnCount - 2; i++) // Iterar por las columnas (menos las dos últimas)
                {
                    tabla.AddCell(new Phrase(dgvProductos.Columns[i].HeaderText, normalFont));
                }

                decimal total = 0;

                // Iterar a través de las filas de la tabla y agregar el contenido al PDF
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dgvProductos.ColumnCount - 2; i++) // Iterar solo las celdas que no son NIT y Nombre
                        {
                            tabla.AddCell(new Phrase(row.Cells[i].Value?.ToString() ?? "", normalFont));
                        }
                        // Calcular el total
                        int cantidad = Convert.ToInt32(row.Cells[3].Value);
                        decimal precio = Convert.ToDecimal(row.Cells[4].Value);
                        total += cantidad * precio;
                    }
                }

                // Agregar la tabla al documento
                doc.Add(tabla);

                // Agregar el total debajo de la tabla
                doc.Add(new Paragraph("\nTotal: Q" + total.ToString("0.00"), tituloFont));

                // Cerrar el documento
                doc.Close();
            }
        }




    }
}

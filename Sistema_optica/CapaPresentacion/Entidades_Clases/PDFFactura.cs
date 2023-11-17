using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CapaPresentacion;
using iTextSharp.text.pdf;

namespace CapaPresentacion.Entidades_Clases
{
    internal class PDFFactura
    {
        /*
        public static void GenerarPdf(CFactura factura, string rutaArchivo)
        {
            // Configuración del documento PDF
            using (var writer = new PdfWriter(rutaArchivo))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    // Agregar contenido al documento PDF
                    document.Add(new Paragraph("Factura")
                        .SetFontFamily("Arial")
                        .SetFontSize(18));

                    document.Add(new Paragraph($"Número de Factura: {factura.NumeroFactura}")
                        .SetFontFamily("Arial")
                        .SetFontSize(12));

                    document.Add(new Paragraph($"Cliente: {factura.Cliente}")
                        .SetFontFamily("Arial")
                        .SetFontSize(12));

                    // Agregar detalles adicionales de la factura
                    if (factura.Detalle != null)
                    {
                        document.Add(new Paragraph("Detalles adicionales:")
                            .SetFontFamily("Arial")
                            .SetFontSize(12));

                        // Puedes agregar más detalles según sea necesario
                    }

                    // Cerrar el documento
                    document.Close();
                }
            }
        }*/
    }
}

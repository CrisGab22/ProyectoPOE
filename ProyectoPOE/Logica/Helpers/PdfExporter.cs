using PdfSharp.Drawing;
using PdfSharp.Pdf;
using ProyectoPOE.Datos.Entidades;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProyectoPOE.Logica.Helpers
{
    public static class PdfExporter
    {
        public static void ExportarResultados(List<ResultadoEvento> resultados)
        {
            PdfDocument documento = new PdfDocument();
            documento.Info.Title = "Resultados del Evento";

            PdfPage pagina = documento.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(pagina);

            XFont fuenteTitulo = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont fuenteTexto = new XFont("Verdana", 12, XFontStyle.Regular);

            int y = 40;
            gfx.DrawString("Resultados del Evento", fuenteTitulo, XBrushes.Black, new XRect(0, y, pagina.Width, 40), XStringFormats.TopCenter);
            y += 60;

            foreach (var resultado in resultados)
            {
                string texto = $"Categoría: {resultado.Categoria.Descripcion}, Emprendimiento: {resultado.Emprendimiento.Nombre}";
                gfx.DrawString(texto, fuenteTexto, XBrushes.Black, new XRect(40, y, pagina.Width - 80, 20), XStringFormats.TopLeft);
                y += 25;

                if (y > pagina.Height - 50)
                {
                    pagina = documento.AddPage();
                    gfx = XGraphics.FromPdfPage(pagina);
                    y = 40;
                }
            }

            string rutaArchivo = "ResultadosEvento.pdf";
            documento.Save(rutaArchivo);
            Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
        }
    }
}

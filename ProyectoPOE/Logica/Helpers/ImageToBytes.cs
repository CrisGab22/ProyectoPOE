using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Logica.Helpers
{
    public class ImageToBytes
    {
        /// <summary>
        /// Convierte una imagen a un arreglo de bytes.
        /// </summary>
        /// <param name="img">La imagen a convertir.</param>
        /// <returns>Un arreglo de bytes que representa la imagen.</returns>
        public static byte[] ConvertirImagenABytes(Image img)
        {
            if (img == null)
            {
                throw new ArgumentNullException(nameof(img), "La imagen no puede ser nula.");
            }
            return ImagenABytes(img);
        }

        private static byte[] ImagenABytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}

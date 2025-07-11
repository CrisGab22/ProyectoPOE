using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ProyectoPOE.Logica.Helpers
{
    public static class ImageToBytes
    {

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

        /// <param name="bytes">
        public static Image ConvertirBytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
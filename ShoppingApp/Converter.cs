using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    public class Converter
    {
        public static Image ToImage(Byte[] binary)
        {
            Image image = null;
            if (binary == null || binary.Length < 100) return image;

            using (MemoryStream ms = new MemoryStream(binary))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        public static Byte[] ToBinary(Image image)
        {
            if (image == null) return null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HelpersLib
{
    public static class ImageHelper
    {
        public static BitmapSource CropImage(BitmapSource img, Rect rect)
        {
            if (img != null && rect.X >= 0 && rect.Y >= 0 && rect.Width > 0 && rect.Height > 0 && new Rect(0, 0, (int)img.Width, (int)img.Height).Contains(rect))
            {
                return new CroppedBitmap(img, new Int32Rect((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height));
            }

            return null;
        }
    }
}
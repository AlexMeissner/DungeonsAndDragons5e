using System;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace EntityManager.Converter
{
    public class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string base64Image && base64Image.Length > 0)
            {
                byte[] buffer = System.Convert.FromBase64String(base64Image);
                BitmapImage bitmapImage = new();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(buffer);
                bitmapImage.EndInit();
                return bitmapImage;
            }

            return BitmapSource.Create(2, 2, 96, 96, PixelFormats.Indexed1, new BitmapPalette(new List<Color> { Colors.Transparent }), new byte[] { 0, 0, 0, 0 }, 1);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
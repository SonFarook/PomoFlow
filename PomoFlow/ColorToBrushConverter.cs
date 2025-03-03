using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace PomoFlow
{
    public class ColorToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color color)
            {
                return new SolidColorBrush(color);
            }
            return Brushes.Transparent; // return transparent brush, if value is not a color
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush brush)
            {
                return brush.Color;
            }
            return Colors.Transparent; // return transparent color, if value is not a brush
        }
    }
}

using System;
using System.Globalization;
using System.Windows.Data;

namespace MotoLens
{
    class SpeedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var startAngle = double.Parse(parameter as string);
            var endAngle = startAngle + (((double)value) * 2);
            return endAngle;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
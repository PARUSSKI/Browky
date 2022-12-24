using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;


namespace VelvetEyebrows.Converters
{
    internal class DiscountToNumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                double disc = (double)value;
                return (int)(disc * 100);
            }
           return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int disc = (int)value;
            return disc / 100.0;
        }
    }
}

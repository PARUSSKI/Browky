using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace VelvetEyebrows.Converters
{
    internal class TimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (TimeSpan)value;
            int hour = (int)time.TotalSeconds / 3600;
            int day = (int)hour / 24;


            int min = (int)time.TotalSeconds / 60 - hour * 60;
            hour = hour - day * 24;
            string result = day.ToString() + " день " + hour.ToString().PadLeft(2, '0') + " часа " + min.ToString().PadLeft(2, '0') + " минут";
            if (day == 0)
            {
                result = hour.ToString().PadLeft(2, '0') + " часа " + min.ToString().PadLeft(2, '0') + " минут";
                return result;
            }
            if (day == 1)
            {
                result = day.ToString() + " день " + hour.ToString().PadLeft(2, '0') + " часа " + min.ToString().PadLeft(2, '0') + " минут";
                return result;
            }

            if (hour == 0)
            {

                result = min.ToString().PadLeft(2, '0') + " минут";
                return result;
            }
            else
            {
                return result;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

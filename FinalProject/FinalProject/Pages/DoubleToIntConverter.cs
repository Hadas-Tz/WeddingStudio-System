using System;
using System.Globalization;
using System.Windows.Data;

namespace FinalProject.Pages
{
    public class DoubleToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleValue)
            {
                return (int)doubleValue;
            }
            else if (value is int intValue)
            {
                return intValue;
            }
            throw new ArgumentException("Value must be a double or an int", nameof(value));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}



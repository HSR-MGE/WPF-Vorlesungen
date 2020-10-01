namespace Vorlesung_11.Converter
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;

    public sealed class ReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = (string) value;
            var reversedValue = stringValue?.Reverse().ToArray() ?? new char[0];
            var reversedString = new string(reversedValue);

            return reversedString;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}

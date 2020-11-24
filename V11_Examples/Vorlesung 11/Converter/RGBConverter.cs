﻿namespace Vorlesung_11.Converter
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;
    using System.Windows.Media;

    public sealed class RGBConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null)
                return DependencyProperty.UnsetValue;

            if (values.Length != 3)
                throw new NotSupportedException($"3 values needed(R, G, B) but only { values.Length } given");

            var r = (byte)System.Convert.ToInt32(values[0]);
            var g = (byte)System.Convert.ToInt32(values[1]);
            var b = (byte)System.Convert.ToInt32(values[2]);

            return Color.FromRgb(r, g, b);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            if (value == DependencyProperty.UnsetValue)
                return null;

            if (value is Color color)
            {
                var colors = new object[] { color.R, color.G, color.B };
                return colors;
            }

            return null;
        }
    }
}

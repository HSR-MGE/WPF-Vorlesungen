using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Vorlesung_09.TypeConverter
{
    public class LocationControl : TextBlock
    {
        public Location Center
        {
            set => this.Text = $"{value.Latitude} / {value.Longitude}";
        }
    }
}

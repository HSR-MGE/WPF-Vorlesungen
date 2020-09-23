using System;
using System.Collections.Generic;
using System.Text;

namespace Vorlesung_09.MarkupExtension
{
    public class LocationExtension : System.Windows.Markup.MarkupExtension
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Latitude + " / " + Longitude;
        }
    }
}

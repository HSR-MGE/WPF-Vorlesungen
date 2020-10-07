using System.Globalization;

namespace Multilanguage
{
    using System;
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SetResourceTranslations("de");
            SetResxTranslations("de");

            InitializeComponent();
        }

        private void SetResourceTranslations(string key)
        {
            var uri = new Uri($"/{nameof(Multilanguage)};component/Resources/Translations.{key}.xaml", UriKind.RelativeOrAbsolute);
            var rd = new ResourceDictionary { Source = uri };

            foreach (var rdKey in rd.Keys)
            {
                Resources[rdKey] = rd[rdKey];
            }
        }

        private static void SetResxTranslations(string culture)
        {
            RESX.Translations.Culture = new CultureInfo(culture);
        }

        private void ButtonDE_OnClick(object sender, RoutedEventArgs e)
        {
            SetResourceTranslations("de");
            SetResxTranslations("de");
        }

        private void ButtonEN_OnClick(object sender, RoutedEventArgs e)
        {
            SetResourceTranslations("en");
            SetResxTranslations("en");
        }
    }
}

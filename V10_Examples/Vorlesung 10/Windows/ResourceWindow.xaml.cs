using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vorlesung_10.Windows
{
    /// <summary>
    /// Interaction logic for ResourceWindow.xaml
    /// </summary>
    public partial class ResourceWindow : Window
    {
        public ResourceWindow()
        {
            InitializeComponent();
        }

        private void UpdateDynamicResource(object sender, RoutedEventArgs e)
        {
            Resources["OSTBrush"] = new SolidColorBrush(Colors.DarkBlue);
        }
    }
}

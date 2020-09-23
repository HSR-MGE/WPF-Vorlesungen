using System.Windows;
using System.Windows.Controls;

namespace Vorlesung_09
{
    /// <summary>
    /// Interaction logic for XamlBasics.xaml
    /// </summary>
    public partial class XamlBasics : Window
    {
        public XamlBasics()
        {
            InitializeComponent();

            this.XamlAttribute.Text = "...";
            this.WpfAttribute.Text = "...";
        }
    }
}

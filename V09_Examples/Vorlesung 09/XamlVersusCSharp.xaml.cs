using System.Windows;
using System.Windows.Controls;

namespace Vorlesung_09
{
    public partial class XamlVersusCSharp : Window
    {
        public XamlVersusCSharp()
        {
            this.InitializeComponent();

            //var textBlock = new TextBlock
            //{
            //    Text = "Hallo MGE",
            //    Height = 20,
            //    Width = 200,
            //    TextAlignment = TextAlignment.Center,
            //    Margin = new Thickness(5)
            //};

            //var button = new Button
            //{
            //    Content = "OK",
            //    Height = 20,
            //    Width = 60,
            //    Margin = new Thickness(5)
            //};

            //var stackPanel = new StackPanel();
            //stackPanel.Children.Add(textBlock);
            //stackPanel.Children.Add(button);

            //this.Content = stackPanel;
        }
    }
}

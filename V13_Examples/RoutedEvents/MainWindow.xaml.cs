using System.Diagnostics;

namespace RoutedEvents
{
    using System.Windows;
    using System.Windows.Input;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static void LogMessage(string message)
        {
            Debug.WriteLine(message);
        }

        #region Tunneling

        private void Window_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(Window_OnPreviewKeyDown));
        }

        private void Border_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(Border_OnPreviewKeyDown));
        }

        private void StackPanel1_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(StackPanel1_OnPreviewKeyDown));
        }

        private void TextBox1_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(TextBox1_OnPreviewKeyDown));
        }

        private void StackPanel2_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(StackPanel2_OnPreviewKeyDown));
        }

        private void TextBox2_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(TextBox2_OnPreviewKeyDown));
        }

        private void Button_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(Button_OnPreviewKeyDown));
        }

        #endregion

        #region Bubbeling

        private void Window_OnKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(Window_OnKeyDown));
        }

        private void Border_OnKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(Border_OnKeyDown));
        }

        private void StackPanel1_OnKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(StackPanel1_OnKeyDown));
        }

        private void TextBox1_OnKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(TextBox1_OnKeyDown));
        }

        private void StackPanel2_OnKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(StackPanel2_OnKeyDown));
        }

        private void TextBox2_OnKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(TextBox2_OnKeyDown));
        }

        private void Button_OnKeyDown(object sender, KeyEventArgs e)
        {
            LogMessage(nameof(Button_OnKeyDown));
        }

        #endregion
    }
}

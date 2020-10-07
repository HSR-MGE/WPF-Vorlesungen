namespace AdvancedControls.CustomControl
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public class RGBLabel : Label
    {
        static RGBLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RGBLabel), new FrameworkPropertyMetadata(typeof(RGBLabel)));
        }

        public static readonly DependencyProperty RProperty =
            DependencyProperty.Register(
                nameof(R),
                typeof(byte),
                typeof(RGBLabel),
                new PropertyMetadata(
                    (byte)0,
                    OnColorChanged)
            );

        public byte R
        {
            get => (byte)GetValue(RProperty);
            set => SetValue(RProperty, value);
        }

        public static readonly DependencyProperty GProperty =
            DependencyProperty.Register(
                nameof(G),
                typeof(byte),
                typeof(RGBLabel),
                new PropertyMetadata(
                    (byte)0,
                    OnColorChanged)
            );

        public byte G
        {
            get => (byte)GetValue(GProperty);
            set => SetValue(GProperty, value);
        }

        public static readonly DependencyProperty BProperty =
            DependencyProperty.Register(
                nameof(B),
                typeof(byte),
                typeof(RGBLabel),
                new PropertyMetadata(
                    (byte)0,
                    OnColorChanged)
            );

        public byte B
        {
            get => (byte)GetValue(BProperty);
            set => SetValue(BProperty, value);
        }

        private static void OnColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var label = (RGBLabel)d;
            label.UpdateTextAndBackground();
        }

        private void UpdateTextAndBackground()
        {
            Content = $"#{R:X2}{G:X2}{B:X2}";
            Background = new SolidColorBrush(Color.FromRgb(R, G, B));
        }
    }
}

namespace AdvancedControls.UserControl
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class RGBLabel : System.Windows.Controls.UserControl
    {
        public RGBLabel()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty RProperty =
            DependencyProperty.Register(
                nameof(R),
                typeof(byte),
                typeof(RGBLabel),
                new PropertyMetadata(
                    (byte)0,
                    OnRChanged)
            );

        public byte R
        {
            get => (byte) GetValue(RProperty);
            set => SetValue(RProperty, value);
        }

        public static readonly DependencyProperty GProperty =
            DependencyProperty.Register(
                nameof(G),
                typeof(byte),
                typeof(RGBLabel),
                new PropertyMetadata(
                    (byte)0,
                    OnGChanged)
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
                    OnBChanged)
            );

        public byte B
        {
            get => (byte)GetValue(BProperty);
            set => SetValue(BProperty, value);
        }
        
        private static void OnRChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var label = (RGBLabel) d;
            var newValue = (byte) e.NewValue;
            var color = Color.FromRgb(newValue, 0, 0);
            UpdateLabel(label.RLabel, newValue, color);
        }

        private static void OnGChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var label = (RGBLabel)d;
            var newValue = (byte)e.NewValue;
            var color = Color.FromRgb(0, newValue, 0);
            UpdateLabel(label.GLabel, newValue, color);
        }

        private static void OnBChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var label = (RGBLabel)d;
            var newValue = (byte)e.NewValue;
            var color = Color.FromRgb(0, 0, newValue);
            UpdateLabel(label.BLabel, newValue, color);
        }

        private static void UpdateLabel(Label label, byte value, Color color)
        {
            label.Content = $"{value:X2}";
            label.Background = new SolidColorBrush(color);
        }
    }
}

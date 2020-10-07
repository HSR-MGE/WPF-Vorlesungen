namespace AdvancedControls
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows;

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private byte _r = 130;
        private byte _g = 80;
        private byte _b = 150;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ChangeColor_OnClick(object sender, RoutedEventArgs e)
        {
            R = 40;
            G = 100;
            B = 120;
        }

        #region Properties for Binding

        public byte R
        {
            get => _r;
            set
            {
                _r = value;
                OnPropertyChanged(nameof(R));
            }
        }

        public byte G
        {
            get => _g;
            set
            {
                _g = value;
                OnPropertyChanged(nameof(G));
            }
        }

        public byte B
        {
            get => _b;
            set
            {
                _b = value;
                OnPropertyChanged(nameof(B));
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

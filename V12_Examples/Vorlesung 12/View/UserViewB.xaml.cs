namespace Vorlesung_12.View
{
    using System.Windows;

    using Vorlesung_12.Model;
    using Vorlesung_12.ViewModel;

    public partial class UserViewB : Window
    {
        public UserViewB(IUser user)
        {
            InitializeComponent();

            DataContext = new UserViewModelB(user);
        }
    }
}

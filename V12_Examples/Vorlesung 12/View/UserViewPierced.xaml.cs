namespace Vorlesung_12.View
{
    using System.Windows;

    using Vorlesung_12.Model;
    using Vorlesung_12.ViewModel;

    public partial class UserViewPierced : Window
    {
        public UserViewPierced(IUser user)
        {
            InitializeComponent();

            DataContext = new UserViewModelPierced(user);
        }
    }
}

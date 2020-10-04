namespace Vorlesung_12.View
{
    using System.Windows;

    using Vorlesung_12.Model;
    using Vorlesung_12.ViewModel;

    public partial class UserViewA : Window
    {
        public UserViewA(IUser user)
        {
            InitializeComponent();
            
            DataContext = new UserViewModelA(user);
        }
    }
}

namespace Vorlesung_12.View
{
    using System.Windows;

    using Vorlesung_12.Model;
    using Vorlesung_12.ViewModel;

    public partial class UserViewClassic : Window
    {
        public UserViewClassic(IUser user)
        {
            InitializeComponent();
            
            DataContext = new UserViewModelClassic(user);
        }
    }
}

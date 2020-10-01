namespace Vorlesung_11.Windows
{
    using System.Collections.ObjectModel;
    using System.Windows;

    using Vorlesung_11.Model;

    public partial class MainWindow : Window
    {
        public IUser User { get; }

        public ObservableCollection<IUser> Users { get; }

        public IUser SelectedUser { get; set; }

        public int SelectedUserIndex { get; set; }

        public string SelectedUserName { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.User = CreateUser();
            this.Users = CreateUsers(20);

            this.DataContext = this;
        }

        private static IUser CreateUser()
        {
            //return new User();
            //return new UserWithINPFC();
            return new UserWithBase();
        }

        private static ObservableCollection<IUser> CreateUsers(int count)
        {
            var oc = new ObservableCollection<IUser>();

            for (var i = 1; i <= count; i++)
            {
                var user = CreateUser();
                user.FirstName = "John";
                user.LastName = $"Doe #{i}";
                user.Age = 20 + i;

                oc.Add(user);
            }

            return oc;
        }

        private void IncrementAge_OnClick(object sender, RoutedEventArgs e)
        {
            User.Age++;
        }

        private void AddThomas_OnClick(object sender, RoutedEventArgs e)
        {
            Users.Add(User);
        }
    }
}

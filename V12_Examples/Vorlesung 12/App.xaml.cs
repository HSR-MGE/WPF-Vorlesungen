namespace Vorlesung_12
{
    using System.Windows;

    using Vorlesung_12.Model;
    using Vorlesung_12.View;

    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            SetupForViewModelA();
            //SetupForViewModelB();
        }

        private void SetupForViewModelA()
        {
            var user = new User
            {
                FirstName = "Thomas",
                LastName = "Kaelin",
                Age = 36
            };

            MainWindow = new UserViewA(user);
            MainWindow.Show();
        }

        private void SetupForViewModelB()
        {
            var user = new UserWithBase
            {
                FirstName = "Thomas",
                LastName = "Kaelin",
                Age = 36
            };

            MainWindow = new UserViewB(user);
            MainWindow.Show();
        }
    }
}

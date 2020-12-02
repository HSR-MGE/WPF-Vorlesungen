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

            SetupForClassic();
            //SetupForPierced();
        }

        private void SetupForClassic()
        {
            var user = new User
            {
                FirstName = "Thomas",
                LastName = "Kaelin",
                Age = 36
            };

            MainWindow = new UserViewClassic(user);
            MainWindow.Show();
        }

        private void SetupForPierced()
        {
            var user = new UserWithBase
            {
                FirstName = "Thomas",
                LastName = "Kaelin",
                Age = 36
            };

            MainWindow = new UserViewPierced(user);
            MainWindow.Show();
        }
    }
}

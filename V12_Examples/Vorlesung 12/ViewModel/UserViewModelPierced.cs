namespace Vorlesung_12.ViewModel
{
    using Vorlesung_12.Infrastructure;
    using Vorlesung_12.Model;

    public class UserViewModelPierced : BindableBase
    {
        private IUser _user;

        public UserViewModelPierced(IUser user)
        {
            User = user;
            DecreaseAgeCommand = new RelayCommand(OnDecreaseAge, CanDecreaseAge);
            IncreaseAgeCommand = new RelayCommand(OnIncreaseAge, CanIncreaseAge);
        }

        #region Properties for Bindings

        public IUser User
        {
            get => _user;
            private set => SetProperty(ref _user, value);
        }

        #endregion

        #region Commands for Bindings

        public RelayCommand DecreaseAgeCommand { get; }

        public RelayCommand IncreaseAgeCommand { get; }

        #endregion

        #region Private Methods

        private void OnDecreaseAge()
        {
            User.Age--;
            DecreaseAgeCommand.RaiseCanExecuteChanged();
            IncreaseAgeCommand.RaiseCanExecuteChanged();
        }

        private bool CanDecreaseAge() => User.Age > 0;

        private void OnIncreaseAge()
        {
            User.Age++;
            DecreaseAgeCommand.RaiseCanExecuteChanged();
            IncreaseAgeCommand.RaiseCanExecuteChanged();
        }

        private bool CanIncreaseAge() => User.Age <= 125;

        #endregion
    }
}

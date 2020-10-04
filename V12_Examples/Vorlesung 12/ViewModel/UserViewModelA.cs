namespace Vorlesung_12.ViewModel
{
    using Vorlesung_12.Infrastructure;
    using Vorlesung_12.Model;

    public class UserViewModelA : BindableBase
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public UserViewModelA(IUser user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            DecreaseAgeCommand = new RelayCommand(OnDecreaseAge, CanDecreaseAge);
            IncreaseAgeCommand = new RelayCommand(OnIncreaseAge, CanIncreaseAge);
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (SetProperty(ref _firstName, value))
                {
                    OnPropertyChanged(nameof(FormattedName));
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (SetProperty(ref _lastName, value))
                {
                    OnPropertyChanged(nameof(FormattedName));
                }
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (SetProperty(ref _age, value))
                {
                    OnPropertyChanged(nameof(FormattedAge));
                }
            }
        }

        public string FormattedName => $"{_firstName} {_lastName}";

        public string FormattedAge => $"{_age} Jahre";

        public RelayCommand DecreaseAgeCommand { get; }

        public RelayCommand IncreaseAgeCommand { get; }

        #region Private Methods

        private void OnDecreaseAge()
        {
            Age--;
            DecreaseAgeCommand.RaiseCanExecuteChanged();
            IncreaseAgeCommand.RaiseCanExecuteChanged();
        }

        private bool CanDecreaseAge() => Age > 0;
        
        private void OnIncreaseAge()
        {
            Age++;
            DecreaseAgeCommand.RaiseCanExecuteChanged();
            IncreaseAgeCommand.RaiseCanExecuteChanged();
        }

        private bool CanIncreaseAge() => Age <= 125;

        #endregion
    }
}

namespace Vorlesung_12.Model
{
    using Vorlesung_12.Infrastructure;
    
    public class UserWithBase : BindableBase, IUser
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private int _age = 0;

        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }
    }
}
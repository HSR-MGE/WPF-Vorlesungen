namespace Vorlesung_12.View
{
    using Vorlesung_12.Model;
    using Vorlesung_12.ViewModel;

    public static class TestData
    {
        private static User User { get; } = new User { FirstName = "Thomas", LastName = "Kaelin", Age = 36 };

        public static UserViewModelA ViewModelA { get; } = new UserViewModelA(User);

        public static UserViewModelB ViewModelB { get; } = new UserViewModelB(User);
    }
}

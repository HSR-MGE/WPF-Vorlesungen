namespace Vorlesung_12.Model
{
    public class User : IUser
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; } = 0;
    }
}

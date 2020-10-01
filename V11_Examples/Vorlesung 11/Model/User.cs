namespace Vorlesung_11.Model
{
    public class User : IUser
    {
        public string FirstName { get; set; } = "Thomas";

        public string LastName { get; set; } = "Kaelin";

        public int Age { get; set; } = 36;
    }
}

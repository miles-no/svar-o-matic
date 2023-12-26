namespace SvarOMatic.Security;

public class AuthorizedUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Name => FirstName + " " + LastName;
    public string Email { get; set; }

    public AuthorizedUser(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}
namespace WebApi.Models;

public class Patient
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public Sex Sex { get; set; }
}

public enum Sex { Male = 0, Female = 1 }

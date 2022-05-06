namespace Entities;

public class User
{
    
    public int userId { get; set; }
    public string password { get; set; }
    public string username { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public int SecurityLevel { get; set; }
    
    public Address Address { get; set; }
    
    public IList<Order> _orders { get; set; }
    

    public User() { }

    public User(int userId, string username,string password, string firstName, string lastName)
    {
        this.userId = userId;
        this.username = username;
        this.firstName = firstName;
        this.lastName = lastName;
        this.password = password;
    }
    public User(int userId, string username, string firstName, string lastName,string email, string password, int securityLevel)
    {
        this.userId = userId;
        this.username = username;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.password = password;
        SecurityLevel = securityLevel;
    }
}
namespace pet_project.net.Users.Domain.Entities;

public class Account
{
    public int Id { get; set; }
    
    public string Login { get; set; }
    
    public string Password { get; set; }
    
    public int UserId { get; set; }
}
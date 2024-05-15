using pet_project.net.Users.Domain.Enums;

namespace pet_project.net.Users.Domain.Entities;

public class User
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Surname { get; set; }
    
    public Role Role { get; set; }
    
    public string Email { get; set; }
    
    public int AccountId { get; set; }
}
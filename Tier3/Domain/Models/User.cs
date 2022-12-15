using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

[Table("User")]
public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]   
    public int Id { get;  set; }
    [Column("Username")]
    public string? Username { get;  set; }
    [Column("Password")]
    public string? Password { get;  set; }  
    [Column("Email")]
    public string? Email { get;  set; }
    [Column("Role")]
    public string? Role { get;  set; }
    
    public string LikedRecipesIds { get;  set; }

    public User()
    {
    }
    public User(int id, string username, string password, string email, string role)
    {
        Id = id;
        Username = username;
        Password = password;
        Email = email;
        Role = role;
    }
}
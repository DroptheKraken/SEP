using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

[Table("User")]
public class User
{
    /*[Key]
    public int Id { get; set; } // auto incremented
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; } // must be unique, must contain @
    public string? Role { get; set; } // not-registered, logged in, admin
    
    public ICollection<Recipe>? LikedRecipes { get; set; }
    public ICollection<Recipe>? PostedRecipes { get; set; }*/
    
    // No relationships
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;  set; }
    [Column("Username")]
    public string? Username { get;  set; }
    [Column("Password")]
    public string? Password { get;  set; }  
    [Column("Email")]
    public string? Email { get;  set; }
    [Column("Role")]
    public string? Role { get;  set; }
    
    public User()
    {
    }
    /*public User(int id, string username, string password, string email, string role)
    {
        Id = id;
        Username = username;
        Password = password;
        Email = email;
        Role = role;
        LikedRecipes = null;
        PostedRecipes = null;
    }
    */
    
    /*
    private User(){}
    */


}
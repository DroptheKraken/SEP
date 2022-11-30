using System.ComponentModel.DataAnnotations;
namespace Domain.Models;

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
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }  
    public string Email { get; set; }
    public string Role { get; set; }
    
    
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
    
    
    private User(){}*/
}
using System.ComponentModel.DataAnnotations;
namespace Domain.Models;

public class Recipe
{
    /*[Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public Description? Description { get; set; }
    public ICollection<Ingredient>? Ingredients { get; set; } 
    public int? NoOfIngredients { get; set; }

    public int? NoOfLikes { get; set; }
    public ICollection<Rating>? Ratings { get; set; }*/

    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string Ingredients { get; set; }
    public int? NoOfIngredients { get; set; }
    public int? NoOfLikes { get; set; }
    public string? Ratings { get; set; }
    
    /*public Recipe(int id, string title, Description description, ICollection<Ingredient> ingredients, int noOfIngredients, int noOfLikes, Rating rating)
    {
        Id = id;
        Title = title;
        Description = description;
        Ingredients = ingredients;
        NoOfIngredients = noOfIngredients;
        NoOfLikes = noOfLikes;
        Rating = rating;
    }*/
}
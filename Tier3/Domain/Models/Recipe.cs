using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Recipe
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    [Column("Id")]
    public int Id { get; set; } // Primary key
    [Column("Title")]
    public string? Title { get; set; }
    [Column("Description")]
    public string? Description { get; set; }
    [Column("NoOfLikes")]
    public int? NoOfLikes { get; set; }
    [Column("NoOfIngredients")]
    public int? NoOfIngredients { get; set; }

    // Navigation properties
    public ICollection<Rating>? Ratings { get; set; }
    public ICollection<Ingredient>? Ingredients { get; set; }
    
    // Posted recipes
    [ForeignKey(nameof(User.Id))]
    public int UserId { get; set; }
    
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
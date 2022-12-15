using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Ingredient
{
    /*public int Id { get; set; }
    public string? IngredientName { get; set; }
    public string? Category { get; set; }*/
    
    // No relationships
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    
    /*// Many to many relationship
    public List<Recipe>? Recipes { get; set; }*/
    public Recipe Recipe { get; set; }
    // Foreign key
    public int RecipeId { get; set; }

    /*public Ingredient(int id, string ingredientName, string? category)
    {
        Id = id;
        IngredientName = ingredientName;
        Category = category;
    }*/
}
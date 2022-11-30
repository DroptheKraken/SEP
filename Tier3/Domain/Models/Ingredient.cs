namespace Domain.Models;

public class Ingredient
{
    /*public int Id { get; set; }
    public string? IngredientName { get; set; }
    public string? Category { get; set; }*/
    
    // No relationships
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }

    /*public Ingredient(int id, string ingredientName, string? category)
    {
        Id = id;
        IngredientName = ingredientName;
        Category = category;
    }*/
}
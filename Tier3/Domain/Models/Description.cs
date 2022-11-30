namespace Domain.Models;

public class Description
{
    /*
    public int Id { get; private set; }
    public string? Content { get; private set; }
    public int RecipeId { get; private set; }
    public Recipe? RecipeDescription { get; private set; }
    */
    
    // No relationships
    public int Id { get; private set; }
    public string? Content { get; private set; }
    
    /*public Description(string content, Recipe recipeDescription)
    {
        Content = content;
        RecipeDescription = recipeDescription;
    }*/
}
namespace Domain.DTOs;

public class RecipeCreationDto
{
    public int Id { get; }
    public string Title { get; }
    
    public string Description { get; }
    
    public string Ingredients { get; }
    
    public int Status { get; }

    public int userID { get; }
    
    public RecipeCreationDto(int ownerId, string title, string description, string ingredients)
    {
        Id = ownerId;
        Title = title;
        Description = description;
        Ingredients = ingredients;
    }
    
}
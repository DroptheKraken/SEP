namespace Domain.DTOs;

public class RecipeCreationDto
{
    public int OwnerId { get; }
    public string Title { get; }

    public RecipeCreationDto(int ownerId, string title)
    {
        OwnerId = ownerId;
        Title = title;
    }
}
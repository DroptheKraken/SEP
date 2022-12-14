namespace Domain.Models;

public class Recipe
{
    
    public int Id { get; set; }
    
    public int userId { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public string Ingredients { get; set; }
    
    public int Status { get; set; }
    
    
    
}
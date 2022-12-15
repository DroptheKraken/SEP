using System.Text.Json.Serialization;

namespace Domain.Models;

public class Recipe
{
    
    public int Id { get; set; }
    
    public int userId { get; set; }
    [JsonPropertyName("name")]
    public string Title { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("ingridient")]
    public string[] Ingredients { get; set; }
    
    public bool Status { get; set; }


    public override string ToString()
    {
       return "Recipe{" +
              "name='" + Title + '\'' +
              ", ingridient=" + Ingredients +
              ", description='" + Description+ '\'' +
              '}';
    }
}
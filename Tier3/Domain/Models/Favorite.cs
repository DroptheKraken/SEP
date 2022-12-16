using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Favorite
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }
    public int RecipeId { get; set; }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Favorite
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("UserId")]
    public int UserId { get; set; }

    [Column("RecipeId")]
    public int RecipeId { get; set; }
}
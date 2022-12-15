using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Rating
{
    [Key]
    public int RatingId { get; set; }
    
    public int RateScore { get; set; }
    
    [ForeignKey(nameof(Recipe.Id))]
    public int RateOfRecipeId { get; set; }
    public Recipe? RateOfRecipe { get; set; }
    
    [ForeignKey(nameof(User.Id))]
    public int RatedByUserId { get; set; }
    public User? RatedByUser { get; set; }

    /*public Rating(int rateScore, Recipe rateOfRecipe, User ratedByUser)
    {
        RateScore = rateScore;
        RateOfRecipe = rateOfRecipe;
        RatedByUser = ratedByUser;
    }*/
}
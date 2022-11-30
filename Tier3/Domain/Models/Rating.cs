namespace Domain.Models;

public class Rating
{
    /*public int RateScore { get; set; }
    public Recipe? RateOfRecipe { get; set; }
    public User? RatedByUser { get; set; }*/
    
    public int Id { get; set; }
    public int RateScore { get; set; }

    /*public Rating(int rateScore, Recipe rateOfRecipe, User ratedByUser)
    {
        RateScore = rateScore;
        RateOfRecipe = rateOfRecipe;
        RatedByUser = ratedByUser;
    }*/
}
using Domain.Models;

namespace DaoInterfaces;

public interface IRatingDao
{
    // Add Rating
    Task<Rating> AddRating(Rating rating);
    
    // Get Rating by Id
    Task<Rating> GetRatingById(int id);

    // Get Ratings by Recipe Id
    Task<List<Rating>> GetRatingsByRecipeId(int recipeId);
    
    // Get Ratings by User Id
    /*
    Task<List<Rating>> GetRatingsByUserId(int userId);
    */
    
    // Update Rating
    Task<Rating> UpdateRating(Rating rating);
    
}
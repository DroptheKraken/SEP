using DaoInterfaces;
using Domain.Models;

namespace EntityDataAccess.DAOs;

public class RatingDaoImpl : IRatingDao
{
    public Task<Rating> AddRating(Rating rating)
    {
        throw new NotImplementedException();
    }

    public Task<Rating> GetRatingById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Rating>> GetRatingsByRecipeId(int recipeId)
    {
        throw new NotImplementedException();
    }

    public Task<Rating> UpdateRating(Rating rating)
    {
        throw new NotImplementedException();
    }
}
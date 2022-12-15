using DaoInterfaces;
using Domain.Models;

namespace EntityDataAccess.DAOs;

public class RecipeDaoImpl : IRecipeDao
{
    public Task<Recipe> AddRecipeAsync(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    public Task<Recipe> GetRecipeByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Recipe> GetRecipeByIngredientAsync(Ingredient ingredient)
    {
        throw new NotImplementedException();
    }

    public Task<List<Recipe>> GetAllRecipesAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateRecipeAsync(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRecipeAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Recipe>> GetRecipesByUserAsync(int userId)
    {
        throw new NotImplementedException();
    }
}
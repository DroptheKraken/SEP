using DaoInterfaces;
using Domain.Models;

namespace EntityDataAccess.DAOs;

public class IngredientDaoImpl : IIngredientDao
{
    public Task<Ingredient> AddIngredientAsync(Ingredient ingredient)
    {
        throw new NotImplementedException();
    }

    public Task<Ingredient> GetIngredientAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Ingredient>> GetAllIngredientsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Ingredient>> GetAllIngredientsByCategoryAsync(string category)
    {
        throw new NotImplementedException();
    }

    public Task<List<Ingredient>> GetAllIngredientsByRecipeAsync(int recipeId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteIngredientAsync(int id)
    {
        throw new NotImplementedException();
    }
}
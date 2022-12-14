using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Application.Logic;

public class RecipeLogic : IRecipeLogic
{
    public Task<Recipe> CreateAsync(RecipeCreationDto userToCreate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Recipe>> GetByIngredientsAsync(string ingredients)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Recipe>> GetAllRequestedRecipesAsync()
    {
        throw new NotImplementedException();
    }

   
}
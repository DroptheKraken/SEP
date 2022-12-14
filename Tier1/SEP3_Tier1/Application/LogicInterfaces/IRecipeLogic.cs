using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IRecipeLogic
{
    Task<Recipe> CreateAsync(RecipeCreationDto recipeToCreate);
    
    
    Task<IEnumerable<Recipe>>GetByIngredientsAsync(string ingredients);
    
        Task<IEnumerable<Recipe>> GetAllRequestedRecipesAsync();
    
}
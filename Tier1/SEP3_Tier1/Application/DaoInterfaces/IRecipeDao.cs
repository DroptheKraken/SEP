using Domain.Models;

namespace Application.DaoInterfaces;

public interface IRecipeDao
{
    Task<Recipe> CreateAsync(Recipe user);
    
    Task<IEnumerable<Recipe>> GetAllRecipesAsync();
    
    Task<User> GetByTitleAsync(string title);
}
using Domain.Models;

namespace DaoInterfaces;

public interface IRecipeDao
{
    // Add Recipe
    Task<Recipe> AddRecipeAsync(Recipe recipe);
    
    // Get Recipe by Id
    Task<Recipe> GetRecipeByIdAsync(int id);
    
    // Get Recipe by Ingredient
    Task<Recipe> GetRecipeByIngredientAsync(Ingredient ingredient);
    
    // Get All Recipes
    Task<List<Recipe>> GetAllRecipesAsync();
    
    // Update Recipe
    Task UpdateRecipeAsync(Recipe recipe); // might be Task<Recipe> UpdateRecipeAsync(Recipe recipe);
    
    // Delete Recipe
    Task DeleteRecipeAsync(int id); // might be Task<Recipe> DeleteRecipeAsync(int id);
    
    // Get Recipes by User
    Task<List<Recipe>> GetRecipesByUserAsync(int userId);

}
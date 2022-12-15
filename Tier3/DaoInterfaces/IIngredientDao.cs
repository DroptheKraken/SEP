using Domain.Models;

namespace DaoInterfaces;

public interface IIngredientDao
{
    // Add Ingredient
    Task<Ingredient> AddIngredientAsync(Ingredient ingredient);
    
    // Get Ingredient
    Task<Ingredient> GetIngredientAsync(int id);
    
    // Get all Ingredients
    Task<List<Ingredient>> GetAllIngredientsAsync();
    
    // Get Ingredients by Category
    Task<List<Ingredient>> GetAllIngredientsByCategoryAsync(string category);
    
    // Get Ingredients by Recipe
    Task<List<Ingredient>> GetAllIngredientsByRecipeAsync(int recipeId);
    
    // Delete Ingredient
    Task DeleteIngredientAsync(int id); // might be Task<Ingredient> instead
    

}
using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Application.Logic;

public class RecipeLogic : IRecipeLogic
{
    public async Task<Recipe> CreateAsync(RecipeCreationDto recipeToCreate)
    {
        ValidateData(recipeToCreate);

       Recipe created = await Connection.CreateRecipe(recipeToCreate.Title, recipeToCreate.Description, recipeToCreate.Ingredients);
        
        return created;
    }

   

    public async Task<List<Recipe>> GetByIngredientsAsync(string ingredients)
    {
       List<Recipe> recipes = await Connection.FetchRecipeByIngredients(ingredients);
        
        return recipes;
    }

    public Task<IEnumerable<Recipe>> GetAllRequestedRecipesAsync()
    {
        throw new NotImplementedException();
    }

    private void ValidateData(RecipeCreationDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Title))
        {
            throw new ArgumentException("Recipe title cannot be empty");
        }
      
      /*  if (string.IsNullOrWhiteSpace(dto.Ingredients))
        {
            throw new ArgumentException("Recipe ingredients cannot be empty");
        }*/
    }

}
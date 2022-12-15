using Domain.Models;
using EntityDataAccess;
using Grpc.Core;

namespace GRPC.Services;

public class RecipeService : RecipeFinder.RecipeFinderBase
{
    private DatabaseAccess _databaseAccess = new DatabaseAccess();

    public override Task<RecipeResponse> GetRecipes(RecipeRequest request, ServerCallContext context)
    {
        List<Recipe> recipes = new List<Recipe>();
        foreach (var VARIABLE in _databaseAccess.Recipes)
        {
            if (VARIABLE.Ingredients.Contains(request.Ingredient))
                recipes.Add(new Recipe()
                {
                    Name = VARIABLE.Title,
                    Description = VARIABLE.Description,
                    Ingredients = VARIABLE.Ingredients,
                    Status = VARIABLE.Status
                });
        }


        RecipeResponse response = new RecipeResponse();

        foreach (var item in recipes)
        {
            response.Recipes.Add(new Recipe()
            {
                Name = item.Name,
                Description = item.Description,
                Ingredients = item.Ingredients,
                Status = item.Status
            });
        }

        return Task.FromResult(response);
    }

    public override Task<RecipeResponse> AddRecipe(Recipe request, ServerCallContext context)
    {
        Domain.Models.Recipe recipe = new Domain.Models.Recipe()
        {
            Title = request.Name,
            Description = request.Description,
            Ingredients = request.Ingredients,
            Status = request.Status
        };
        RecipeResponse response = new RecipeResponse()
        {
            Recipes =
            {
                new Recipe()
                {
                    Name = request.Name, Description = request.Description, Ingredients = request.Ingredients,
                    Status = request.Status
                }
            }
        };
        _databaseAccess.Recipes.Add(recipe);
        _databaseAccess.SaveChanges();
        return Task.FromResult(response);
    }
}
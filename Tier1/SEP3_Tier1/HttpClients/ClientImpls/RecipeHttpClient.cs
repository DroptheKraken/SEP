using System.Data;
using System.Net.Http.Json;
using Domain.DTOs;
using Domain.Models;
using HttpClients.ClientInterfaces;

namespace HttpClients.ClientImpls;

public class RecipeHttpClient : IRecipeInterface
{
    private readonly HttpClient client;

    public RecipeHttpClient(HttpClient client)
    {
        this.client = client;
    }


    public async Task<Recipe> CreateAsync(RecipeCreationDto dto)
    {
        Recipe recipe = await Connection.CreateRecipe(dto.Title,dto.Description,dto.Ingredients);
       
        return recipe;
    }
}
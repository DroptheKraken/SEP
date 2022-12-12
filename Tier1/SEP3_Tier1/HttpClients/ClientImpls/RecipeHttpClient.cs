using System.Net.Http.Json;
using Domain.DTOs;
using HttpClients.ClientInterfaces;

namespace HttpClients.ClientImpls;

public class RecipeHttpClient : IRecipeInterface
{
    private readonly HttpClient client;

    public RecipeHttpClient(HttpClient client)
    {
        this.client = client;
    }


    public async Task CreateAsync(RecipeCreationDto dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/todos", dto);
        if (!response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();
            throw new Exception(content);
        }

    }
}
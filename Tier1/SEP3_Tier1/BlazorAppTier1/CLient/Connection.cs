using System.Text.Json;
using BlazorAppTier1.Pages;

namespace BlazorAppTier1.CLient;

public class Connection
{
    public static async Task<String> FetchRecipeAsync()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();
    
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        using HttpClient client = new HttpClient(clientHandler);
        HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/recipes/v1/recipes");
        
        if(!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception("Error");
        }
        
        string result = await responseMessage.Content.ReadAsStringAsync();

        String recipes = JsonSerializer.Deserialize<String>(result, new JsonSerializerOptions
        {

            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        Console.WriteLine(recipes);
        return recipes;
    }
}
using System.Text;
using System.Text.Json;

using Domain.Models;

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
    
    public static async Task<User?> FetchUser(string username)
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);
        HttpResponseMessage responseMessage = await client.GetAsync($"http://localhost:8080/user/v1/user/{username}");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

        User user = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        Console.WriteLine(user);

        return user;
    }
    public static async Task<User?> CreateUser(string username, string password)
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);
        var user = new User
        {
            UserName = username,
            Password = password
        };

        var data = new StringContent(JsonSerializer.Serialize(user , new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }), Encoding.UTF8, "application/json");
        HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8080/user/v1/user", data);

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

        User user1 = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        Console.WriteLine(user1);

        return user1;
    }

}
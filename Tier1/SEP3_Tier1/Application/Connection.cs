using System.Text;
using System.Text.Json;
using Domain.Models;


public class Connection
{
    public static async Task<List<Recipe>> FetchRecipeAsync()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);
        HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/recipes/v1/recipes");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception("Error");
        }

        string result = await responseMessage.Content.ReadAsStringAsync();

        List<Recipe> recipes = JsonSerializer.Deserialize<List<Recipe>>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        Console.WriteLine(recipes);
        Console.WriteLine(result);
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
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        });
        Console.WriteLine(user + " Connection ");
        DataStorageStatic.CurrentUser = user;
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

        var data = new StringContent(
            JsonSerializer.Serialize(user,
                new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }), Encoding.UTF8,
            "application/json");
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

    public static async Task<List<User>> FetchUsers()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);
        HttpResponseMessage responseMessage = await client.GetAsync($"http://localhost:8080/user/v1/users");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

        List<User> user = JsonSerializer.Deserialize<List<User>>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        Console.WriteLine(user);

        return user;
    }

    public static async Task<Recipe> CreateRecipe(string title, string description, string[] ingredients)
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);
        var recipe = new Recipe
        {
            Title = title,
            Description = description,
            Ingredients = ingredients
        };

        var data = new StringContent(
            JsonSerializer.Serialize(recipe,
                new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }), Encoding.UTF8,
            "application/json");
        HttpResponseMessage responseMessage = await client.PostAsync("http://localhost:8080/recipes/v1/recipe", data);

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

        Recipe recipe1 = JsonSerializer.Deserialize<Recipe>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
        Console.WriteLine(recipe1);

        return recipe1;
    }

    public static async Task<List<Recipe>> FetchRecipeByIngredients(string ingredients)
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);
        HttpResponseMessage responseMessage =
            await client.GetAsync($"http://localhost:8080/recipes/v1/recipe/{ingredients}");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

        List<Recipe> recipe = JsonSerializer.Deserialize<List<Recipe>>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        });
        Console.WriteLine(recipe);

        return recipe;
    }

    public static async Task<List<Recipe>> UpdateRecipe(Recipe recipe)
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);
        recipe.Status = true;

        var data = new StringContent(
            JsonSerializer.Serialize(recipe,
                new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }), Encoding.UTF8,
            "application/json");
        HttpResponseMessage responseMessage =
            await client.PutAsync($"http://localhost:8080/recipes/v1/recipe/{recipe.Title}", data);

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

        List<Recipe> recipe1 = JsonSerializer.Deserialize<List<Recipe>>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        });
        Console.WriteLine(recipe1);

        return recipe1;
    }

    public static async Task<List<Recipe>> DeleteRecipe(Recipe recipe)
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);

        HttpResponseMessage responseMessage =
            await client.DeleteAsync($"http://localhost:8080/recipes/v1/recipe/{recipe.Id}");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

        List<Recipe> recipe1 = JsonSerializer.Deserialize<List<Recipe>>(result, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        });
        Console.WriteLine(recipe1);

        return recipe1;
    }

    public static async void LikeRecipe(Recipe recipe)
    {
        HttpClientHandler clientHandler = new HttpClientHandler();

        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
        {
            return true;
        };
        using HttpClient client = new HttpClient(clientHandler);

        var data = new StringContent(
            JsonSerializer.Serialize(recipe,
                new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }), Encoding.UTF8,
            "application/json");
        HttpResponseMessage responseMessage =
            await client.PutAsync(
                $"http://localhost:8080/users/v1/likerecipe/{recipe.Id}/{DataStorageStatic.CurrentUser.Id}", data);
        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception(responseMessage.StatusCode.ToString());
        }

        string result = await responseMessage.Content.ReadAsStringAsync();
        Console.WriteLine(result);

     
    }
}
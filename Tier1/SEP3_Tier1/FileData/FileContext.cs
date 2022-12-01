using System.Text.Json;
using Domain.Models;

namespace FileData;

public class FileContext
{
    private const string filePath = "data.json";
    private DataContainer? dataContainer;

   

    public ICollection<User> Users
    {
        get
        {
            LoadDataUsers();
            return dataContainer!.Users;
        }
    }

    /*public ICollection<SubPost> SubPosts
    {
        get
        {
            LoadData();
            return dataContainer!.SubPosts;
        }
    }*/
    private void LoadDataUsers()
    {
        if (dataContainer != null)
        {
            return;
        }

        if (!File.Exists(filePath))
        {
            dataContainer = new()
            {
                Users = new List<User>(),
            };
            return;
        }

        string content = File.ReadAllText(filePath);
        dataContainer = JsonSerializer.Deserialize<DataContainer>(content);
    }

    

    public void SaveChangesUser()
    {
        string content = JsonSerializer.Serialize(dataContainer, new JsonSerializerOptions()
        {
            WriteIndented = true
        });

        File.WriteAllText(filePath, content);
        dataContainer = null;
    }

    public void SaveChangesPost()
    {
        string content = JsonSerializer.Serialize(dataContainer, new JsonSerializerOptions()
        {
            WriteIndented = true
        });

        File.WriteAllText("postData.json", content);
        dataContainer = null;
    }
}
using System.Text.Json.Serialization;

namespace Domain.Models;

public class Root
{
    public List<User> Users { get; set; }
}

public class User
{
    public int Id { get; set; }
    [JsonPropertyName("username")]
    public string UserName { get; set; }
    public string Password { get; set; }
    
    public override string ToString()
    {
        return  string.Format("Id: {0}, UserName{1}, Password: {2}", Id, UserName, Password);
    }
}
using System.Data;
using System.Net.Http.Json;
using System.Text.Json;

using Domain.DTOs;
using Domain.Models;
using HttpClients.ClientInterfaces;

namespace HttpClients.ClientImpls;

public class UserHttpClient : IUserInterface

{
    private readonly HttpClient client;

    public UserHttpClient(HttpClient client)
    {
        this.client = client;
    }

    public async Task<User> Create(UserCreationDto dto)
    {
        User user = Connection.CreateUser(dto.UserName, dto.Password).Result;
  
        return user;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
       List<User> users = Connection.FetchUsers().Result;
        return users;
    }  
}
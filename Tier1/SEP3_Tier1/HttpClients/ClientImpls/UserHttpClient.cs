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
        User user = await Connection.CreateUser(dto.UserName, dto.Password);

        return user;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        List<User> users = await Connection.FetchUsers();
        return users;
    }
}
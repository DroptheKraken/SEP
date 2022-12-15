using System.Security.Cryptography;
using System.Text;
using Domain.Models;


namespace Domain.DTOs;

public class UserCreationDto
{
    public string UserName { get; init; }
    public string Password { get; init; }

    public UserCreationDto(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
    
    
}
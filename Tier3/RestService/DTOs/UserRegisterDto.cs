namespace RestServer.DTOs;

public class UserRegisterDto
{
    public string Username { get; }
    public string Password { get; }
    public string Email { get; }
    
    public UserRegisterDto(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }
}
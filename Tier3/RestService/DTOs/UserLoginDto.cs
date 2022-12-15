namespace RestServer.DTOs;

public class UserLoginDto
{
    public string Username { get; set; }
    public string Password { get; set; }

    public UserLoginDto(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
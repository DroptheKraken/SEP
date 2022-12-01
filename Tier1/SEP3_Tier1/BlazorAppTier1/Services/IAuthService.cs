using System.Security.Claims;
using Domain.Models;


namespace BlazorAppTier1.Services;

public interface IAuthService
{
    Task LoginAsync(string userName, string Password);
    Task LogoutAsync();

    Task RegisterAsync(User user);
    /*public Task<ClaimsPrincipal> GetAuthAsync();*/

    Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }
    Task<ClaimsPrincipal> GetAuthAsync();
}
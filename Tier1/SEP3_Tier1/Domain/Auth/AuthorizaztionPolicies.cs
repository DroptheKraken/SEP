using Microsoft.Extensions.DependencyInjection;

namespace Domain.Auth;

public class AuthorizaztionPolicies
{
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("user", a =>
                a.RequireAuthenticatedUser().RequireClaim("Role", "user"));

            options.AddPolicy("admin", a =>
                a.RequireAuthenticatedUser().RequireClaim("Role", "admin","Admin"));
        });
    }
}
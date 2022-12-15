using BlazorAppTier1.Auth;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorAppTier1.Data;
using BlazorAppTier1.Services;
using BlazorAppTier1.Services.Http;
using Domain.Auth;
using HttpClients.ClientImpls;
using HttpClients.ClientInterfaces;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthProvider>();
builder.Services.AddScoped(sp => new HttpClient());
builder.Services.AddScoped<IAuthService, JwtAuthService>();
builder.Services.AddHttpContextAccessor();



builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7049")
    });
builder.Services.AddScoped<IAuthService, JwtAuthService>();
builder.Services.AddScoped<IUserInterface, UserHttpClient>();
builder.Services.AddScoped<IRecipeInterface, RecipeHttpClient>();
AuthorizaztionPolicies.AddPolicies(builder.Services);
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


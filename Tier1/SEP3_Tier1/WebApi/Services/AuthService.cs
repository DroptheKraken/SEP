﻿using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Domain.DTOs;
using Domain.Models;

namespace WebApi.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient client = new ();

        public Task<User> ValidateUser(string username, string password)
        {
            
            string json = File .ReadAllText("data.json");
            Root users = JsonSerializer.Deserialize<Root>(json);
            
            User existingUser = users.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (existingUser == null)
            {
                throw new Exception("User not found");
            }

            if (!existingUser.Password.Equals(password))
            {
                throw new Exception("Password mismatch");
            }

            return Task.FromResult(existingUser);
        }

        public Task<User> GetUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task RegisterUser(User user)
        {

            if (string.IsNullOrEmpty(user.UserName))
            {
                throw new ValidationException("Username cannot be null");
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                throw new ValidationException("Password cannot be null");
            }
            // Do more user info validation here
        
            // save to persistence instead of list
        
            /*users.Add(user);*/
            
             
            return Task.CompletedTask;
        }
        public static string? Jwt { get; private set; } = "";
    
        private static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            string payload = jwt.Split('.')[1];
            byte[] jsonBytes = ParseBase64WithoutPadding(payload);
            Dictionary<string, object>? keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            return keyValuePairs!.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()!));
        }

        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2:
                    base64 += "==";
                    break;
                case 3:
                    base64 += "=";
                    break;
            }

            return Convert.FromBase64String(base64);
        }

        public async Task LoginAsync(string username, string password)
        {
            UserCreationDto userCreationDto = new(username, password)
            {
                UserName = username,
                Password = password
            };
            

            string userAsJson = JsonSerializer.Serialize(userCreationDto);
            StringContent content = new(userAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("http://localhost:7267/auth/login", content);
            string responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(responseContent);
            }

            string token = responseContent;
            Jwt = token;

            ClaimsPrincipal principal = CreateClaimsPrincipal();

            OnAuthStateChanged.Invoke(principal);
        }
        
        private static ClaimsPrincipal CreateClaimsPrincipal()
        {
            if (string.IsNullOrEmpty(Jwt))
            {
                return new ClaimsPrincipal();
            }

            IEnumerable<Claim> claims = ParseClaimsFromJwt(Jwt);
    
            ClaimsIdentity identity = new(claims, "jwt");

            ClaimsPrincipal principal = new(identity);
            return principal;
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
        

        public async Task RegisterAsync(User user)
        {
            User user1 = user;
            string userAsJson = JsonSerializer.Serialize(user1);
            StringContent content = new(userAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("http://localhost:7111/register", content);
            string responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(responseContent);
            }

            string token = responseContent;
            Jwt = token;

            ClaimsPrincipal principal = CreateClaimsPrincipal();

            OnAuthStateChanged.Invoke(principal);
        }

        public Task<ClaimsPrincipal> GetAuthAsync()
        {
            throw new NotImplementedException();
        }

        public Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }
}
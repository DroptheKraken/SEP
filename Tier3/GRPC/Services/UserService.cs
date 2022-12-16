using Domain.Models;
using EntityDataAccess;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestServer.Controllers;


namespace GRPC.Services;

public class UserService : UserService1.UserService1Base
{
    private DatabaseAccess _databaseAccess;

    public override async Task<UserObj> AddUser(UserObj request, ServerCallContext context)
    {
        try
        {
            _databaseAccess = new DatabaseAccess();
            User addingUser = new User()
            {
                Username = request.Username,
                Password = request.Password,
                Email = request.Email,
                Role = request.Role,
                LikedRecipesIds = request.LikedRecipes
            };
            EntityEntry<User> addedUser = _databaseAccess.Users.Add(addingUser);
            await _databaseAccess.SaveChangesAsync();

            UserObj userObj = new UserObj()
            {
                Id = addedUser.Entity.Id,
                Username = addedUser.Entity.Username,
                Password = addedUser.Entity.Password,
                Role = addedUser.Entity.Role,
                Email = addedUser.Entity.Email,
                LikedRecipes = addedUser.Entity.LikedRecipesIds
            };
            Console.WriteLine("User added");
            return userObj;
        }
        catch (Exception e)
        {
            throw new RpcException(new Status(StatusCode.PermissionDenied, e.Message));
        }
    }

    public override Task<UserObj> GetUser(Username request, ServerCallContext context)
    {
        try
        {
            _databaseAccess = new DatabaseAccess();

            User user = _databaseAccess.Users.FirstOrDefault(u => u.Username == request.UserName)!;
            UserObj userToSend = new UserObj()
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                Role = user.Role
            };
            Console.WriteLine("User found");
            return Task.FromResult(userToSend);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message + "\n\n\n");
            throw new RpcException(new Status(StatusCode.NotFound, e.Message));
        }
    }

    public override Task GetUsers(Empty request, IServerStreamWriter<UserObj> responseStream, ServerCallContext context)
    {
        try
        {
            _databaseAccess = new DatabaseAccess();
            List<User> users = _databaseAccess.Users.ToList();
            foreach (User user in users)
            {
                UserObj userToSend = new UserObj()
                {
                    Id = user.Id,
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    Role = user.Role
                };
                responseStream.WriteAsync(userToSend);
            }

            Console.WriteLine("Users found");
            return Task.FromResult(0);
        }
        catch (Exception e)
        {
            throw new RpcException(new Status(StatusCode.NotFound, e.Message));
        }
    }

    public override Task<RecipeResponse1> GetLikedRecipes(Username request, ServerCallContext context)
    {
        return base.GetLikedRecipes(request, context);
    }

    public override async Task<Recipe1> LikeRecipe(LikeRequest request, ServerCallContext context)
    {
        _databaseAccess.Favorites.Add(new Favorite()
        {
            RecipeId = request.RecipeId,
            UserId = request.UserId
        });
        _databaseAccess.SaveChanges();
        Domain.Models.Recipe recipe = await _databaseAccess.Recipes.FindAsync(request.RecipeId);
        Recipe1 recipe1 = new Recipe1()
        {
            Id = recipe.Id,
            Name = recipe.Title,
            Description = recipe.Description,
            Ingredients = recipe.Ingredients,
            UserId = recipe.UserId,
        };
        return recipe1;
    }
}
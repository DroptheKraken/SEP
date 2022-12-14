using Domain.Models;
using EntityDataAccess;
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
                Role = request.Role
            };
            EntityEntry<User> addedUser = _databaseAccess.Users.Add(addingUser);
            await _databaseAccess.SaveChangesAsync();

            UserObj userObj = new UserObj()
            {
                Id = addedUser.Entity.Id,
                Username = addedUser.Entity.Username,
                Password = addedUser.Entity.Password,
                Role = addedUser.Entity.Role,
                Email = addedUser.Entity.Email
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
}
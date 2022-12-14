using Application.DaoInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace FileData.DAOs;

public class UserFileDao : IUserDao
{
    private readonly FileContext context;
    
    public UserFileDao(FileContext context)
    {
        this.context = context;
    }
    public Task<User> CreateAsync(User user)
    {
        int userId = 1;
        if (context.Users.Any())
        {
            userId = context.Users.Max(u => u.Id) + 1;
        }
        
        user.Id = userId;
        
        context.Users.Add(user);
        context.SaveChangesUser();
        return Task.FromResult(user);
    }
    
    
    public Task<User?> GetByUsernameAsync(string userName)
    {
        User? existing = context.Users.FirstOrDefault(u => u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase));
        return Task.FromResult(existing);
    }

    public Task<IEnumerable<User>> GetAsync(SearchUserParameterDto searchPostParametersDto)
    {
        IEnumerable<User> users = context.Users.AsEnumerable();
        if (searchPostParametersDto.UsernameContains != null)
        {
            users = context.Users.Where(u => u.UserName.Contains(searchPostParametersDto.UsernameContains, StringComparison.OrdinalIgnoreCase));
        }

        return Task.FromResult(users);
    }
    public Task<User?> GetByIdAsync(int id)
    {   
        User? existing = context.Users.FirstOrDefault(u => u.Id == id);
        return Task.FromResult(existing);
    }

    public Task<IEnumerable<User>> GetAllUsersAsync()
    { 
        IEnumerable<User> users = context.Users.AsEnumerable();
        return Task.FromResult(users);
        
    }
}
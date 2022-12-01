using Domain.Models;

namespace DaoInterfaces;

public interface IUserDao
{
    // Create User
    Task<User> AddUserAsync(User user);
    // Get User by Id
    Task<User> GetUserByIdAsync(int id);
    
    

}
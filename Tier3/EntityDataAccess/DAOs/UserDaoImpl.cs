using DaoInterfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EntityDataAccess.DAOs;

public class UserDaoImpl : IUserDao
{
    private readonly DatabaseAccess _context;
    
    public UserDaoImpl(DatabaseAccess context)
    {
        _context = context;
    }
    
    public async Task<User> AddUserAsync(User user)
    {
        try
        {
            Console.Write(user.Username);
            EntityEntry<User> addedUser = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return addedUser.Entity;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error UserDao AddUserAsync: " + e.Message);
            throw new Exception("Error adding user", e);
        }
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        try
        {
            User? user = await _context.Users.FindAsync(id);
            
                Console.Write(user.ToString());
            
            return user;
        }
        catch (Exception e)
        {
            Console.Write("Error UserDao GetUserAsync: " + e.Message);
            throw new Exception("Error getting user", e);
        }
    }
}
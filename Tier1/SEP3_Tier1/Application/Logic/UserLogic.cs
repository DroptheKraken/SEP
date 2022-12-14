using Application.DaoInterfaces;
using Application.LogicInterfaces;
using BlazorAppTier1.CLient;
using Domain.DTOs;
using Domain.Models;

namespace Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDao userDao;
    
    public UserLogic(IUserDao userDao)
    {
        this.userDao = userDao;
    }

    public async Task<User> CreateAsync(UserCreationDto dto)
    {
        User? existingUser = await userDao.GetByUsernameAsync(dto.UserName);
        if (existingUser != null)
        {
            throw new ArgumentException("User already exists");
        }
        
        ValidateData(dto);
        User toCreate = new User
        {
            UserName = dto.UserName,
            Password = dto.Password
        };
        
        User created = await Connection.CreateUser(dto.UserName, dto.Password);
        
        return created;
    }
    
    public async Task<User?> GetByIdAsync(int id)
    {
        return await userDao.GetByIdAsync(id);
    }

    private void ValidateData(UserCreationDto dto)
    {
        string userName = dto.UserName;

        if (userName.Length < 3)
            throw new Exception("Username must be at least 3 characters!");

        if (userName.Length > 15)
            throw new Exception("Username must be less than 16 characters!");    }
    
    public Task<IEnumerable<User>> GetAsync(SearchUserParameterDto searchParameters)
    {
        return userDao.GetAsync(searchParameters);
    }
    
    public Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return userDao.GetAllUsersAsync();
    }
}
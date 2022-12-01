using Domain.Models;
using EntityDataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestServer.DTOs;

namespace RestServer.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{

    private readonly DatabaseAccess _databaseAccess;
    public UserController(DatabaseAccess databaseAccess)
    {
        _databaseAccess = databaseAccess;
    }

    // Add user to database
    [HttpPost("/addUser")]
    public async Task<ActionResult<User>> AddUserAsync(User user)
    {
        try
        {
            /*_databaseAccess.Users.Add(user);
            await _databaseAccess.SaveChangesAsync();
            return Ok(await _databaseAccess.Users.ToListAsync());*/
            EntityEntry<User> newUser = _databaseAccess.Users.Add(user); 
            await _databaseAccess.SaveChangesAsync();
            return newUser.Entity;
        }
        catch (Exception e)
        {
            throw new Exception("Error in UserController\n" + e.Message);
        }
    }
    
    // Register user
    [HttpPost("/register")]
    public async Task<ActionResult<User>> RegisterUserAsync(UserRegisterDto userRegisterDto)
    {
        try
        {
            User? user = new User(
                0,
                userRegisterDto.Username,
                userRegisterDto.Password,
                userRegisterDto.Email,
                "User");

            var newUser = await _databaseAccess.Users.AddAsync(user);
           /* 
            var newUser = _databaseAccess.Users.AddAsync(
                 user => user.Username.equals(userRegisterDto.Username) 
                        && user.Password.equals(userRegisterDto.Password)
                        && user.Email.equals(userRegisterDto.Email)); */
            
            await _databaseAccess.SaveChangesAsync();
            return newUser.Entity;
        }
        catch (Exception e)
        {
            throw new Exception("Error in UserController\n" + e.Message);
        }
    }
    
    [HttpPost("/login")]
    public async Task<ActionResult<User>> UserLoginAsync([FromBody]UserLoginDto userLoginDto)
    {
        try
        {
            User? user = await _databaseAccess.Users.FirstOrDefaultAsync(u => u.Username.Equals(userLoginDto.Username)
            && u.Password.Equals(userLoginDto.Password));
       
            return user;
        }
        catch (Exception e)
        {
            throw new Exception("Error in UserController\n" + e.Message);
        }
    }

    [HttpGet("/getUserById/{id}")]
    public async Task<ActionResult<User?>> GetUserByIdAsync(int id)
    {
        try
        {
            User? userToGet = await _databaseAccess.Users.FirstOrDefaultAsync(user => user.Id == id);
            return userToGet;
        }
        catch (Exception e)
        {
            throw new Exception("Error in UserController\n" + e.Message + "User" + id + "not found or already exists");
        }
    }
    [HttpGet("/")]
    
    [HttpGet("/getUserByUserName/{userName}")]
    public async Task<ActionResult<List<User>>> GetUserByUsernameAsync(string userName)
    {
        try
        {
            User? userToGet =
                await _databaseAccess.Users.FirstOrDefaultAsync(user =>
                    user.Username.ToLower().Equals(userName.ToLower()));
            return Ok(userToGet);
        }
        catch (Exception e)
        {
            throw new Exception("Error in UserController\n" + e.Message);
        }
    }
}
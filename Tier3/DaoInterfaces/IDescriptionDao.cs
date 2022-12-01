using Domain.Models;

namespace DaoInterfaces;

public interface IDescriptionDao
{
    // Add Description
    Task<Description> AddDescription(Description description);
    
    // Get Description by Id
    Task<Description> GetDescriptionById(int id);
    
    // Get Description by Recipe Id
    Task<Description> GetDescriptionByRecipeId(int recipeId);
    
    // Update Description
    Task<Description> UpdateDescription(Description description);
    
    // Delete Description
    Task DeleteDescription(Description description);
}
using DaoInterfaces;
using Domain.Models;

namespace EntityDataAccess.DAOs;

public class DescriptionDaoImpl : IDescriptionDao
{
    public Task<Description> AddDescription(Description description)
    {
        throw new NotImplementedException();
    }

    public Task<Description> GetDescriptionById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Description> GetDescriptionByRecipeId(int recipeId)
    {
        throw new NotImplementedException();
    }

    public Task<Description> UpdateDescription(Description description)
    {
        throw new NotImplementedException();
    }

    public Task DeleteDescription(Description description)
    {
        throw new NotImplementedException();
    }
}
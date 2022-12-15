using Domain.DTOs;
using Domain.Models;

namespace HttpClients.ClientInterfaces;

public interface IRecipeInterface
{
     Task<Recipe> CreateAsync(RecipeCreationDto dto);
}
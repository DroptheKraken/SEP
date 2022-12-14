using Domain.DTOs;

namespace HttpClients.ClientInterfaces;

public interface IRecipeInterface
{
     Task CreateAsync(RecipeCreationDto dto);
}
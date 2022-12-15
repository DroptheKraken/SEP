using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;




[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{
        private readonly IRecipeLogic recipelogic;
        
         public RecipeController(IRecipeLogic recipeLogic)
         {
            this.recipelogic = recipeLogic;
         }
        
         [HttpPost]
         public async Task<ActionResult<Recipe>> CreateAsync(RecipeCreationDto dto)
         {
             try
             {
                 Recipe recipe = await recipelogic.CreateAsync(dto);
                 return Created($"/", recipe);
             }
             catch (Exception e)
             {
                 Console.WriteLine(e);
                 return StatusCode(500, e.Message);
             }
         }

         [HttpGet]
         public async Task<List<Recipe>> SearchRecipesAsync(string searchItem)
         {
             try
             {
                    return await recipelogic.GetByIngredientsAsync(searchItem);
             }
             catch (Exception e)
             {
                 Console.WriteLine(e);
                 throw;
             }

         }

}
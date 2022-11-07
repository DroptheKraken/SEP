package via.sep3.sep3_1.controller;

import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;
import via.sep3.sep3_1.model.Recipe;
import via.sep3.sep3_1.repository.RecipeRepository;

import java.util.List;

@RestController
@RequestMapping("/recipes/v1")
public class RecipeController
{
    private RecipeRepository recipeRepository;

    public RecipeController(RecipeRepository recipeRepository)
    {
        this.recipeRepository = recipeRepository;
    }

    @RequestMapping(value = "/recipe", method = RequestMethod.POST, produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public void saveRecipe(Recipe recipe)

    {
        recipeRepository.saveRecipe(recipe);

    }

    // R --> read (get)
    @RequestMapping(value = "/recipe/{ingredient}",
            method = RequestMethod.GET,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public Recipe getRecipeByIngredient(@PathVariable String ingredient)
    {
        return recipeRepository.getByIngredient(ingredient);
    }

    //get all recipes
    @RequestMapping(value = "/recipes",
            method = RequestMethod.GET,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public List<Recipe> getAllRecipes()
    {
        return recipeRepository.getAllRecipes();
    }
}


package via.sep3.repository;

import org.springframework.stereotype.Repository;
import via.sep3.model.Recipe;

import java.util.List;

@Repository
public class RecipeRepository
{
    private static final List<Recipe> recipes = List.of(
            new Recipe("Chicken", new String[]{"Chicken", "salt", "pepper", "oil"}, "Fry the chicken in a pan with oil"),
            new Recipe("Pasta", new String[]{"Pasta", "salt", "water",}, "Boil the pasta in a pot with water"),
            new Recipe("Rice", new String[]{"Rice", "salt", "water"}, "Boil the rice in a pot with water"),
            new Recipe("Bread", new String[]{"Bread", "salt", "pepper", "oil"}, "Bake the bread in the oven"));

    public void saveRecipe(Recipe recipe)
    {
        recipes.add(recipe
        );
    }


    public Recipe getByIngredient(String ingredient)
    {
        for (Recipe recipe : recipes)
        {
            for (String ingridient : recipe.getIngridient())
            {
                if (ingridient.equals(ingredient))
                {
                    return recipe;
                }
            }
        }
        return null;
    }


    public List<Recipe> getAllRecipes()
    {
        return recipes;
    }
}

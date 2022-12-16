package via.sep3.controller;

import protos.Recipe;
import protos.RecipeResponse;
import protos.UserObj;
import via.sep3.model.User;

import java.util.ArrayList;
import java.util.List;

public class GRPCconverter
{
    public static UserObj getGrpcUserFromUser(User user)
    {
        UserObj userObj = UserObj.newBuilder()
                .setPassword(user.getPassword())
                .setUsername(user.getUsername())
                .setRole("user")
                .build();
        return userObj;
    }

    public static User getUserFromGrpcUser(UserObj userObj)
    {
        User user = new User();
        user.setId(userObj.getId());
        user.setUsername(userObj.getUsername());
        user.setPassword(userObj.getPassword());
        user.setEmail(userObj.getEmail());
        user.setRole(userObj.getRole());
        return user;
    }

    public static Recipe getGrpcRecipeFromRecipe(via.sep3.model.Recipe recipe)
    {
        String ingredients = "";
        for (int i = 0; i < recipe.getIngridient().length; i++)
        {
            ingredients += recipe.getIngridient()[i] + ",";
        }


        Recipe recipe1 = Recipe.newBuilder()
                .setName(recipe.getName())
                .setDescription(recipe.getDescription())
                .setIngredients(ingredients)
                .setId(recipe.getId())
                .setStatus(recipe.isStatus())
                .build();
        return recipe1;
    }

    public static List<via.sep3.model.Recipe> getRecipeFromRecipeResponese(RecipeResponse recipe)
    {
        List<via.sep3.model.Recipe> recipes = new ArrayList<>();

        for (Recipe recipe1 : recipe.getRecipesList())
        {
            via.sep3.model.Recipe recipe2 = new via.sep3.model.Recipe();
            recipe2.setName(recipe1.getName());
            recipe2.setDescription(recipe1.getDescription());
            String[] ingredients = recipe1.getIngredients().split(",");

            recipe2.setIngridient(ingredients);
            recipe2.setStatus(recipe1.getStatus());
            recipe2.setId(recipe1.getId());
            recipes.add(recipe2);
        }
        {

        }


        return recipes;
    }
}

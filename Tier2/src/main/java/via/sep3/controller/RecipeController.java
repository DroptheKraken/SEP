package via.sep3.controller;

import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;
import protos.RecipeFinderGrpc;
import protos.RecipeRequest;
import via.sep3.model.Recipe;

import java.util.List;

@RestController
@RequestMapping("/recipes/v1")
public class RecipeController
{

    @RequestMapping(value = "/recipe", method = RequestMethod.POST, produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public Recipe saveRecipe(@RequestBody Recipe recipe)
    {
        System.out.println(recipe.getName());
        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        RecipeFinderGrpc.RecipeFinderBlockingStub stub
                = RecipeFinderGrpc.newBlockingStub(channel);

        stub.addRecipe(GRPCconverter.getGrpcRecipeFromRecipe(recipe));
        return recipe;
    }

    // R --> read (get)
    @RequestMapping(value = "/recipe/{ingredients}",
            method = RequestMethod.GET,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public List<Recipe> getRecipeByIngredient(@PathVariable String ingredients)
    {

        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        RecipeFinderGrpc.RecipeFinderBlockingStub stub
                = RecipeFinderGrpc.newBlockingStub(channel);
        RecipeRequest recipeRequest = RecipeRequest.newBuilder()
                .setIngredient(ingredients)
                .build();

        return GRPCconverter.getRecipeFromRecipeResponese(stub.getRecipes(recipeRequest));
    }

    @RequestMapping(value = "/recipes",
            method = RequestMethod.GET,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public List<Recipe> getAllRecipes()
    {

        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        RecipeFinderGrpc.RecipeFinderBlockingStub stub
                = RecipeFinderGrpc.newBlockingStub(channel);
        RecipeRequest recipeRequest = RecipeRequest.newBuilder()
                .setIngredient("")
                .build();

        return GRPCconverter.getRecipeFromRecipeResponese(stub.getRecipes(recipeRequest));
    }

    //update
    @RequestMapping(value = "/recipe/{name}",
            method = RequestMethod.PUT,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public List<Recipe> updateRecipe(@RequestBody Recipe recipe)
    {
        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        RecipeFinderGrpc.RecipeFinderBlockingStub stub
                = RecipeFinderGrpc.newBlockingStub(channel);
        protos.Recipe recipe1 = GRPCconverter.getGrpcRecipeFromRecipe(recipe);
        return GRPCconverter.getRecipeFromRecipeResponese(stub.updateRecipe(recipe1));

    }

    //delete
    @RequestMapping(value = "/recipe/{id}",
            method = RequestMethod.DELETE,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public List<Recipe> deleteRecipe(@PathVariable int id)
    {
        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        RecipeFinderGrpc.RecipeFinderBlockingStub stub
                = RecipeFinderGrpc.newBlockingStub(channel);
        protos.Recipe recipe1 = protos.Recipe.newBuilder()
                .setId(id)
                .build();
        return GRPCconverter.getRecipeFromRecipeResponese(stub.deleteRecipe(recipe1));

    }
}




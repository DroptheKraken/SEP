package via.sep3.grpc.server;

import io.grpc.stub.StreamObserver;
import org.lognet.springboot.grpc.GRpcService;

import via.sep3.grpc.proto.RecipeFinderGrpc;
import via.sep3.grpc.proto.RecipeRequest;
import via.sep3.grpc.proto.RecipeResponse;
import via.sep3.repository.RecipeRepository;

@GRpcService


public class SepImpl  extends RecipeFinderGrpc.RecipeFinderImplBase
{

    @java.lang.Override
    public void getRecipes (RecipeRequest requestText, StreamObserver<RecipeResponse> responsetext)
    {
        RecipeRepository recipeRepository =new RecipeRepository();
        RecipeResponse responseText1 = RecipeResponse.newBuilder().setRecipes(String.valueOf(recipeRepository.getByIngredient(requestText.getIngredient()))).build();


            responsetext.onNext(responseText1);
            responsetext.onCompleted();

    }

}
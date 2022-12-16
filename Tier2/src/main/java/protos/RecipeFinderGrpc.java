package protos;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler (version 1.39.0)",
    comments = "Source: recipes.proto")
public final class RecipeFinderGrpc {

  private RecipeFinderGrpc() {}

  public static final String SERVICE_NAME = "protos.RecipeFinder";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<protos.RecipeRequest,
      protos.RecipeResponse> getGetRecipesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetRecipes",
      requestType = protos.RecipeRequest.class,
      responseType = protos.RecipeResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<protos.RecipeRequest,
      protos.RecipeResponse> getGetRecipesMethod() {
    io.grpc.MethodDescriptor<protos.RecipeRequest, protos.RecipeResponse> getGetRecipesMethod;
    if ((getGetRecipesMethod = RecipeFinderGrpc.getGetRecipesMethod) == null) {
      synchronized (RecipeFinderGrpc.class) {
        if ((getGetRecipesMethod = RecipeFinderGrpc.getGetRecipesMethod) == null) {
          RecipeFinderGrpc.getGetRecipesMethod = getGetRecipesMethod =
              io.grpc.MethodDescriptor.<protos.RecipeRequest, protos.RecipeResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetRecipes"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.RecipeRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.RecipeResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RecipeFinderMethodDescriptorSupplier("GetRecipes"))
              .build();
        }
      }
    }
    return getGetRecipesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<protos.Recipe,
      protos.RecipeResponse> getAddRecipeMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "AddRecipe",
      requestType = protos.Recipe.class,
      responseType = protos.RecipeResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<protos.Recipe,
      protos.RecipeResponse> getAddRecipeMethod() {
    io.grpc.MethodDescriptor<protos.Recipe, protos.RecipeResponse> getAddRecipeMethod;
    if ((getAddRecipeMethod = RecipeFinderGrpc.getAddRecipeMethod) == null) {
      synchronized (RecipeFinderGrpc.class) {
        if ((getAddRecipeMethod = RecipeFinderGrpc.getAddRecipeMethod) == null) {
          RecipeFinderGrpc.getAddRecipeMethod = getAddRecipeMethod =
              io.grpc.MethodDescriptor.<protos.Recipe, protos.RecipeResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "AddRecipe"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.Recipe.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.RecipeResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RecipeFinderMethodDescriptorSupplier("AddRecipe"))
              .build();
        }
      }
    }
    return getAddRecipeMethod;
  }

  private static volatile io.grpc.MethodDescriptor<protos.Recipe,
      protos.RecipeResponse> getUpdateRecipeMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateRecipe",
      requestType = protos.Recipe.class,
      responseType = protos.RecipeResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<protos.Recipe,
      protos.RecipeResponse> getUpdateRecipeMethod() {
    io.grpc.MethodDescriptor<protos.Recipe, protos.RecipeResponse> getUpdateRecipeMethod;
    if ((getUpdateRecipeMethod = RecipeFinderGrpc.getUpdateRecipeMethod) == null) {
      synchronized (RecipeFinderGrpc.class) {
        if ((getUpdateRecipeMethod = RecipeFinderGrpc.getUpdateRecipeMethod) == null) {
          RecipeFinderGrpc.getUpdateRecipeMethod = getUpdateRecipeMethod =
              io.grpc.MethodDescriptor.<protos.Recipe, protos.RecipeResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateRecipe"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.Recipe.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.RecipeResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RecipeFinderMethodDescriptorSupplier("UpdateRecipe"))
              .build();
        }
      }
    }
    return getUpdateRecipeMethod;
  }

  private static volatile io.grpc.MethodDescriptor<protos.Recipe,
      protos.RecipeResponse> getDeleteRecipeMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteRecipe",
      requestType = protos.Recipe.class,
      responseType = protos.RecipeResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<protos.Recipe,
      protos.RecipeResponse> getDeleteRecipeMethod() {
    io.grpc.MethodDescriptor<protos.Recipe, protos.RecipeResponse> getDeleteRecipeMethod;
    if ((getDeleteRecipeMethod = RecipeFinderGrpc.getDeleteRecipeMethod) == null) {
      synchronized (RecipeFinderGrpc.class) {
        if ((getDeleteRecipeMethod = RecipeFinderGrpc.getDeleteRecipeMethod) == null) {
          RecipeFinderGrpc.getDeleteRecipeMethod = getDeleteRecipeMethod =
              io.grpc.MethodDescriptor.<protos.Recipe, protos.RecipeResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteRecipe"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.Recipe.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.RecipeResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RecipeFinderMethodDescriptorSupplier("DeleteRecipe"))
              .build();
        }
      }
    }
    return getDeleteRecipeMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static RecipeFinderStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RecipeFinderStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RecipeFinderStub>() {
        @java.lang.Override
        public RecipeFinderStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RecipeFinderStub(channel, callOptions);
        }
      };
    return RecipeFinderStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static RecipeFinderBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RecipeFinderBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RecipeFinderBlockingStub>() {
        @java.lang.Override
        public RecipeFinderBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RecipeFinderBlockingStub(channel, callOptions);
        }
      };
    return RecipeFinderBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static RecipeFinderFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RecipeFinderFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RecipeFinderFutureStub>() {
        @java.lang.Override
        public RecipeFinderFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RecipeFinderFutureStub(channel, callOptions);
        }
      };
    return RecipeFinderFutureStub.newStub(factory, channel);
  }

  /**
   */
  public static abstract class RecipeFinderImplBase implements io.grpc.BindableService {

    /**
     */
    public void getRecipes(protos.RecipeRequest request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetRecipesMethod(), responseObserver);
    }

    /**
     */
    public void addRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getAddRecipeMethod(), responseObserver);
    }

    /**
     */
    public void updateRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateRecipeMethod(), responseObserver);
    }

    /**
     */
    public void deleteRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteRecipeMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetRecipesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                protos.RecipeRequest,
                protos.RecipeResponse>(
                  this, METHODID_GET_RECIPES)))
          .addMethod(
            getAddRecipeMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                protos.Recipe,
                protos.RecipeResponse>(
                  this, METHODID_ADD_RECIPE)))
          .addMethod(
            getUpdateRecipeMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                protos.Recipe,
                protos.RecipeResponse>(
                  this, METHODID_UPDATE_RECIPE)))
          .addMethod(
            getDeleteRecipeMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                protos.Recipe,
                protos.RecipeResponse>(
                  this, METHODID_DELETE_RECIPE)))
          .build();
    }
  }

  /**
   */
  public static final class RecipeFinderStub extends io.grpc.stub.AbstractAsyncStub<RecipeFinderStub> {
    private RecipeFinderStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RecipeFinderStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RecipeFinderStub(channel, callOptions);
    }

    /**
     */
    public void getRecipes(protos.RecipeRequest request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetRecipesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     */
    public void addRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getAddRecipeMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     */
    public void updateRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateRecipeMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     */
    public void deleteRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteRecipeMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class RecipeFinderBlockingStub extends io.grpc.stub.AbstractBlockingStub<RecipeFinderBlockingStub> {
    private RecipeFinderBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RecipeFinderBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RecipeFinderBlockingStub(channel, callOptions);
    }

    /**
     */
    public protos.RecipeResponse getRecipes(protos.RecipeRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetRecipesMethod(), getCallOptions(), request);
    }

    /**
     */
    public protos.RecipeResponse addRecipe(protos.Recipe request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getAddRecipeMethod(), getCallOptions(), request);
    }

    /**
     */
    public protos.RecipeResponse updateRecipe(protos.Recipe request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateRecipeMethod(), getCallOptions(), request);
    }

    /**
     */
    public protos.RecipeResponse deleteRecipe(protos.Recipe request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteRecipeMethod(), getCallOptions(), request);
    }
  }

  /**
   */
  public static final class RecipeFinderFutureStub extends io.grpc.stub.AbstractFutureStub<RecipeFinderFutureStub> {
    private RecipeFinderFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RecipeFinderFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RecipeFinderFutureStub(channel, callOptions);
    }

    /**
     */
    public com.google.common.util.concurrent.ListenableFuture<protos.RecipeResponse> getRecipes(
        protos.RecipeRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetRecipesMethod(), getCallOptions()), request);
    }

    /**
     */
    public com.google.common.util.concurrent.ListenableFuture<protos.RecipeResponse> addRecipe(
        protos.Recipe request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getAddRecipeMethod(), getCallOptions()), request);
    }

    /**
     */
    public com.google.common.util.concurrent.ListenableFuture<protos.RecipeResponse> updateRecipe(
        protos.Recipe request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateRecipeMethod(), getCallOptions()), request);
    }

    /**
     */
    public com.google.common.util.concurrent.ListenableFuture<protos.RecipeResponse> deleteRecipe(
        protos.Recipe request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteRecipeMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_RECIPES = 0;
  private static final int METHODID_ADD_RECIPE = 1;
  private static final int METHODID_UPDATE_RECIPE = 2;
  private static final int METHODID_DELETE_RECIPE = 3;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final RecipeFinderImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(RecipeFinderImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET_RECIPES:
          serviceImpl.getRecipes((protos.RecipeRequest) request,
              (io.grpc.stub.StreamObserver<protos.RecipeResponse>) responseObserver);
          break;
        case METHODID_ADD_RECIPE:
          serviceImpl.addRecipe((protos.Recipe) request,
              (io.grpc.stub.StreamObserver<protos.RecipeResponse>) responseObserver);
          break;
        case METHODID_UPDATE_RECIPE:
          serviceImpl.updateRecipe((protos.Recipe) request,
              (io.grpc.stub.StreamObserver<protos.RecipeResponse>) responseObserver);
          break;
        case METHODID_DELETE_RECIPE:
          serviceImpl.deleteRecipe((protos.Recipe) request,
              (io.grpc.stub.StreamObserver<protos.RecipeResponse>) responseObserver);
          break;
        default:
          throw new AssertionError();
      }
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public io.grpc.stub.StreamObserver<Req> invoke(
        io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        default:
          throw new AssertionError();
      }
    }
  }

  private static abstract class RecipeFinderBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    RecipeFinderBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return protos.Recipes.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("RecipeFinder");
    }
  }

  private static final class RecipeFinderFileDescriptorSupplier
      extends RecipeFinderBaseDescriptorSupplier {
    RecipeFinderFileDescriptorSupplier() {}
  }

  private static final class RecipeFinderMethodDescriptorSupplier
      extends RecipeFinderBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    RecipeFinderMethodDescriptorSupplier(String methodName) {
      this.methodName = methodName;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.MethodDescriptor getMethodDescriptor() {
      return getServiceDescriptor().findMethodByName(methodName);
    }
  }

  private static volatile io.grpc.ServiceDescriptor serviceDescriptor;

  public static io.grpc.ServiceDescriptor getServiceDescriptor() {
    io.grpc.ServiceDescriptor result = serviceDescriptor;
    if (result == null) {
      synchronized (RecipeFinderGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new RecipeFinderFileDescriptorSupplier())
              .addMethod(getGetRecipesMethod())
              .addMethod(getAddRecipeMethod())
              .addMethod(getUpdateRecipeMethod())
              .addMethod(getDeleteRecipeMethod())
              .build();
        }
      }
    }
    return result;
  }
}
/*Sure, I can provide you with an example of how you could implement a favorites feature in your application. Here is a general outline of the steps you can follow:

        Create a database table to store the favorite recipes for each user. This table should have columns for the user's ID, the recipe's ID, and possibly some additional metadata (e.g. a timestamp to track when the recipe was added to the favorites).

        In your Java server, create a RESTful API endpoint that allows users to add and remove recipes from their favorites. This endpoint should accept a request containing the user's ID and the recipe's ID, and should insert or delete a row in the favorites table accordingly.

        In your Blazor frontend, create a user interface for displaying and interacting with the favorite recipes. This could be a separate page or a section on an existing page. You can use a list or a grid layout to display the recipes, and include buttons or other controls for adding and removing them from the favorites.

        To retrieve the favorite recipes for a user, you can create a GRPC service method in your Java server that accepts a user's ID as a parameter and returns a list of the user's favorite recipes. You can then call this method from your Blazor frontend to populate the favorites page with the appropriate data.

        Here is some sample code to illustrate these steps:

        SQL table for storing favorite recipes:
        Copy code
        CREATE TABLE favorites (
        user_id INTEGER NOT NULL,
        recipe_id INTEGER NOT NULL,
        added_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
        PRIMARY KEY (user_id, recipe_id)
        );
        Java RESTful API endpoint for adding and removing favorite recipes:
        Copy code
@POST
@Path("/favorites/add")
public Response addToFavorites(@FormParam("userId") int userId, @FormParam("recipeId") int recipeId) {
        // Insert a row into the favorites table for the given user and recipe
        String sql = "INSERT INTO favorites (user_id, recipe_id) VALUES (?, ?)";
        try (PreparedStatement ps = connection.prepareStatement(sql)) {
        ps.setInt(1, userId);
        ps.setInt(2, recipeId);
        ps.executeUpdate();
        } catch (SQLException e) {
        // Handle the exception
        }
        return Response.ok().build();
        }

@POST
@Path("/favorites/remove")
public Response removeFromFavorites(@FormParam("userId") int userId, @FormParam("recipeId") int recipeId) {
        // Delete the row from the favorites table for the given user and recipe
        String sql = "DELETE FROM favorites WHERE user_id = ? AND recipe_id = ?";
        try (PreparedStatement ps = connection.prepareStatement(sql)) {
        ps.setInt(1, userId);
        ps.setInt(2, recipeId);
        ps.executeUpdate();
        } catch (SQLException e) {
        // Handle the exception
        }
        return Response.ok().build();
        }
        Blazor user interface for displaying and interacting with favorite recipes:
        Copy code
@page "/favorites"*/

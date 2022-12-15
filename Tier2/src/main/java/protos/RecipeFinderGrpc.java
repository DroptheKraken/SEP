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

  private static volatile io.grpc.MethodDescriptor<protos.UserObject,
      protos.RecipeResponse> getGetLikedRecipesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetLikedRecipes",
      requestType = protos.UserObject.class,
      responseType = protos.RecipeResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<protos.UserObject,
      protos.RecipeResponse> getGetLikedRecipesMethod() {
    io.grpc.MethodDescriptor<protos.UserObject, protos.RecipeResponse> getGetLikedRecipesMethod;
    if ((getGetLikedRecipesMethod = RecipeFinderGrpc.getGetLikedRecipesMethod) == null) {
      synchronized (RecipeFinderGrpc.class) {
        if ((getGetLikedRecipesMethod = RecipeFinderGrpc.getGetLikedRecipesMethod) == null) {
          RecipeFinderGrpc.getGetLikedRecipesMethod = getGetLikedRecipesMethod =
              io.grpc.MethodDescriptor.<protos.UserObject, protos.RecipeResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetLikedRecipes"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.UserObject.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  protos.RecipeResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RecipeFinderMethodDescriptorSupplier("GetLikedRecipes"))
              .build();
        }
      }
    }
    return getGetLikedRecipesMethod;
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
    public void getLikedRecipes(protos.UserObject request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetLikedRecipesMethod(), responseObserver);
    }

    /**
     */
    public void updateRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateRecipeMethod(), responseObserver);
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
            getGetLikedRecipesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                protos.UserObject,
                protos.RecipeResponse>(
                  this, METHODID_GET_LIKED_RECIPES)))
          .addMethod(
            getUpdateRecipeMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                protos.Recipe,
                protos.RecipeResponse>(
                  this, METHODID_UPDATE_RECIPE)))
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
    public void getLikedRecipes(protos.UserObject request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetLikedRecipesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     */
    public void updateRecipe(protos.Recipe request,
        io.grpc.stub.StreamObserver<protos.RecipeResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateRecipeMethod(), getCallOptions()), request, responseObserver);
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
    public protos.RecipeResponse getLikedRecipes(protos.UserObject request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetLikedRecipesMethod(), getCallOptions(), request);
    }

    /**
     */
    public protos.RecipeResponse updateRecipe(protos.Recipe request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateRecipeMethod(), getCallOptions(), request);
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
    public com.google.common.util.concurrent.ListenableFuture<protos.RecipeResponse> getLikedRecipes(
        protos.UserObject request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetLikedRecipesMethod(), getCallOptions()), request);
    }

    /**
     */
    public com.google.common.util.concurrent.ListenableFuture<protos.RecipeResponse> updateRecipe(
        protos.Recipe request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateRecipeMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_RECIPES = 0;
  private static final int METHODID_ADD_RECIPE = 1;
  private static final int METHODID_GET_LIKED_RECIPES = 2;
  private static final int METHODID_UPDATE_RECIPE = 3;

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
        case METHODID_GET_LIKED_RECIPES:
          serviceImpl.getLikedRecipes((protos.UserObject) request,
              (io.grpc.stub.StreamObserver<protos.RecipeResponse>) responseObserver);
          break;
        case METHODID_UPDATE_RECIPE:
          serviceImpl.updateRecipe((protos.Recipe) request,
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
              .addMethod(getGetLikedRecipesMethod())
              .addMethod(getUpdateRecipeMethod())
              .build();
        }
      }
    }
    return result;
  }
}

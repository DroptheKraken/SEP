package via.sep3.grpc.proto;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler (version 1.39.0)",
    comments = "Source: recipes.proto")
public final class RecipeFinderGrpc {

  private RecipeFinderGrpc() {}

  public static final String SERVICE_NAME = "RecipeFinder";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<via.sep3.grpc.proto.RecipeRequest,
      via.sep3.grpc.proto.RecipeResponse> getGetRecipesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetRecipes",
      requestType = via.sep3.grpc.proto.RecipeRequest.class,
      responseType = via.sep3.grpc.proto.RecipeResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<via.sep3.grpc.proto.RecipeRequest,
      via.sep3.grpc.proto.RecipeResponse> getGetRecipesMethod() {
    io.grpc.MethodDescriptor<via.sep3.grpc.proto.RecipeRequest, via.sep3.grpc.proto.RecipeResponse> getGetRecipesMethod;
    if ((getGetRecipesMethod = RecipeFinderGrpc.getGetRecipesMethod) == null) {
      synchronized (RecipeFinderGrpc.class) {
        if ((getGetRecipesMethod = RecipeFinderGrpc.getGetRecipesMethod) == null) {
          RecipeFinderGrpc.getGetRecipesMethod = getGetRecipesMethod =
              io.grpc.MethodDescriptor.<via.sep3.grpc.proto.RecipeRequest, via.sep3.grpc.proto.RecipeResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetRecipes"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  via.sep3.grpc.proto.RecipeRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  via.sep3.grpc.proto.RecipeResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RecipeFinderMethodDescriptorSupplier("GetRecipes"))
              .build();
        }
      }
    }
    return getGetRecipesMethod;
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
    public void getRecipes(via.sep3.grpc.proto.RecipeRequest request,
        io.grpc.stub.StreamObserver<via.sep3.grpc.proto.RecipeResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetRecipesMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetRecipesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                via.sep3.grpc.proto.RecipeRequest,
                via.sep3.grpc.proto.RecipeResponse>(
                  this, METHODID_GET_RECIPES)))
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
    public void getRecipes(via.sep3.grpc.proto.RecipeRequest request,
        io.grpc.stub.StreamObserver<via.sep3.grpc.proto.RecipeResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetRecipesMethod(), getCallOptions()), request, responseObserver);
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
    public via.sep3.grpc.proto.RecipeResponse getRecipes(via.sep3.grpc.proto.RecipeRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetRecipesMethod(), getCallOptions(), request);
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
    public com.google.common.util.concurrent.ListenableFuture<via.sep3.grpc.proto.RecipeResponse> getRecipes(
        via.sep3.grpc.proto.RecipeRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetRecipesMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_RECIPES = 0;

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
          serviceImpl.getRecipes((via.sep3.grpc.proto.RecipeRequest) request,
              (io.grpc.stub.StreamObserver<via.sep3.grpc.proto.RecipeResponse>) responseObserver);
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
      return via.sep3.grpc.proto.Recipes.getDescriptor();
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
              .build();
        }
      }
    }
    return result;
  }
}

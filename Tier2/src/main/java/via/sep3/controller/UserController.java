package via.sep3.controller;

import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;
import protos.Empty;

import protos.UserObj;
import protos.UserService1Grpc;
import via.sep3.model.User;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;


@RestController
@RequestMapping("/user/v1")
public class UserController
{

    //post method
    @PostMapping(value = "/user", consumes = MediaType.APPLICATION_JSON_VALUE)
    public User addUser(@RequestBody User user)
    {
        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        UserService1Grpc.UserService1BlockingStub stub
                = UserService1Grpc.newBlockingStub(channel);

        UserObj userObj = GRPCconverter.getGrpcUserFromUser(user);

        UserObj helloResponse2 = stub.addUser(userObj);


        return GRPCconverter.getUserFromGrpcUser(helloResponse2);
    }


    // R --> read (get)
    @RequestMapping(value = "/user/{username}",
            method = RequestMethod.GET,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public User getUserByUsername(@PathVariable String username)
    {
        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        UserService1Grpc.UserService1BlockingStub stub
                = UserService1Grpc.newBlockingStub(channel);

        protos.Username request = protos.Username.newBuilder().setUserName(username).build();
        System.out.println(GRPCconverter.getUserFromGrpcUser(stub.getUser(request)));
        return GRPCconverter.getUserFromGrpcUser(stub.getUser(request));

    }

    //get all users
    @RequestMapping(value = "/users",
            method = RequestMethod.GET,
            produces = MediaType.APPLICATION_JSON_VALUE)
    @ResponseBody
    public List<User> getAllUsers()
    {
        List<User> users = new ArrayList<>();

        ManagedChannel channel = ManagedChannelBuilder.forAddress("localhost", 5001)
                .usePlaintext()
                .build();

        UserService1Grpc.UserService1BlockingStub stub
                = UserService1Grpc.newBlockingStub(channel);
        for (Iterator<UserObj> it = stub.getUsers(Empty.newBuilder().build()); it.hasNext(); )
        {
            UserObj userObj = it.next();
            users.add(GRPCconverter.getUserFromGrpcUser(userObj));
        }
        return users;

    }
}

package via.sep3.model;


import lombok.Data;
import org.springframework.stereotype.Component;

@Component
@Data
public class User
{
    private int id;
    private String username;
    private String password;
    private String email;
    private String Role;
    private String likedRecipes;


}

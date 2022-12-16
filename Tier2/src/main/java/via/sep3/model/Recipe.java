package via.sep3.model;

import lombok.Data;
import org.springframework.stereotype.Component;


@Component
@Data
public class Recipe
{
    private String name;
    private String[] ingridient;
    private String description;
    private boolean status;
    private int id;


}

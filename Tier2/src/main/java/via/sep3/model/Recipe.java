package via.sep3.model;

import java.util.Arrays;

public class Recipe
{
    private final String name;
    private final String[] ingridient;
    private final String description;

    public Recipe(String name, String[] ingridient, String description)
    {
        this.name = name;
        this.ingridient = ingridient;
        this.description = description;
    }

    public String[] getIngridient()
    {
        return ingridient;
    }

    public String getName()
    {
        return name;
    }

    public String getDescription()
    {
        return description;
    }

    @Override
    public String toString()
    {
        return "Recipe{" +
                "name='" + name + '\'' +
                ", ingridient=" + Arrays.toString(ingridient) +
                ", description='" + description + '\'' +
                '}';
    }
}

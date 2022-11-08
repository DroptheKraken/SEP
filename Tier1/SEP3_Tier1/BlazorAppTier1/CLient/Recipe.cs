namespace BlazorAppTier1.CLient;

public class Recipe
{
    private readonly string name;
    private readonly string[] ingridient;
    private readonly string description;

    public Recipe(string name, string[] ingridient, string description)
    {
        this.name = name;
        this.ingridient = ingridient;
        this.description = description;
    }

    public virtual string[] Ingridient
    {
        get
        {
            return ingridient;
        }
    }

    public virtual string Name
    {
        get
        {
            return name;
        }
    }

    public virtual string Description
    {
        get
        {
            return description;
        }
    }

    public override string ToString()
    {
        return "Recipe{" +
               "name='" + name + '\'' +
               ", ingridient=" + ingridient +
               ", description='" + description + '\'' +
               '}';
    }
}
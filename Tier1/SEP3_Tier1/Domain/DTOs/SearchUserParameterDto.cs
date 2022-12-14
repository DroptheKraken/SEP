namespace Domain.DTOs;

public class SearchUserParameterDto
{
    public string? UsernameContains { get;  }
    

    public SearchUserParameterDto(string? usernameContains)
    {
        UsernameContains = usernameContains;
    }
}
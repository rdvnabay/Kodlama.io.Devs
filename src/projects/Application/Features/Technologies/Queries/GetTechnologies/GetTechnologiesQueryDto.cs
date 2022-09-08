namespace Application.Features.Technologies.Queries.GetTechnologies;

public class GetTechnologiesQueryDto
{
    public int Id { get; set; } 
    public string Name { get; set; }

    //Includes
    public string ProgrammingLanguageName { get; set; }
}

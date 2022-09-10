using Core.Domain.Entities.Base;

namespace Domain.Entities;

public class Technology:Entity<int>
{
    public int ProgrammingLanguageId { get; set; }
    public string Name { get; set; }

    //Relationship
    public ProgrammingLanguage ProgrammingLanguage { get; set; }
}

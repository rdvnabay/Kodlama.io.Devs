using Core.Domain.Entities.Base;

namespace Domain.Entities;

public class ProgrammingLanguage : Entity<int>
{
    public string Name { get; set; }


    //Relationship
    public ICollection<Technology> Technologies { get; set; }
}
using Core.Domain.Entities;
namespace Domain.Entities;

public class ProgrammingLanguage : Entity<int>
{
    public string Name { get; set; }
}
using Core.Domain.Entities.Base;
namespace Core.Domain.Entities;

public class OperationClaim:Entity
{
    public string Name { get; set; }

    //Relationship
    public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}

using Core.Domain.Entities.Base;

namespace Core.Domain.Entities;

public class UserOperationClaim:IEntity
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }

    //Relationship
    public User User { get; set; }
    public OperationClaim OperationClaim { get; set; }
}

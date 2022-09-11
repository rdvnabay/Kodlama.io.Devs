using Core.Domain.Entities.Base;
namespace Core.Domain.Entities;

public partial class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; }

    //Relationship
    public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}

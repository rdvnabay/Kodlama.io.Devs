using Core.Domain.Entities.Base;
namespace Core.Domain.Entities;

public class RefreshToken : Entity
{
    public int UserId { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedByIp { get; set; }
    public DateTime? Revoked { get; set; }
    public string? RevokedByIp { get; set; }
    public string? ReplaceByToken { get; set; }
    public string? ReasonRevoked { get; set; }

    //Relationship
    public User User { get; set; }
}

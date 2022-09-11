using Core.Domain.Entities;
namespace Domain.Entities;

public class Developer : User
{
    //Relationship
    public ICollection<SocialMediaAccount> SocialMediaAccounts { get; set; }
}

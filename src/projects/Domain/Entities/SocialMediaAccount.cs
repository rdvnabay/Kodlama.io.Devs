using Core.Domain.Entities.Base;
namespace Domain.Entities;

public class SocialMediaAccount:Entity
{
    public int DeveloperId { get; set; }
    public string Website { get; set; }
    public string Link { get; set; }

    //Relationship
    public Developer Developer { get; set; }
}

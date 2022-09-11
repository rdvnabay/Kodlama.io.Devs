namespace Persistence.Repositories;

public class SocialMediaAccountRepository : EfRepositoryBase<ApplicationDbContext, SocialMediaAccount>, ISocialMediaAccountRepository
{
    public SocialMediaAccountRepository(ApplicationDbContext context) : base(context) { }
}


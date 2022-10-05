namespace Persistence.Repositories;

public class UserOperationClaimRepository : EfRepositoryBase<ApplicationDbContext, UserOperationClaim>, IUserOperationClaimRepository
{
    public UserOperationClaimRepository(ApplicationDbContext context) : base(context) { }
}



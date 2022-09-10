namespace Persistence.Repositories;

public class OperationClaimRepository : EfRepositoryBase<ApplicationDbContext, OperationClaim>, IOperationClaimRepository
{
    public OperationClaimRepository(ApplicationDbContext context) : base(context) { }
}


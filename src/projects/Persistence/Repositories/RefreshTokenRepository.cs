namespace Persistence.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<ApplicationDbContext, RefreshToken>, IRefreshTokenRepository
{
    public RefreshTokenRepository(ApplicationDbContext context) : base(context) { }
}



namespace Persistence.Repositories;

public class UserRepository : EfRepositoryBase<ApplicationDbContext, User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context) { }
}


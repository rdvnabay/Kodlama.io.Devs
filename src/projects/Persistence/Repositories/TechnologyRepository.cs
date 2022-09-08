using Application.Services.Repositories;

namespace Persistence.Repositories;
public class TechnologyRepository : EfRepositoryBase<ApplicationDbContext, Technology>, ITechnologyRepository
{
    public TechnologyRepository(ApplicationDbContext context) : base(context) { }
}


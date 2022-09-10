using Application.Services.Repositories;
using Core.Persistence.Repositories.Base;
namespace Persistence.Repositories;

public class TechnologyRepository : EfRepositoryBase<ApplicationDbContext, Technology>, ITechnologyRepository
{
    public TechnologyRepository(ApplicationDbContext context) : base(context) { }
}


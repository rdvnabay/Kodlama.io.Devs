using Core.Domain.Entities;
using Core.Persistence.Contexts;
using Core.Persistence.Repositories.Base;
using Core.Persistence.Repositories.Interfaces;
namespace Core.Persistence.Repositories;

public class UserRepository : EfRepositoryBase<ProjectDbContext, User>, IUserRepository
{
    public UserRepository(ProjectDbContext context) : base(context) { }
}

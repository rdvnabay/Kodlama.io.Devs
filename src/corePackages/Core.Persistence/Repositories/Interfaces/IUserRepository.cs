using Core.Domain.Entities;
using Core.Persistence.Repositories.Base;
namespace Core.Persistence.Repositories.Interfaces;

public interface IUserRepository : IAsyncRepository<User> { }

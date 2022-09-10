using Core.Domain.Entities;
using Core.Persistence.Repositories.Base;
namespace Application.Services.Repositories;

public interface IUserRepository : IAsyncRepository<User> { }

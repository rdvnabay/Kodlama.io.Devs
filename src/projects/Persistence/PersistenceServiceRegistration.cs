using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();

        //Repositories
        services.AddScoped<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();
        services.AddScoped<ITechnologyRepository, TechnologyRepository>();

        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}

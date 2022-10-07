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
        services.AddScoped<ISocialMediaAccountRepository, SocialMediaAccountRepository>();
        services.AddScoped<ITechnologyRepository, TechnologyRepository>();

        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();
        return services;
    }
}

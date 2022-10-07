using Application.Features.ProgrammingLanguages;
using Application.Features.SocialMediaAccounts;
using Application.Features.Technologies;
using Application.Features.Users;
using Application.Services.AuthService;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Validation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
namespace Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        //Services
        services.AddScoped<IAuthService, AuthService>();

        //Business Rules
        services.AddScoped<ProgrammingLanguageBusinessRules>();
        services.AddScoped<SocialMediaAccountBusinessRules>();
        services.AddScoped<TechnologyBusinessRules>();
        services.AddScoped<AuthBusinessRules>();

        //Behaviors
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

        return services;
    }
}

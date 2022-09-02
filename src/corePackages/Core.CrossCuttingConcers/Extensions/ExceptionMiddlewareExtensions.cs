using Core.CrossCuttingConcers.Middlewares;
using Microsoft.AspNetCore.Builder;
namespace Core.CrossCuttingConcers.Extensions;

public static class ExceptionMiddlewareExtensions
{
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}

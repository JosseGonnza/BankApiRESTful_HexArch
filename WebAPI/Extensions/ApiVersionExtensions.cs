using Asp.Versioning;

namespace WebAPI.Extensions;

public static class ApiVersionExtensions
{
    public static IServiceCollection AddApiVersion(this IServiceCollection services)
    {
        services.AddApiVersioning(config =>
        {
            config.DefaultApiVersion = new ApiVersion(1, 0);
                
            // Si el cliente no define la versión, directamente se enruta a la versión 1.0
            config.AssumeDefaultVersionWhenUnspecified = true;

            config.ReportApiVersions = true;
        });

        return services;
    }
}
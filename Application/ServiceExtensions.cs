using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    // Nos permite agrupar las inyecciones de nuestros servicios de terceros o los nuestros propios.
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services, params Assembly[] otherAssemblies) 
        {
            var currentAssembly = typeof(ServiceExtensions).Assembly;
            services.AddValidatorsFromAssembly(currentAssembly);

            var assemblies = new List<Assembly> { currentAssembly};
        
            if (otherAssemblies.Any())
            {
                assemblies.AddRange(otherAssemblies);
            }
            
            // Los servicios que creo dentro, pueden ser llamados desde WebAPI por AddApplicationLayer
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

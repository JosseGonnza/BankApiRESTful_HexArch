using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    // Nos permite agrupar las inyecciones de nuestros servicios de terceros o los nuestros propios.
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services) 
        {
            // Los servicios que creo dentro, pueden ser llamados desde WebAPI por AddApplicationLayer
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}

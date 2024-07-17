using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EasyCommerceShop.ProdcutService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProductServiceApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        } 
    }
}

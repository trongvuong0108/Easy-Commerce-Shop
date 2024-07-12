using EasyCommerceShop.Application.Services;
using EasyCommerceShop.OrderService.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace EasyCommerceShop.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPaymentService, MomoPaymentService>();
        }
    }
}

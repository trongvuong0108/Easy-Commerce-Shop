using EasyCommerceShop.Domain.Entities;

namespace EasyCommerceShop.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<IQueryable<Product>> GetProductsAsync();
    }
}

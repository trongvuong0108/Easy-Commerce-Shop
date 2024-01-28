using EasyCommerceShop.Infrastructure.Data.Entities;

namespace EasyCommerceShop.Infrastructure.Abstraction.IRepositories
{
    public interface IProductRepository
    {
        Task<IQueryable<Product>> GetProductsAsync();
    }
}

using EasyCommerceShop.Infrastructure.Abstraction.IRepositories;
using EasyCommerceShop.Infrastructure.Data.Entities;

namespace EasyCommerceShop.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IQueryable<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

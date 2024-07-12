using EasyCommerceShop.Infrastructure.Abstraction;
using EasyCommerceShop.Infrastructure.Data;
using EasyCommerceShop.Domain.Entities;

namespace EasyCommerceShop.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(EasyShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}

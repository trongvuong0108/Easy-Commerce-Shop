using EasyCommerceShop.Domain.Entities;
using EasyCommerceShop.Infrastructure.Abstraction;
using EasyCommerceShop.Persistence.Data;

namespace EasyCommerceShop.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product, Guid>
    {
        public ProductRepository(EasyShopDbContext dbContext) : base(dbContext)
        {
        }
    }
}

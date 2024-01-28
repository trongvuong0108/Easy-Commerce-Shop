using EasyCommerceShop.Application.Abstraction.IApplicationService;
using EasyCommerceShop.Infrastructure.Data.Entities;

namespace EasyCommerceShop.Application.BusinessService
{
    public class ProductService : IProductService
    {
        public Task<IQueryable<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Product>> GetAllProductsByBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Product>> GetAllProductsByCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

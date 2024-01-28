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

        public Task<IQueryable<Product>> GetAllProductsByBrand(BrandEntityConfiguration brand)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Product>> GetAllProductsByCategoryAsync(CategoryEntityConfiguration category)
        {
            throw new NotImplementedException();
        }
    }
}

using EasyCommerceShop.Application.BusinessAbstraction;
using EasyCommerceShop.Domain.Entities;

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

using EasyCommerceShop.Infrastructure.Data.Entities;

namespace EasyCommerceShop.Application.Abstraction
{
    public interface IProductService
    {
        Task<IQueryable<Product>> GetAllProductsAsync();
        Task<IQueryable<Product>> GetAllProductsByCategoryAsync(Category category);
        Task<IQueryable<Product>> GetAllProductsByBrand(Brand brand);
    }
}

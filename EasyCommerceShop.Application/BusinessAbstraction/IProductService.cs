using EasyCommerceShop.Domain.Entities;

namespace EasyCommerceShop.Application.BusinessAbstraction
{
    public interface IProductService
    {
        Task<IQueryable<Product>> GetAllProductsAsync();
        Task<IQueryable<Product>> GetAllProductsByCategoryAsync(Category category);
        Task<IQueryable<Product>> GetAllProductsByBrand(Brand brand);
    }
}

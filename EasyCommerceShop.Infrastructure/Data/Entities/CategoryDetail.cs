using EasyCommerceShop.Infrastructure.Abstraction;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class CategoryDetail : GenericEntity
    {
        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}

using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class CategoryDetail : GenericEntity
    {
        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}

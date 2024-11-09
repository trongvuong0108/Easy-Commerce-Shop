using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class BrandCategoryDetail : GenericEntity<int>
    {
        public Brand? Brand { get; set; }    
        public Category? Category { get; set; }
    }
}

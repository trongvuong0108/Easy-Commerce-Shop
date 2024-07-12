using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class BrandCategoryDetail : GenericEntity
    {
        public Brand Brand { get; set; }    
        public Category Category { get; set; }
    }
}

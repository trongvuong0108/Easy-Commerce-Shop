using EasyCommerceShop.Infrastructure.Abstraction;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class BrandCategoryDetail : GenericEntity
    {

        public Brand Brand { get; set; }    
        public Category Category { get; set; }


    }
}

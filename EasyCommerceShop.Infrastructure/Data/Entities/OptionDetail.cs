using EasyCommerceShop.Infrastructure.Abstraction;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class OptionDetail : GenericEntity
    {
        public Guid OptionId { get; set; }
        public Guid ProductId { get; set; }
        public Option? Option { get; set; }
        public Product? Product { get; set; }   
    }
}

using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class OptionDetail : GenericEntity<int>
    {
        public Guid OptionId { get; set; }
        public Guid ProductId { get; set; }
        public Option? Option { get; set; }
        public Product? Product { get; set; }   
    }
}

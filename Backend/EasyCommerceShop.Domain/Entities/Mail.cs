using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class Mail : GenericEntity<int>
    {

        public string From  { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string CC { get; set; } = string.Empty;
        public string Subject  { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}

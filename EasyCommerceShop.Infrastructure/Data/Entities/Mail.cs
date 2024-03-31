using EasyCommerceShop.Infrastructure.Abstraction;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Mail : GenericEntity
    {

        public string From  { get; set; }
        public string To  { get; set; }
        public string CC  { get; set; }
        public string Subject  { get; set; }
        public string Content  { get; set; }
    }
}

using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class Mail : GenericEntity<int>
    {

        public string From  { get; set; }
        public string To  { get; set; }
        public string CC  { get; set; }
        public string Subject  { get; set; }
        public string Content  { get; set; }
    }
}

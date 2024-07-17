using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class BranchContactPoint : GenericEntity<int>
    {

        public string Name { get; set; }= string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;



        public Brand brand { get; set; }
    }
}

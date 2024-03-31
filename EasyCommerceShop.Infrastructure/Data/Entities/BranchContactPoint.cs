using EasyCommerceShop.Infrastructure.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class BranchContactPoint : GenericEntity
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

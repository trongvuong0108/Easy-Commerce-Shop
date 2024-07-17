using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommerceShop.Domain.Abstraction
{
    public interface IPagableRequest
    {
        public int PageNum { get; set; }
        public int PageSize { get; set; }
    }
}

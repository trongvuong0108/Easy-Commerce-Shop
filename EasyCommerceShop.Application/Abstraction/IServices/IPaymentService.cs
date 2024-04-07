using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommerceShop.Application.Abstraction.IServices
{
    public interface IPaymentService
    {
        public Task<string> doPayment();
    }
}

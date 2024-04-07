using EasyCommerceShop.Application.Abstraction.IServices;
using EasyCommerceShop.Application.Services;
using EasyCommerceShop.Infrastructure.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace EasyCommerceShop.ProdcutService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public async Task<EasyCommerceShopResponseBase<string>> GetPaymentLink()
        {
            IPaymentService paymentService = new MomoPaymentService();
            string link = await paymentService.doPayment();
            return new EasyCommerceShopResponseBase<string>
            {
                dataObject = link,
                Status = 200,
                IsSuccess = true,
            };
        }
    }
}

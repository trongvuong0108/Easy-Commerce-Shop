using EasyCommerceShop.Application.Services;
using EasyCommerceShop.Infrastructure.Abstraction;
using EasyCommerceShop.OrderService.Application.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace EasyCommerceShop.ProdcutService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
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

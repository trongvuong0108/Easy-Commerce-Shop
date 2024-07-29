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
        private readonly IPaymentService _paymentService;

        public OrderController(IPaymentService orderService)
        {
            _paymentService = orderService;
        }
        [HttpGet]
        public async Task<EasyCommerceShopResponseBase<string>> GetPaymentLink()
        {
            string link = await _paymentService.doPayment();
            return new EasyCommerceShopResponseBase<string>
            {
                dataObject = link,
                Status = 200,
                IsSuccess = true,
            };
        }
        //[HttpGet]
        //public async Task<IActionResult> DownloadInvoice()
        //{

        //}
    }
}

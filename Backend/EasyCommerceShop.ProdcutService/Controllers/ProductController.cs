using EasyCommerceShop.Domain.Entities;
using EasyCommerceShop.Infrastructure.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace EasyCommerceShop.ProdcutService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public EasyCommerceShopResponseBase<ICollection<Product>> GetAllProduct()
        {
            EasyCommerceShopResponseBase<ICollection<Product>> myResult =
                new EasyCommerceShopResponseBase<ICollection<Product>>()
                {
                    IsSuccess = true,
                    Status = 200,
                    dataObject = null
                };
            return myResult; 
        }
    }
}

using EasyCommerceShop.Infrastructure.Abstraction;
using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

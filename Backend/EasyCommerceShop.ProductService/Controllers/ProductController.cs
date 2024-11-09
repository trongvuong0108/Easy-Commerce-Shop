using EasyCommerceShop.Domain.Entities;
using EasyCommerceShop.Infrastructure.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace EasyCommerceShop.ProductService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public EasyCommerceShopResponseBase<ICollection<Product>> GetAllProduct()
        {
           
                
            return EasyCommerceShopResponseBase<ICollection<Product>>.Succeed(); 
        }
    }
}

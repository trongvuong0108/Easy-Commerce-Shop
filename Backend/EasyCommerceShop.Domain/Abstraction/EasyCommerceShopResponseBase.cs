using System.Net;

namespace EasyCommerceShop.Infrastructure.Abstraction
{
    public class EasyCommerceShopResponseBase<T> where T : class
    {
        public T? DataObject { get; set; }
        public bool IsSuccess { get; set; }
        public ICollection<string> ErrorMessages { get; set; } = new List<string>();
        public int Status { get; set; }

        public static EasyCommerceShopResponseBase<T> Succeed() => new EasyCommerceShopResponseBase<T>()
        {
            IsSuccess = true,
            Status = (int)HttpStatusCode.OK
        };
        public static EasyCommerceShopResponseBase<T> Fail() => new EasyCommerceShopResponseBase<T>()
            {
                IsSuccess = false,
                Status = (int) HttpStatusCode.InternalServerError
            };
}
}

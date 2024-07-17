namespace EasyCommerceShop.Infrastructure.Abstraction
{
    public class EasyCommerceShopResponseBase<T> where T : class
    {
        public T? dataObject { get; set; }
        public bool IsSuccess { get; set; }
        public ICollection<string> Message { get; set; } = new List<string>();
        public int Status { get; set; }
    }
}

namespace EasyCommerceShop.Domain.Abstraction
{
    public interface IPagable : IPagableRequest
    {
        int PageCount { get; set; }
        int TotalPages { get; set; }
    }
}

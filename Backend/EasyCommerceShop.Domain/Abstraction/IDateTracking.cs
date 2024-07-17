namespace EasyCommerceShop.Domain.Abstraction
{
    public interface IDateTracking
    {
        public DateTime? DateCreate { get; set; }
        public DateTime? DateChange { get; set; }
    }
}

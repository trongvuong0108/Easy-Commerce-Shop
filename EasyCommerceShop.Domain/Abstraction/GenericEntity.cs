namespace EasyCommerceShop.Domain.Abstraction
{
    public class GenericEntity
    {
        public string Id { get; set; }
        public DateTime? DateCreate{ get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateChange{ get; set; }
        public string? ChangedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}

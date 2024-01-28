namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class OptionCategoryDetail
    {
        public Guid Id { get; set; }
        public Option Option { get; set; }
        public Category Category { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
    }
}

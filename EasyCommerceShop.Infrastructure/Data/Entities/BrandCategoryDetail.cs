namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class BrandCategoryDetail
    {
        public Guid Id { get; set; }
        public Brand Brand { get; set; }    
        public Category Category { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
    }
}

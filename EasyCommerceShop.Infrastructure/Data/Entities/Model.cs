namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Model
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public string ModelDetail { get; set; } = string.Empty;
        public int YearManufacture { get; set; } = DateTime.Now.Year;
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
    }
}

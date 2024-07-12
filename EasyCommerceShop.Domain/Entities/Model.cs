using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class Model : GenericEntity
    {

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string AuthorName { get; set; } = string.Empty;
        public string ModelDetail { get; set; } = string.Empty;
        public int YearManufacture { get; set; } = DateTime.Now.Year;


    }
}

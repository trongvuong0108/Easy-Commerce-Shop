using EasyCommerceShop.Infrastructure.Abstraction;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Product : GenericEntity
    {
        #region MainProperties
        public string? Name { get; set; }
        public string? NameLocalized { get; set; }
        public string? Description { get; set; }
        public string? DescriptionLocalized { get; set; }
        public decimal PriceIn { get; set; }
        public decimal PriceOut { get; set; }
        public string? ProductCode { get; set; }
        public int Quantity { get; set; }
        public bool? IsShowOnWeb { get; set; }
        #endregion

        #region RelationshipMapping
        public Brand? Brand { get; set; }
        public List<OptionDetail>? OptionCategories { get; set; }    
        #endregion
    }
}

using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class Option : GenericEntity<int>
    {
        #region MainProperties

        public string Name { get; set; } = string.Empty;
        public string NameLocalized { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DescriptionLocalized { get; set; } = string.Empty;


        #endregion

        #region RelationShipMapping 
        public ICollection<Product>? Products { get; set; }
        #endregion
    }
}

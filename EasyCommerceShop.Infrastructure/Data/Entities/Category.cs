using EasyCommerceShop.Infrastructure.Abstraction;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Category : GenericEntity
    {
        #region MainProperties

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        #endregion

        #region RelationshipMapping
        public List<Product>? Products { get; set; }
        public List<Option>? Options { get; set; }
        #endregion
    }
}

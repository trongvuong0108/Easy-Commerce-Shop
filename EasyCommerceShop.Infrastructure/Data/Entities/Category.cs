namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Category
    {
        #region MainProperties
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
        #endregion

        #region RelationshipMapping
        public List<Product> Products { get; set; }
        public List<OptionEntityConfiguration> Options { get; set; }
        #endregion
    }
}

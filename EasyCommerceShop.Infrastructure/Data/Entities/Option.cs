namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Option
    {
        #region MainProperties
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameLocalized { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DescriptionLocalized { get; set; } = string.Empty;
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
        #endregion

        #region RelationShipMapping 
        public List<OptionCategoryDetail> Category { get; set; }
        #endregion
    }
}

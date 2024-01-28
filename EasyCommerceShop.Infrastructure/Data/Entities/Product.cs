namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Product
    {
        #region MainProperties
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameLocalized { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DescriptionLocalized { get; set; } = string.Empty;
        public decimal PriceIn { get; set; }
        public decimal PriceOut { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsShowOnWeb { get; set; } = true;
        #endregion

        #region RelationshipMapping
        //public Brand Brand { get; set; }
        //public List<OptionCategoryDetail> OptionCategories { get; set; }    
        #endregion
    }
}

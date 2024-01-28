namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Brand
    {
        #region MainProperties
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int Fax { get; set; }
        public string FaxNumber { get; set; } = string.Empty;
        public string FaxName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime Create { get; set; } = DateTime.Now;
        public DateTime Update { get; set; } = DateTime.Now;
        #endregion

        #region RelationshipMapping
        public List<BrandCategoryDetail> categories { get; set; }
        public List<Product> products { get; set; }

        public BranchContactPoint contactPoint { get; set; }
        #endregion
    }
}

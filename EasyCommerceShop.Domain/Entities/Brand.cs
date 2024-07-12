using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class Brand : GenericEntity
    {
        #region MainProperties

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


        #endregion

        #region RelationshipMapping
        public List<BrandCategoryDetail>? categories { get; set; }
        public List<Product>? products { get; set; }

        public BranchContactPoint? contactPoint { get; set; }
        #endregion
    }
}

using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class CartProductDetailEntityConfiguration : IEntityTypeConfiguration<CartProductDetail>
    {
        public void Configure(EntityTypeBuilder<CartProductDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}

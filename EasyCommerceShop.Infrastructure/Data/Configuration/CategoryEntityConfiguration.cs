using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<CartProductDetail>
    {
        public void Configure(EntityTypeBuilder<CartProductDetail> builder)
        {
        }
    }
}

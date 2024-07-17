using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<CartProductDetail>
    {
        public void Configure(EntityTypeBuilder<CartProductDetail> builder)
        {
        }
    }
}

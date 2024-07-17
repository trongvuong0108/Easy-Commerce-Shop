using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class ShoppingCartEntityConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            throw new NotImplementedException();
        }
    }
}

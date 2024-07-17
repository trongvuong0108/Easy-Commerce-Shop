using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class OrderStatusEntityConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            throw new NotImplementedException();
        }
    }
}

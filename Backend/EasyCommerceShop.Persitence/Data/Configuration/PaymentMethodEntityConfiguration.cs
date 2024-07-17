using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class PaymentMethodEntityConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            throw new NotImplementedException();
        }
    }
}

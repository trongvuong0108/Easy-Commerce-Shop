using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class BrandEntityConfiguration : IEntityTypeConfiguration<BranchContactPoint>
    {
        public void Configure(EntityTypeBuilder<BranchContactPoint> builder)
        {
        }
    }
}

using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class BrandEntityConfiguration : IEntityTypeConfiguration<BranchContactPoint>
    {
        public void Configure(EntityTypeBuilder<BranchContactPoint> builder)
        {
        }
    }
}

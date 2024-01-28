using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class BranchContactPointEntityConfiguration : IEntityTypeConfiguration<BranchContactPoint>
    {
        public void Configure(EntityTypeBuilder<BranchContactPoint> builder)
        {
        }
    }
}

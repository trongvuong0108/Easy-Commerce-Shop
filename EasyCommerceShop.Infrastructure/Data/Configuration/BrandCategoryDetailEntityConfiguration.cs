using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class BrandCategoryDetailEntityConfiguration : IEntityTypeConfiguration<BranchContactPoint>
    {
        public void Configure(EntityTypeBuilder<BranchContactPoint> builder)
        {
            throw new NotImplementedException();
        }
    }
}

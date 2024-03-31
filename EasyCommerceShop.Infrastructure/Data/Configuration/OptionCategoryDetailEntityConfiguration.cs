using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class OptionCategoryDetailEntityConfiguration : IEntityTypeConfiguration<OptionDetail>
    {
        public void Configure(EntityTypeBuilder<OptionDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}

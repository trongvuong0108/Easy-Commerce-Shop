using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class OptionCategoryDetailEntityConfiguration : IEntityTypeConfiguration<OptionDetail>
    {
        public void Configure(EntityTypeBuilder<OptionDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}

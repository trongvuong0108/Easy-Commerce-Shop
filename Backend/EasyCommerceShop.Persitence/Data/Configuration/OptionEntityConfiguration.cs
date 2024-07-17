using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class OptionEntityConfiguration : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            throw new NotImplementedException();
        }
    }
}

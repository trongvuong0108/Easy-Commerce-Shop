using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class CountryLanguageDetailEntityConfiguration : IEntityTypeConfiguration<CountryLanguageDetail>
    {

        public void Configure(EntityTypeBuilder<CountryLanguageDetail> builder)
        {
            throw new NotImplementedException();
        }
    }

}

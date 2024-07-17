using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class CountryLanguageDetailEntityConfiguration : IEntityTypeConfiguration<CountryLanguageDetail>
    {

        public void Configure(EntityTypeBuilder<CountryLanguageDetail> builder)
        {
            throw new NotImplementedException();
        }
    }

}

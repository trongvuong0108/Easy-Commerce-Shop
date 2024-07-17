using EasyCommerceShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Persistence.Data.Configuration
{
    public class ShopSettingEntityConfiguration : IEntityTypeConfiguration<ShopSetting>
    {
        public void Configure(EntityTypeBuilder<ShopSetting> builder)
        {
            throw new NotImplementedException();
        }
    }
}

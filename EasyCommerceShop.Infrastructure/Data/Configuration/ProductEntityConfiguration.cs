using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .ToTable(nameof(Product))
                .HasKey(s => s.Id);
            builder
                .HasIndex(s => s.Id);
            builder
                .Property(s => s.Id)
                .HasColumnName("product_id");
            builder
                .Property(s => s.Name)
                .IsRequired();
            builder
                .Property(s => s.NameLocalized)
                .IsRequired();
            builder
                .Property(s => s.Description)
                .HasDefaultValue(string.Empty)
                .HasColumnType("ntext");
            builder
                .Property(s => s.DescriptionLocalized)
                .HasDefaultValue(string.Empty);
            builder
                .Property(s => s.PriceIn)
                .IsRequired();
            builder
                .Property(s => s.PriceOut)
                .IsRequired();
            builder
                .Property(s => s.Quantity)
                .IsRequired()
                .HasDefaultValue(0);
            builder
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false);
            builder
                .Property(s => s.IsShowOnWeb)
                .HasDefaultValue(true);
            builder
                .HasMany(s => s.OptionCategories)
                .WithOne()
                .HasForeignKey(s=>s.ProductId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

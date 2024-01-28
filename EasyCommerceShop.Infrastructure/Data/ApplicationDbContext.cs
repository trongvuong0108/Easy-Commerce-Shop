using EasyCommerceShop.Infrastructure.Data.Configuration;
using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyCommerceShop.Infrastructure.Helpers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }
        public DbSet<BranchContactPoint> BranchContactPoints { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandCategoryDetail> BrandCategoryDetails { get; set; }
        public DbSet<CartProductDetail> CartProductDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryLanguageDetail> CountryLanguageDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionCategoryDetail> OptionCategoryDetails { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShopSetting> ShopSettings { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BranchContactPointEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BrandEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BrandCategoryDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CartProductDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryLanguageDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ModelEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OptionCategoryDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OptionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingCartEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ShopSettingEntityConfiguration());
            modelBuilder.ApplyConfiguration(new VoucherEntityConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=mssql; Initial Catalog=EasyCommerceShop; User ID=sa; pwd=Password@1234; MultipleActiveResultSets = True; TrustServerCertificate = True");            
        }
    }
}

using EasyCommerceShop.Infrastructure.Repositories;
using EasyCommerceShop.Persistence.Data;

namespace EasyCommerceShop.Infrastructure.Abstraction
{
    public class UnitOfWork
    {
        private readonly EasyShopDbContext _context;

        public ProductRepository _productRepository { set; get; }

        public UnitOfWork(EasyShopDbContext context) 
        {
            _context = context;
            _productRepository = new ProductRepository(context);
        }

        public async Task SaveChanges ()
        {
            await _context.SaveChangesAsync();
        }
    }
}

using EasyCommerceShop.Domain.Abstraction;
using EasyCommerceShop.Infrastructure.Repositories;
using EasyCommerceShop.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EasyCommerceShop.Infrastructure.Abstraction
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> , IDisposable, IAsyncDisposable
        where TEntity : GenericEntity<TKey>
    {
        private readonly EasyShopDbContext _dbContext;
        public GenericRepository(EasyShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TEntity>> GetAll() => await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        
        public async Task<List<TEntity>> GetByCondition<TResult>(Expression<Func<TEntity, bool>> selector)
            => await _dbContext.Set<TEntity>().AsNoTracking().Where(selector).ToListAsync();

        public async Task Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task SoftDelete(string id)
        {
            throw new NotImplementedException();
        }
        // public async Task SoftDelete(string id)
        // {
        //     GenericEntity? item = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(x=>x.Id == id);
        //     if (item != null)
        //     {
        //         item.IsDeleted = true;
        //     }
        //     await _dbContext.SaveChangesAsync();
        // }

        public async Task Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}

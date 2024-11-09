using EasyCommerceShop.Domain.Abstraction;
using EasyCommerceShop.Infrastructure.Repositories;
using EasyCommerceShop.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EasyCommerceShop.Infrastructure.Abstraction
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey>, IDisposable, IAsyncDisposable
        where TEntity : GenericEntity<TKey>
    {
        private readonly EasyShopDbContext _dbContext;
        public GenericRepository(EasyShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TEntity>> GetAll() => await _dbContext.Set<TEntity>().Where(x=> !x.IsDeleted).AsNoTracking().ToListAsync();

        public async Task<List<TEntity>> GetWithDelete() => await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<List<TEntity>> GetByCondition<TResult>(Expression<Func<TEntity, bool>> selector)
            => await _dbContext.Set<TEntity>().AsNoTracking().Where(selector).ToListAsync();

        public async Task Create(TEntity entity) => await _dbContext.Set<TEntity>().AddAsync(entity);

        public async Task<int> Delete(TKey id) => 
            await _dbContext.Set<TEntity>().Where(x => x.Id.Equals(id)).ExecuteDeleteAsync();

        public async Task<int> SoftDelete(TKey id) =>
            await _dbContext.Set<TEntity>().Where(x => x.Id.Equals(id)).ExecuteUpdateAsync(record => record.SetProperty(y => y.IsDeleted, true));

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

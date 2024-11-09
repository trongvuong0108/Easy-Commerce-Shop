using System.Linq.Expressions;
using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Infrastructure.Repositories;

public interface IGenericRepository<TEntity, TKey> where TEntity : GenericEntity<TKey> 
{
    Task<List<TEntity>> GetAll();
    Task<List<TEntity>> GetWithDelete();
    Task<List<TEntity>> GetByCondition<TResult>(Expression<Func<TEntity, bool>> selector);
    Task Create(TEntity entity);
    Task Update(TEntity entity);
    Task<int> Delete(TKey id);
    Task<int> SoftDelete(TKey id);
}
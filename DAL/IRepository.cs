using Entities;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity> : IDisposable, IAsyncDisposable where TEntity : class, IEntity
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken token = default);
        Task<TEntity> GetAsync(Guid id, CancellationToken token = default);
    }
}
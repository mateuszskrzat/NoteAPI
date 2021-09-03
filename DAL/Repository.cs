using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly IDataContext _context;
        private readonly DbSet<TEntity> _entities;

        public Repository(IDataContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        public async Task<TEntity> GetAsync(Guid id, CancellationToken token = default)
            => await _entities.FirstOrDefaultAsync(entity => entity.Id == id, token);
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken token = default)
            => await _entities.FirstOrDefaultAsync(predicate, token);

    }
}

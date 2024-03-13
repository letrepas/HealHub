using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarLab.Academy.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository <TEntity> where TEntity : class
    {
        protected DbContext DbContext { get; }

        protected DbSet<TEntity> DbSet { get; }

        public Repository(DbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
            
        }
        public Task AddAsync(TEntity model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetFiltered(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));
            return DbSet.Where(predicate);
        }

        public Task UpdateAsync(TEntity model)
        {
            throw new NotImplementedException();
        }
    }
}

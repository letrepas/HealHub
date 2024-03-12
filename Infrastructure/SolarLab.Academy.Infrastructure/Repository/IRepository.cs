using System.Linq.Expressions;

namespace SolarLab.Academy.Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Возращает все элементы сущности <see cref="TEntity"/>
        /// </summary>
        /// <returns>Все элементы сущности <see cref="TEntity"/></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Возращает все элементы сущности <see cref="TEntity"/> по предикату
        /// </summary>
        /// <param name="predicate">Прекдикат</param>
        /// <returns>Все элементы сущности <see cref="TEntity"/> по предикату</returns>
        IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Возращает элемент сущности по идентификатору
        /// </summary>
        /// <param name="id">Индентификатор сущности</param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(Guid id);

        Task AddAsync(TEntity model);

        Task UpdateAsync(TEntity model);

        Task DeleteAsync(Guid id);

    }
}

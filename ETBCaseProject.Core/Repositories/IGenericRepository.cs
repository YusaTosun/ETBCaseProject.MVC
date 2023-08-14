using System.Linq.Expressions;

namespace ETBCaseProject.Core.Repositories
{
    /// <summary>
    /// Farklı varlık (entity) tipleri için temel veritabanı işlemlerini içerir
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T Entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T Entity);
        void Remove(T Entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}

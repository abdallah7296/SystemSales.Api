using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace SystemSales.infrastructure.infrastructure
{
    public interface IGenericRepositoryAsync<T> where T : class
    {
        Task DeleteRangeAsync(ICollection<T> entities);
        Task<T> GetByIdAsync(int id);
        Task SaveChangesAsync();
        IDbContextTransaction BeginTransaction();
        void Commit();
        void RollBack();
        IQueryable<T> GetTableNoTracking();
        IQueryable<T> GetTableAsTracking();
        IQueryable<T> Search(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetListAsync();

        Task<T> AddWithCodeAsync<TId>(T entity, string prefix, Func<T, string> codePropertySelector);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
        Task<string> GenerateCodeAsync<TEntity>(string prefix) where TEntity : class;
        Task<T> AddAsync(T entity);

    }

}

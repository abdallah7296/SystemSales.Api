using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;
using SystemSales.infrastructure.Context;

namespace SystemSales.infrastructure.infrastructure
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        #region Vars / Props

        protected readonly ApplicationDbContext _dbContext;

        #endregion

        #region Constructor(s)
        public GenericRepositoryAsync(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion


        #region Methods

        #endregion

        #region Actions
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public IQueryable<T> GetTableNoTracking()
        {
            return _dbContext.Set<T>().AsNoTracking().AsQueryable();
        }

        public virtual async Task AddRangeAsync(ICollection<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();

        }
        public async Task<string> GenerateCodeAsync<TEntity>(string prefix) where TEntity : class
        {
            var count = await _dbContext.Set<TEntity>().CountAsync() + 1;
            return $"{prefix.ToUpper()}{count:D5}";
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<T> AddWithCodeAsync<TId>(T entity, string prefix, Func<T, string> codePropertySelector)
        {
            var count = await _dbContext.Set<T>().CountAsync() + 1;
            var codePropertyName = codePropertySelector(entity); // Get the name of the code property
            var codeProperty = typeof(T).GetProperty(codePropertyName);
            if (codeProperty != null && codeProperty.PropertyType == typeof(string))
            {
                codeProperty.SetValue(entity, $"{prefix.ToUpper()}{count:D5}");
            }
            else
            {
                throw new ArgumentException($"Property '{codePropertyName}' is not of type 'string' or does not exist in entity '{typeof(T).Name}'.");
            }

            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }


        public virtual async Task UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();

        }

        public virtual async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        public virtual async Task DeleteRangeAsync(ICollection<T> entities)
        {
            foreach (var entity in entities)
            {
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }



        public IDbContextTransaction BeginTransaction()
        {


            return _dbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _dbContext.Database.CommitTransaction();

        }

        public void RollBack()
        {
            _dbContext.Database.RollbackTransaction();

        }

        public IQueryable<T> GetTableAsTracking()
        {
            return _dbContext.Set<T>().AsQueryable();

        }

        public virtual async Task UpdateRangeAsync(ICollection<T> entities)
        {
            _dbContext.Set<T>().UpdateRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().AsNoTracking().Where(predicate);
        }
        #endregion
    }

}

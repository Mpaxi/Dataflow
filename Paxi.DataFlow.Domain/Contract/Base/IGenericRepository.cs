using Paxi.DataFlow.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Paxi.DataFlow.Domain.Contract.Base
{
    public interface IGenericRepository<T> where T : EntityBase
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, bool NoLock = true, params Expression<Func<T, object>>[] includeProperties);
        Task<IQueryable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate, bool NoLock = true, params Expression<Func<T, object>>[] includeProperties);
        Task<bool> AddAsync(T Entity, bool SaveChanges = false);
        Task<bool> AddRangeAsync(IEnumerable<T> Entity, bool SaveChanges = false);
        Task<bool> UpdateRangAsync(IEnumerable<T> Entity, bool SaveChanges = false);
        Task<bool> UpdateAsync(T Entity, bool SaveChanges = false);
        Task<bool> DeleteAsync(T Entity, bool SaveChanges = false);
        Task<bool> DeleteRangeAsync(IEnumerable<T> Entity, bool SaveChanges = false);
        Task<int> SaveChangesAsync();

    }
}

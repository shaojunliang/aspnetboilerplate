#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

#endregion

namespace Abp.Domain.Repositories
{
    public partial interface IRepository<TEntity, TPrimaryKey>
    {
        IQueryable<TEntity> GetAllIncluding(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] propertySelectors);

        List<TEntity> GetAllListIncluding(params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<List<TEntity>> GetAllListIncludingAsync(params Expression<Func<TEntity, object>>[] propertySelectors);

        List<TEntity> GetAllListIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<List<TEntity>> GetAllListIncludingAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        TEntity GetIncluding(TPrimaryKey id, params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<TEntity> GetIncludingAsync(TPrimaryKey id, params Expression<Func<TEntity, object>>[] propertySelectors);

        TEntity SingleIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<TEntity> SingleIncludingAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        TEntity FirstOrDefaultIncluding(TPrimaryKey id, params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<TEntity> FirstOrDefaultIncludingAsync(TPrimaryKey id,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        TEntity FirstOrDefaultIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        Task<TEntity> FirstOrDefaultIncludingAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);
    }
}
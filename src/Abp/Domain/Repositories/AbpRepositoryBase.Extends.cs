#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abp.Collections.Extensions;
using Abp.Domain.Entities;

#endregion

namespace Abp.Domain.Repositories
{
    public abstract partial class AbpRepositoryBase<TEntity, TPrimaryKey>
    {
        public abstract IQueryable<TEntity> GetAllIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        public virtual List<TEntity> GetAllListIncluding(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            if (propertySelectors.IsNullOrEmpty())
            {
                return GetAllList();
            }

            return GetAllIncluding(propertySelectors).ToList();
        }

        public virtual Task<List<TEntity>> GetAllListIncludingAsync(
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return Task.FromResult(GetAllListIncluding(propertySelectors));
        }

        public virtual List<TEntity> GetAllListIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            if (propertySelectors.IsNullOrEmpty())
            {
                return GetAllList(predicate);
            }

            return GetAllIncluding(predicate, propertySelectors).ToList();
        }

        public virtual Task<List<TEntity>> GetAllListIncludingAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return Task.FromResult(GetAllListIncluding(predicate, propertySelectors));
        }

        public virtual TEntity GetIncluding(TPrimaryKey id,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            var entity = FirstOrDefaultIncluding(id, propertySelectors);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity), id);
            }

            return entity;
        }

        public virtual Task<TEntity> GetIncludingAsync(TPrimaryKey id,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return Task.FromResult(GetIncluding(id, propertySelectors));
        }

        public abstract TEntity SingleIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        public virtual Task<TEntity> SingleIncludingAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return Task.FromResult(SingleIncluding(predicate, propertySelectors));
        }

        public virtual TEntity FirstOrDefaultIncluding(TPrimaryKey id,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return FirstOrDefaultIncluding(CreateEqualityExpressionForId(id), propertySelectors);
        }

        public virtual Task<TEntity> FirstOrDefaultIncludingAsync(TPrimaryKey id,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return Task.FromResult(FirstOrDefaultIncluding(id, propertySelectors));
        }

        public abstract TEntity FirstOrDefaultIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors);

        public virtual Task<TEntity> FirstOrDefaultIncludingAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return Task.FromResult(FirstOrDefaultIncluding(predicate, propertySelectors));
        }
    }
}
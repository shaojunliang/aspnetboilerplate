#region

using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Abp.Collections.Extensions;

#endregion

namespace Abp.EntityFramework.Repositories
{
    public partial class EfRepositoryBase<TDbContext, TEntity, TPrimaryKey>
    {
        public override IQueryable<TEntity> GetAllIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            if (propertySelectors.IsNullOrEmpty())
            {
                return GetAll().Where(predicate);
            }

            var query = GetAll().Where(predicate);

            foreach (var propertySelector in propertySelectors)
            {
                query = query.Include(propertySelector);
            }

            return query;
        }

        public override TEntity SingleIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return GetAllIncluding(predicate, propertySelectors).Single();
        }

        public override TEntity FirstOrDefaultIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return GetAllIncluding(predicate, propertySelectors).FirstOrDefault();
        }
    }
}
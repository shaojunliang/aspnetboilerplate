#region

using System;
using System.Linq;
using System.Linq.Expressions;
using Abp.Collections.Extensions;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Abp.EntityFrameworkCore.Repositories
{
    public partial class EfCoreRepositoryBase<TDbContext, TEntity, TPrimaryKey>
    {
        public override IQueryable<TEntity> GetAllIncluding(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            var query = Table.AsQueryable().Where(predicate);

            if (!propertySelectors.IsNullOrEmpty())
            {
                foreach (var propertySelector in propertySelectors)
                {
                    query = query.Include(propertySelector);
                }
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
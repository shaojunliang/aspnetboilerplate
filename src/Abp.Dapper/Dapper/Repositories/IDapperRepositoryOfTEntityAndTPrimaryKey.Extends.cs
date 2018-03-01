#region

using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using JetBrains.Annotations;

#endregion

namespace Abp.Dapper.Repositories
{
    public partial interface IDapperRepository<TEntity, TPrimaryKey> // where TEntity : class, IEntity<TPrimaryKey>
    {
        #region Execute

        int ExecuteProcedure([NotNull] string query, [CanBeNull] object parameters = null);

        Task<int> ExecuteProcedureAsync([NotNull] string query, [CanBeNull] object parameters = null);

        /*int Execute(CommandDefinition command);
        
        Task<int> ExecuteAsync(CommandDefinition command);*/

        #endregion

        #region ExecuteScalar
            
        object ExecuteScalar([NotNull] string query, [CanBeNull] object parameters = null);

        Task<object> ExecuteScalarAsync([NotNull] string query, [CanBeNull] object parameters = null);

        object ExecuteScalarProcedure([NotNull] string query, [CanBeNull] object parameters = null);

        Task<object> ExecuteScalarProcedureAsync([NotNull] string query, [CanBeNull] object parameters = null);

        /*object ExecuteScalar(CommandDefinition command);

        Task<object> ExecuteScalarAsync(CommandDefinition command);*/

        #endregion

        #region ExecuteScalar<T>

        T ExecuteScalar<T>([NotNull] string query, [CanBeNull] object parameters = null);

        Task<T> ExecuteScalarAsync<T>([NotNull] string query, [CanBeNull] object parameters = null);

        T ExecuteScalarProcedure<T>([NotNull] string query, [CanBeNull] object parameters = null);

        Task<T> ExecuteScalarProcedureAsync<T>([NotNull] string query, [CanBeNull] object parameters = null);

        /*T ExecuteScalar<T>(CommandDefinition command);

        Task<T> ExecuteScalarAsync<T>(CommandDefinition command);*/

        #endregion

        #region Query

        [NotNull]
        IEnumerable<TEntity> QueryProcedure([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<IEnumerable<TEntity>> QueryProcedureAsync([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        IEnumerable<TAny> QueryProcedure<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<IEnumerable<TAny>> QueryProcedureAsync<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        #endregion

        #region QueryFirst

        [NotNull]
        TEntity QueryFirst([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QueryFirstAsync([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        TAny QueryFirst<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QueryFirstAsync<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        TEntity QueryFirstProcedure([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QueryFirstProcedureAsync([NotNull] string query,
            [CanBeNull] object parameters = null);

        [NotNull]
        TAny QueryFirstProcedure<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QueryFirstProcedureAsync<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null) where TAny : class;

        #endregion

        #region QueryFirstOrDefault

        [NotNull]
        TEntity QueryFirstOrDefault([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QueryFirstOrDefaultAsync([NotNull] string query,
            [CanBeNull] object parameters = null);

        [NotNull]
        TAny QueryFirstOrDefault<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QueryFirstOrDefaultAsync<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        TEntity QueryFirstOrDefaultProcedure([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QueryFirstOrDefaultProcedureAsync([NotNull] string query,
            [CanBeNull] object parameters = null);

        [NotNull]
        TAny QueryFirstOrDefaultProcedure<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QueryFirstOrDefaultProcedureAsync<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null) where TAny : class;

        #endregion

        #region QuerySingle

        [NotNull]
        TEntity QuerySingle([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QuerySingleAsync([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        TAny QuerySingle<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QuerySingleAsync<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        TEntity QuerySingleProcedure([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QuerySingleProcedureAsync([NotNull] string query,
            [CanBeNull] object parameters = null);

        [NotNull]
        TAny QuerySingleProcedure<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QuerySingleProcedureAsync<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null) where TAny : class;

        #endregion

        #region QuerySingleOrDefault

        [NotNull]
        TEntity QuerySingleOrDefault([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QuerySingleOrDefaultAsync([NotNull] string query,
            [CanBeNull] object parameters = null);

        [NotNull]
        TAny QuerySingleOrDefault<TAny>([NotNull] string query, [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QuerySingleOrDefaultAsync<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        TEntity
            QuerySingleOrDefaultProcedure([NotNull] string query, [CanBeNull] object parameters = null);

        [NotNull]
        Task<TEntity> QuerySingleOrDefaultProcedureAsync([NotNull] string query,
            [CanBeNull] object parameters = null);

        [NotNull]
        TAny QuerySingleOrDefaultProcedure<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null)
            where TAny : class;

        [NotNull]
        Task<TAny> QuerySingleOrDefaultProcedureAsync<TAny>([NotNull] string query,
            [CanBeNull] object parameters = null) where TAny : class;

        #endregion
    }
}
#region

using System.Collections.Generic;
using System.Threading.Tasks;

#endregion

namespace Abp.Dapper.Repositories
{
    public abstract partial class AbpDapperRepositoryBase<TEntity, TPrimaryKey>
    {
        #region Execute

        public abstract int ExecuteProcedure(string query, object parameters = null);

        public virtual Task<int> ExecuteProcedureAsync(string query, object parameters = null)
        {
            return Task.FromResult(ExecuteProcedure(query, parameters));
        }

        /*public abstract int Execute(CommandDefinition command);

        /// <returns></returns>
        public virtual Task<int> ExecuteAsync(CommandDefinition command)
        {
            return Task.FromResult(Execute(command));
        }*/

        #endregion

        #region ExecuteScalar

        public abstract object ExecuteScalar(string query, object parameters = null);

        public virtual Task<object> ExecuteScalarAsync(string query, object parameters = null)
        {
            return Task.FromResult(ExecuteScalar(query, parameters));
        }

        public abstract object ExecuteScalarProcedure(string query, object parameters = null);

        public virtual Task<object> ExecuteScalarProcedureAsync(string query, object parameters = null)
        {
            return Task.FromResult(ExecuteScalarProcedure(query, parameters));
        }

        /*public abstract object ExecuteScalar(CommandDefinition command);

        public virtual Task<object> ExecuteScalarAsync(CommandDefinition command)
        {
            return Task.FromResult(ExecuteScalar(command));
        }*/

        #endregion

        #region ExecuteScalar<T>

        public abstract T ExecuteScalar<T>(string query, object parameters = null);

        public virtual Task<T> ExecuteScalarAsync<T>(string query, object parameters = null)
        {
            return Task.FromResult(ExecuteScalar<T>(query, parameters));
        }

        public abstract T ExecuteScalarProcedure<T>(string query, object parameters = null);

        public virtual Task<T> ExecuteScalarProcedureAsync<T>(string query, object parameters = null)
        {
            return Task.FromResult(ExecuteScalarProcedure<T>(query, parameters));
        }

        /*public abstract T ExecuteScalar<T>(CommandDefinition command);

        public virtual Task<T> ExecuteScalarAsync<T>(CommandDefinition command)
        {
            return Task.FromResult(ExecuteScalar<T>(command));
        }*/

        #endregion

        #region Query

        public abstract IEnumerable<TEntity> QueryProcedure(string query, object parameters = null);

        public virtual Task<IEnumerable<TEntity>> QueryProcedureAsync(string query, object parameters = null)
        {
            return Task.FromResult(QueryProcedure(query, parameters));
        }

        public abstract IEnumerable<TAny> QueryProcedure<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<IEnumerable<TAny>> QueryProcedureAsync<TAny>(string query, object parameters = null)
            where TAny : class
        {
            return Task.FromResult(QueryProcedure<TAny>(query, parameters));
        }

        #endregion

        #region QueryFirst

        public abstract TEntity QueryFirst(string query, object parameters = null);

        public virtual Task<TEntity> QueryFirstAsync(string query, object parameters = null)
        {
            return Task.FromResult(QueryFirst(query, parameters));
        }

        public abstract TAny QueryFirst<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QueryFirstAsync<TAny>(string query, object parameters = null)
            where TAny : class
        {
            return Task.FromResult(QueryFirst<TAny>(query, parameters));
        }

        public abstract TEntity QueryFirstProcedure(string query, object parameters = null);

        public virtual Task<TEntity> QueryFirstProcedureAsync(string query,
            object parameters = null)
        {
            return Task.FromResult(QueryFirstProcedure(query, parameters));
        }

        public abstract TAny QueryFirstProcedure<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QueryFirstProcedureAsync<TAny>(string query,
            object parameters = null) where TAny : class
        {
            return Task.FromResult(QueryFirstProcedure<TAny>(query, parameters));
        }

        #endregion

        #region QueryFirstOrDefault

        public abstract TEntity QueryFirstOrDefault(string query, object parameters = null);

        public virtual Task<TEntity> QueryFirstOrDefaultAsync(string query, object parameters = null)
        {
            return Task.FromResult(QueryFirstOrDefault(query, parameters));
        }

        public abstract TAny QueryFirstOrDefault<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QueryFirstOrDefaultAsync<TAny>(string query, object parameters = null)
            where TAny : class
        {
            return Task.FromResult(QueryFirstOrDefault<TAny>(query, parameters));
        }

        public abstract TEntity QueryFirstOrDefaultProcedure(string query, object parameters = null);

        public virtual Task<TEntity> QueryFirstOrDefaultProcedureAsync(string query,
            object parameters = null)
        {
            return Task.FromResult(QueryFirstOrDefaultProcedure(query, parameters));
        }

        public abstract TAny QueryFirstOrDefaultProcedure<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QueryFirstOrDefaultProcedureAsync<TAny>(string query,
            object parameters = null) where TAny : class
        {
            return Task.FromResult(QueryFirstOrDefaultProcedure<TAny>(query, parameters));
        }

        #endregion

        #region QuerySingle

        public abstract TEntity QuerySingle(string query, object parameters = null);

        public virtual Task<TEntity> QuerySingleAsync(string query, object parameters = null)
        {
            return Task.FromResult(QuerySingle(query, parameters));
        }

        public abstract TAny QuerySingle<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QuerySingleAsync<TAny>(string query, object parameters = null)
            where TAny : class
        {
            return Task.FromResult(QuerySingle<TAny>(query, parameters));
        }

        public abstract TEntity QuerySingleProcedure(string query, object parameters = null);

        public virtual Task<TEntity> QuerySingleProcedureAsync(string query,
            object parameters = null)
        {
            return Task.FromResult(QuerySingleProcedure(query, parameters));
        }

        public abstract TAny QuerySingleProcedure<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QuerySingleProcedureAsync<TAny>(string query,
            object parameters = null) where TAny : class
        {
            return Task.FromResult(QuerySingleProcedure<TAny>(query, parameters));
        }

        #endregion

        #region QuerySingleOrDefault

        public abstract TEntity QuerySingleOrDefault(string query, object parameters = null);

        public virtual Task<TEntity> QuerySingleOrDefaultAsync(string query, object parameters = null)
        {
            return Task.FromResult(QuerySingleOrDefault(query, parameters));
        }

        public abstract TAny QuerySingleOrDefault<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QuerySingleOrDefaultAsync<TAny>(string query, object parameters = null)
            where TAny : class
        {
            return Task.FromResult(QuerySingleOrDefault<TAny>(query, parameters));
        }

        public abstract TEntity QuerySingleOrDefaultProcedure(string query, object parameters = null);

        public virtual Task<TEntity> QuerySingleOrDefaultProcedureAsync(string query,
            object parameters = null)
        {
            return Task.FromResult(QuerySingleOrDefaultProcedure(query, parameters));
        }

        public abstract TAny QuerySingleOrDefaultProcedure<TAny>(string query, object parameters = null)
            where TAny : class;

        public virtual Task<TAny> QuerySingleOrDefaultProcedureAsync<TAny>(string query,
            object parameters = null) where TAny : class
        {
            return Task.FromResult(QuerySingleOrDefaultProcedure<TAny>(query, parameters));
        }

        #endregion
    }
}
#region

using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

#endregion

namespace Abp.Dapper.Repositories
{
    public partial class DapperRepositoryBase<TEntity, TPrimaryKey>
    {
        #region Execute

        public override int ExecuteProcedure(string query, object parameters = null)
        {
            return Connection.Execute(query, parameters, ActiveTransaction, commandType: CommandType.StoredProcedure);
        }

        public override Task<int> ExecuteProcedureAsync(string query, object parameters = null)
        {
            return Connection.ExecuteAsync(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region ExecuteScalar

        public override object ExecuteScalar(string query, object parameters = null)
        {
            return Connection.ExecuteScalar(query, parameters, ActiveTransaction);
        }

        public override Task<object> ExecuteScalarAsync(string query, object parameters = null)
        {
            return Connection.ExecuteScalarAsync(query, parameters, ActiveTransaction);
        }

        public override object ExecuteScalarProcedure(string query, object parameters = null)
        {
            return Connection.ExecuteScalar(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<object> ExecuteScalarProcedureAsync(string query, object parameters = null)
        {
            return Connection.ExecuteScalarAsync(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region ExecuteScalar<T>

        public override T ExecuteScalar<T>(string query, object parameters = null)
        {
            return Connection.ExecuteScalar<T>(query, parameters, ActiveTransaction);
        }

        public override Task<T> ExecuteScalarAsync<T>(string query, object parameters = null)
        {
            return Connection.ExecuteScalarAsync<T>(query, parameters, ActiveTransaction);
        }

        public override T ExecuteScalarProcedure<T>(string query, object parameters = null)
        {
            return Connection.ExecuteScalar<T>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<T> ExecuteScalarProcedureAsync<T>(string query, object parameters = null)
        {
            return Connection.ExecuteScalarAsync<T>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region Query

        public override IEnumerable<TEntity> QueryProcedure(string query, object parameters = null)
        {
            return Connection.Query<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<IEnumerable<TEntity>> QueryProcedureAsync(string query, object parameters = null)
        {
            return Connection.QueryAsync<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override IEnumerable<TAny> QueryProcedure<TAny>(string query, object parameters = null)
        {
            return Connection.Query<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<IEnumerable<TAny>> QueryProcedureAsync<TAny>(string query, object parameters = null)
        {
            return Connection.QueryAsync<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region QueryFirst

        public override TEntity QueryFirst(string query, object parameters = null)
        {
            return Connection.QueryFirst<TEntity>(query, parameters, ActiveTransaction);
        }

        public override Task<TEntity> QueryFirstAsync(string query, object parameters = null)
        {
            return Connection.QueryFirstAsync<TEntity>(query, parameters, ActiveTransaction);
        }

        public override TAny QueryFirst<TAny>(string query, object parameters = null)
        {
            return Connection.QueryFirst<TAny>(query, parameters, ActiveTransaction);
        }

        public override Task<TAny> QueryFirstAsync<TAny>(string query, object parameters = null)
        {
            return Connection.QueryFirstAsync<TAny>(query, parameters, ActiveTransaction);
        }

        public override TEntity QueryFirstProcedure(string query, object parameters = null)
        {
            return Connection.QueryFirst<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TEntity> QueryFirstProcedureAsync(string query,
            object parameters = null)
        {
            return Connection.QueryFirstAsync<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override TAny QueryFirstProcedure<TAny>(string query, object parameters = null)
        {
            return Connection.QueryFirst<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TAny> QueryFirstProcedureAsync<TAny>(string query,
            object parameters = null)
        {
            return Connection.QueryFirstAsync<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region QueryFirstOrDefault

        public override TEntity QueryFirstOrDefault(string query, object parameters = null)
        {
            return Connection.QueryFirstOrDefault<TEntity>(query, parameters, ActiveTransaction);
        }

        public override Task<TEntity> QueryFirstOrDefaultAsync(string query, object parameters = null)
        {
            return Connection.QueryFirstOrDefaultAsync<TEntity>(query, parameters, ActiveTransaction);
        }

        public override TAny QueryFirstOrDefault<TAny>(string query, object parameters = null)
        {
            return Connection.QueryFirstOrDefault<TAny>(query, parameters, ActiveTransaction);
        }

        public override Task<TAny> QueryFirstOrDefaultAsync<TAny>(string query, object parameters = null)
        {
            return Connection.QueryFirstOrDefaultAsync<TAny>(query, parameters, ActiveTransaction);
        }

        public override TEntity QueryFirstOrDefaultProcedure(string query, object parameters = null)
        {
            return Connection.QueryFirstOrDefault<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TEntity> QueryFirstOrDefaultProcedureAsync(string query,
            object parameters = null)
        {
            return Connection.QueryFirstOrDefaultAsync<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override TAny QueryFirstOrDefaultProcedure<TAny>(string query, object parameters = null)
        {
            return Connection.QueryFirstOrDefault<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TAny> QueryFirstOrDefaultProcedureAsync<TAny>(string query,
            object parameters = null)
        {
            return Connection.QueryFirstOrDefaultAsync<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region QuerySingle

        public override TEntity QuerySingle(string query, object parameters = null)
        {
            return Connection.QuerySingle<TEntity>(query, parameters, ActiveTransaction);
        }

        public override Task<TEntity> QuerySingleAsync(string query, object parameters = null)
        {
            return Connection.QuerySingleAsync<TEntity>(query, parameters, ActiveTransaction);
        }

        public override TAny QuerySingle<TAny>(string query, object parameters = null)
        {
            return Connection.QuerySingle<TAny>(query, parameters, ActiveTransaction);
        }

        public override Task<TAny> QuerySingleAsync<TAny>(string query, object parameters = null)
        {
            return Connection.QuerySingleAsync<TAny>(query, parameters, ActiveTransaction);
        }

        public override TEntity QuerySingleProcedure(string query, object parameters = null)
        {
            return Connection.QuerySingle<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TEntity> QuerySingleProcedureAsync(string query,
            object parameters = null)
        {
            return Connection.QuerySingleAsync<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override TAny QuerySingleProcedure<TAny>(string query, object parameters = null)
        {
            return Connection.QuerySingle<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TAny> QuerySingleProcedureAsync<TAny>(string query,
            object parameters = null)
        {
            return Connection.QuerySingleAsync<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion

        #region QuerySingleOrDefault

        public override TEntity QuerySingleOrDefault(string query, object parameters = null)
        {
            return Connection.QuerySingleOrDefault<TEntity>(query, parameters, ActiveTransaction);
        }

        public override Task<TEntity> QuerySingleOrDefaultAsync(string query, object parameters = null)
        {
            return Connection.QuerySingleOrDefaultAsync<TEntity>(query, parameters, ActiveTransaction);
        }

        public override TAny QuerySingleOrDefault<TAny>(string query, object parameters = null)
        {
            return Connection.QuerySingleOrDefault<TAny>(query, parameters, ActiveTransaction);
        }

        public override Task<TAny> QuerySingleOrDefaultAsync<TAny>(string query, object parameters = null)
        {
            return Connection.QuerySingleOrDefaultAsync<TAny>(query, parameters, ActiveTransaction);
        }

        public override TEntity QuerySingleOrDefaultProcedure(string query, object parameters = null)
        {
            return Connection.QuerySingleOrDefault<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TEntity> QuerySingleOrDefaultProcedureAsync(string query,
            object parameters = null)
        {
            return Connection.QuerySingleOrDefaultAsync<TEntity>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override TAny QuerySingleOrDefaultProcedure<TAny>(string query, object parameters = null)
        {
            return Connection.QuerySingleOrDefault<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        public override Task<TAny> QuerySingleOrDefaultProcedureAsync<TAny>(string query,
            object parameters = null)
        {
            return Connection.QuerySingleOrDefaultAsync<TAny>(query, parameters, ActiveTransaction,
                commandType: CommandType.StoredProcedure);
        }

        #endregion
    }
}
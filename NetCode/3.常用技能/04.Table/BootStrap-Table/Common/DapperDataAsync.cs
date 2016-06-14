using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BootStrap_Table
{
    /// <summary>
    /// dunitian
    /// </summary>
    public abstract partial class DapperDataAsync
    {
        private static readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnStr"].ConnectionString;

        #region 动态参数
        /// <summary>
        /// 动态参数
        /// </summary>
        public static DynamicParameters GetDynamicParameters()
        {
            return new DynamicParameters();
        }
        #endregion

        #region 查询系列
        /// <summary>
        /// 单个值返回值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<T> ExecuteScalarAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();
                return await conn.ExecuteScalarAsync<T>(sql, param, transaction, commandTimeout, commandType);
            }
        }
        /// <summary>
        /// 强类型查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="buffered"></param>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();
                return await conn.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);
            }
        }

        /// <summary>
        /// 动态类型查询 | 多映射动态查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="buffered"></param>
        /// <returns></returns>
        public static async Task<IEnumerable<dynamic>> QueryAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();
                return await conn.QueryAsync(sql, param, transaction, commandTimeout, commandType);
            }
        }

        #region 多返回值
        ///// <summary>
        ///// 多返回值
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <param name="param"></param>
        ///// <param name="transaction"></param>
        ///// <param name="commandTimeout"></param>
        ///// <param name="commandType"></param>
        ///// <returns></returns>
        //public static async Task<SqlMapper.GridReader> QueryMultipleAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        //{
        //    SqlConnection conn = new SqlConnection(connStr);
        //    await conn.OpenAsync();
        //    return await conn.QueryMultipleAsync(sql, param, transaction, commandTimeout, commandType);
        //} 
        #endregion
        #endregion

        #region 增删改系
        /// <summary>
        /// 增删改系
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();
                return await conn.ExecuteAsync(sql, param, transaction, commandTimeout, commandType);
            }
        }
        #endregion
    }
}
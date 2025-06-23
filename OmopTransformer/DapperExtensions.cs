using Dapper;
using System.Data;

namespace OmopTransformer;

public static class DapperExtensions
{
    public static Task<int> ExecuteLongTimeoutAsync(
        this IDbConnection cnn, 
        string sql, 
        object? param = null, 
        IDbTransaction? transaction = null, 
        CommandType? commandType = null)
    {
        const int fourHoursInSeconds = 4 * 60 * 60;

        return
             cnn.ExecuteAsync(
                 sql: sql,
                 param: param,
                 transaction: transaction,
                 commandType: commandType,
                 commandTimeout: fourHoursInSeconds);
    }
}
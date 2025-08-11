using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace OmopTransformer;

public static class DapperExtensions
{
    private const int FourHoursInSeconds = 4 * 60 * 60;

    public static async Task<int> ExecuteLongTimeoutAsync(
        this RetryConnection cnn, 
        string sql, 
        object? param = null, 
        IDbTransaction? transaction = null, 
        CommandType? commandType = null)
    {
        return await ExecuteQueryWithRetry(
            async () =>
            {
                using var c = cnn.Open();

                return
                    await c.ExecuteAsync(
                        sql: sql,
                        param: param,
                        transaction: transaction,
                        commandType: commandType,
                        commandTimeout: FourHoursInSeconds);
            });

    }

    public static async Task<IEnumerable<T>> QueryLongTimeoutAsync<T>(
        this RetryConnection connection,
        string commandText,
        CancellationToken cancellationToken)
    {
        return await ExecuteQueryWithRetry(
            async () =>
            {
                using var c = connection.Open();

                return
                    await c.QueryAsync<T>(
                        new CommandDefinition(
                            commandText: commandText,
                            commandTimeout: FourHoursInSeconds,
                            cancellationToken: cancellationToken));
            });
    }

    private static async Task<T> ExecuteQueryWithRetry<T>(Func<Task<T>> connectAndQueryDelegate)
    {
        // Code taken from https://learn.microsoft.com/en-us/sql/connect/ado-net/step-4-connect-resiliently-sql-ado-net?view=sql-server-ver17

        const int totalNumberOfTimesToTry = 4;
        int retryIntervalSeconds = 10;

        List<int> TransientErrorNumbers = new()
        {
            4060, 40197, 40501, 40613, 49918, 49919, 49920, 11001
        };

        Exception? lastException = null;
        for (int tries = 1; tries <= totalNumberOfTimesToTry; tries++)
        {
            try
            {
                if (tries > 1)
                {
                    Console.WriteLine(
                        "Transient error encountered. Will begin attempt number {0} of {1} max...",
                        tries,
                        totalNumberOfTimesToTry
                    );
                    Thread.Sleep(1000 * retryIntervalSeconds);
                    retryIntervalSeconds = Convert.ToInt32(retryIntervalSeconds * 1.5);
                }
                
                return await connectAndQueryDelegate();
            }
            catch (SqlException sqlExc)
            {
                lastException = sqlExc;

                if (TransientErrorNumbers.Contains(sqlExc.Number))
                {
                    Console.WriteLine("{0}: transient occurred.", sqlExc.Number);
                    continue;
                }

                Console.WriteLine(sqlExc);
                break;
            }
        }

        
        throw lastException!;
        
    }
}
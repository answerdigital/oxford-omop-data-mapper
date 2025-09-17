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
        const int totalNumberOfTimesToTry = 4;
        int retryIntervalSeconds = 10;

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
            catch (SqlException exception)
            {
                Console.WriteLine("{0}: transient error occurred.", exception.Number);

                await Console.Error.WriteLineAsync(exception.ToString());
            }
            catch (Exception exception)
            {
                await Console.Error.WriteLineAsync($"Fatal error during query execution. {exception}.");

                throw;
            }
        }

        throw lastException!;
    }
}
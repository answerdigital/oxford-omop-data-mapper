using System.Data;
using DuckDB.NET.Data;
using Microsoft.Data.SqlClient;

namespace OmopTransformer;

public class RetryConnection
{
    private readonly Func<IDbConnection> _createConnection;

    private RetryConnection(Func<IDbConnection> createConnection)
    {
        _createConnection = createConnection;
    }

    public static RetryConnection CreateSqlServer(string connectionString)
    {
        return new RetryConnection(() => new SqlConnection(connectionString));
    }

    public static RetryConnection CreateDuckDbInMemory()
    {
        return new RetryConnection(() => new DuckDBConnection("Data Source=:memory:"));
    }

    public IDbConnection Open()
    {
        _createConnection().Open();

        return _createConnection();
    }
}
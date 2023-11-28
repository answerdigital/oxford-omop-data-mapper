using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.COSD;

internal class CosdStagingSchema : ICosdStagingSchema
{
    private readonly Configuration _configuration;
    private readonly ILogger<CosdStagingSchema> _logger;

    public CosdStagingSchema(IOptions<Configuration>  configuration, ILogger<CosdStagingSchema> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task CreateStagingTablesIfTheyDoNotExist(CancellationToken cancellationToken)
    {
        if (!await StagingTablesExist(cancellationToken))
        {
            await CreateTables(cancellationToken);
        }
    }

    public async Task DropStagingTables(CancellationToken cancellationToken)
    {
        var connection = new SqlConnection(_configuration.StagingConnectionString);

        await connection.OpenAsync(cancellationToken);

        if (await StagingTablesExist(cancellationToken))
        {
            _logger.LogInformation("Dropping staging tables.");
            await connection.ExecuteAsync("drop table cosd_staging");
        }
        else
        {
            _logger.LogInformation("Staging tables did not exist. No changes made.");
        }
    }

    private async Task<bool> StagingTablesExist(CancellationToken cancellationToken)
    {
        var connection = new SqlConnection(_configuration.StagingConnectionString);

        await connection.OpenAsync(cancellationToken);

        var tableId = await connection.QuerySingleAsync<int?>("select object_id ('cosd_staging')");

        return tableId.HasValue;
    }

    private async Task CreateTables(CancellationToken cancellationToken)
    {
        var connection = new SqlConnection(_configuration.StagingConnectionString);

        await connection.OpenAsync(cancellationToken);

        _logger.LogInformation("Creating staging tables.");

        string table =
            "create table cosd_staging                                                                      " +
            "(                                                                                              " +
            "    SubmissionName varchar(200) not null,                                                      " +
            "	FileName varchar(200) not null,                                                             " +
            "	Content xml not null,                                                                       " +
            "	constraint PK_cosd_staging_SubmissionName_FileName primary key(SubmissionName, FileName)    " +
            ");";

        await connection.ExecuteAsync(table);
    }
}
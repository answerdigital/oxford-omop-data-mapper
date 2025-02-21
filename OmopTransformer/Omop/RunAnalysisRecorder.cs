using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace OmopTransformer.Omop;

internal class RunAnalysisRecorder : IRunAnalysisRecorder
{
    private readonly Configuration _configuration;

    public RunAnalysisRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertRunAnalysis(Guid runId, string tableType, string origin, int validCount, int invalidCount, CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        await 
            connection
                .ExecuteLongTimeoutAsync(
                    "dbo.insert_RunAnalysis", 
                    new
                    {
                        RunId = runId,
                        TableType = tableType,
                        Origin = origin,
                        ValidCount = validCount,
                        InvalidCount = invalidCount
                    }, commandType: CommandType.StoredProcedure);
    }
}
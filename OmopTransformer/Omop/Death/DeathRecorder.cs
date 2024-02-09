using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Death;

internal class DeathRecorder : IDeathRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<DeathRecorder> _logger;

    public DeathRecorder(IOptions<Configuration> configuration, ILogger<DeathRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateDeaths<T>(IReadOnlyCollection<OmopDeath<T>> deaths, string dataSource, CancellationToken cancellationToken)
    {
        if (deaths == null) throw new ArgumentNullException(nameof(deaths));

        _logger.LogInformation("Recording {0} Deaths.", deaths.Count);

        var stopwatch = Stopwatch.StartNew();

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = deaths.Batch(1000);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("death_date", typeof(DateTime));
            dataTable.Columns.Add("death_datetime", typeof(DateTime));
            dataTable.Columns.Add("death_type_concept_id");
            dataTable.Columns.Add("cause_concept_id");
            dataTable.Columns.Add("cause_source_value");
            dataTable.Columns.Add("cause_source_concept_id");

            foreach (var record in batch)
            {
                dataTable.Rows.Add(
                    record.NhsNumber,
                    record.death_date,
                    record.death_datetime,
                    record.death_type_concept_id,
                    record.cause_concept_id,
                    record.cause_source_value,
                    record.cause_source_concept_id);
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("cdm.death_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_death", parameter, commandType: CommandType.StoredProcedure);
        }

        stopwatch.Stop();

        _logger.LogTrace("Inserting Deaths took {0}ms.", stopwatch.ElapsedMilliseconds);

    }
}
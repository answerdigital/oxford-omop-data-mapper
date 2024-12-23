using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Provider;

internal class ProviderRecorder : IProviderRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<ProviderRecorder> _logger;

    public ProviderRecorder(IOptions<Configuration> configuration, ILogger<ProviderRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateProvider<T>(IReadOnlyCollection<OmopProvider<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        _logger.LogInformation("Recording {0} providers.", records.Count);

        var batchLogger = new BatchTimingLogger<ProviderRecorder>(_configuration.BatchSize!.Value, records.Count, "care sites", _logger);

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize.Value);

        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("provider_name");
            dataTable.Columns.Add("npi");
            dataTable.Columns.Add("dea");
            dataTable.Columns.Add("specialty_concept_id");
            dataTable.Columns.Add("care_site_id");
            dataTable.Columns.Add("year_of_birth");
            dataTable.Columns.Add("gender_concept_id");
            dataTable.Columns.Add("provider_source_value");
            dataTable.Columns.Add("specialty_source_value");
            dataTable.Columns.Add("specialty_source_concept_id");
            dataTable.Columns.Add("gender_source_value");
            dataTable.Columns.Add("gender_source_concept_id");

            foreach (var record in batch)
            {
                dataTable.Rows.Add(
                    record.provider_name,
                    record.npi,
                    record.dea,
                    record.specialty_concept_id,
                    record.care_site_id,
                    record.year_of_birth,
                    record.gender_concept_id,
                    record.provider_source_value,
                    record.specialty_source_value,
                    record.specialty_source_concept_id,
                    record.gender_source_value,
                    record.gender_source_concept_id);
            }

            var parameter = new
            {
                rows = dataTable.AsTableValuedParameter("cdm.provider_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_provider", parameter, commandType: CommandType.StoredProcedure);

            batchLogger.LogNext();

        }

        batchLogger.LogSummary();
    }
}
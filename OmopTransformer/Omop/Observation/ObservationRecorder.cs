using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Observation;

internal class ObservationRecorder : IObservationRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<ObservationRecorder> _logger;

    public ObservationRecorder(IOptions<Configuration> configuration, ILogger<ObservationRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateObservations<T>(IReadOnlyCollection<OmopObservation<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        _logger.LogInformation("Recording {0} observation.", records.Count);
        Logger.LogNonValid(_logger, records);

        var batchLogger = new BatchTimingLogger<ObservationRecorder>(_configuration.BatchSize!.Value, records.Count, "observation", _logger);

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize.Value);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("HospitalProviderSpellNumber", typeof(int));
            dataTable.Columns.Add("observation_concept_id", typeof(int));
            dataTable.Columns.Add("observation_date", typeof(DateTime));
            dataTable.Columns.Add("observation_datetime", typeof(DateTime));
            dataTable.Columns.Add("observation_type_concept_id", typeof(int));
            dataTable.Columns.Add("value_as_number", typeof(int));
            dataTable.Columns.Add("value_as_string");
            dataTable.Columns.Add("value_as_concept_id", typeof(int));
            dataTable.Columns.Add("qualifier_concept_id", typeof(int));
            dataTable.Columns.Add("unit_concept_id", typeof(int));
            dataTable.Columns.Add("provider_id", typeof(int));
            dataTable.Columns.Add("observation_source_value");
            dataTable.Columns.Add("observation_source_concept_id", typeof(int));
            dataTable.Columns.Add("unit_source_value");
            dataTable.Columns.Add("qualifier_source_value");
            dataTable.Columns.Add("value_source_value");
            dataTable.Columns.Add("observation_event_id", typeof(int));
            dataTable.Columns.Add("obs_event_field_concept_id", typeof(int));

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                dataTable.Rows.Add(
                    record.nhs_number,
                    record.RecordConnectionIdentifier,
                    record.HospitalProviderSpellNumber,
                    record.observation_concept_id,
                    record.observation_date,
                    record.observation_datetime,
                    record.observation_type_concept_id,
                    record.value_as_number,
                    record.value_as_string,
                    record.value_as_concept_id,
                    record.qualifier_concept_id,
                    record.unit_concept_id,
                    record.provider_id,
                    record.observation_source_value,
                    record.observation_source_concept_id,
                    record.unit_source_value,
                    record.qualifier_source_value,
                    record.value_source_value,
                    record.observation_event_id,
                    record.obs_event_field_concept_id);
            }

            var parameter = new
            {
                @rows = dataTable.AsTableValuedParameter("cdm.[observation_row]"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_observation", parameter, commandType: CommandType.StoredProcedure);

            batchLogger.LogNext();
        }

        batchLogger.LogSummary();
    }
}
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.ConditionOccurrence;

internal class ConditionOccurrenceRecorder : IConditionOccurrenceRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<ConditionOccurrenceRecorder> _logger;

    public ConditionOccurrenceRecorder(IOptions<Configuration> configuration, ILogger<ConditionOccurrenceRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateConditionOccurrence<T>(IReadOnlyCollection<OmopConditionOccurrence<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        _logger.LogInformation("Recording {0} condition occurrences.", records.Count);

        var batchLogger = new BatchTimingLogger<ConditionOccurrenceRecorder>(_configuration.BatchSize!.Value, records.Count, "condition occurrences", _logger);

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize.Value);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("condition_concept_id");
            dataTable.Columns.Add("condition_start_date", typeof(DateTime));
            dataTable.Columns.Add("condition_start_datetime", typeof(DateTime));
            dataTable.Columns.Add("condition_end_date", typeof(DateTime));
            dataTable.Columns.Add("condition_end_datetime", typeof(DateTime));
            dataTable.Columns.Add("condition_type_concept_id");
            dataTable.Columns.Add("condition_status_concept_id");
            dataTable.Columns.Add("stop_reason");
            dataTable.Columns.Add("provider_id");
            dataTable.Columns.Add("visit_occurrence_id");
            dataTable.Columns.Add("visit_detail_id");
            dataTable.Columns.Add("condition_source_value");
            dataTable.Columns.Add("condition_source_concept_id");
            dataTable.Columns.Add("condition_status_source_value");

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                dataTable.Rows.Add(
                    record.nhs_number,
                    record.RecordConnectionIdentifier,
                    record.condition_concept_id,
                    record.condition_start_date,
                    record.condition_start_datetime,
                    record.condition_end_date,
                    record.condition_end_datetime,
                    record.condition_type_concept_id,
                    record.condition_status_concept_id,
                    record.stop_reason,
                    record.provider_id,
                    record.visit_occurrence_id,
                    record.visit_detail_id,
                    record.condition_source_value,
                    record.condition_source_concept_id,
                    record.condition_status_source_value);
            }

            var parameter = new
            {
                @rows = dataTable.AsTableValuedParameter("cdm.condition_occurrence_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_condition_occurrence", parameter, commandType: CommandType.StoredProcedure);

            batchLogger.LogNext();
        }

        batchLogger.LogSummary();
    }
}
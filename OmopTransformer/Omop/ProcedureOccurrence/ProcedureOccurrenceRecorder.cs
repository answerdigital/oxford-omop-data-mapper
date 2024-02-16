using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.ProcedureOccurrence;

internal class ProcedureOccurrenceRecorder : IProcedureOccurrenceRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<ProcedureOccurrenceRecorder> _logger;

    public ProcedureOccurrenceRecorder(IOptions<Configuration> configuration, ILogger<ProcedureOccurrenceRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateProcedureOccurrence<T>(IReadOnlyCollection<OmopProcedureOccurrence<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        _logger.LogInformation("Recording {0} procedure occurrences.", records.Count);

        var stopwatch = Stopwatch.StartNew();

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(1000);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("procedure_concept_id");
            dataTable.Columns.Add("procedure_date", typeof(DateTime));
            dataTable.Columns.Add("procedure_datetime", typeof(DateTime));
            dataTable.Columns.Add("procedure_end_date", typeof(DateTime));
            dataTable.Columns.Add("procedure_end_datetime", typeof(DateTime));
            dataTable.Columns.Add("procedure_type_concept_id");
            dataTable.Columns.Add("modifier_concept_id");
            dataTable.Columns.Add("quantity");
            dataTable.Columns.Add("provider_id");
            dataTable.Columns.Add("visit_occurrence_id");
            dataTable.Columns.Add("visit_detail_id");
            dataTable.Columns.Add("procedure_source_value");
            dataTable.Columns.Add("procedure_source_concept_id");
            dataTable.Columns.Add("modifier_source_value");
            dataTable.Columns.Add("RecordConnectionIdentifier");

            foreach (var record in batch)
            {
                if (record.procedure_concept_id == null)
                    continue;

                foreach (var concept in record.procedure_concept_id)
                {
                    dataTable.Rows.Add(
                        record.nhs_number,
                        concept,
                        record.procedure_date,
                        record.procedure_datetime,
                        record.procedure_end_date,
                        record.procedure_end_datetime,
                        record.procedure_type_concept_id,
                        record.modifier_concept_id,
                        record.quantity,
                        record.provider_id,
                        record.visit_occurrence_id,
                        record.visit_detail_id,
                        record.procedure_source_value,
                        record.procedure_source_concept_id,
                        record.modifier_source_value,
                        record.RecordConnectionIdentifier);
                }
            }

            var parameter = new
            {
                @rows = dataTable.AsTableValuedParameter("cdm.procedure_occurrence_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_procedure_occurrence", parameter, commandType: CommandType.StoredProcedure);
        }

        stopwatch.Stop();

        _logger.LogTrace("Inserting procedure occurrences took {0}ms.", stopwatch.ElapsedMilliseconds);
    }
}
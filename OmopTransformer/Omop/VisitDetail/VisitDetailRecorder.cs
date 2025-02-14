using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.VisitDetail;

internal class VisitDetailRecorder : IVisitDetailRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<VisitDetailRecorder> _logger;

    public VisitDetailRecorder(IOptions<Configuration> configuration, ILogger<VisitDetailRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateVisitDetail<T>(IReadOnlyCollection<OmopVisitDetail<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        _logger.LogInformation("Recording {0} visit details.", records.Count);
        Logger.LogNonValid(_logger, records);

        var batchLogger = new BatchTimingLogger<VisitDetailRecorder>(_configuration.BatchSize!.Value, records.Count, "visit details", _logger);

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        foreach (var batch in records.Batch(_configuration.BatchSize.Value))
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("HospitalProviderSpellNumber", typeof(string));
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("visit_detail_concept_id");
            dataTable.Columns.Add("visit_detail_start_date", typeof(DateTime));
            dataTable.Columns.Add("visit_detail_start_datetime", typeof(DateTime));
            dataTable.Columns.Add("visit_detail_end_date", typeof(DateTime));
            dataTable.Columns.Add("visit_detail_end_datetime", typeof(DateTime));
            dataTable.Columns.Add("visit_detail_type_concept_id");
            dataTable.Columns.Add("provider_id");
            dataTable.Columns.Add("care_site_id");
            dataTable.Columns.Add("visit_detail_source_value");
            dataTable.Columns.Add("visit_detail_source_concept_id");
            dataTable.Columns.Add("admitted_from_concept_id");
            dataTable.Columns.Add("admitted_from_source_value");
            dataTable.Columns.Add("discharged_to_source_value");
            dataTable.Columns.Add("discharged_to_concept_id");

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                dataTable.Rows.Add(
                   record.nhs_number,
                    record.HospitalProviderSpellNumber,
                    record.RecordConnectionIdentifier,
                    record.visit_detail_concept_id,
                    record.visit_detail_start_date,
                    record.visit_detail_start_datetime,
                    record.visit_detail_end_date,
                    record.visit_detail_end_datetime,
                    record.visit_detail_type_concept_id,
                    record.provider_id,
                    record.care_site_id,
                    record.visit_detail_source_value,
                    record.visit_detail_source_concept_id,
                    record.admitted_from_concept_id,
                    record.admitted_from_source_value,
                    record.discharged_to_source_value,
                    record.discharged_to_concept_id);
            }

            var parameter = new
            {
                rows = dataTable.AsTableValuedParameter("cdm.visit_detail_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_visit_detail", parameter, commandType: CommandType.StoredProcedure);

            batchLogger.LogNext();
        }

        batchLogger.LogSummary();

    }
}
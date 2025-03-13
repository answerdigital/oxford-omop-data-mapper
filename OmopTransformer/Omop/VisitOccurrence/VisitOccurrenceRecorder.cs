using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.VisitOccurrence;

internal class VisitOccurrenceRecorder : IVisitOccurrenceRecorder
{
    private readonly Configuration _configuration;

    public VisitOccurrenceRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateVisitOccurrence<T>(IReadOnlyCollection<OmopVisitOccurrence<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("HospitalProviderSpellNumber");
            dataTable.Columns.Add("RecordConnectionIdentifier");
            dataTable.Columns.Add("visit_concept_id");
            dataTable.Columns.Add("visit_start_date", typeof(DateTime));
            dataTable.Columns.Add("visit_start_datetime", typeof(DateTime));
            dataTable.Columns.Add("visit_end_date", typeof(DateTime));
            dataTable.Columns.Add("visit_end_datetime", typeof(DateTime));
            dataTable.Columns.Add("visit_type_concept_id");
            dataTable.Columns.Add("provider_id");
            dataTable.Columns.Add("care_site_id");
            dataTable.Columns.Add("visit_source_value");
            dataTable.Columns.Add("visit_source_concept_id");
            dataTable.Columns.Add("admitted_from_concept_id");
            dataTable.Columns.Add("admitted_from_source_value");
            dataTable.Columns.Add("discharged_to_concept_id");
            dataTable.Columns.Add("discharged_to_source_value");

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                dataTable.Rows.Add(
                   record.NhsNumber,
                    record.HospitalProviderSpellNumber,
                    record.RecordConnectionIdentifier,
                    record.visit_concept_id,
                    record.visit_start_date,
                    record.visit_start_datetime,
                    record.visit_end_date,
                    record.visit_end_datetime,
                    record.visit_type_concept_id,
                    record.provider_id,
                    record.care_site_id,
                    record.visit_source_value,
                    record.visit_source_concept_id,
                    record.admitted_from_concept_id,
                    record.admitted_from_source_value,
                    record.discharged_to_concept_id,
                    record.discharged_to_source_value);
            }

            var parameter = new
            {
                rows = dataTable.AsTableValuedParameter("cdm.visit_occurrence_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_visit_occurrence", parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
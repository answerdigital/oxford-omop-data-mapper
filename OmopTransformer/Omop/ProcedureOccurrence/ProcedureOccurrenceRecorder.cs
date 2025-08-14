using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.ProcedureOccurrence;

internal class ProcedureOccurrenceRecorder : IProcedureOccurrenceRecorder
{
    private readonly Configuration _configuration;

    public ProcedureOccurrenceRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateProcedureOccurrence<T>(IReadOnlyCollection<OmopProcedureOccurrence<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        var connection = RetryConnection.CreateSqlServer(_configuration.ConnectionString!);



        var batches = records.Batch(_configuration.BatchSize!.Value);
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
                if (record.IsValid == false)
                    continue;

                foreach (var conceptId in record.procedure_concept_id!)
                {
                    dataTable.Rows.Add(
                        record.nhs_number,
                        conceptId,
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
    }
}
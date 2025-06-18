using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.DrugExposure;

internal class DrugExposureRecorder : IDrugExposureRecorder
{
    private readonly Configuration _configuration;

    public DrugExposureRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateDrugExposure<T>(IReadOnlyCollection<OmopDrugExposure<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize!.Value);
        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("nhs_number");
            dataTable.Columns.Add("drug_concept_id");
            dataTable.Columns.Add("drug_exposure_start_date", typeof(DateTime));
            dataTable.Columns.Add("drug_exposure_start_datetime", typeof(DateTime));
            dataTable.Columns.Add("drug_exposure_end_date", typeof(DateTime));
            dataTable.Columns.Add("drug_exposure_end_datetime", typeof(DateTime));
            dataTable.Columns.Add("verbatim_end_date", typeof(DateTime));
            dataTable.Columns.Add("drug_type_concept_id");
            dataTable.Columns.Add("stop_reason");
            dataTable.Columns.Add("refills");
            dataTable.Columns.Add("quantity");
            dataTable.Columns.Add("days_supply");
            dataTable.Columns.Add("sig");
            dataTable.Columns.Add("route_concept_id");
            dataTable.Columns.Add("lot_number");
            dataTable.Columns.Add("provider_id");
            dataTable.Columns.Add("drug_source_value");
            dataTable.Columns.Add("drug_source_concept_id");
            dataTable.Columns.Add("route_source_value");
            dataTable.Columns.Add("dose_unit_source_value");
            dataTable.Columns.Add("RecordConnectionIdentifier");

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                foreach (var conceptId in record.drug_concept_id!)
                {
                    dataTable.Rows.Add(
                        record.nhs_number,
                        conceptId,
                        record.drug_exposure_start_date,
                        record.drug_exposure_start_datetime,
                        record.drug_exposure_end_date,
                        record.drug_exposure_end_datetime,
                        record.verbatim_end_date,
                        record.drug_type_concept_id,
                        record.stop_reason,
                        record.refills,
                        record.quantity,
                        record.days_supply,
                        record.sig,
                        record.route_concept_id,
                        record.lot_number,
                        record.provider_id,
                        record.drug_source_value,
                        record.drug_source_concept_id,
                        record.route_source_value,
                        record.dose_unit_source_value,
                        record.RecordConnectionIdentifier);
                }
            }

            var parameter = new
            {
                Rows = dataTable.AsTableValuedParameter("cdm.drug_exposure_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_drug_exposure", parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
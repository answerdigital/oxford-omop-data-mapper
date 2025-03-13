using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.CareSite;

internal class CareSiteRecorder : ICareSiteRecorder
{
    private readonly Configuration _configuration;
    public CareSiteRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateCareSite<T>(IReadOnlyCollection<OmopCareSite<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize!.Value);

        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("care_site_name");
            dataTable.Columns.Add("place_of_service_concept_id");
            dataTable.Columns.Add("location_id");
            dataTable.Columns.Add("care_site_source_value");
            dataTable.Columns.Add("place_of_service_source_value");

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                dataTable.Rows.Add(
                    record.care_site_name,
                    record.place_of_service_concept_id,
                    record.location_id,
                    record.care_site_source_value,
                    record.place_of_service_source_value);
            }

            var parameter = new
            {
                rows = dataTable.AsTableValuedParameter("cdm.care_site_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_care_site", parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
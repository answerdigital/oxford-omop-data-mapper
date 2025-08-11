using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Death;

internal class DeathRecorder : IDeathRecorder
{
    private readonly Configuration _configuration;

    public DeathRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateDeaths<T>(IReadOnlyCollection<OmopDeath<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        var connection = RetryConnection.CreateSqlServer(_configuration.ConnectionString!);



        var batches = records.Batch(_configuration.BatchSize!.Value);
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
                if (record.IsValid == false)
                    continue;

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
    }
}
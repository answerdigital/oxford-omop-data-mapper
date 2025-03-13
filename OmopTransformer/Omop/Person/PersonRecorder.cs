using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Person;

internal class PersonRecorder : IPersonRecorder
{
    private readonly Configuration _configuration;

    public PersonRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdatePersons<T>(IReadOnlyCollection<OmopPerson<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        await using var connection = new SqlConnection(_configuration!.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = records.Batch(_configuration.BatchSize!.Value);

        foreach (var batch in batches)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("gender_concept_id");
            dataTable.Columns.Add("year_of_birth");
            dataTable.Columns.Add("month_of_birth");
            dataTable.Columns.Add("day_of_birth");
            dataTable.Columns.Add("birth_datetime", typeof(DateTime));
            dataTable.Columns.Add("race_concept_id");
            dataTable.Columns.Add("ethnicity_concept_id");
            dataTable.Columns.Add("provider_id");
            dataTable.Columns.Add("care_site_id");
            dataTable.Columns.Add("person_source_value");
            dataTable.Columns.Add("gender_source_value");
            dataTable.Columns.Add("gender_source_concept_id");
            dataTable.Columns.Add("race_source_value");
            dataTable.Columns.Add("race_source_concept_id");
            dataTable.Columns.Add("ethnicity_source_value");
            dataTable.Columns.Add("ethnicity_source_concept_id");

            foreach (var record in batch)
            {
                if (record.IsValid == false)
                    continue;

                dataTable.Rows.Add(
                   record.gender_concept_id,
                    record.year_of_birth,
                    record.month_of_birth,
                    record.day_of_birth,
                    record.birth_datetime,
                    record.race_concept_id,
                    record.ethnicity_concept_id,
                    record.provider_id,
                    record.care_site_id,
                    record.person_source_value,
                    record.gender_source_value,
                    record.gender_source_concept_id,
                    record.race_source_value,
                    record.race_source_concept_id,
                    record.ethnicity_source_value,
                    record.ethnicity_source_concept_id);
            }

            var parameter = new
            {
                rows = dataTable.AsTableValuedParameter("cdm.person_row"),
                DataSource = dataSource
            };

            await connection.ExecuteLongTimeoutAsync("cdm.insert_update_person", parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
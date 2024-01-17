using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Person;

internal class PersonRecorder : IPersonRecorder
{
    private readonly Configuration _configuration;
    private readonly ILogger<PersonRecorder> _logger;

    public PersonRecorder(IOptions<Configuration> configuration, ILogger<PersonRecorder> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task InsertUpdatePersons<T>(IReadOnlyCollection<OmopPerson<T>> persons, string dataSource, CancellationToken cancellationToken)
    {
        if (persons == null) throw new ArgumentNullException(nameof(persons));

        _logger.LogInformation("Recording {0} persons.", persons.Count);

        var stopwatch = Stopwatch.StartNew();

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = persons.Batch(1000);
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

            await connection.ExecuteAsync("cdm.insert_update_person", parameter, commandType: CommandType.StoredProcedure);
        }

        stopwatch.Stop();

        _logger.LogTrace("Inserting persons took {0}ms.", stopwatch.ElapsedMilliseconds);

    }
}
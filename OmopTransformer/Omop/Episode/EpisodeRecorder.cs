using Dapper;
using DuckDB.NET.Data;
using Microsoft.Extensions.Options;
using System.Data;

namespace OmopTransformer.Omop.Episode;

internal class EpisodeRecorder : IEpisodeRecorder
{
    private readonly Configuration _configuration;

    public EpisodeRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateEpisodes<T>(IReadOnlyCollection<OmopEpisode<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        await connection.OpenAsync(cancellationToken);

        await connection.ExecuteAsync("truncate table omop_staging.episode_row;");

        using (IDbTransaction transaction = connection.BeginTransaction())
        {
            try
            {
                using var appender = connection.CreateAppender("omop_staging", "episode_row");
                {
                    foreach (var row in records)
                    {
                        if (row.IsValid == false)
                            continue;

                        var dbRow = appender.CreateRow();

                        dbRow
                            .AppendValue(row.episode_concept_id)
                            .AppendValue(row.episode_start_date)
                            .AppendValue(row.episode_start_datetime)
                            .AppendValue(row.episode_end_date)
                            .AppendValue(row.episode_end_datetime)
                            .AppendValue(row.episode_parent_id)
                            .AppendValue(row.episode_number)
                            .AppendValue(row.episode_object_concept_id)
                            .AppendValue(row.episode_type_concept_id)
                            .AppendValue(row.episode_source_value)
                            .AppendValue(row.episode_source_concept_id)
                            .AppendValue(row.nhs_number)
                            .AppendValue(dataSource)
                            .EndRow();
                    }
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();

                throw;
            }
        }

        await connection
            .ExecuteAsync(
                @"
insert into cdm.episode
(
    person_id,
    episode_concept_id,
    episode_start_date,
    episode_start_datetime,
    episode_end_date,
    episode_end_datetime,
    episode_parent_id,
    episode_number,
    episode_object_concept_id,
    episode_type_concept_id,
    episode_source_value,
    episode_source_concept_id,
    data_source
)
select
    distinct
        p.person_id,
        r.episode_concept_id,
        r.episode_start_date,
        r.episode_start_datetime,
        r.episode_end_date,
        r.episode_end_datetime,
        r.episode_parent_id,
        r.episode_number,
        r.episode_object_concept_id,
        r.episode_type_concept_id,
        r.episode_source_value,
        r.episode_source_concept_id,
        r.data_source
 from omop_staging.episode_row r
    inner join cdm.person p 
        on r.nhs_number = p.person_source_value
where not exists (
    select 1 from cdm.episode e
    where 
        e.person_id = p.person_id
        and e.episode_concept_id = r.episode_concept_id
        and e.episode_start_date = r.episode_start_date
        and ((e.episode_source_value = r.episode_source_value or (e.episode_source_value is null and r.episode_source_value is null)))
);

truncate table omop_staging.episode_row;",
                cancellationToken);
    }

}
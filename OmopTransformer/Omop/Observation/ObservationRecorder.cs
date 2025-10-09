using Dapper;
using DuckDB.NET.Data;
using Microsoft.Extensions.Options;
using System.Data;
using DuckDB.NET.Data.Mapping;

namespace OmopTransformer.Omop.Observation;


public class ObservationRow
{
    public string? nhs_number { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string? HospitalProviderSpellNumber { get; init; }
    public int? conceptId { get; init; }
    public DateTime? observation_date { get; init; }
    public DateTime? observation_datetime { get; init; }
    public int? observation_type_concept_id { get; init; }
    public float? value_as_number { get; init; }
    public string? value_as_string { get; init; }
    public int? value_as_concept_id { get; init; }
    public int? qualifier_concept_id { get; init; }
    public int? unit_concept_id { get; init; }
    public int? provider_id { get; init; }
    public string? observation_source_value { get; init; }
    public int? observation_source_concept_id { get; init; }
    public string? unit_source_value { get; init; }
    public string? qualifier_source_value { get; init; }
    public string? value_source_value { get; init; }
    public int? observation_event_id { get; init; }
    public int? obs_event_field_concept_id { get; init; }
    public string? dataSource { get; init; }
}

public class ObservationRowMap : DuckDBClassMap<ObservationRow>
{
    public ObservationRowMap()
    {
        Map(row => row.nhs_number);
        Map(row => row.RecordConnectionIdentifier);
        Map(row => row.HospitalProviderSpellNumber);
        Map(row => row.conceptId);
        Map(row => row.observation_date);
        Map(row => row.observation_datetime);
        Map(row => row.observation_type_concept_id);
        Map(row => row.value_as_number);
        Map(row => row.value_as_string);
        Map(row => row.value_as_concept_id);
        Map(row => row.qualifier_concept_id);
        Map(row => row.unit_concept_id);
        Map(row => row.provider_id);
        Map(row => row.observation_source_value);
        Map(row => row.observation_source_concept_id);
        Map(row => row.unit_source_value);
        Map(row => row.qualifier_source_value);
        Map(row => row.value_source_value);
        Map(row => row.observation_event_id);
        Map(row => row.obs_event_field_concept_id);
        Map(row => row.dataSource);
    }
}

internal class ObservationRecorder : IObservationRecorder
{
    private readonly Configuration _configuration;

    public ObservationRecorder(IOptions<Configuration> configuration)
    {
        _configuration = configuration.Value;
    }

    public async Task InsertUpdateObservations<T>(IReadOnlyCollection<OmopObservation<T>> records, string dataSource, CancellationToken cancellationToken)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));

        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        await connection.OpenAsync(cancellationToken);

        await connection.ExecuteAsync("truncate table omop_staging.observation_row;");

        var rows =
            records
                .Where(record => record.IsValid)
                .SelectMany(
                    record =>
                        record
                            .observation_concept_id
                            .Select(
                                concept =>
                                    new ObservationRow
                                    {
                                        nhs_number = record.nhs_number,
                                        RecordConnectionIdentifier = record.RecordConnectionIdentifier,
                                        HospitalProviderSpellNumber = record.HospitalProviderSpellNumber,
                                        conceptId = concept,
                                        observation_date = record.observation_date,
                                        observation_datetime = record.observation_datetime,
                                        observation_type_concept_id = record.observation_type_concept_id,
                                        value_as_number = (float?)record.value_as_number,
                                        value_as_string = record.value_as_string,
                                        value_as_concept_id = record.value_as_concept_id,
                                        qualifier_concept_id = record.qualifier_concept_id,
                                        unit_concept_id = record.unit_concept_id,
                                        provider_id = record.provider_id,
                                        observation_source_value = record.observation_source_value,
                                        observation_source_concept_id = record.observation_source_concept_id,
                                        unit_source_value = record.unit_source_value,
                                        qualifier_source_value = record.qualifier_source_value,
                                        value_source_value = record.value_source_value,
                                        observation_event_id = record.observation_event_id,
                                        obs_event_field_concept_id = record.obs_event_field_concept_id,
                                        dataSource = dataSource
                                    }
                            ));


        using (IDbTransaction transaction = connection.BeginTransaction())
        {
            try
            {
                using var appender = connection.CreateAppender<ObservationRow, ObservationRowMap>("omop_staging", "observation_row");
                {
                    appender.AppendRecords(rows);
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


insert into cdm.observation (
    person_id,
    observation_concept_id,
    observation_date,
    observation_datetime,
    observation_type_concept_id,
    value_as_number,
    value_as_string,
    value_as_concept_id,
    qualifier_concept_id,
    unit_concept_id,
    provider_id,
    visit_occurrence_id,
    visit_detail_id,
    observation_source_value,
    observation_source_concept_id,
    unit_source_value,
    qualifier_source_value,
    value_source_value,
    observation_event_id,
    obs_event_field_concept_id,
    RecordConnectionIdentifier,
    HospitalProviderSpellNumber,
    data_source
)
select
    p.person_id,
    r.observation_concept_id,
    r.observation_date,
    r.observation_datetime,
    r.observation_type_concept_id,
    r.value_as_number,
    r.value_as_string,
    r.value_as_concept_id,
    r.qualifier_concept_id,
    r.unit_concept_id,
    r.provider_id,
    (
        select
            vd.visit_occurrence_id
        from cdm.visit_detail vd
        where vd.RecordConnectionIdentifier = r.RecordConnectionIdentifier
            and vd.person_id = p.person_id
        limit 1
    ) as visit_occurrence_id,
    (
        select
            vd.visit_detail_id
        from cdm.visit_detail vd
        where vd.RecordConnectionIdentifier = r.RecordConnectionIdentifier
            and vd.person_id = p.person_id
        limit 1
    ) as visit_detail_id,
    r.observation_source_value,
    r.observation_source_concept_id,
    r.unit_source_value,
    r.qualifier_source_value,
    r.value_source_value,
    r.observation_event_id,
    r.obs_event_field_concept_id,
    r.RecordConnectionIdentifier,
    r.HospitalProviderSpellNumber,
    r.data_source
from omop_staging.observation_row r
inner join cdm.person p
    on r.nhs_number = p.person_source_value
where 
    not exists (
        select 1
        from cdm.observation o
        where 
            (
                r.RecordConnectionIdentifier is not null and
                o.person_id = p.person_id and
                o.observation_date = r.observation_date and
                o.observation_concept_id = r.observation_concept_id and
                o.RecordConnectionIdentifier = r.RecordConnectionIdentifier and
                (r.HospitalProviderSpellNumber is null or o.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber) and
                (r.observation_source_concept_id is null or o.observation_source_concept_id = r.observation_source_concept_id)
            )
            or
            (
                r.RecordConnectionIdentifier is null and
                o.person_id = p.person_id and
                o.observation_date = r.observation_date and
                o.observation_concept_id = r.observation_concept_id and
                o.observation_source_concept_id = r.observation_source_concept_id
            )
    );

truncate table omop_staging.observation_row;",
        cancellationToken);
    }
}
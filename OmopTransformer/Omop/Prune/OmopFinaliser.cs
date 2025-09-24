using DuckDB.NET.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Dapper;

namespace OmopTransformer.Omop.Prune;

internal class OmopFinaliser
{
    private readonly Configuration _configuration;
    private readonly ILogger<OmopFinaliser> _logger;

    public OmopFinaliser(IOptions<Configuration> configuration, ILogger<OmopFinaliser> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Prune(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Clearing incomplete omop records.");

        await PruneRecords(cancellationToken);

        _logger.LogInformation("Apply data fixes.");

        await ApplyDQDFixes(cancellationToken);

        _logger.LogInformation("Rebuilding era tables.");

        // await connection.ExecuteLongTimeoutAsync("cdm.build_era");
    }

    private async Task ApplyDQDFixes(CancellationToken cancellationToken)
    {
        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        await connection.OpenAsync(cancellationToken);

        await connection.ExecuteAsync(@"
-- Combined UPDATE statements for the 'person' table
-- Updates gender to MALE (8507) based on specific conditions
UPDATE cdm.person
SET gender_concept_id = 8507
FROM cdm.CONDITION_OCCURRENCE AS cdmTable
JOIN cdm.concept_ancestor AS ca 
    ON ca.descendant_concept_id = cdmTable.CONDITION_CONCEPT_ID
WHERE 
    cdm.person.person_id = cdmTable.person_id
    AND cdm.person.gender_concept_id <> 8507
    AND (
        ca.ancestor_concept_id IN (4090861, 4025213)
        OR cdmTable.CONDITION_CONCEPT_ID = 79758
    );

-- Updates gender to FEMALE (8532) based on a list of conditions
UPDATE cdm.person
SET gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE AS cdmTable
WHERE 
    cdm.person.person_id = cdmTable.person_id
    AND cdm.person.gender_concept_id <> 8532
    AND cdmTable.CONDITION_CONCEPT_ID IN (
        201801, 200052, 4194652, 437501, 201817, 201238, 195500,
        195197, 197236, 199764, 4162860, 441805, 196359, 196048
    );

-- Combined DELETE statements for the 'death' table
-- Deletes death records where related events occur >60 days after death
DELETE FROM cdm.death
WHERE person_id IN (
    SELECT person_id FROM cdm.DEVICE_EXPOSURE
    WHERE 
        (DEVICE_EXPOSURE_END_DATE IS NOT NULL AND DEVICE_EXPOSURE_END_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (DEVICE_EXPOSURE_START_DATE IS NOT NULL AND DEVICE_EXPOSURE_START_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (DEVICE_EXPOSURE_END_DATETIME IS NOT NULL AND CAST(DEVICE_EXPOSURE_END_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY)) OR
        (DEVICE_EXPOSURE_START_DATETIME IS NOT NULL AND CAST(DEVICE_EXPOSURE_START_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY))
);

DELETE FROM cdm.death
WHERE person_id IN (
    SELECT person_id FROM cdm.PROCEDURE_OCCURRENCE
    WHERE
        (PROCEDURE_DATE IS NOT NULL AND PROCEDURE_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (PROCEDURE_END_DATE IS NOT NULL AND PROCEDURE_END_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (PROCEDURE_DATETIME IS NOT NULL AND CAST(PROCEDURE_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY)) OR
        (PROCEDURE_END_DATETIME IS NOT NULL AND CAST(PROCEDURE_END_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY))
);

DELETE FROM cdm.death
WHERE person_id IN (
    SELECT person_id FROM cdm.VISIT_DETAIL
    WHERE
        (VISIT_DETAIL_END_DATE IS NOT NULL AND VISIT_DETAIL_END_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (VISIT_DETAIL_START_DATE IS NOT NULL AND VISIT_DETAIL_START_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (VISIT_DETAIL_END_DATETIME IS NOT NULL AND CAST(VISIT_DETAIL_END_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY)) OR
        (VISIT_DETAIL_START_DATETIME IS NOT NULL AND CAST(VISIT_DETAIL_START_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY))
);

DELETE FROM cdm.death
WHERE person_id IN (
    SELECT person_id FROM cdm.VISIT_OCCURRENCE
    WHERE
        (VISIT_END_DATE IS NOT NULL AND VISIT_END_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (VISIT_START_DATE IS NOT NULL AND VISIT_START_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (VISIT_END_DATETIME IS NOT NULL AND CAST(VISIT_END_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY)) OR
        (VISIT_START_DATETIME IS NOT NULL AND CAST(VISIT_START_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY))
);

DELETE FROM cdm.death
WHERE person_id IN (
    SELECT person_id FROM cdm.DRUG_EXPOSURE
    WHERE
        (DRUG_EXPOSURE_END_DATE IS NOT NULL AND DRUG_EXPOSURE_END_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (DRUG_EXPOSURE_START_DATE IS NOT NULL AND DRUG_EXPOSURE_START_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (DRUG_EXPOSURE_END_DATETIME IS NOT NULL AND CAST(DRUG_EXPOSURE_END_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY)) OR
        (DRUG_EXPOSURE_START_DATETIME IS NOT NULL AND CAST(DRUG_EXPOSURE_START_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY))
);

DELETE FROM cdm.death
WHERE person_id IN (
    SELECT person_id FROM cdm.OBSERVATION
    WHERE
        (OBSERVATION_DATE IS NOT NULL AND OBSERVATION_DATE > (death.death_date + INTERVAL '60' DAY)) OR
        (OBSERVATION_DATETIME IS NOT NULL AND CAST(OBSERVATION_DATETIME AS DATE) > (death.death_date + INTERVAL '60' DAY))
);

DELETE FROM cdm.death
WHERE person_id IN (
    SELECT person_id FROM cdm.CONDITION_ERA
    WHERE
        CONDITION_ERA_END_DATE IS NOT NULL 
        AND CONDITION_ERA_END_DATE > (death.death_date + INTERVAL '60' DAY)
);


");
    }

    private async Task PruneRecords(CancellationToken cancellationToken)
    {
        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        await connection.OpenAsync(cancellationToken);

        await connection.ExecuteAsync(@"
create temporary table personstodelete_temp (
    person_id integer not null
);

insert into personstodelete_temp (
    person_id
)
select
    person_id
from cdm.person
where gender_concept_id is null
    or person_source_value is null
    or race_concept_id is null
    or ethnicity_concept_id is null;

update cdm.observation
set
    visit_occurrence_id = null,
    visit_detail_id = null
where person_id in (select person_id from personstodelete_temp);

delete from cdm.condition_occurrence
where person_id in (select person_id from personstodelete_temp);

delete from cdm.measurement
where person_id in (select person_id from personstodelete_temp);

delete from cdm.death
where person_id in (select person_id from personstodelete_temp);

delete from cdm.procedure_occurrence
where person_id in (select person_id from personstodelete_temp);

delete from cdm.drug_exposure
where person_id in (select person_id from personstodelete_temp);

delete from cdm.device_exposure
where person_id in (select person_id from personstodelete_temp);

delete from cdm.visit_detail
where person_id in (select person_id from personstodelete_temp);

delete from cdm.visit_occurrence
where person_id in (select person_id from personstodelete_temp);

delete from cdm.observation
where person_id in (select person_id from personstodelete_temp);

delete from cdm.person
where person_id in (select person_id from personstodelete_temp);

drop table personstodelete_temp;

delete from cdm.location l
where not exists (
    select 1
    from cdm.person p
    where p.location_id = l.location_id
);");
    }
}


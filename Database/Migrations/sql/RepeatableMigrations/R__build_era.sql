if object_id('cdm.build_era') is not null
begin
	drop procedure cdm.build_era;
end

go

create procedure cdm.build_era
as

begin

truncate table cdm.condition_era;
truncate table cdm.drug_era;


/****************************************************
OHDSI-SQL File Instructions
-----------------------------
 1. Set parameter name of schema that contains CDMv4 instance
    (@SOURCE_CDMV4, @SOURCE_CDMV4_SCHEMA)
 2. Set parameter name of schema that contains CDMv5 instance
    (@TARGET_CDMV5, cdm)
 3. Run this script through SqlRender to produce a script that will work in your
    source dialect. SqlRender can be found here: https://github.com/OHDSI/SqlRender
 4. Run the script produced by SQL Render on your target RDBDMS.
<RDBMS> File Instructions
-------------------------
 1. This script will hold a number of placeholders for your CDM V4 and CDMV5
    database/schema. In order to make this file work in your environment, you
    should plan to do a global "FIND AND REPLACE" on this file to fill in the
    file with values that pertain to your environment. The following are the
    tokens you should use when doing your "FIND AND REPLACE" operation:
    
     [CDM]
     [CDM].[CDMSCHEMA]
    
*********************************************************************************/
/* SCRIPT PARAMETERS */

/****
CONDITION ERA
Note: Eras derived from CONDITION_OCCURRENCE table, using 30d gap
 ****/
IF OBJECT_ID('tempdb..#condition_era_phase_1', 'U') IS NOT NULL
    DROP TABLE #condition_era_phase_1;

/* / */

IF OBJECT_ID('tempdb..#cteConditionTarget', 'U') IS NOT NULL
    DROP TABLE #cteConditionTarget;

/* / */

-- create base eras from the concepts found in condition_occurrence
SELECT co.PERSON_ID
    ,co.condition_concept_id
    ,co.CONDITION_START_DATE
    ,COALESCE(co.CONDITION_END_DATE, DATEADD(day, 1, CONDITION_START_DATE)) AS CONDITION_END_DATE
INTO #cteConditionTarget
FROM cdm.CONDITION_OCCURRENCE co;

/* / */

IF OBJECT_ID('tempdb..#cteCondEndDates', 'U') IS NOT NULL
    DROP TABLE #cteCondEndDates;

/* / */

SELECT PERSON_ID
    ,CONDITION_CONCEPT_ID
    ,DATEADD(day, - 30, EVENT_DATE) AS END_DATE -- unpad the end date
INTO #cteCondEndDates
FROM (
    SELECT E1.PERSON_ID
        ,E1.CONDITION_CONCEPT_ID
        ,E1.EVENT_DATE
        ,COALESCE(E1.START_ORDINAL, MAX(E2.START_ORDINAL)) START_ORDINAL
        ,E1.OVERALL_ORD
    FROM (
        SELECT PERSON_ID
            ,CONDITION_CONCEPT_ID
            ,EVENT_DATE
            ,EVENT_TYPE
            ,START_ORDINAL
            ,ROW_NUMBER() OVER (
                PARTITION BY PERSON_ID
                ,CONDITION_CONCEPT_ID ORDER BY EVENT_DATE
                    ,EVENT_TYPE
                ) AS OVERALL_ORD -- this re-numbers the inner UNION so all rows are numbered ordered by the event date
        FROM (
            -- select the start dates, assigning a row number to each
            SELECT PERSON_ID
                ,CONDITION_CONCEPT_ID
                ,CONDITION_START_DATE AS EVENT_DATE
                ,- 1 AS EVENT_TYPE
                ,ROW_NUMBER() OVER (
                    PARTITION BY PERSON_ID
                    ,CONDITION_CONCEPT_ID ORDER BY CONDITION_START_DATE
                    ) AS START_ORDINAL
            FROM #cteConditionTarget

            UNION ALL

            -- pad the end dates by 30 to allow a grace period for overlapping ranges.
            SELECT PERSON_ID
                ,CONDITION_CONCEPT_ID
                ,DATEADD(day, 30, CONDITION_END_DATE)
                ,1 AS EVENT_TYPE
                ,NULL
            FROM #cteConditionTarget
            ) RAWDATA
        ) E1
    INNER JOIN (
        SELECT PERSON_ID
            ,CONDITION_CONCEPT_ID
            ,CONDITION_START_DATE AS EVENT_DATE
            ,ROW_NUMBER() OVER (
                PARTITION BY PERSON_ID
                ,CONDITION_CONCEPT_ID ORDER BY CONDITION_START_DATE
                ) AS START_ORDINAL
        FROM #cteConditionTarget
        ) E2 ON E1.PERSON_ID = E2.PERSON_ID
        AND E1.CONDITION_CONCEPT_ID = E2.CONDITION_CONCEPT_ID
        AND E2.EVENT_DATE <= E1.EVENT_DATE
    GROUP BY E1.PERSON_ID
        ,E1.CONDITION_CONCEPT_ID
        ,E1.EVENT_DATE
        ,E1.START_ORDINAL
        ,E1.OVERALL_ORD
    ) E
WHERE (2 * E.START_ORDINAL) - E.OVERALL_ORD = 0;

/* / */

IF OBJECT_ID('tempdb..#cteConditionEnds', 'U') IS NOT NULL
    DROP TABLE #cteConditionEnds;

/* / */

SELECT c.PERSON_ID
    ,c.CONDITION_CONCEPT_ID
    ,c.CONDITION_START_DATE
    ,MIN(e.END_DATE) AS ERA_END_DATE
INTO #cteConditionEnds
FROM #cteConditionTarget c
INNER JOIN #cteCondEndDates e ON c.PERSON_ID = e.PERSON_ID
    AND c.CONDITION_CONCEPT_ID = e.CONDITION_CONCEPT_ID
    AND e.END_DATE >= c.CONDITION_START_DATE
GROUP BY c.PERSON_ID
    ,c.CONDITION_CONCEPT_ID
    ,c.CONDITION_START_DATE;

/* / */


create index idx_cteConditionEnds on #cteConditionEnds 
(
	person_id,
	CONDITION_CONCEPT_ID,
	ERA_END_DATE
)
include
(
	CONDITION_START_DATE
)

INSERT INTO cdm.condition_era 
(
	person_id
    ,condition_concept_id
    ,condition_era_start_date
    ,condition_era_end_date
    ,condition_occurrence_count
)
SELECT
    person_id
    ,CONDITION_CONCEPT_ID
    ,min(CONDITION_START_DATE) AS CONDITION_ERA_START_DATE
    ,ERA_END_DATE AS CONDITION_ERA_END_DATE
    ,COUNT(*) AS CONDITION_OCCURRENCE_COUNT
FROM #cteConditionEnds
GROUP BY person_id
    ,CONDITION_CONCEPT_ID
    ,ERA_END_DATE;



-- Code taken from:
-- https://github.com/OHDSI/ETL-CMS/blob/master/SQL/create_CDMv5_drug_era_non_stockpile.sql
-- JC: 2025-06-24 Use temp tables to avoid performance problems changes (4h+ to 10m).

if object_id('tempdb..#tmp_de', 'U') is not null drop table #tmp_de;

drop table if exists #ctePreDrugTarget;
drop table if exists #cteDrugExposureEnds;

with ctePreDrugTarget(drug_exposure_id, person_id, ingredient_concept_id, drug_exposure_start_date, days_supply, drug_exposure_end_date) AS
(-- Normalize DRUG_EXPOSURE_END_DATE to either the existing drug exposure end date, or add days supply, or add 1 day to the start date
    SELECT
        d.drug_exposure_id
        , d.person_id
        , c.concept_id AS ingredient_concept_id
        , d.drug_exposure_start_date AS drug_exposure_start_date
        , d.days_supply AS days_supply
        , COALESCE(
            ---NULLIF returns NULL if both values are the same, otherwise it returns the first parameter
            NULLIF(drug_exposure_end_date, NULL),
            ---If drug_exposure_end_date != NULL, return drug_exposure_end_date, otherwise go to next case
            NULLIF(dateadd(day,days_supply,drug_exposure_start_date), drug_exposure_start_date),
            ---If days_supply != NULL or 0, return drug_exposure_start_date + days_supply, otherwise go to next case
            dateadd(day,1,drug_exposure_start_date)
            ---Add 1 day to the drug_exposure_start_date since there is no end_date or INTERVAL for the days_supply
        ) AS drug_exposure_end_date
    FROM cdm.drug_exposure d
        JOIN cdm.concept_ancestor ca ON ca.descendant_concept_id = d.drug_concept_id
        JOIN cdm.concept c ON ca.ancestor_concept_id = c.concept_id
        WHERE c.vocabulary_id = 'RxNorm' ---8 selects RxNorm from the vocabulary_id
        AND c.concept_class_id = 'Ingredient'
        AND d.drug_concept_id != 0 ---Our unmapped drug_concept_id's are set to 0, so we don't want different drugs wrapped up in the same era
        AND coalesce(d.days_supply,0) >= 0 ---We have cases where days_supply is negative, and this can set the end_date before the start_date, which we don't want. So we're just looking over those rows. This is a data-quality issue.
)
select
	*
into #ctePreDrugTarget
from ctePreDrugTarget

CREATE NONCLUSTERED INDEX IDX_ctePreDrugTarget
ON [#ctePreDrugTarget] ([person_id],[ingredient_concept_id],[drug_exposure_start_date])
INCLUDE ([drug_exposure_id])

;with cteSubExposureEndDates (person_id, ingredient_concept_id, end_date) AS --- A preliminary sorting that groups all of the overlapping exposures into one exposure so that we don't double-count non-gap-days
(
    SELECT person_id, ingredient_concept_id, event_date AS end_date
    FROM
    (
        SELECT person_id, ingredient_concept_id, event_date, event_type,
        MAX(start_ordinal) OVER (PARTITION BY person_id, ingredient_concept_id
            ORDER BY event_date, event_type ROWS unbounded preceding) AS start_ordinal,
        -- this pulls the current START down from the prior rows so that the NULLs
        -- from the END DATES will contain a value we can compare with
            ROW_NUMBER() OVER (PARTITION BY person_id, ingredient_concept_id
                ORDER BY event_date, event_type) AS overall_ord
            -- this re-numbers the inner UNION so all rows are numbered ordered by the event date
        FROM (
            -- select the start dates, assigning a row number to each
            SELECT person_id, ingredient_concept_id, drug_exposure_start_date AS event_date,
            -1 AS event_type,
            ROW_NUMBER() OVER (PARTITION BY person_id, ingredient_concept_id
                ORDER BY drug_exposure_start_date) AS start_ordinal
            FROM #ctePreDrugTarget

            UNION ALL

            SELECT person_id, ingredient_concept_id, drug_exposure_end_date, 1 AS event_type, NULL
            FROM #ctePreDrugTarget
        ) RAWDATA
    ) e
    WHERE (2 * e.start_ordinal) - e.overall_ord = 0
)
SELECT
    dt.person_id
    , dt.ingredient_concept_id as drug_concept_id
    , dt.drug_exposure_start_date as drug_exposure_start_date
    , MIN(e.end_date) AS drug_sub_exposure_end_date
into #cteDrugExposureEnds
FROM #ctePreDrugTarget dt
	JOIN cteSubExposureEndDates e 
		ON dt.person_id = e.person_id 
		AND dt.ingredient_concept_id = e.ingredient_concept_id 
		AND e.end_date >= dt.drug_exposure_start_date
GROUP BY
        dt.drug_exposure_id
        , dt.person_id
    , dt.ingredient_concept_id
    , dt.drug_exposure_start_date
	
--------------------------------------------------------------------------------------------------------------
;with cteSubExposures(row_number, person_id, drug_concept_id, drug_sub_exposure_start_date, drug_sub_exposure_end_date, drug_exposure_count) AS
(
    SELECT ROW_NUMBER() OVER (PARTITION BY person_id, drug_concept_id, drug_sub_exposure_end_date ORDER BY person_id)
        , person_id, drug_concept_id, MIN(drug_exposure_start_date) AS drug_sub_exposure_start_date, drug_sub_exposure_end_date, COUNT(*) AS drug_exposure_count
    FROM #cteDrugExposureEnds
    GROUP BY person_id, drug_concept_id, drug_sub_exposure_end_date
    --ORDER BY person_id, drug_concept_id
)
--------------------------------------------------------------------------------------------------------------
/*Everything above grouped exposures into sub_exposures if there was overlap between exposures.
 *So there was no persistence window. Now we can add the persistence window to calculate eras.
 */
--------------------------------------------------------------------------------------------------------------
, cteFinalTarget(row_number, person_id, ingredient_concept_id, drug_sub_exposure_start_date, drug_sub_exposure_end_date, drug_exposure_count, days_exposed) AS
(
    SELECT row_number, person_id, drug_concept_id, drug_sub_exposure_start_date, drug_sub_exposure_end_date, drug_exposure_count
        , datediff(day,drug_sub_exposure_start_date,drug_sub_exposure_end_date) AS days_exposed
    FROM cteSubExposures
)
--------------------------------------------------------------------------------------------------------------
, cteEndDates (person_id, ingredient_concept_id, end_date) AS -- the magic
(
    SELECT person_id, ingredient_concept_id, dateadd(day,-30,event_date) AS end_date -- unpad the end date
    FROM
    (
        SELECT person_id, ingredient_concept_id, event_date, event_type,
        MAX(start_ordinal) OVER (PARTITION BY person_id, ingredient_concept_id
            ORDER BY event_date, event_type ROWS UNBOUNDED PRECEDING) AS start_ordinal,
        -- this pulls the current START down from the prior rows so that the NULLs
        -- from the END DATES will contain a value we can compare with
            ROW_NUMBER() OVER (PARTITION BY person_id, ingredient_concept_id
                ORDER BY event_date, event_type) AS overall_ord
            -- this re-numbers the inner UNION so all rows are numbered ordered by the event date
        FROM (
            -- select the start dates, assigning a row number to each
            SELECT person_id, ingredient_concept_id, drug_sub_exposure_start_date AS event_date,
            -1 AS event_type,
            ROW_NUMBER() OVER (PARTITION BY person_id, ingredient_concept_id
                ORDER BY drug_sub_exposure_start_date) AS start_ordinal
            FROM cteFinalTarget

            UNION ALL

            -- pad the end dates by 30 to allow a grace period for overlapping ranges.
            SELECT person_id, ingredient_concept_id, dateadd(day,30,drug_sub_exposure_end_date), 1 AS event_type, NULL
            FROM cteFinalTarget
        ) RAWDATA
    ) e
    WHERE (2 * e.start_ordinal) - e.overall_ord = 0

)
, cteDrugEraEnds (person_id, drug_concept_id, drug_sub_exposure_start_date, drug_era_end_date, drug_exposure_count, days_exposed) AS
(
SELECT
    ft.person_id
    , ft.ingredient_concept_id
    , ft.drug_sub_exposure_start_date
    , MIN(e.end_date) AS era_end_date
    , drug_exposure_count
    , days_exposed
FROM cteFinalTarget ft
JOIN cteEndDates e ON ft.person_id = e.person_id AND ft.ingredient_concept_id = e.ingredient_concept_id AND e.end_date >= ft.drug_sub_exposure_start_date
GROUP BY
        ft.person_id
    , ft.ingredient_concept_id
    , ft.drug_sub_exposure_start_date
    , drug_exposure_count
    , days_exposed
)
SELECT
    person_id
    , drug_concept_id
    , MIN(drug_sub_exposure_start_date) AS drug_era_start_date
    , drug_era_end_date
    , SUM(drug_exposure_count) AS drug_exposure_count
    , datediff(day,MIN(drug_sub_exposure_start_date),drug_era_end_date)-SUM(days_exposed) as gap_days
INTO #tmp_de
FROM cteDrugEraEnds dee
GROUP BY person_id, drug_concept_id, drug_era_end_date;

INSERT INTO cdm.drug_era(person_id, drug_concept_id, drug_era_start_date, drug_era_end_date, drug_exposure_count, gap_days)
SELECT * FROM #tmp_de;

end

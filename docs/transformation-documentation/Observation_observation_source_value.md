---
layout: default
title: observation_source_value
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# observation_source_value
### Sus CCMDS High Cost Drugs
* Value copied from `ObservationSourceValue`

* `ObservationSourceValue` High cost drugs. [HIGH COST DRUGS (OPCS)](https://www.datadictionary.nhs.uk/data_elements/high_cost_drugs__opcs_.html)

```sql
		select distinct
			apc.NHSNumber,
			apc.HospitalProviderSpellNumber,
			cc.CriticalCareStartDate as ObservationDate,
			coalesce(cc.CriticalCareStartTime, '00:00:00') as ObservationDateTime,
			d.CriticalCareHighCostDrugs as ObservationSourceValue
		from omop_staging.sus_CCMDS_CriticalCareHighCostDrugs d
		inner join omop_staging.sus_CCMDS cc on d.MessageId = cc.MessageId
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20Sus%20CCMDS%20High%20Cost%20Drugs%20mapping){: .btn }
### SACT Clinical Trial
* Value copied from `Source_value`

* `Source_value` Source value for the Systemic Anti-Cancer Therapy Data Set, CLINICAL TRIAL INDICATOR identifies if a PATIENT  is currently in an active Systemic Anti-Cancer Therapy CLINICAL TRIAL [CLINICAL TRIAL INDICATOR](https://www.datadictionary.nhs.uk/data_elements/clinical_trial_indicator.html)

```sql
		select
			distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
      		Clinical_Trial,
			Case 
				When Clinical_Trial = 1 then concat(Clinical_Trial, ' - PATIENT is taking part in a CLINICAL TRIAL')
			else '' end as Source_Value,
		  	CASE
				-- Check for yyyy-MM-dd format (contains dash and year first)
				WHEN Administration_Date LIKE '____-__-__' 
					THEN CAST(strptime(Administration_Date, '%Y-%m-%d') AS TIMESTAMP)
				-- dd/MM/yyyy format, where day is between 1 and 31
			    WHEN Administration_Date LIKE '__/__/____' AND CAST(substring(Administration_Date, 1, 2) AS INTEGER) BETWEEN 1 AND 31
				    THEN CAST(strptime(Administration_Date, '%d/%m/%Y') AS TIMESTAMP)
				-- Otherwise assume MM/dd/yyyy format
				WHEN Administration_Date LIKE '__/__/____'
					THEN CAST(strptime(Administration_Date, '%m/%d/%Y') AS TIMESTAMP)
				ELSE NULL
			END AS Administration_Date
		from omop_staging.sact_staging
  		where Clinical_Trial = '1'
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20SACT%20Clinical%20Trial%20mapping){: .btn }
### Oxford Lab General Comment Observation
* Value copied from `EVENT`

* `EVENT` Lab test event [EVENT]()

```sql
select
    NHS_NUMBER,
    EVENT,
    EVENT_START_DT_TM,
    RESULT_VALUE
from ##duckdb_source##
where lower(EVENT) like '%comment%'
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20Oxford%20Lab%20General%20Comment%20Observation%20mapping){: .btn }

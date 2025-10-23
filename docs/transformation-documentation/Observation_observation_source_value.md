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

* `ObservationSourceValue` High cost drugs. [HIGH COST DRUGS (OPCS)]()

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

* `Source_value` Source value for the Systemic Anti-Cancer Therapy Data Set, CLINICAL TRIAL INDICATOR identifies if a PATIENT  is currently in an active Systemic Anti-Cancer Therapy CLINICAL TRIAL [CLINICAL TRIAL INDICATOR]()

```sql
		select
			distinct
  			replace(NHS_Number, ' ', '') as NHS_Number,
      		Clinical_Trial,
			Case 
				When Clinical_Trial = 1 then concat(Clinical_Trial, ' - PATIENT is taking part in a CLINICAL TRIAL')
			else '' end as Source_Value,
		  	Date_Decision_To_Treat
		from omop_staging.sact_staging
  		where Clinical_Trial = '1'
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20SACT%20Clinical%20Trial%20mapping){: .btn }

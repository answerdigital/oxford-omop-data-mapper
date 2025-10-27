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

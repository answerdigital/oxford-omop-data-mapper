---
layout: default
title: RecordConnectionIdentifier
parent: VisitOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# RecordConnectionIdentifier
### SUS APC VisitOccurrenceWithoutSpell
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER]()

```sql
with RecordConnectionIdentifierNHSNumberCombination as (
	select
		distinct 
			apc.NHSNumber,
			apc.GeneratedRecordIdentifier
	from omop_staging.sus_APC apc
),

RecordsWithVariableNhsNumber as (
select
	m1.GeneratedRecordIdentifier
from RecordConnectionIdentifierNHSNumberCombination m1
	inner join RecordConnectionIdentifierNHSNumberCombination m2
		on m1.NHSNumber != m2.NHSNumber
where m1.GeneratedRecordIdentifier = m2.GeneratedRecordIdentifier
)

select
	apc.NHSNumber,
	apc.GeneratedRecordIdentifier,
	min (apc.CDSActivityDate) as EpisodeStartDate,
	'000000' as EpisodeStartTime,
	max (apc.CDSActivityDate) as EpisodeEndDate,
	'000000' as EpisodeEndTime,
	max (apc.SourceOfAdmissionHospitalProviderSpell) as SourceofAdmissionCode,
	max (apc.DischargeDestinationHospitalProviderSpell) as DischargeDestinationCode
from omop_staging.sus_APC apc
	inner join dbo.Code c 
		on c.Code = apc.TreatmentFunctionCode
where apc.UpdateType = 9   -- New/Modification     (1 = Delete)
	and apc.NHSNumber is not null
	and c.CodeTypeId = 2 -- activity_treatment_function_code
	and apc.HospitalProviderSpellNumber is null
	and not exists (select * from RecordsWithVariableNhsNumber rwvnn where rwvnn.GeneratedRecordIdentifier = apc.GeneratedRecordIdentifier)
group by 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20RecordConnectionIdentifier%20field%20SUS%20APC%20VisitOccurrenceWithoutSpell%20mapping){: .btn }
### CDS VisitOccurrenceWithoutSpell
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER]()

```sql
;with RecordConnectionIdentifierNHSNumberCombination as (
	select
		distinct 
			l1.NHSNumber,
			l1.RecordConnectionIdentifier
	from omop_staging.cds_line01 l1
), RecordsWithVariableNhsNumber as (
select
	m1.RecordConnectionIdentifier
from RecordConnectionIdentifierNHSNumberCombination m1
	inner join RecordConnectionIdentifierNHSNumberCombination m2
		on m1.NHSNumber != m2.NHSNumber
where m1.RecordConnectionIdentifier = m2.RecordConnectionIdentifier
)
select
	l1.NHSNumber,
	l1.RecordConnectionIdentifier,
	min (l1.CDSActivityDate) as EpisodeStartDate,
	'000000' as EpisodeStartTime,
	max (l1.CDSActivityDate) as EpisodeEndDate,
	'000000' as EpisodeEndTime,
	max (l5.SourceofAdmissionCode) as SourceofAdmissionCode,
	max (l5.DischargeDestinationCode) as DischargeDestinationCode
from omop_staging.cds_line01 l1
	left join omop_staging.cds_line04 l4 
		on l1.MessageId = l4.MessageId -- Location Details 
	left join omop_staging.cds_line05 l5 
		on l1.MessageId = l5.MessageId  -- Hospital Provider Spell
	inner join dbo.Code c 
		on c.Code = l1.ActivityTreatmentFunctionCode
where l1.CDSUpdateType = 9   -- New/Modification     (1 = Delete)
	and l1.NHSNumber is not null
	and c.CodeTypeId = 2 -- activity_treatment_function_code
	and l5.HospitalProviderSpellNumber is null
	and not exists (select * from RecordsWithVariableNhsNumber rwvnn where rwvnn.RecordConnectionIdentifier = l1.RecordConnectionIdentifier)
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20RecordConnectionIdentifier%20field%20CDS%20VisitOccurrenceWithoutSpell%20mapping){: .btn }

---
layout: default
title: HospitalProviderSpellNumber
parent: VisitOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# HospitalProviderSpellNumber
### SUS OP VisitOccurrenceWithSpell
* Value copied from `SUSgeneratedspellID`

* `SUSgeneratedspellID` CDS specific hospital spell number that binds many episodes together. [HOSPITAL PROVIDER SPELL NUMBER](https://www.datadictionary.nhs.uk/data_elements/hospital_provider_spell_number.html)

```sql
select
	op.NHSNumber,
	op.SUSgeneratedspellID,
	op.GeneratedRecordIdentifier,
	coalesce(min(op.AppointmentDate), min(op.CDSActivityDate)) as VisitStartDate,  -- visit_start_date
	coalesce(min(op.AppointmentTime), '000000') as VisitStartTime,  -- visit_start_time

	coalesce(max(op.AppointmentDate), max(op.CDSActivityDate)) as VisitEndDate,
	'000000' as VisitEndTime,

	case
		when max(op.LocationClassatAttendance) in ('04') then 581380
	else 9202
	end as VisitOccurrenceConceptId,    -- ""visit_concept_id""

	32818 as VisitTypeConceptId
from [omop_staging].[sus_OP] op
	inner join dbo.Code c
	on c.Code = op.TreatmentFunctionCode
where op.UpdateType = 9   -- New/Modification     (1 = Delete)
	and op.NHSNumber is not null
	and c.CodeTypeId = 2 -- activity_treatment_function_code
	and op.SUSgeneratedspellID is not null
group by
	op.NHSNumber,
	op.SUSgeneratedspellID,
	GeneratedRecordIdentifier;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20HospitalProviderSpellNumber%20field%20SUS%20OP%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS APC VisitOccurrenceWithSpell
* Value copied from `HospitalProviderSpellNumber`

* `HospitalProviderSpellNumber` CDS specific hospital spell number that binds many episodes together. [HOSPITAL PROVIDER SPELL NUMBER](https://www.datadictionary.nhs.uk/data_elements/hospital_provider_spell_number.html)

```sql
select
	apc.NHSNumber,
	apc.HospitalProviderSpellNumber,
	min (apc.StartDateHospitalProviderSpell) as EpisodeStartDate,
	coalesce
	(
		min (apc.StartTimeEpisode),
		'000000'
	) as EpisodeStartTime,
	coalesce
	(
		max (apc.DischargeDateFromHospitalProviderSpell),
		max (apc.EndDateConsultantEpisode),
		max (apc.CDSActivityDate)
	) as EpisodeEndDate,
	coalesce
	(
		max (apc.DischargeTimeHospitalProviderSpell),
		'000000'
	) as EpisodeEndTime,
	apc.GeneratedRecordIdentifier,
	case
		when max(apc.AdmissionMethodHospitalProviderSpell) in ('21','24') and max(apc.PatientClassification) = 1 then 262
        when max(apc.AdmissionMethodHospitalProviderSpell) in ('21','24') then 9203
        when max(apc.PatientClassification) in (1) then 9201
        when max(apc.LocationClassAtEpisodeStartDate) in ('02') then 581476
		else 9202
	end as VisitOccurrenceConceptId,    -- "visit_concept_id"
	case
		when max(apc.EndDateConsultantEpisode) is null and max(apc.DischargeDestinationHospitalProviderSpell) is null then 32220
        else 32818
	end as VisitTypeConceptId,
	max (apc.SourceOfAdmissionHospitalProviderSpell) as SourceofAdmissionCode,
	max (apc.DischargeDestinationHospitalProviderSpell) as DischargeDestinationCode
from [omop_staging].[sus_APC] apc
	inner join dbo.Code c
		on c.Code = apc.TreatmentFunctionCode
where apc.UpdateType = 9   -- New/Modification     (1 = Delete)
	and apc.NHSNumber is not null
	and c.CodeTypeId = 2 -- activity_treatment_function_code
	and apc.HospitalProviderSpellNumber is not null
group by
	apc.GeneratedRecordIdentifier,
	apc.NHSNumber,
	apc.HospitalProviderSpellNumber;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20HospitalProviderSpellNumber%20field%20SUS%20APC%20VisitOccurrenceWithSpell%20mapping){: .btn }
### CDS VisitOccurrenceWithSpell
* Value copied from `HospitalProviderSpellNumber`

* `HospitalProviderSpellNumber` CDS specific hospital spell number that binds many episodes together. [HOSPITAL PROVIDER SPELL NUMBER](https://www.datadictionary.nhs.uk/data_elements/hospital_provider_spell_number.html)

```sql
select
	l1.NHSNumber,
	l5.HospitalProviderSpellNumber,
	min (l5.EpisodeStartDate) as EpisodeStartDate,
	coalesce 
	(
		min (l5.EpisodeStartTime), 
		'000000'
	) as EpisodeStartTime,
	coalesce 
	(
		max (l5.EpisodeEndDate), 
		max (l1.CDSActivityDate)
	) as EpisodeEndDate,
	coalesce 
	(
		max (l5.EpisodeEndTime), 
		'000000'
	) as EpisodeEndTime,
	case 
		when max(l5.AdmissionMethodCode) in ('21','24') and max(l5.PatientClassification) = 1 then 262
        when max(l5.AdmissionMethodCode) in ('21','24') then 9203
        when max(l5.PatientClassification) in (1) then 9201
        when max(l4.LocationClass) in ('02') then 581476
		else 9202
	end as VisitOccurrenceConceptId,    -- "visit_concept_id"
	case 
		when max(l5.EpisodeEndDate) is null and max(l5.DischargeDateHospitalProviderSpell) is null then 32220
        else 32818
	end as VisitTypeConceptId,
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
	and l5.HospitalProviderSpellNumber is not null
group by 
	l1.NHSNumber, 
	l5.HospitalProviderSpellNumber;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20HospitalProviderSpellNumber%20field%20CDS%20VisitOccurrenceWithSpell%20mapping){: .btn }

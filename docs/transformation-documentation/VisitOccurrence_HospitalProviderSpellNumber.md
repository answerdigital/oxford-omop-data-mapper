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
		distinct
		op.NHSNumber,
		op.SUSgeneratedspellID,

		9202 as VisitOccurrenceConceptId,  -- "outpatient visit"
		32818 as VisitTypeConceptId,

		coalesce(op.AppointmentDate, op.CDSActivityDate) as VisitStartDate,  -- visit_start_date
		coalesce(op.AppointmentTime, '000000') as VisitStartTime,  -- visit_start_time
		coalesce(op.AppointmentDate, op.CDSActivityDate) as VisitEndDate,
		null as VisitEndTime,

		op.SourceofReferralForOutpatients as SourceofAdmissionCode

	from omop_staging.sus_OP op
	where op.UpdateType = 9
		and op.NHSNumber is not null

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20HospitalProviderSpellNumber%20field%20SUS%20OP%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS APC VisitOccurrenceWithSpell
* Value copied from `HospitalProviderSpellNumber`

* `HospitalProviderSpellNumber` CDS specific hospital spell number that binds many episodes together. [HOSPITAL PROVIDER SPELL NUMBER](https://www.datadictionary.nhs.uk/data_elements/hospital_provider_spell_number.html)

```sql
	select
		max(apc.NHSNumber) as NHSNumber,
		apc.HospitalProviderSpellNumber,

		9201 as VisitOccurrenceConceptId,  -- "inpatient visit"
		32818 as VisitTypeConceptId,

		coalesce(min(apc.StartDateConsultantEpisode), min(apc.StartDateHospitalProviderSpell), min(apc.CDSActivityDate)) as VisitStartDate,
		coalesce(min(apc.StartTimeEpisode), min(apc.StartTimeHospitalProviderSpell), '000000') as VisitStartTime,
		coalesce(max(apc.EndDateConsultantEpisode), max(apc.DischargeDateFromHospitalProviderSpell), max(apc.CDSActivityDate)) as VisitEndDate,
		coalesce(max(apc.EndTimeEpisode), max(apc.DischargeTimeHospitalProviderSpell), '000000') as VisitEndTime,

		max(apc.SourceOfAdmissionHospitalProviderSpell) as SourceofAdmissionCode,
		max(apc.DischargeDestinationHospitalProviderSpell) as DischargeDestinationCode

	from omop_staging.sus_APC apc
	where apc.NHSNumber is not null
	group by HospitalProviderSpellNumber

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20HospitalProviderSpellNumber%20field%20SUS%20APC%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS AE VisitOccurrenceWithSpell
* Value copied from `AEAttendanceNumber`

* `AEAttendanceNumber` ATTENDANCE IDENTIFIER is a sequential number or time of day used to enable an attendance to be uniquely identified. [ATTENDANCE IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/attendance_identifier.html)

```sql
	select  
		distinct
			ae.NHSNumber,
			ae.AEAttendanceNumber,

			9203 as VisitOccurrenceConceptId,    -- ""Emergency Room Visit""
			32818 as VisitTypeConceptId,

			coalesce(ae.ArrivalDate, ae.CDSActivityDate) as EpisodeStartDate,
			coalesce(ae.ArrivalTime, '000000') as EpisodeStartTime,
			coalesce(ae.AEDepartureDate, ae.AEAttendanceConclusionDate) as EpisodeEndDate,
			coalesce(ae.AEDepartureTime, ae.AEAttendanceConclusionTime, '000000') as EpisodeEndTime,

			ae.AEArrivalMode as SourceofAdmissionCode,
			ae.AEAttendanceDisposal as DischargeDestinationCode

	from omop_staging.sus_AE ae
	where ae.NHSNumber is not null

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20HospitalProviderSpellNumber%20field%20SUS%20AE%20VisitOccurrenceWithSpell%20mapping){: .btn }
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

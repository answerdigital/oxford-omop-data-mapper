---
layout: default
title: visit_end_datetime
parent: VisitOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# visit_end_datetime
### SUS OP VisitOccurrenceWithSpell
Source columns  `VisitEndDate`, `VisitEndTime`.
Combines a date with a time of day.

* `VisitEndDate` The latest episode end date for the spell, or the latest activity date if none are specified. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [END DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/end_date__episode_.html)

* `VisitEndTime` The latest episode end time for the spell, or midnight if none are specified. [END TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/end_time__episode_.html)

```sql
with results as
(
	select
		distinct
			op.NHSNumber,
			op.SUSgeneratedspellID,
			coalesce(op.AppointmentDate, op.CDSActivityDate) as VisitStartDate,  -- visit_start_date
			coalesce(op.AppointmentTime, '000000') as VisitStartTime,  -- visit_start_time
			coalesce(op.AppointmentDate, op.CDSActivityDate) as VisitEndDate,
			null as VisitEndTime
	from omop_staging.sus_OP op
	where op.UpdateType = 9
		and op.NHSNumber is not null
		and AttendedorDidNotAttend in ('5','6')
)
select *
from results
order by 
	NHSNumber,
	SUSgeneratedspellID,
	VisitStartDate, 
	VisitStartTime,
	VisitEndDate,
	VisitEndTime
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_end_datetime%20field%20SUS%20OP%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS APC VisitOccurrenceWithSpell
Source columns  `VisitEndDate`, `VisitEndTime`.
Combines a date with a time of day.

* `VisitEndDate` The latest episode end date for the spell, or the latest activity date if none are specified. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [END DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/end_date__episode_.html)

* `VisitEndTime` The latest episode end time for the spell, or midnight if none are specified. [END TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/end_time__episode_.html)

```sql
	with records as (
		select
			max(apc.NHSNumber) as NHSNumber,
			apc.HospitalProviderSpellNumber,
	
			coalesce(min(apc.StartDateConsultantEpisode), min(apc.StartDateHospitalProviderSpell), min(apc.CDSActivityDate)) as VisitStartDate,
			coalesce(min(apc.StartTimeEpisode), min(apc.StartTimeHospitalProviderSpell), '000000') as VisitStartTime,
			coalesce(max(apc.EndDateConsultantEpisode), max(apc.DischargeDateFromHospitalProviderSpell), max(apc.CDSActivityDate)) as VisitEndDate,
			coalesce(max(apc.EndTimeEpisode), max(apc.DischargeTimeHospitalProviderSpell), '000000') as VisitEndTime,
	
			max(apc.SourceOfAdmissionHospitalProviderSpell) as SourceofAdmissionCode,
			max(apc.DischargeDestinationHospitalProviderSpell) as DischargeDestinationCode
	
		from omop_staging.sus_APC apc
		where apc.NHSNumber is not null
		group by HospitalProviderSpellNumber
	)
	select *
	from records
	order by 
		NHSNumber, 
		HospitalProviderSpellNumber, 
		VisitStartDate, 
		VisitStartTime, 
		VisitEndDate, 
		VisitEndTime, 
		SourceofAdmissionCode, 
		DischargeDestinationCode

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_end_datetime%20field%20SUS%20APC%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS AE VisitOccurrenceWithSpell
Source columns  `VisitEndDate`, `VisitEndTime`.
Combines a date with a time of day.

* `VisitEndDate` The latest episode end date for the spell, or the latest activity date if none are specified. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [END DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/end_date__episode_.html)

* `VisitEndTime` The latest episode end time for the spell, or midnight if none are specified. [END TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/end_time__episode_.html)

```sql
		with records as (
			select  
				distinct
					ae.NHSNumber,
					ae.AEAttendanceNumber,
					coalesce(ae.ArrivalDate, ae.CDSActivityDate) as VisitStartDate,
					coalesce(ae.ArrivalTime, '000000') as VisitStartTime,
					coalesce(ae.AEDepartureDate, ae.AEAttendanceConclusionDate, ae.ArrivalDate, ae.CDSActivityDate) as VisitEndDate,
					coalesce(ae.AEDepartureTime, ae.AEAttendanceConclusionTime, '000000') as VisitEndTime,
					ae.AEArrivalMode as SourceofAdmissionCode,
					ae.AEAttendanceDisposal as DischargeDestinationCode
			from omop_staging.sus_AE ae
			where ae.NHSNumber is not null
		)
		select *
		from records
		order by 
			NHSNumber, 
			AEAttendanceNumber, 
			VisitStartDate, 
			VisitStartTime, 
			VisitEndDate, 
			VisitEndTime, 
			SourceofAdmissionCode, 
			DischargeDestinationCode

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_end_datetime%20field%20SUS%20AE%20VisitOccurrenceWithSpell%20mapping){: .btn }
### Sact VisitOccurrence
Source column  `Administration_date`.
Converts text to dates.

* `Administration_date` Date when drug was administered or date an oral drug was initially dispensed to the patient [SYSTEMIC ANTI-CANCER THERAPY ADMINISTRATION DATE](https://www.datadictionary.nhs.uk/data_elements/systemic_anti-cancer_therapy_administration_date.html)

```sql
		select distinct 
			NHS_Number,
			Administration_Date 
		from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_end_datetime%20field%20Sact%20VisitOccurrence%20mapping){: .btn }
### Rtds VisitOccurrence
Source column  `event_end_date`.
Converts text to dates.

* `event_end_date` Appointment End Time 

```sql
with results as (
	select 
		distinct
			(select top 1 PatientId from omop_staging.rtds_1_demographics b where b.PatientSer = a.PatientSer) as PatientId,
			a.start_date as event_start_date,
			a.end_date as event_end_date
	from omop_staging.rtds_2b_plan a
)
select
	PatientId,
	event_start_date,
	event_end_date
from results
where
  PatientId is not null
  and regexp_matches(PatientId, '\d{10}');

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_end_datetime%20field%20Rtds%20VisitOccurrence%20mapping){: .btn }
### Oxford Visit Occurrence
Source column  `EventDate`.
Converts text to dates.

* `EventDate` Event date 

```sql
select
	GPEventsPrimaryKey,
	d.NHSNumber,
	e.EventDate
from omop_staging.oxford_gp_event e
	inner join omop_staging.oxford_gp_demographic d
		on e.PatientIdentifier = d.PatientIdentifier
order by
	d.NHSNumber,
	e.EventDate
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_end_datetime%20field%20Oxford%20Visit%20Occurrence%20mapping){: .btn }

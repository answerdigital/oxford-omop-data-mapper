---
layout: default
title: visit_start_datetime
parent: VisitOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# visit_start_datetime
### SUS OP VisitOccurrenceWithSpell
Source columns  `VisitStartDate`, `VisitStartTime`.
Combines a date with a time of day.

* `VisitStartDate` Start date of the episode. [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

* `VisitStartTime` The earliest episode start time for the spell, or midnight if none are specified. [START TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_time__episode_.html)

```sql
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
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_start_datetime%20field%20SUS%20OP%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS APC VisitOccurrenceWithSpell
Source columns  `VisitStartDate`, `VisitStartTime`.
Combines a date with a time of day.

* `VisitStartDate` Start date of the episode. [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

* `VisitStartTime` The earliest episode start time for the spell, or midnight if none are specified. [START TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_time__episode_.html)

```sql
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

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_start_datetime%20field%20SUS%20APC%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS AE VisitOccurrenceWithSpell
Source columns  `VisitStartDate`, `VisitStartTime`.
Combines a date with a time of day.

* `VisitStartDate` Start date of the episode. [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

* `VisitStartTime` The earliest episode start time for the spell, or midnight if none are specified. [START TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_time__episode_.html)

```sql
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

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_start_datetime%20field%20SUS%20AE%20VisitOccurrenceWithSpell%20mapping){: .btn }

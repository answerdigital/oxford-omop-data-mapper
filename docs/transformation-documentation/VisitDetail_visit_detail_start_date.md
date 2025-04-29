---
layout: default
title: visit_detail_start_date
parent: VisitDetail
grand_parent: Transformation Documentation
has_toc: false
---
# visit_detail_start_date
### Sus Outpatient VisitDetails
Source column  `VisitStartDate`.
Converts text to dates.

* `VisitStartDate` Start date of the episode, if exists, else the start date of the spell. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html), [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

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
	where op.UpdateType = 9   -- New/Modification     (1 = Delete)
		and op.NHSNumber is not null
		and AttendedorDidNotAttend in ('5','6')

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_date%20field%20Sus%20Outpatient%20VisitDetails%20mapping){: .btn }
### Sus Critical Care VisitDetails
Source column  `VisitStartDate`.
Converts text to dates.

* `VisitStartDate` Start date of the visit [CRITICAL CARE START DATE](https://www.datadictionary.nhs.uk/data_elements/critical_care_start_date.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.HospitalProviderSpellNumber,
				cc.CriticalCareStartDate as VisitStartDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as VisitStartTime,
				coalesce(cc.CriticalCarePeriodDischargeDate, cc.EventDate) as VisitEndDate,
				coalesce(cc.CriticalCarePeriodDischargeTime, '00:00:00') as VisitEndTime
		from omop_staging.sus_CCMDS cc
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_date%20field%20Sus%20Critical%20Care%20VisitDetails%20mapping){: .btn }
### Sus Inptatient VisitDetails
Source column  `VisitStartDate`.
Converts text to dates.

* `VisitStartDate` Start date of the episode, if exists, else the start date of the spell. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html), [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

```sql
	select
		apc.NHSNumber,
		apc.HospitalProviderSpellNumber,

		coalesce(apc.StartDateConsultantEpisode, apc.StartDateHospitalProviderSpell, apc.CDSActivityDate) as VisitStartDate,
		coalesce(apc.StartTimeEpisode, apc.StartTimeHospitalProviderSpell, '000000') as VisitStartTime,
		coalesce(apc.EndDateConsultantEpisode, apc.DischargeDateFromHospitalProviderSpell, apc.CDSActivityDate) as VisitEndDate,
		coalesce(apc.EndTimeEpisode, apc.DischargeTimeHospitalProviderSpell, '000000') as VisitEndTime,

		apc.SourceOfAdmissionHospitalProviderSpell as SourceofAdmissionCode,
		apc.DischargeDestinationHospitalProviderSpell as DischargeDestinationCode

	from omop_staging.sus_APC apc
	where apc.NHSNumber is not null

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_date%20field%20Sus%20Inptatient%20VisitDetails%20mapping){: .btn }
### Sus Inptatient VisitDetails
Source column  `VisitStartDate`.
Converts text to dates.

* `VisitStartDate` Start date of the episode, if exists, else the start date of the spell. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html), [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

```sql
	select  
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_date%20field%20Sus%20Inptatient%20VisitDetails%20mapping){: .btn }

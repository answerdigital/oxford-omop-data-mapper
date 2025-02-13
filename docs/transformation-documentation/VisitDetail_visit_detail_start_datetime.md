---
layout: default
title: visit_detail_start_datetime
parent: VisitDetail
grand_parent: Transformation Documentation
has_toc: false
---
# visit_detail_start_datetime
### Sus Outpatient VisitDetails
Source columns  `VisitStartDate`, `VisitStartTime`.
Combines a date with a time of day.

* `VisitStartDate` Start date of the episode, if exists, else the start date of the spell. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html), [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

* `VisitStartTime` Start time of the episode, if exists, else midnight. [START TIME (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_time__hospital_provider_spell_.html), [START TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_time__episode_.html)

```sql
	select  
		distinct
			op.NHSNumber,
			op.SUSgeneratedspellID,

			coalesce(op.AppointmentDate, op.CDSActivityDate) as VisitStartDate,  -- visit_start_date
			coalesce(op.AppointmentTime, '000000') as VisitStartTime,  -- visit_start_time
			coalesce(op.AppointmentDate, op.CDSActivityDate) as VisitEndDate,
			null as VisitEndTime,

			op.SourceofReferralForOutpatients as SourceofAdmissionCode

	from omop_staging.sus_OP op
	where op.UpdateType = 9   -- New/Modification     (1 = Delete)
		and op.NHSNumber is not null

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_datetime%20field%20Sus%20Outpatient%20VisitDetails%20mapping){: .btn }
### Sus Inptatient VisitDetails
Source columns  `VisitStartDate`, `VisitStartTime`.
Combines a date with a time of day.

* `VisitStartDate` Start date of the episode, if exists, else the start date of the spell. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html), [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

* `VisitStartTime` Start time of the episode, if exists, else midnight. [START TIME (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_time__hospital_provider_spell_.html), [START TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_time__episode_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_datetime%20field%20Sus%20Inptatient%20VisitDetails%20mapping){: .btn }
### Sus Inptatient VisitDetails
Source columns  `VisitStartDate`, `VisitStartTime`.
Combines a date with a time of day.

* `VisitStartDate` Start date of the episode, if exists, else the start date of the spell. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html), [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

* `VisitStartTime` Start time of the episode, if exists, else midnight. [START TIME (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_time__hospital_provider_spell_.html), [START TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_time__episode_.html)

```sql
	select  
		ae.NHSNumber,
		ae.AEAttendanceNumber,

		coalesce(ae.ArrivalDate, ae.CDSActivityDate) as EpisodeStartDate,
		coalesce(ae.ArrivalTime, '000000') as EpisodeStartTime,
		coalesce(ae.AEDepartureDate, ae.AEAttendanceConclusionDate) as EpisodeEndDate,
		coalesce(ae.AEDepartureTime, ae.AEAttendanceConclusionTime, '000000') as EpisodeEndTime,

		ae.AEArrivalMode as SourceofAdmissionCode,
		ae.AEAttendanceDisposal as DischargeDestinationCode

	from omop_staging.sus_AE ae
	where ae.NHSNumber is not null

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_datetime%20field%20Sus%20Inptatient%20VisitDetails%20mapping){: .btn }
### CDS VisitDetails
Source columns  `VisitStartDate`, `VisitStartTime`.
Combines a date with a time of day.

* `VisitStartDate` Start date of the episode, if exists, else the start date of the spell. [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html), [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

* `VisitStartTime` Start time of the episode, if exists, else midnight. [START TIME (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_time__hospital_provider_spell_.html), [START TIME (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_time__episode_.html)

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
), VisitDetail as (
	select  
		distinct
    
			l1.NHSNumber,
			l5.HospitalProviderSpellNumber,

			case 
				when l5.AdmissionMethodCode in ('21','24') and l5.PatientClassification = 1 then 262 
				when l5.AdmissionMethodCode in ('21','24') then 9203
				when l5.PatientClassification in (1) then 9201
				when l4.LocationClass in ('02') then 581476
				else 9202
			end as VisitOccurrenceConceptId,    -- ""visit_concept_id""

			l1.RecordConnectionIdentifier,

			coalesce(l5.EpisodeStartDate, l5.StartDateHospitalProviderSpell, l1.CDSActivityDate) as VisitStartDate,  -- visit_start_date
			coalesce(l5.EpisodeStartTime, l5.StartTimeHospitalProviderSpell, '000000') as VisitStartTime,  -- visit_start_time

			coalesce(l5.EpisodeEndDate, l5.DischargeDateHospitalProviderSpell, l1.CDSActivityDate) as VisitEndDate,

			coalesce(l5.EpisodeEndTime, l5.DischargeTimeHospitalProviderSpell, '000000') as VisitEndTime,

			case 
				when l5.EpisodeEndDate is null and l5.DischargeDateHospitalProviderSpell is null and l5.PatientClassification = 1 then 32220
				else 32818
			end as VisitTypeConceptId,

			case 
				when l5.EpisodeEndDate is null and l5.DischargeDateHospitalProviderSpell is null and l5.PatientClassification = 1 then 2
				else 1
			end as RowPriority,

			l5.SourceofAdmissionCode,
			l5.DischargeDestinationCode
	from [omop_staging].[cds_line01] l1
		left join [omop_staging].[cds_line04] l4 
			on l1.MessageId = l4.MessageId -- Location Details
		left join [omop_staging].[cds_line05] l5 
			on l1.MessageId = l5.MessageId -- Hospital Provider Spell
		inner join dbo.Code c 
			on l1.ActivityTreatmentFunctionCode = c.Code
	where l1.CDSUpdateType = 9   -- New/Modification     (1 = Delete)
		and l1.NHSNumber is not null
		and c.CodeTypeId = 2 -- activity_treatment_function_code
		and not exists (select * from RecordsWithVariableNhsNumber rwvnn where rwvnn.RecordConnectionIdentifier = l1.RecordConnectionIdentifier)
), VisitDetailWithRank as (
	select
		*,
		row_number() over (partition by RecordConnectionIdentifier order by RowPriority asc) as RowRank
	from VisitDetail
)
select
	*
from VisitDetailWithRank
where RowRank = 1
		
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_start_datetime%20field%20CDS%20VisitDetails%20mapping){: .btn }

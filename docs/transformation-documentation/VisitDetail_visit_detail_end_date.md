---
layout: default
title: visit_detail_end_date
parent: VisitDetail
grand_parent: Transformation Documentation
has_toc: false
---
# visit_detail_end_date
### Sus Inptatient VisitDetails
Source column  `VisitEndDate`.
Converts text to dates.

* `VisitEndDate` End date of the episode, if exists, else the spell discharge date, if exists, else the message date. [CDS ACTIVITY DATE](), [END DATE (EPISODE)](), [DISCHARGE DATE (HOSPITAL PROVIDER SPELL)]()

```sql
;with RecordConnectionIdentifierNHSNumberCombination as (
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
),

VisitDetail as (
	select  
		distinct
    
			apc.NHSNumber,
			apc.HospitalProviderSpellNumber,

			case 
				when apc.AdmissionMethodHospitalProviderSpell in ('21','24') and apc.PatientClassification = 1 then 262 
				when apc.AdmissionMethodHospitalProviderSpell in ('21','24') then 9203
				when apc.PatientClassification in (1) then 9201
				when apc.LocationClassAtEpisodeStartDate in ('02') then 581476
				else 9202
			end as VisitOccurrenceConceptId,    -- ""visit_concept_id""

			apc.GeneratedRecordIdentifier,

			coalesce(apc.StartDateHospitalProviderSpell, apc.CDSActivityDate, apc.StartDateConsultantEpisode) as VisitStartDate,  -- visit_start_date
			coalesce(apc.StartTimeEpisode, apc.StartTimeHospitalProviderSpell, '000000') as VisitStartTime,  -- visit_start_time

			coalesce(apc.DischargeDateFromHospitalProviderSpell, apc.CDSActivityDate, apc.EndDateConsultantEpisode) as VisitEndDate,

			coalesce(apc.EndTimeEpisode, apc.DischargeTimeHospitalProviderSpell, '000000') as VisitEndTime,

			case 
				when apc.CDSActivityDate is null and apc.DischargeDateFromHospitalProviderSpell is null and apc.StartDateConsultantEpisode is null and apc.PatientClassification = 1 then 32220
				else 32818
			end as VisitTypeConceptId,

			case 
				when apc.DischargeDateFromHospitalProviderSpell is null and apc.PatientClassification = 1 then 2
				else 1
			end as RowPriority,

			apc.SourceOfAdmissionHospitalProviderSpell,
			apc.DischargeDestinationHospitalProviderSpell
	from omop_staging.sus_APC apc
		inner join dbo.Code c 
			on apc.TreatmentFunctionCode = c.Code
	where apc.UpdateType = 9   -- New/Modification     (1 = Delete)
		and apc.NHSNumber is not null
		and c.CodeTypeId = 2 -- activity_treatment_function_code
		and not exists (select * from RecordsWithVariableNhsNumber rwvnn where rwvnn.GeneratedRecordIdentifier = apc.GeneratedRecordIdentifier)
), VisitDetailWithRank as (
	select
		*,
		row_number() over (partition by GeneratedRecordIdentifier order by RowPriority asc) as RowRank
	from VisitDetail
)
select
	*
from VisitDetailWithRank
where RowRank = 1

		
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_end_date%20field%20Sus%20Inptatient%20VisitDetails%20mapping){: .btn }
### CDS VisitDetails
Source column  `VisitEndDate`.
Converts text to dates.

* `VisitEndDate` End date of the episode, if exists, else the spell discharge date, if exists, else the message date. [CDS ACTIVITY DATE](), [END DATE (EPISODE)](), [DISCHARGE DATE (HOSPITAL PROVIDER SPELL)]()

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20visit_detail_end_date%20field%20CDS%20VisitDetails%20mapping){: .btn }

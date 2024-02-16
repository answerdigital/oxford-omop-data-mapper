# `VisitDetail` `discharged_to_concept_id`
### CDS VisitDetails
Source column  `DischargeDestinationCode`.
Lookup discharge destination concept.


|DischargeDestinationCode|discharged_to_concept_id|notes|
|------|-----|-----|
|19|0|Home - Used 0 as `Home` as per the OHDSI documentation|
|29|8602|Temporary Lodging|
|30|38004284|Psychiatric Hospital|
|37|4050489|County court bailiff - Had to use the Social Context Domain and SNOMED Vocab|
|38|38003619|Prison / Correctional Facility - Went with `Prison / Correctional Facility` over Police Station (4107305)|
|48|38004284|Psychiatric Hospital|
|49|38004284|Psychiatric Hospital|
|50|8971|Inpatient Psychiatric Facility|
|51|8717|Inpatient Hospital|
|52|8650|Birthing Center|
|53|8976|Psychiatric Residential Treatment Center|
|54|8676|Nursing Facility|
|65|8676|Nursing Facility|
|66|38004205|Foster Care Agency|
|79||No mapping possible|
|84|8971|Inpatient Psychiatric Facility|
|85|8676|Nursing Facility|
|87|8717|Inpatient Hospital|
|88|8546|Hospice|
|98||No mapping possible|
|99||No mapping possible|

Notes
* [Discharge Destination](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)
* `DischargeDestinationCode` [Discharge Destination Code](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20discharged_to_concept_id%20field%20CDS%20VisitDetails%20mapping)

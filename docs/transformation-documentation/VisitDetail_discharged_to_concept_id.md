---
layout: default
title: discharged_to_concept_id
parent: VisitDetail
grand_parent: Transformation Documentation
has_toc: false
---
# discharged_to_concept_id
### Sus Inptatient VisitDetails
Source column  `DischargeDestinationCode`.
Lookup discharge destination concept.


|DischargeDestinationCode|discharged_to_concept_id|notes|
|------|-----|-----|
|01|8717|In Patient Hospital|
|02|581476|Home Visit|
|03|38004693|Clinic or Group Practice|
|04|8870|Emergency Room - Hospital|
|05|8870|Emergency Room - Hospital|
|06|8756|Out Patient Hospital|
|07||No mapping possible|
|10||No mapping possible|
|11||No mapping possible|
|12||No mapping possible|
|13||No mapping possible|
|14||No mapping possible|
|19|581476|Home Visit|
|29|8602|Temporary Lodging|
|30|38004284|Psychiatric Hospital|
|37|38003619|Prison / Correctional Facility|
|38|38003619|Prison / Correctional Facility|
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
* [Discharge Destination A&E](https://archive.datadictionary.nhs.uk/DD%20Release%20September%202020/data_elements/accident_and_emergency_attendance_disposal_code.html)

* `DischargeDestinationCode` Discharge Destination Code [DISCHARGE DESTINATION CODE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20discharged_to_concept_id%20field%20Sus%20Inptatient%20VisitDetails%20mapping){: .btn }
### Sus Inptatient VisitDetails
Source column  `DischargeDestinationCode`.
Lookup discharge destination concept.


|DischargeDestinationCode|discharged_to_concept_id|notes|
|------|-----|-----|
|01|8717|In Patient Hospital|
|02|581476|Home Visit|
|03|38004693|Clinic or Group Practice|
|04|8870|Emergency Room - Hospital|
|05|8870|Emergency Room - Hospital|
|06|8756|Out Patient Hospital|
|07||No mapping possible|
|10||No mapping possible|
|11||No mapping possible|
|12||No mapping possible|
|13||No mapping possible|
|14||No mapping possible|
|19|581476|Home Visit|
|29|8602|Temporary Lodging|
|30|38004284|Psychiatric Hospital|
|37|38003619|Prison / Correctional Facility|
|38|38003619|Prison / Correctional Facility|
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
* [Discharge Destination A&E](https://archive.datadictionary.nhs.uk/DD%20Release%20September%202020/data_elements/accident_and_emergency_attendance_disposal_code.html)

* `DischargeDestinationCode` Discharge Destination Code [DISCHARGE DESTINATION CODE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20discharged_to_concept_id%20field%20Sus%20Inptatient%20VisitDetails%20mapping){: .btn }
### CDS VisitDetails
Source column  `DischargeDestinationCode`.
Lookup discharge destination concept.


|DischargeDestinationCode|discharged_to_concept_id|notes|
|------|-----|-----|
|01|8717|In Patient Hospital|
|02|581476|Home Visit|
|03|38004693|Clinic or Group Practice|
|04|8870|Emergency Room - Hospital|
|05|8870|Emergency Room - Hospital|
|06|8756|Out Patient Hospital|
|07||No mapping possible|
|10||No mapping possible|
|11||No mapping possible|
|12||No mapping possible|
|13||No mapping possible|
|14||No mapping possible|
|19|581476|Home Visit|
|29|8602|Temporary Lodging|
|30|38004284|Psychiatric Hospital|
|37|38003619|Prison / Correctional Facility|
|38|38003619|Prison / Correctional Facility|
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
* [Discharge Destination A&E](https://archive.datadictionary.nhs.uk/DD%20Release%20September%202020/data_elements/accident_and_emergency_attendance_disposal_code.html)

* `DischargeDestinationCode` Discharge Destination Code [DISCHARGE DESTINATION CODE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20discharged_to_concept_id%20field%20CDS%20VisitDetails%20mapping){: .btn }

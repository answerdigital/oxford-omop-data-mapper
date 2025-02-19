---
layout: default
title: discharged_to_concept_id
parent: VisitOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# discharged_to_concept_id
### SUS APC VisitOccurrenceWithSpell
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20discharged_to_concept_id%20field%20SUS%20APC%20VisitOccurrenceWithSpell%20mapping){: .btn }
### SUS AE VisitOccurrenceWithSpell
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
		distinct
			ae.NHSNumber,
			ae.AEAttendanceNumber,

			coalesce(ae.ArrivalDate, ae.CDSActivityDate) as VisitStartDate,
			coalesce(ae.ArrivalTime, '000000') as VisitStartTime,
			coalesce(ae.AEDepartureDate, ae.AEAttendanceConclusionDate) as VisitEndDate,
			coalesce(ae.AEDepartureTime, ae.AEAttendanceConclusionTime, '000000') as VisitEndTime,

			ae.AEArrivalMode as SourceofAdmissionCode,
			ae.AEAttendanceDisposal as DischargeDestinationCode

	from omop_staging.sus_AE ae
	where ae.NHSNumber is not null

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20discharged_to_concept_id%20field%20SUS%20AE%20VisitOccurrenceWithSpell%20mapping){: .btn }
### CDS VisitOccurrenceWithSpell
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20discharged_to_concept_id%20field%20CDS%20VisitOccurrenceWithSpell%20mapping){: .btn }
### CDS VisitOccurrenceWithoutSpell
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20discharged_to_concept_id%20field%20CDS%20VisitOccurrenceWithoutSpell%20mapping){: .btn }

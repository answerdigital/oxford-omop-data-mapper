---
layout: default
title: death_datetime
parent: Death
grand_parent: Transformation Documentation
has_toc: false
---
# death_datetime
### SUS Inpatient Death
Source columns  `death_date`, `death_time`.
Combines a date with a time of day.

* `death_date` Discharge date of the patient's spell. [DISCHARGE DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/discharge_date__hospital_provider_spell_.html)

* `death_time` Discharge time of the patient's spell. [DISCHARGE TIME (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/discharge_time__hospital_provider_spell_.html)

```sql
;with primarydiagnosis as (
	select *
	from omop_staging.sus_ICDDiagnosis
	where IsPrimaryDiagnosis = 1
)

select
	apc.NHSNumber as nhs_number,
	max(apc.DischargeDateFromHospitalProviderSpell) as death_date,
	max(apc.DischargeTimeHospitalProviderSpell) as death_time,
	max(d.DiagnosisICD) as DiagnosisICD
from omop_staging.sus_APC apc
	left join primarydiagnosis d
		on apc.MessageId = d.MessageId
where
	apc.NHSNumber is not null and
	apc.DischargeDateFromHospitalProviderSpell is not null and
	apc.DischargeMethodHospitalProviderSpell = '4' -- "Patient died"

group by apc.NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Death%20table%20death_datetime%20field%20SUS%20Inpatient%20Death%20mapping){: .btn }
### COSD v9 DeathDischargeDestination
* Value copied from `DeathDate`

* `DeathDate` The date on which a PERSON died or is officially deemed to have died. [DISCHARGE DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/discharge_date__hospital_provider_spell_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD901:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
)
select
	distinct
		Node.value('(*/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		coalesce
		(
			Node.value('(/*/Treatment/DischargeDateHospitalProviderSpell)[1]', 'varchar(max)'),
			datefromparts
			(
				year(convert(datetime, Node.value('(/*/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)'))),
				12,
				31
			)
		) as DeathDate
from CosdRecords
where Node.value('(/*/Treatment/DischargeDestinationHospitalProviderSpell/@code)[1]', 'varchar(max)') = 79 -- Not applicable - PATIENT died or stillbirth
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Death%20table%20death_datetime%20field%20COSD%20v9%20DeathDischargeDestination%20mapping){: .btn }
### COSD v9 BasisOfDiagnosisCancer
* Value copied from `DeathDate`

* `DeathDate` The date on which a PERSON died or is officially deemed to have died. [MULTIDISCIPLINARY TEAM DISCUSSION DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/multidisciplinary_team_discussion_date__cancer_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD901:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
), CosdDates as (
	select 
		convert(varchar(max), Node.value('(*/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)')) as NhsNumber,
		convert(datetime, Node.value('(/*/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)')) as TreatmentStartDateCancer,
		convert(datetime, Node.value('(/*/CancerCarePlan/MultidisciplinaryTeamDiscussionDateCancer)[1]', 'varchar(max)')) as MultidisciplinaryTeamDiscussionDateCancer,
		convert(datetime, Node.value('(/*/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)')) as StageDateFinalPretreatmentStage,
		convert(datetime, Node.value('(/*/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)')) as DateOfPrimaryDiagnosisClinicallyAgreed
	from CosdRecords
	where Node.value('(//BasisOfDiagnosisCancer/@code)[1]', 'int') in (0, 1)
), Dates as (
	select
		NhsNumber,
		TreatmentStartDateCancer as [Date]
	from CosdDates

	union 

	select
		NhsNumber,
		MultidisciplinaryTeamDiscussionDateCancer as [Date]
	from CosdDates

	union 

	select
		NhsNumber,
		StageDateFinalPretreatmentStage as [Date]
	from CosdDates

	union 

	select
		NhsNumber,
		DateOfPrimaryDiagnosisClinicallyAgreed as [Date]
	from CosdDates
)
select
	NhsNumber,
	datefromparts(year(max ([Date])), 12, 31) as DeathDate
from Dates
group by NhsNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Death%20table%20death_datetime%20field%20COSD%20v9%20BasisOfDiagnosisCancer%20mapping){: .btn }
### COSD v8 Death
Source column  `DeathDate`.
Converts text to dates.

* `DeathDate` The date on which a PERSON died or is officially deemed to have died. [PERSON DEATH DATE](https://www.datadictionary.nhs.uk/data_elements/person_death_date.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
	CosdRecords as ( 
	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node -- Select the first inner element of the element that is not called Id.
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
		--and substring (FileName, 15, 2) = 'CO'
)
select 
	distinct
		Node.value('(//NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(//PersonDeathDate)[1]', 'varchar(max)') as DeathDate
from CosdRecords
where Node.value('(//PersonDeathDate)[1]', 'varchar(max)') is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Death%20table%20death_datetime%20field%20COSD%20v8%20Death%20mapping){: .btn }

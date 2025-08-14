---
layout: default
title: day_of_birth
parent: Person
grand_parent: Transformation Documentation
has_toc: false
---
# day_of_birth
### SUS Outpatient Person
Source column  `DateOfBirth`.
Selects the day of the month or null if the date is null.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)

```sql
	select
		NHSNumber,
		max(DateofBirth) as DateOfBirth,
		max(EthnicCategory) as EthnicCategory,
		max(Sex) as PersonCurrentGenderCode
	from [omop_staging].[sus_OP]
	where NHSNumber is not null
	group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20day_of_birth%20field%20SUS%20Outpatient%20Person%20mapping){: .btn }
### SUS Inpatient Person
Source column  `DateOfBirth`.
Selects the day of the month or null if the date is null.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)

```sql
	select
		NHSNumber,
		max(DateofBirth) as DateOfBirth,
		max(EthnicGroup) as EthnicCategory,
		max(Sex) as PersonCurrentGenderCode
	from omop_staging.sus_APC
	where NHSNumber is not null
	group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20day_of_birth%20field%20SUS%20Inpatient%20Person%20mapping){: .btn }
### SUS A&E Person
Source column  `DateOfBirth`.
Selects the day of the month or null if the date is null.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)

```sql
	select
		NHSNumber,
		max(DateofBirth) as DateOfBirth,
		max(EthnicCategory) as EthnicCategory,
		max(Sex) as PersonCurrentGenderCode
	from omop_staging.sus_AE
	where NHSNumber is not null
	group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20day_of_birth%20field%20SUS%20A&E%20Person%20mapping){: .btn }
### SACT Person
Source column  `Date_Of_Birth`.
Selects the day of the month or null if the date is null.

* `Date_Of_Birth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)

```sql
	select
		NHS_Number,
		max (Date_Of_Birth) as Date_Of_Birth,
		max (Person_Stated_Gender_Code) as Person_Stated_Gender_Code
	from omop_staging.sact_staging
	group by NHS_Number
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20day_of_birth%20field%20SACT%20Person%20mapping){: .btn }
### Rtds Person
Source column  `DateOfBirth`.
Selects the day of the month or null if the date is null.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)

```sql
select
	PatientId,
	max (DateOfBirth) as DateOfBirth,
	max (Sex) as Sex
from omop_staging.RTDS_1_Demographics d
where PatientId is not null
group by PatientId
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20day_of_birth%20field%20Rtds%20Person%20mapping){: .btn }
### Oxford GP Person
Source column  `DOB`.
Selects the day of the month or null if the date is null.

* `DOB` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)

```sql
select
	distinct
		NHSNumber,
		DOB
from omop_staging.oxford_gp_demographic
order by
	NHSNumber,
	DOB
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20day_of_birth%20field%20Oxford%20GP%20Person%20mapping){: .btn }
### COSD Demographics
Source column  `DateOfBirth`.
Selects the day of the month or null if the date is null.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)

```sql
with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD81, 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node, -- Select the first inner element of the element that is not called Id.
		convert(bit, 1) as Is81
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD81:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
	union all
	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node,
		convert(bit, 0) as Is81
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD901:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
), COSDElements as (
	select
		Id,
		Node.query('(*[1]/*[fn:contains (fn:local-name(.), "LinkagePatientId")])[1]') as LinkagePatient,
		Node.query('(*[1]/*[fn:contains (fn:local-name(.), "Demographics")])[1]') as Demographics,
		Is81
	from CosdRecords
), Patients as (
	select
		LinkagePatient.value('(*/*[local-name() = "NHSNumber" or local-name() = "NhsNumber"]/@extension)[1]', 'varchar(max)') as NhsNumber,
		LinkagePatient.value('(*/*[local-name() = "PersonBirthDate" or local-name() = "Birthdate"])[1]', 'varchar(max)') as DateOfBirth,
		Demographics.value('(*/EthnicCategory/@code)[1]', 'varchar(max)') as EthnicCategory,
		Demographics.value('(*/Address/StructuredAddress/*[local-name() = "StreetAddressLine" or local-name() = "streetAddressLine"][1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
		Demographics.value('(*/Address/StructuredAddress/*[local-name() = "StreetAddressLine" or local-name() = "streetAddressLine"][2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
		Demographics.value('(*/Address/StructuredAddress/*[local-name() = "StreetAddressLine" or local-name() = "streetAddressLine"][3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
		Demographics.value('(*/Address/StructuredAddress/*[local-name() = "StreetAddressLine" or local-name() = "streetAddressLine"][4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
		case when Is81 = 1 then Demographics.value('(*/Postcode/postalCode)[1]', 'varchar(max)') else Demographics.value('(*/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') end as Postcode
	from COSDElements
)
select
	NhsNumber,
	max (DateOfBirth) as DateOfBirth,
	max (EthnicCategory) as EthnicCategory,
	max (StreetAddressLine1) as StreetAddressLine1,
	max (StreetAddressLine2) as StreetAddressLine2,
	max (StreetAddressLine3) as StreetAddressLine3,
	max (StreetAddressLine4) as StreetAddressLine4,
	max (Postcode) as Postcode
from Patients 
where NhsNumber != ''
group by NhsNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20day_of_birth%20field%20COSD%20Demographics%20mapping){: .btn }

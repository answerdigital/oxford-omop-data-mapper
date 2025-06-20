---
layout: default
title: location_source_value
parent: Location
grand_parent: Transformation Documentation
has_toc: false
---
# location_source_value
### SUS Outpatient Location
* Value copied from `Postcode`

* `Postcode` Patient Postcode [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)

```sql
	select
		distinct
			Postcode,
			Country,
			NHSNumber
	from [omop_staging].[sus_OP]
	where NHSNumber is not null
		and Postcode is not null
		and AttendedorDidNotAttend in ('5','6')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20location_source_value%20field%20SUS%20Outpatient%20Location%20mapping){: .btn }
### SUS Inpatient Location
* Value copied from `Postcode`

* `Postcode` Patient Postcode [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)

```sql
select
	distinct
		Postcode,
		NHSNumber
from omop_staging.sus_APC
where Postcode is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20location_source_value%20field%20SUS%20Inpatient%20Location%20mapping){: .btn }
### SUS A&E Location
* Value copied from `Postcode`

* `Postcode` Patient Postcode [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)

```sql
select
	distinct
		Postcode,
		NHSNumber
from omop_staging.sus_AE
where Postcode is not null
and NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20location_source_value%20field%20SUS%20A&E%20Location%20mapping){: .btn }
### SACT Location
* Value copied from `Patient_Postcode`

* `Patient_Postcode` Patient's Postcode. [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)

```sql
select
	NHS_Number,
	max (Patient_Postcode) as Patient_Postcode,
	max (Date_Of_Birth) as Date_Of_Birth
from omop_staging.sact_staging
group by NHS_Number
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20location_source_value%20field%20SACT%20Location%20mapping){: .btn }
### Rtds PAS Location
* Value copied from `FirstOfNHSNUMBER`

* `FirstOfNHSNUMBER` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select
	distinct
		p.FirstOfNHSNUMBER,
		p.FirstOfPOSTCODE
from omop_staging.RTDS_PASDATA p
where p.FirstOfPOSTCODE is not null
	and p.FirstOfNHSNUMBER is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20location_source_value%20field%20Rtds%20PAS%20Location%20mapping){: .btn }
### Oxford GP Location
* Value copied from `Postcode`

* `Postcode` Patient Postcode [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)

```sql
select
	distinct
		NHSNumber,
		Postcode
from omop_staging.oxford_gp_demographic
where Postcode is not null
order by
	NHSNumber,
	Postcode
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20location_source_value%20field%20Oxford%20GP%20Location%20mapping){: .btn }
### COSD Demographics
Source columns  `StreetAddressLine1`, `StreetAddressLine2`, `StreetAddressLine3`, `StreetAddressLine4`, `Postcode`.
Separates text with newlines. Trim whitespace.

* `StreetAddressLine1` The first line of the address. [PATIENT USUAL ADDRESS (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/patient_usual_address__at_diagnosis_.html)

* `StreetAddressLine2` The second line of the address. [PATIENT USUAL ADDRESS (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/patient_usual_address__at_diagnosis_.html)

* `StreetAddressLine3` The third line of the address. [PATIENT USUAL ADDRESS (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/patient_usual_address__at_diagnosis_.html)

* `StreetAddressLine4` The fourth line of the address. [PATIENT USUAL ADDRESS (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/patient_usual_address__at_diagnosis_.html)

* `Postcode` Patient Postcode [POSTCODE OF USUAL ADDRESS (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/postcode_of_usual_address__at_diagnosis_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20location_source_value%20field%20COSD%20Demographics%20mapping){: .btn }

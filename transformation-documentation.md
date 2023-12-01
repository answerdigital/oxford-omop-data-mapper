`Automatically generated documentation`

# Location
## address_1
### COSD Demographics
Value copied from `StreetAddressLine1`
* `StreetAddressLine1` The first element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from cosd_staging
cross apply content.nodes('*:COSD/*') as T(staging)
)
select
	StreetAddressLine1,
	StreetAddressLine2,
	StreetAddressLine3,
	StreetAddressLine4,
	PostcodeOfUsualAddressAtDiagnosis,
	NhsNumber,
	PersonBirthDate
from Demographics
where 
	NhsNumber is not null 
	or 
	(
		StreetAddressLine1 is not null or 
		StreetAddressLine2 is not null or 
		StreetAddressLine3 is not null or 
		StreetAddressLine4 is not null or 
		PostcodeOfUsualAddressAtDiagnosis is not null
	);
	
```
</details>

## address_2
### COSD Demographics
Value copied from `StreetAddressLine2`
* `StreetAddressLine2` The second element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from cosd_staging
cross apply content.nodes('*:COSD/*') as T(staging)
)
select
	StreetAddressLine1,
	StreetAddressLine2,
	StreetAddressLine3,
	StreetAddressLine4,
	PostcodeOfUsualAddressAtDiagnosis,
	NhsNumber,
	PersonBirthDate
from Demographics
where 
	NhsNumber is not null 
	or 
	(
		StreetAddressLine1 is not null or 
		StreetAddressLine2 is not null or 
		StreetAddressLine3 is not null or 
		StreetAddressLine4 is not null or 
		PostcodeOfUsualAddressAtDiagnosis is not null
	);
	
```
</details>

## city
### COSD Demographics
Value copied from `StreetAddressLine3`
* `StreetAddressLine3` The third element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from cosd_staging
cross apply content.nodes('*:COSD/*') as T(staging)
)
select
	StreetAddressLine1,
	StreetAddressLine2,
	StreetAddressLine3,
	StreetAddressLine4,
	PostcodeOfUsualAddressAtDiagnosis,
	NhsNumber,
	PersonBirthDate
from Demographics
where 
	NhsNumber is not null 
	or 
	(
		StreetAddressLine1 is not null or 
		StreetAddressLine2 is not null or 
		StreetAddressLine3 is not null or 
		StreetAddressLine4 is not null or 
		PostcodeOfUsualAddressAtDiagnosis is not null
	);
	
```
</details>

## county
### COSD Demographics
Value copied from `StreetAddressLine4`
* `StreetAddressLine4` The fourth and final element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from cosd_staging
cross apply content.nodes('*:COSD/*') as T(staging)
)
select
	StreetAddressLine1,
	StreetAddressLine2,
	StreetAddressLine3,
	StreetAddressLine4,
	PostcodeOfUsualAddressAtDiagnosis,
	NhsNumber,
	PersonBirthDate
from Demographics
where 
	NhsNumber is not null 
	or 
	(
		StreetAddressLine1 is not null or 
		StreetAddressLine2 is not null or 
		StreetAddressLine3 is not null or 
		StreetAddressLine4 is not null or 
		PostcodeOfUsualAddressAtDiagnosis is not null
	);
	
```
</details>

## zip
### COSD Demographics
Value copied from `PostcodeOfUsualAddressAtDiagnosis`
* `PostcodeOfUsualAddressAtDiagnosis` The value of the PostcodeOfUsualAddressAtDiagnosis element within the Demographics element.
<details>
<summary>SQL</summary>

```
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from cosd_staging
cross apply content.nodes('*:COSD/*') as T(staging)
)
select
	StreetAddressLine1,
	StreetAddressLine2,
	StreetAddressLine3,
	StreetAddressLine4,
	PostcodeOfUsualAddressAtDiagnosis,
	NhsNumber,
	PersonBirthDate
from Demographics
where 
	NhsNumber is not null 
	or 
	(
		StreetAddressLine1 is not null or 
		StreetAddressLine2 is not null or 
		StreetAddressLine3 is not null or 
		StreetAddressLine4 is not null or 
		PostcodeOfUsualAddressAtDiagnosis is not null
	);
	
```
</details>

## location_source_value
### COSD Demographics
Source columns  `StreetAddressLine1`, `StreetAddressLine2`, `StreetAddressLine3`, `StreetAddressLine4`, `PostcodeOfUsualAddressAtDiagnosis`.
Deliminate text with newlines.
* `StreetAddressLine1` The first element of the StructuredAddress element, within the Demographics element.
* `StreetAddressLine2` The second element of the StructuredAddress element, within the Demographics element.
* `StreetAddressLine3` The third element of the StructuredAddress element, within the Demographics element.
* `StreetAddressLine4` The fourth and final element of the StructuredAddress element, within the Demographics element.
* `PostcodeOfUsualAddressAtDiagnosis` The value of the PostcodeOfUsualAddressAtDiagnosis element within the Demographics element.
<details>
<summary>SQL</summary>

```
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from cosd_staging
cross apply content.nodes('*:COSD/*') as T(staging)
)
select
	StreetAddressLine1,
	StreetAddressLine2,
	StreetAddressLine3,
	StreetAddressLine4,
	PostcodeOfUsualAddressAtDiagnosis,
	NhsNumber,
	PersonBirthDate
from Demographics
where 
	NhsNumber is not null 
	or 
	(
		StreetAddressLine1 is not null or 
		StreetAddressLine2 is not null or 
		StreetAddressLine3 is not null or 
		StreetAddressLine4 is not null or 
		PostcodeOfUsualAddressAtDiagnosis is not null
	);
	
```
</details>


`Automatically generated documentation`

# Location
## address_1
### COSD Demographics
Source column  `StreetAddressLine1`.
Convert text to uppercase. Trim whitespace.
* `StreetAddressLine1` The first element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```sql
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from omop_staging.cosd_staging
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

### CDS Structured Address
Source columns  `PatientAddressStructured1`, `PatientAddressStructured2`.
Separates text with newlines.
## address_2
### COSD Demographics
Source column  `StreetAddressLine2`.
Convert text to uppercase. Trim whitespace.
* `StreetAddressLine2` The second element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```sql
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from omop_staging.cosd_staging
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

### CDS Structured Address
* Value copied from `PatientAddressStructured3`
## city
### COSD Demographics
Source column  `StreetAddressLine3`.
Convert text to uppercase. Trim whitespace.
* `StreetAddressLine3` The third element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```sql
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from omop_staging.cosd_staging
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

### CDS Structured Address
* Value copied from `PatientAddressStructured4`
## county
### COSD Demographics
Source column  `StreetAddressLine4`.
Convert text to uppercase. Trim whitespace.
* `StreetAddressLine4` The fourth and final element of the StructuredAddress element, within the Demographics element.
<details>
<summary>SQL</summary>

```sql
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from omop_staging.cosd_staging
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

### CDS Structured Address
* Value copied from `PatientAddressStructured5`
## location_source_value
### SACT
* Value copied from `Patient_Postcode`
### COSD Demographics
Source columns  `StreetAddressLine1`, `StreetAddressLine2`, `StreetAddressLine3`, `StreetAddressLine4`, `PostcodeOfUsualAddressAtDiagnosis`.
Separates text with newlines.
* `StreetAddressLine1` The first element of the StructuredAddress element, within the Demographics element.
* `StreetAddressLine2` The second element of the StructuredAddress element, within the Demographics element.
* `StreetAddressLine3` The third element of the StructuredAddress element, within the Demographics element.
* `StreetAddressLine4` The fourth and final element of the StructuredAddress element, within the Demographics element.
* `PostcodeOfUsualAddressAtDiagnosis` The value of the PostcodeOfUsualAddressAtDiagnosis element within the Demographics element.
<details>
<summary>SQL</summary>

```sql
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from omop_staging.cosd_staging
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

### CDS UnstructuredAddress
* Value copied from `Postcode`
* `Postcode` Postcode
<details>
<summary>SQL</summary>

```sql
select
	PatientAddressStructured1,
	PatientAddressStructured2,
	PatientAddressStructured3,
	PatientAddressStructured4,
	PatientAddressStructured5,
	Postcode,
	NHSNumber
from omop_staging.cds_line01
where PatientAddressType = '02'
	and 
	(
		PatientAddressStructured1 is not null or 
		PatientAddressStructured2 is not null or 
		PatientAddressStructured3 is not null or 
		PatientAddressStructured4 is not null or 
		PatientAddressStructured5 is not null or 
		Postcode is not null
	)
	and NHSNumber is not null;
	
```
</details>

### CDS Structured Address
Source columns  `PatientAddressStructured1`, `PatientAddressStructured2`, `PatientAddressStructured3`, `PatientAddressStructured4`, `PatientAddressStructured5`, `Postcode`.
Separates text with newlines.
* `Postcode` Postcode
<details>
<summary>SQL</summary>

```sql
select
	NHSNumber,
	PatientUnstructuredAddress,
	Postcode
from omop_staging.cds_line01
where PatientAddressType = '01'
	and Postcode is not null
	and NHSNumber is not null;
	
```
</details>

## zip
### SACT
Source column  `Patient_Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
### COSD Demographics
Source column  `PostcodeOfUsualAddressAtDiagnosis`.
Uppercase the postcode then insert the space in the correct location, if needed.
* `PostcodeOfUsualAddressAtDiagnosis` The value of the PostcodeOfUsualAddressAtDiagnosis element within the Demographics element.
<details>
<summary>SQL</summary>

```sql
with Demographics as (
select
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[1]/text())[1]', 'VARCHAR(255)') as StreetAddressLine1,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[2]/text())[1]', 'VARCHAR(255)') as StreetAddressLine2,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[3]/text())[1]', 'VARCHAR(255)') as StreetAddressLine3,
	T.staging.value('(Demographics/Address/StructuredAddress/StreetAddressLine[4]/text())[1]', 'VARCHAR(255)') as StreetAddressLine4,
	T.staging.value('(Demographics/PostcodeOfUsualAddressAtDiagnosis/text())[1]', 'VARCHAR(10)') as PostcodeOfUsualAddressAtDiagnosis,
	T.staging.value('(LinkagePatientId/NhsNumber/@extension)[1]', 'VARCHAR(255)') as NhsNumber,
	T.staging.value('(LinkagePatientId/PersonBirthDate/text())[1]', 'VARCHAR(10)') as PersonBirthDate
from omop_staging.cosd_staging
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

### CDS UnstructuredAddress
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
* `Postcode` Postcode
<details>
<summary>SQL</summary>

```sql
select
	PatientAddressStructured1,
	PatientAddressStructured2,
	PatientAddressStructured3,
	PatientAddressStructured4,
	PatientAddressStructured5,
	Postcode,
	NHSNumber
from omop_staging.cds_line01
where PatientAddressType = '02'
	and 
	(
		PatientAddressStructured1 is not null or 
		PatientAddressStructured2 is not null or 
		PatientAddressStructured3 is not null or 
		PatientAddressStructured4 is not null or 
		PatientAddressStructured5 is not null or 
		Postcode is not null
	)
	and NHSNumber is not null;
	
```
</details>

### CDS Structured Address
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
* `Postcode` Postcode
<details>
<summary>SQL</summary>

```sql
select
	NHSNumber,
	PatientUnstructuredAddress,
	Postcode
from omop_staging.cds_line01
where PatientAddressType = '01'
	and Postcode is not null
	and NHSNumber is not null;
	
```
</details>

# Person
## birth_datetime
### CDS Person
Source column  `DateOfBirth`.
Converts text to dates.
* `DateOfBirth` Patient DateOfBirth
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## day_of_birth
### CDS Person
Source column  `DateOfBirth`.
Selects the day of the month or null if the date is null.
* `DateOfBirth` Patient DateOfBirth
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## gender_concept_id
### CDS Person


|before|after|notes|
|------|-----|-----|
|1|8507||
|2|8532||
|9|8551||
|X|8551||

Notes
* [NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)
* [OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)
* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [Data Dictionary](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## gender_source_value
### CDS Person
* Value copied from `PersonCurrentGenderCode`
* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [Data Dictionary](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## month_of_birth
### CDS Person
Source column  `DateOfBirth`.
Selects the month of the year or null if the date is null.
* `DateOfBirth` Patient DateOfBirth
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## person_source_value
### CDS Person
* Value copied from `NHSNumber`
* `NHSNumber` Patient NHS Number
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## race_concept_id
### CDS Person


|before|after|notes|
|------|-----|-----|
|A|8527|White - British|
|B|8527|White - Irish|
|C|8527|White - Any other White background|
|D|0|Mixed - White and Black Caribbean|
|E|0|Mixed - White and Black African|
|F|0|Mixed - White and Asian|
|G|0|Mixed - Any other mixed background|
|H|38003574|Asian or Asian British - Indian|
|J|38003589|Asian or Asian British - Pakistani|
|K|38003575|Asian or Asian British - Bangladeshi|
|L|8515|Asian or Asian British - Any other Asian background|
|M|38003598|Black or Black British - Caribbean|
|N|38003600|Black or Black British - African|
|P|38003598|Black or Black British - Any other Black background|
|R|38003579|Other Ethnic Groups - Chinese|
|S|0|Other Ethnic Groups - Any other ethnic group|
|Z|0|Not stated|
|99|0|Not known|

Notes
* [NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)
* [OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)
* `EthnicCategory` Patient EthnicCategory [Data Dictionary](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## race_source_concept_id
### CDS Person


|before|after|notes|
|------|-----|-----|
|A|700385|White - British|
|B|700386|White - Irish|
|C|700387|White - Any other White background|
|D|700388|Mixed - White and Black Caribbean|
|E|700389|Mixed - White and Black African|
|F|700390|Mixed - White and Asian|
|G|700391|Mixed - Any other mixed background|
|H|700362|Asian or Asian British - Indian|
|J|700363|Asian or Asian British - Pakistani|
|K|700364|Asian or Asian British - Bangladeshi|
|L|700365|Asian or Asian British - Any other Asian background|
|M|700366|Black or Black British - Caribbean|
|N|700367|Black or Black British - African|
|P|700368|Black or Black British - Any other Black background|
|R|700369|Other Ethnic Groups - Chinese|
|S||Other Ethnic Groups - Any other ethnic group|
|Z||Not stated|
|99||Not known|

Notes
* [NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)
* [OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)
* `EthnicCategory` Patient EthnicCategory [Data Dictionary](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## race_source_value
### CDS Person
* Value copied from `EthnicCategory`
* `EthnicCategory` Patient EthnicCategory [Data Dictionary](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>

## year_of_birth
### CDS Person
Source column  `DateOfBirth`.
Selects the year from a date or null of the date is null.
* `DateOfBirth` Patient DateOfBirth
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>


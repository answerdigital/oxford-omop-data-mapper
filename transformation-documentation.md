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
	Postcode
from cds_line01
where PatientAddressType = '02'
	and 
	(
		PatientAddressStructured1 is not null or 
		PatientAddressStructured2 is not null or 
		PatientAddressStructured3 is not null or 
		PatientAddressStructured4 is not null or 
		PatientAddressStructured5 is not null or 
		Postcode is not null
	);
	
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
	PatientUnstructuredAddress,
	Postcode
from cds_line01
where PatientAddressType = '01'
	and Postcode is not null;
	
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
	Postcode
from cds_line01
where PatientAddressType = '02'
	and 
	(
		PatientAddressStructured1 is not null or 
		PatientAddressStructured2 is not null or 
		PatientAddressStructured3 is not null or 
		PatientAddressStructured4 is not null or 
		PatientAddressStructured5 is not null or 
		Postcode is not null
	);
	
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
	PatientUnstructuredAddress,
	Postcode
from cds_line01
where PatientAddressType = '01'
	and Postcode is not null;
	
```
</details>


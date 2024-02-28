# `Person` `birth_datetime`
### SACT
Source column  `Date_Of_Birth`.
Converts text to dates.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20birth_datetime%20field%20SACT%20mapping)
### Rtds Demographics
Source column  `DateOfBirth`.
Converts text to dates.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct 
		d.PatientId,
		d.DateOfBirth,
		d.Sex
from omop_staging.RTDS_1_Demographics d
where d.PatientId not like '%[^0-9]%'
	and len(d.PatientId) = 10
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20birth_datetime%20field%20Rtds%20Demographics%20mapping)
### COSD Demographics
Source column  `DateOfBirth`.
Converts text to dates.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20birth_datetime%20field%20COSD%20Demographics%20mapping)
### CDS Person
Source column  `DateOfBirth`.
Converts text to dates.

* `DateOfBirth` Patient's date of birth. [PERSON BIRTH DATE](https://www.datadictionary.nhs.uk/data_elements/person_birth_date.html)
<details>
<summary>SQL</summary>

```sql
select
	NHSNumber,
	max(DateofBirth) as DateOfBirth,
	max(EthnicCategory) as EthnicCategory,
	max(PersonCurrentGenderCode) as PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null
group by NHSNumber
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20birth_datetime%20field%20CDS%20Person%20mapping)

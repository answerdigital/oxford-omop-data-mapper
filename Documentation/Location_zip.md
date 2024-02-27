# `Location` `zip`
### SACT
Source column  `Patient_Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20SACT%20mapping)
### Rtds PAS Location
Source column  `FirstOfPOSTCODE`.
Uppercase the postcode then insert the space in the correct location, if needed.

* `FirstOfPOSTCODE` Patient's Postcode. [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct
		p.FirstOfNHSNUMBER,
		p.FirstOfPOSTCODE
from omop_staging.RTDS_PASDATA p
where p.FirstOfPOSTCODE is not null
	and p.FirstOfNHSNUMBER is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20Rtds%20PAS%20Location%20mapping)
### COSD Demographics
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.

* `Postcode` Patient Postcode [POSTCODE OF USUAL ADDRESS (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/postcode_of_usual_address__at_diagnosis_.html)
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
	distinct
		NhsNumber,
		DateOfBirth,
		EthnicCategory,
		StreetAddressLine1,
		StreetAddressLine2,
		StreetAddressLine3,
		StreetAddressLine4,
		Postcode
from Patients 
where NhsNumber != '';
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20COSD%20Demographics%20mapping)
### CDS Structured Address
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.

* `Postcode` Patient's Postcode. [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)
<details>
<summary>SQL</summary>

```sql
		select
		distinct
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
		);
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20CDS%20Structured%20Address%20mapping)
### CDS UnstructuredAddress
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.

* `Postcode` Patient's Postcode. [POSTCODE](https://www.datadictionary.nhs.uk/data_elements/postcode.html)
<details>
<summary>SQL</summary>

```sql
		select
		distinct
		PatientUnstructuredAddress,
		Postcode,
		NHSNumber
		from omop_staging.cds_line01
		where PatientAddressType = '01'
		and Postcode is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20CDS%20UnstructuredAddress%20mapping)

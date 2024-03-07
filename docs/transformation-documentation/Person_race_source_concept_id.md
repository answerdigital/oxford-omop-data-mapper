---
layout: default
title: race_source_concept_id
parent: Person
grand_parent: Transformation Documentation
has_toc: false
---
# race_source_concept_id
### COSD Demographics
Source column  `EthnicCategory`.
Lookup race source concept.


|EthnicCategory|race_source_concept_id|notes|
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

* `EthnicCategory` Patient EthnicCategory [ETHNIC CATEGORY]()

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20race_source_concept_id%20field%20COSD%20Demographics%20mapping){: .btn }
### CDS Person
Source column  `EthnicCategory`.
Lookup race source concept.


|EthnicCategory|race_source_concept_id|notes|
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

* `EthnicCategory` Patient EthnicCategory [ETHNIC CATEGORY]()

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20race_source_concept_id%20field%20CDS%20Person%20mapping){: .btn }

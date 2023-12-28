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


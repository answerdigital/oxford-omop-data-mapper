# `Person` `gender_source_value`
### SACT
* Value copied from `Person_Stated_Gender_Code`

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_source_value%20field%20mapping)
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_source_value%20field%20mapping)

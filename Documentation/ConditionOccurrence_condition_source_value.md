# `ConditionOccurrence` `condition_source_value`
### CDS Condition Occurrence
* Value copied from `DiagnosisCode`
* `DiagnosisCode` ICD10 diagnosis code
<details>
<summary>SQL</summary>

```sql
select
	distinct
		d.DiagnosisCode,
		line01.RecordConnectionIdentifier,
		line01.NHSNumber,
		line01.CDSActivityDate
from omop_staging.cds_diagnosis d
	inner join omop_staging.cds_line01 line01
		on d.MessageId = line01.MessageId
where line01.NHSNumber is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_value%20field%20CDS%20Condition%20Occurrence%20mapping)

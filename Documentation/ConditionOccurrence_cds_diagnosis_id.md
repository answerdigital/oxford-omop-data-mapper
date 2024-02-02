# `ConditionOccurrence` `cds_diagnosis_id`
### CDS Condition Occurrence
* Value copied from `DiagnosisId`
* `DiagnosisId` Cds DiagnosisId
<details>
<summary>SQL</summary>

```sql
select
	distinct
		d.DiagnosisCode,
		d.DiagnosisId,
		line01.NHSNumber,
		line01.CDSActivityDate
from omop_staging.cds_diagnosis d
	inner join omop_staging.cds_line01 line01
		on d.MessageId = line01.MessageId
where line01.NHSNumber is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20cds_diagnosis_id%20field%20mapping)

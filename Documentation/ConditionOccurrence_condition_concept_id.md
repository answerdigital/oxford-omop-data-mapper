# `ConditionOccurrence` `condition_concept_id`
### CDS Condition Occurrence
Source column  `DiagnosisCode`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.
* `DiagnosisCode` ICD10 diagnosis code
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


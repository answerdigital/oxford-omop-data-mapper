# `ProcedureOccurrence` `procedure_datetime`
### CDS Procedure Occurrence
Source columns  `PrimaryProcedureDate`, `ProcedureTime`.
Combines a date with a time of day.
* `PrimaryProcedureDate` Procedure Date
<details>
<summary>SQL</summary>

```sql
select
	distinct
		l1.RecordConnectionIdentifier,
		l1.NHSNumber,
		p.PrimaryProcedureDate,
		'000000' as ProcedureTime,
		p.PrimaryProcedure
from omop_staging.cds_line01 l1
	inner join omop_staging.cds_procedure p
		on l1.MessageId = p.MessageId
where l1.NHSNumber is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20CDS%20Procedure%20Occurrence%20mapping)
---
layout: default
title: procedure_source_concept_id
parent: ProcedureOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# procedure_source_concept_id
### CDS Procedure Occurrence
Source column  `PrimaryProcedure`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `PrimaryProcedure` OPC4 Procedure code. [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

```sql
select
	distinct
		l1.RecordConnectionIdentifier,
		l1.NHSNumber,
		p.PrimaryProcedureDate,
		p.PrimaryProcedure
from omop_staging.cds_line01 l1
	inner join omop_staging.cds_procedure p
		on l1.MessageId = p.MessageId
where l1.NHSNumber is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20CDS%20Procedure%20Occurrence%20mapping){: .btn }
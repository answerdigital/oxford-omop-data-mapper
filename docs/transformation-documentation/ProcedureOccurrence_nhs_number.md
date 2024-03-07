---
layout: default
title: nhs_number
parent: ProcedureOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# nhs_number
### CDS Procedure Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER]()

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20nhs_number%20field%20CDS%20Procedure%20Occurrence%20mapping){: .btn }

---
layout: default
title: condition_start_date
parent: ConditionOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# condition_start_date
### CDS Condition Occurrence
Source column  `CDSActivityDate`.
Converts text to dates.

* `CDSActivityDate` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_start_date%20field%20CDS%20Condition%20Occurrence%20mapping){: .btn }

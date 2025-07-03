---
layout: default
title: RecordConnectionIdentifier
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# RecordConnectionIdentifier
### Oxford Prescribing Drug Exposure
* Value copied from `WAREHOUSE_IDENTIFIER`

* `WAREHOUSE_IDENTIFIER` Unique identifier 

```sql
select
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	lower(replace(catalog, 'zzz', '')) as catalog,
	lower(order_mnemonic) as order_mnemonic,
	order_detail_display_line,
	lower(rxroute) as rxroute,
	strengthdoseunit,
	strengthdose,
	WAREHOUSE_IDENTIFIER
from omop_staging.oxford_prescribing
where concept_identifier is null
order by
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	catalog,
	order_mnemonic,
	order_detail_display_line,
	rxroute,
	strengthdoseunit,
	strengthdose,
	WAREHOUSE_IDENTIFIER
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20RecordConnectionIdentifier%20field%20Oxford%20Prescribing%20Drug%20Exposure%20mapping){: .btn }

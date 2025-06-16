---
layout: default
title: route_source_value
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# route_source_value
### Oxford Prescribing Drug Exposure
* Value copied from `rxroute`

* `rxroute` The route of drug administration 

```sql
select
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	order_mnemonic,
	order_detail_display_line,
	rxroute,
	strengthdoseunit,
	strengthdose
from omop_staging.oxford_prescribing
order by
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	order_mnemonic,
	order_detail_display_line,
	rxroute,
	strengthdoseunit,
	strengthdose
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20route_source_value%20field%20Oxford%20Prescribing%20Drug%20Exposure%20mapping){: .btn }

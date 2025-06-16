---
layout: default
title: sig
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# sig
### Oxford Prescribing Drug Exposure
* Value copied from `order_detail_display_line`

* `order_detail_display_line` All the prescribed drug item details as shown in the order screen as selected by the clinician 

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20sig%20field%20Oxford%20Prescribing%20Drug%20Exposure%20mapping){: .btn }

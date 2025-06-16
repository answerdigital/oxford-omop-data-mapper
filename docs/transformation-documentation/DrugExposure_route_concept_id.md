---
layout: default
title: route_concept_id
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# route_concept_id
### Oxford Prescribing Drug Exposure
Source column  `rxroute`.
Prescribing Drug Routes to OMOP Condition Concept IDs


|rxroute|route_concept_id|notes|
|------|-----|-----|
|affected eye(s)|40549429|Ocular|
|anal|4290759|Rectal|
|bath|4263689|Topical|
|both ears|4023156|Otic|
|both eyes|40549429|Ocular|
|buccal|4181897|Buccal|
|caudal|4220455|Caudal|
|chewed|4132161|Oral|
|dental|4163765|Dental|
|endotracheal|40491832|Transtracheal|
|enteral feed|4167540|Enteral|
|epidural|4225555|Epidural|
|flush|||
|gastrojejunostomy|4133177|Jejunostomy|
|gastrostomy|4132254|Gastrostomy|
|gingival|4156704|Gingival|
|handihaler|40486069|Respiratory tract|
|inhalation|40486069|Respiratory tract|
|intraArterial|4240824|Intra-arterial|
|intraArticular|4006860|Intra-articular|
|intraBiliary|4223965|Intrabiliary|
|intraCameral|4303409|Intracameral|
|intraCardiac|4156705|Intracardiac|
|intraCavernosal|37174549|Intracorporus cavernosum|
|intraDermal|4156706|Intradermal|
|intraDISCal|4163769|Intradiscal|
|intraLesional|4157758|Intralesional|
|intraLymphatic|4157759|Intralymphatic|
|intraMuscular|4302612|Intramuscular|
|intraMyometrial|4168038|Intramyometrial|
|intraOcular|4157760|Intraocular|
|intraOsseous|4213522|Intraosseous|
|intraPeritoneal|4243022|Intraperitoneal|
|intraPleural|4156707|Intrapleural|
|intraThecal|4217202|Intrathecal|
|intraTracheal|4229543|Intratracheal|
|intraUrethral|4305382|Transurethral|
|intraUterine|4269621|Intrauterine|
|intraVenous|4171047|Intravenous|
|intraVenous (central)|4170113|Intravenous central|
|intraVentricular|4222259|Intraventricular route - cardiac|
|intraVesical|4186838|Intravesical|
|intravITeal|4302785|intraVitreal|
|intraVitreal|4302785|Intravitreal|
|irrigation|||
|jejunostomy|4133177|Jejunostomy|
|left ear|4023156|Otic|
|left eye|40549429|Ocular|
|line lock|||
|local infiltration|37397638|Infiltrationr|
|nasal|4262914|Nasal|
|nasogastric|4132711|Nasogastric|
|nasojejunal|4305834|Nasojejunal|
|nebulised inhalation|40486069|Respiratory tract|
|oral|4132161|Oral|
|orogastric|4303795|Orogastric|
|orojejunal|4133177|jejunostomy|
|oromucosal|4186839|Oromucosal|
|paravertebral|4170267|Paravertebral|
|patient-controlled epidural analgesia|4225555|Epidural|
|patient-controlled intravenous analgesia|4171047|Intravenous|
|per rectum|4290759|Rectal|
|regional analgesia|||
|right ear|4023156|Otic|
|right eye|40549429|Ocular|
|rinse|4263689|Topical|
|soak|4263689|Topical|
|soap|4263689|Topical|
|subconjunctival|4163770|Subconjunctival|
|subcutaneous|4142048|Subcutaneous|
|subdermal|4142048|Subcutaneous|
|sublingual|4292110|Sublingual|
|topical|4263689|Topical|
|transdermal|4262099|Transdermal|
|transUrethral|4305382|Transurethral|
|vaginal|4057765|Vaginal|
|via CVVHD|||

Notes
* [OMOP Routes](https://athena.ohdsi.org/search-terms/terms?domain=Route&standardConcept=Standard&page=1&pageSize=500&query=&boosts

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20route_concept_id%20field%20Oxford%20Prescribing%20Drug%20Exposure%20mapping){: .btn }

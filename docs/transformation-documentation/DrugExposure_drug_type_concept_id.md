---
layout: default
title: drug_type_concept_id
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# drug_type_concept_id
### CDS Drug Exposure
* Value copied from `DrugTypeConceptId`

* `DrugTypeConceptId` If the patient was discharged `32818` otherwise `32220`. [END DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/end_date__episode_.html), [DISCHARGE DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/discharge_date__hospital_provider_spell_.html)

```sql
select
	distinct
		l1.RecordConnectionIdentifier,
		l1.NHSNumber as nhs_number,
		drugs.Code as DrugSourceValue,
		coalesce(l5.EpisodeStartDate, l5.StartDateHospitalProviderSpell, l1.CDSActivityDate) as ExposureStartDate,  
		coalesce(l5.EpisodeEndDate, l5.DischargeDateHospitalProviderSpell, l1.CDSActivityDate) as ExposureEndDate,
		case 
			when l5.EpisodeEndDate is null and l5.DischargeDateHospitalProviderSpell is null then 32220
			else 32818
		end as DrugTypeConceptId
from [omop_staging].[cds_line01] l1
	inner join [omop_staging].[cds_high_cost_drugs] drugs
		on l1.MessageId = drugs.MessageId
	inner join [omop_staging].[cds_line04] l4 
		on l4.MessageId = l1.MessageId
	left join [omop_staging].[cds_line05] l5 
		on l5.MessageId = l1.MessageId
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20drug_type_concept_id%20field%20CDS%20Drug%20Exposure%20mapping){: .btn }

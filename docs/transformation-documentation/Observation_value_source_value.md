---
layout: default
title: value_source_value
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# value_source_value
### SACT Adjunctive Therapy Type
* Value copied from `Source_value`

* `Source_value` Source value of the type of Adjunctive Therapy  given to a PATIENT  during a Cancer Care Spell. [ADJUNCTIVE THERAPY TYPE](https://www.datadictionary.nhs.uk/data_elements/adjunctive_therapy_type.html)

```sql
		select distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
			Adjunctive_Therapy,
			Case 
				When Adjunctive_Therapy = 1 then concat(Adjunctive_Therapy, ' - Adjuvant Therapy')
				When Adjunctive_Therapy = 2 then concat(Adjunctive_Therapy, ' - Neoadjuvant Therapy')
				When Intent_Of_Treatment = 3 then concat(Adjunctive_Therapy, ' - Not Applicable (Primary Treatment)')
				When Intent_Of_Treatment = 9 then concat(Adjunctive_Therapy, ' - Not Known (Not Recorded)')
			else '' end as Source_value,
		  	Administration_Date
		from omop_staging.sact_staging
  		where Adjunctive_Therapy != ''
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20SACT%20Adjunctive%20Therapy%20Type%20mapping){: .btn }
### SACT Administration Route
* Value copied from `Administration_Route`

* `Administration_Route` The prescribed route of administration for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle. [SYSTEMIC ANTI-CANCER THERAPY DRUG ROUTE OF ADMINISTRATION](https://www.datadictionary.nhs.uk/data_elements/systemic_anti-cancer_therapy_drug_route_of_administration.html)

```sql
		select
		distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
      		SACT_Administration_Route as Administration_Route,
		  	Administration_Date
	from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20SACT%20Administration%20Route%20mapping){: .btn }
### SACT Treatment Intent
* Value copied from `Source_value`

* `Source_value` Source value of the intent of the Systemic Anti-Cancer Therapy Drug Regimen. [SYSTEMIC ANTI-CANCER THERAPY DRUG REGIMEN TREATMENT INTENT](https://www.datadictionary.nhs.uk/data_elements/systemic_anti-cancer_therapy_drug_regimen_treatment_intent.html)

```sql
		select distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
			Intent_Of_Treatment,
			Case 
				When Intent_Of_Treatment = 1 then concat(Intent_Of_Treatment, ' - Curative(aiming to permanently eradicate disease)')
				When Intent_Of_Treatment = 2 then concat(Intent_Of_Treatment, ' - Palliative(aiming to extend life expectancy)')
				When Intent_Of_Treatment = 3 then concat(Intent_Of_Treatment, ' - Palliative(aiming to relieve and/or control malignancy related symptoms)')
				When Intent_Of_Treatment = 4 then concat(Intent_Of_Treatment, ' - Palliative(aiming to achieve remission)')
				When Intent_Of_Treatment = 5 then concat(Intent_Of_Treatment, ' - Palliative(aiming to permanently eradicate disease)')
			else '' end as Source_value,
		  	Administration_Date
		from omop_staging.sact_staging
        where Intent_Of_Treatment != ''
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20SACT%20Treatment%20Intent%20mapping){: .btn }
### RTDS External Beam Radiation Therapy Energy
* Value copied from `NominalEnergy`

* `NominalEnergy` RADIOTHERAPY PRESCRIBED BEAM ENERGY  is the prescribed beam energy of a Radiotherapy Exposure used in External Beam Radiotherapy [RADIOTHERAPY PRESCRIBED BEAM ENERGY](https://www.datadictionary.nhs.uk/data_elements/radiotherapy_prescribed_beam_energy.html)

```sql
		with results as (
			select distinct
			(select PatientId from omop_staging.rtds_1_demographics d where d.PatientSer = PatientSer limit 1) as NhsNumber,
			Treatmentdatetime,
			Cast(NominalEnergy as double) / 1000 as CalculatedNominalEnergy,
			NominalEnergy as NominalEnergy
		from omop_staging.RTDS_4_Exposures
		)
		select
			NhsNumber,
			Treatmentdatetime,
			CalculatedNominalEnergy,
			NominalEnergy
		from results
		where
			NhsNumber is not null
			and regexp_matches(NhsNumber, '\d{10}');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20RTDS%20External%20Beam%20Radiation%20Therapy%20Energy%20mapping){: .btn }
### RTDS Number Of Fractions
* Value copied from `NoFracs`

* `NoFracs` The prescribed number of Radiotherapy Fractions delivered to a PATIENT as described in the Radiotherapy Plan [RADIOTHERAPY PRESCRIBED FRACTIONS](https://www.datadictionary.nhs.uk/data_elements/radiotherapy_prescribed_fractions.html)

```sql
		with results as (
			select distinct
				(select PatientId from omop_staging.rtds_1_demographics d where d.PatientSer = PatientSer limit 1) as NhsNumber,
				StartDateTime,
				NoFracs 
			from omop_staging.RTDS_3_Prescription
		)
		select
			NhsNumber,
			StartDateTime,
			NoFracs
		from results
		where
			NhsNumber is not null
			and regexp_matches(NhsNumber, '\d{10}');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20RTDS%20Number%20Of%20Fractions%20mapping){: .btn }
### RTDS Treatment Anatomical Site
* Value copied from `AttributeValue`

* `AttributeValue` ANATOMIC SITE OF RADIOTHERAPY PROCEDURE 

```sql
		with results as (
			select distinct
				(select PatientId from omop_staging.rtds_1_demographics d where d.PatientSer = PatientSer limit 1) as NHSNumber,
				AttributeValue,
				(select concept_id from cdm.concept where domain_id = 'Spec Anatomic Site'
						and concept_code = CASE WHEN length(code) > 3 THEN substr(code, 1, 3) || '.' || substr(code, 4) ELSE code END) as AnatomicalSiteConceptId,
				DueDateTime
			from omop_staging.RTDS_2b_Plan,
			LATERAL (SELECT regexp_extract(AttributeValue, '^([A-Z][0-9A-Z]+)', 1) AS code) AS t
			where Description = 'Anatomical Site' 
			and AttributeValue is not null 
			and AttributeValue != 'None'
		)
		select
			NhsNumber,
			AttributeValue,
			AnatomicalSiteConceptId,
			DueDateTime
		from results
		where
			NhsNumber is not null
			and regexp_matches(NhsNumber, '\d{10}');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20RTDS%20Treatment%20Anatomical%20Site%20mapping){: .btn }

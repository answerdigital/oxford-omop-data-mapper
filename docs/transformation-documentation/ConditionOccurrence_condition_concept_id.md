---
layout: default
title: condition_concept_id
parent: ConditionOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# condition_concept_id
### SUS Inpatient Condition Occurrence
Source column  `condition_source_concept_id`.
Maps concepts to standard valid concepts in the `condition` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis
Source column  `condition_source_concept_id`.
Maps concepts to standard valid concepts in the `condition` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis Histology Topography
Source columns  `CancerHistology`, `CancerTopography`.
Resolve ICD-o-3 codes to OMOP concepts.

* `CancerHistology` MORPHOLOGY (ICD-O CANCER TRANSFORMATION) is the morphology code of the Cancer Transformation using the ICD-O CODE. [MORPHOLOGY (ICD-O CANCER TRANSFORMATION)](https://www.datadictionary.nhs.uk/data_elements/morphology__icd-o_cancer_transformation_.html)

* `CancerTopography` TOPOGRAPHY (ICD-O) is the topographical site of the Tumour using the ICD-O CODE. [TOPOGRAPHY (ICD-O)](https://www.datadictionary.nhs.uk/data_elements/topography__icd-o_.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 
    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node -- Select the first inner element of the element that is not called Id.
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select 
        Id,
        Node,
        Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as DiagnosisDate,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as NonPrimaryDiagnosisDate,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/MorphologyICDODiagnosis/@code)[1]', 'varchar(max)') as CancerHistology,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/TopographyICDO/@code)[1]', 'varchar(max)') as CancerTopography,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/BasisOfCancerDiagnosis/@code)[1]', 'varchar(max)') as BasisOfDiagnosisCancer,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/PrimaryDiagnosis/@code)[1]', 'varchar(max)') as CancerDiagnosis
	from CosdRecords        
)
select 
	distinct
		NhsNumber,
		coalesce (DiagnosisDate, NonPrimaryDiagnosisDate) as DiagnosisDate,
		BasisOfDiagnosisCancer,
		CancerHistology,
		CancerTopography
from CO
where NhsNumber is not null and
	(
		DiagnosisDate is not null or 
		NonPrimaryDiagnosisDate is not null
	)
	and (CancerHistology is not null and CancerTopography is not null)
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
Source column  `condition_source_concept_id`.
Maps concepts to standard valid concepts in the `condition` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
Source column  `condition_source_concept_id`.
Maps concepts to standard valid concepts in the `condition` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Progression
Source column  `condition_source_concept_id`.
Maps concepts to standard valid concepts in the `condition` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Progression%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis
Source column  `condition_source_concept_id`.
Maps concepts to standard valid concepts in the `condition` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis Histology Topography
Source columns  `CancerHistology`, `CancerTopography`.
Resolve ICD-o-3 codes to OMOP concepts.

* `CancerHistology` MORPHOLOGY (ICD-O CANCER TRANSFORMATION) is the morphology code of the Cancer Transformation using the ICD-O CODE. [MORPHOLOGY (ICD-O CANCER TRANSFORMATION)](https://www.datadictionary.nhs.uk/data_elements/morphology__icd-o_cancer_transformation_.html)

* `CancerTopography` TOPOGRAPHY (ICD-O) is the topographical site of the Tumour using the ICD-O CODE. [TOPOGRAPHY (ICD-O)](https://www.datadictionary.nhs.uk/data_elements/topography__icd-o_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
		Id,
		Node,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/MorphologyIcd-o-3/@code)[1]', 'varchar(max)') as CancerHistology,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/TopographyIcd-o-3/@code)[1]', 'varchar(max)') as CancerTopography,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/BasisOfDiagnosisCancer/@code)[1]', 'varchar(max)') as BasisOfDiagnosisCancer,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/PrimaryDiagnosisIcd/@code)[1]', 'varchar(max)') as CancerDiagnosis
	from CosdRecords
)
select
	distinct
		NhsNumber,
		DateOfPrimaryDiagnosisClinicallyAgreed,
		BasisOfDiagnosisCancer,
		CancerHistology,
		CancerTopography
from CO
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
	and CancerHistology is not null
	and CancerTopography is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### CDS Condition Occurrence
Source column  `condition_source_concept_id`.
Maps concepts to standard valid concepts in the `condition` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_concept_id%20field%20CDS%20Condition%20Occurrence%20mapping){: .btn }

---
layout: default
title: condition_source_concept_id
parent: ConditionOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# condition_source_concept_id
### SUS Inpatient Condition Occurrence
Source column  `DiagnosisICD`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `DiagnosisICD` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)]()

```sql
		select
		distinct
		d.DiagnosisICD,
		apc.GeneratedRecordIdentifier,
		apc.NHSNumber,
		apc.CDSActivityDate
		from omop_staging.sus_ICDDiagnosis d
		inner join omop_staging.sus_APC apc
		on d.MessageId = apc.MessageId
		where apc.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis
Source column  `CancerDiagnosis`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `CancerDiagnosis` PRIMARY DIAGNOSIS (ICD) is the International Classification of Diseases (ICD) code used to identify the PRIMARY DIAGNOSIS. [PRIMARY DIAGNOSIS (ICD)]()

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
		CancerDiagnosis
from CO
where NhsNumber is not null and
	(
		DiagnosisDate is not null or 
		NonPrimaryDiagnosisDate is not null
	);
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis Histology Topography
Source columns  `CancerHistology`, `CancerTopography`.
Resolve ICD-o-3 codes to OMOP concepts.

* `CancerHistology` MORPHOLOGY (ICD-O CANCER TRANSFORMATION) is the morphology code of the Cancer Transformation using the ICD-O CODE. [MORPHOLOGY (ICD-O CANCER TRANSFORMATION)]()

* `CancerTopography` TOPOGRAPHY (ICD-O) is the topographical site of the Tumour using the ICD-O CODE. [TOPOGRAPHY (ICD-O)]()

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
Source column  `SecondaryDiagnosis`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `SecondaryDiagnosis` SECONDARY DIAGNOSIS (ICD) is the International Classification of Diseases (ICD) code used to identify the secondary PATIENT DIAGNOSIS. [SECONDARY DIAGNOSIS (ICD)]()

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
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/DiagnosisAdditionalItems/SecondaryDiagnosisIcd/@code)[1]', 'varchar(max)') as SecondaryDiagnosis
	from CosdRecords
)
select
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	max (SecondaryDiagnosis) as SecondaryDiagnosis
from CO
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
	and SecondaryDiagnosis is not null
group by NhsNumber, DateOfPrimaryDiagnosisClinicallyAgreed;

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
Source column  `NonPrimaryRecurrenceOriginalDiagnosis`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `NonPrimaryRecurrenceOriginalDiagnosis` PRIMARY DIAGNOSIS (ICD ORIGINAL) is the International Classification of Diseases (ICD) code used to identify the original PRIMARY DIAGNOSIS. [PRIMARY DIAGNOSIS (ICD ORIGINAL)]()

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
		Node.value('(ColorectalRecord/NonPrimaryPathway/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/NonPrimaryPathway/Recurrence/OriginalPrimaryDiagnosisIcd/@code)[1]', 'varchar(max)') as NonPrimaryRecurrenceOriginalDiagnosis
	from CosdRecords
)
select 
	distinct 
        NhsNumber,
        DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
		NonPrimaryRecurrenceOriginalDiagnosis
from CO
where NonPrimaryRecurrenceOriginalDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Progression
Source column  `NonPrimaryProgressionOriginalDiagnosis`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `NonPrimaryProgressionOriginalDiagnosis` CANCER PROGRESSION (ICD ORIGINAL) is the International Classification of Diseases (ICD) code of the original PATIENT DIAGNOSIS of the Cancer Progression. [CANCER PROGRESSION (ICD ORIGINAL)]()

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
		Node.value('(ColorectalRecord/NonPrimaryPathway/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as NonPrimaryDiagnosisDate,
		Node.value('(ColorectalRecord/NonPrimaryPathway/Progression/ProgressionIcd/@code)[1]', 'varchar(max)') as NonPrimaryProgressionOriginalDiagnosis
	from CosdRecords
)
select 
	distinct 
        NhsNumber,
        NonPrimaryDiagnosisDate,
		NonPrimaryProgressionOriginalDiagnosis
from CO
where NonPrimaryProgressionOriginalDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Progression%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis
Source column  `CancerDiagnosis`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `CancerDiagnosis` The basis of how a PATIENT DIAGNOSIS relating to cancer was identified. [BASIS OF DIAGNOSIS (CANCER)]()

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
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	max(BasisOfDiagnosisCancer) as BasisOfDiagnosisCancer,
	CancerDiagnosis
from CO
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
group by NhsNumber, DateOfPrimaryDiagnosisClinicallyAgreed, CancerDiagnosis;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis Histology Topography
Source columns  `CancerHistology`, `CancerTopography`.
Resolve ICD-o-3 codes to OMOP concepts.

* `CancerHistology` MORPHOLOGY (ICD-O CANCER TRANSFORMATION) is the morphology code of the Cancer Transformation using the ICD-O CODE. [MORPHOLOGY (ICD-O CANCER TRANSFORMATION)]()

* `CancerTopography` TOPOGRAPHY (ICD-O) is the topographical site of the Tumour using the ICD-O CODE. [TOPOGRAPHY (ICD-O)]()

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### CDS Condition Occurrence
Source column  `DiagnosisCode`.
Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `DiagnosisCode` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](), [SECONDARY DIAGNOSIS (ICD)]()

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20CDS%20Condition%20Occurrence%20mapping){: .btn }

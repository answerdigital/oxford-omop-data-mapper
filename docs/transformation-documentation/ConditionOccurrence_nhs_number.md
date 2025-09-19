---
layout: default
title: nhs_number
parent: ConditionOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# nhs_number
### SUS Outpatient Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
	select
		distinct
			d.DiagnosisICD,
			op.GeneratedRecordIdentifier,
			op.NHSNumber,
			op.CDSActivityDate
	from omop_staging.sus_OP_ICDDiagnosis d
		inner join omop_staging.sus_OP op
			on d.MessageId = op.MessageId
	where op.NHSNumber is not null
		and AttendedorDidNotAttend in ('5','6')
	order by
		d.DiagnosisICD,
		op.GeneratedRecordIdentifier,
		op.NHSNumber,
		op.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SUS%20Outpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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
		order by 
			d.DiagnosisICD, 
			apc.GeneratedRecordIdentifier,
			apc.NHSNumber,
			apc.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
	select
		distinct
			d.AccidentAndEmergencyDiagnosis,
			ae.GeneratedRecordIdentifier,
			ae.NHSNumber,
			ae.CDSActivityDate
	from omop_staging.sus_AE_diagnosis d
		inner join omop_staging.sus_AE ae
			on d.MessageId = ae.MessageId
	where ae.NHSNumber is not null
	order by
		d.AccidentAndEmergencyDiagnosis,
		ae.GeneratedRecordIdentifier,
		ae.NHSNumber,
		ae.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### SACT Condition Occurrence
* Value copied from `NHS_Number`

* `NHS_Number` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
	select
		Primary_Diagnosis,
		replace(NHS_Number, ' ', '') as NHS_Number,
		min(Administration_Date) as Administration_Date
	from omop_staging.sact_staging
	group by
		Primary_Diagnosis,
		NHS_Number
	order by
		NHS_Number,
		Primary_Diagnosis,
		min(Administration_Date)
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SACT%20Condition%20Occurrence%20mapping){: .btn }
### Rtds Condition Occurrence
* Value copied from `PatientId`

* `PatientId` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
with results as (
	select 
		distinct
			(select top 1 PatientId from omop_staging.rtds_1_demographics d where d.PatientSer = dc.PatientSer) as PatientId,
			dc.DiagnosisCode,
			dc.DateStamp as event_start_date,
			dc.DateStamp as event_end_date
	from omop_staging.RTDS_5_Diagnosis_Course dc
	where dc.DiagnosisTableName = 'ICD-10'
)
select
	PatientId,
	DiagnosisCode,
	event_start_date,
	event_end_date
from results
where
    PatientId is not null
    and patientid not like '%[^0-9]%';
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Rtds%20Condition%20Occurrence%20mapping){: .btn }
### Oxford Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select
	distinct
		d.NHSNumber,
		e.EventDate,
		e.SuppliedCode
from omop_staging.oxford_gp_event e
	inner join omop_staging.oxford_gp_demographic d
		on e.PatientIdentifier = d.PatientIdentifier
order by
	d.NHSNumber,
	e.EventDate,
	e.SuppliedCode
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Oxford%20Condition%20Occurrence%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis Histology Topography
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Progression
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Progression%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis Histology Topography
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }

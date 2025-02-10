---
layout: default
title: procedure_source_concept_id
parent: ProcedureOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# procedure_source_concept_id
### SUS Outpatient Procedure Occurrence
Source column  `PrimaryProcedure`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `PrimaryProcedure` OPC4 Procedure code. [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

```sql
		select
		distinct
		op.GeneratedRecordIdentifier,
		op.NHSNumber,
		op.AppointmentDate,
		op.AppointmentTime,
		p.ProcedureOPCS as PrimaryProcedure
		from omop_staging.sus_OP op
		inner join omop_staging.sus_OP_OPCSProcedure p
		on op.MessageId = p.MessageId
		where NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20SUS%20Outpatient%20Procedure%20Occurrence%20mapping){: .btn }
### SUS APC Procedure Occurrence
Source column  `PrimaryProcedure`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `PrimaryProcedure` OPC4 Procedure code. [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

```sql
select
	distinct
		apc.GeneratedRecordIdentifier,
		apc.NHSNumber,
		p.ProcedureDateOPCS as PrimaryProcedureDate,
		p.ProcedureOPCS as PrimaryProcedure
from omop_staging.sus_APC apc
	inner join omop_staging.sus_OPCSProcedure p
		on apc.MessageId = p.MessageId
where NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20SUS%20APC%20Procedure%20Occurrence%20mapping){: .btn }
### SUS AE Procedure Occurrence
Source column  `PrimaryProcedure`.
Accident and Emergency Treatment to SNOMED


|PrimaryProcedure|procedure_source_concept_id|notes|
|------|-----|-----|
|01|4305581|Dressing|
|02|4080807|Bandage|
|03|4088727|Sutures|
|04|42538257|Wound closure|
|041|4074344|Wound closure - steristrips|
|042|4141971|Wound closure - wound glue|
|043|42538257|Wound closure - other|
|05|4232206|Plaster of Paris|
|06|4038879|Splint|
|07|4052492|Prescription|
|08|4032408|Removal foreign body|
|091|4145658|Physiotherapy|
|092|4080504|Physiotherapy - manipulation|
|093|4145658|Physiotherapy - other |
|10|4045714|Reduction|
|11|4211374|Incision & Drainage|
|12|4311035|Intravenous cannula|
|13|4041656|Central line|
|14|4046291|Lavage/Emesis|
|15|4202832|Intubation|
|16|44782942|Chest drain|
|17|4074328|Urinary catheter|
|18|4180456|Defibrillation/pacing|
|19|4205502|Resuscitation|
|20|46273093|Minor surgery|
|21|4304206|Observation|
|23|4160439|Anaesthesia|
|231|4174669|General anaesthetic|
|232|4303995|Local anaesthetic|
|233|4117443|Regional block|
|234|4140470|Entonox|
|235|4219502|Sedation|
|236|4160439|Anaesthesia - other|
|24|4293740|Tetanus|
|241|4293740|Tetanus - immune|
|242|4293740|Tetanus toxoid course|
|243|4293740|Tetanus toxoid booster|
|244|4037789|Human immunoglobulin|
|25|44790388|Nebuliser|
|28|4085113|Parenteral thrombolysis|

Notes
* [ACCIDENT and EMERGENCY CLINICAL CODES](https://v2.datadictionary.nhs.uk/web_site_content/pages/codes/administrative_codes/a_amp_e_treatment_tables.asp@shownav=1.html)
* [OMOP Procedures](https://athena.ohdsi.org/search-terms/terms?domain=Procedure&standardConcept=Standard&vocabulary=SNOMED&invalidReason=Valid&page=1&pageSize=15&query=)

* `PrimaryProcedure` 
			ACCIDENT AND EMERGENCY TREATMENT is a six character code, comprising:
				Condition	n2 (see Treatment Table below)
				Sub-Analysis	n1 (see Sub-analysis Table below)
				Local use	up to an3
			 [ACCIDENT and EMERGENCY CLINICAL CODES]()

```sql
	select
		distinct
			ae.GeneratedRecordIdentifier,
			ae.NHSNumber,
			ae.CDSActivityDate as PrimaryProcedureDate,
			p.AccidentAndEmergencyTreatment as PrimaryProcedure
	from omop_staging.sus_AE ae
		inner join omop_staging.sus_AE_treatment p
			on AE.MessageId = p.MessageId
	where NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20SUS%20AE%20Procedure%20Occurrence%20mapping){: .btn }
### Cosd V9 Procedure Occurrence Procedure Opcs
Source column  `ProcedureOpcsCode`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `ProcedureOpcsCode` PROCEDURE (OPCS) is a Patient Procedure other than the PRIMARY PROCEDURE (OPCS). [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),								
CosdRecords as (				
	select								
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,								
		T.staging.query('.') as Node								
		from omop_staging.cosd_staging								
	cross apply content.nodes('COSD901:COSD/*') as T(staging)								
	where T.staging.exist('Id/@root') = 1								
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'								
		and substring (FileName, 15, 2) = 'CO'								
), ProcedureOpcs as (				
	select								
		Id,								
		T.p.value('.', 'varchar(max)') as ProcedureOpcsCode															
	from CosdRecords								
	cross apply Node.nodes('ColorectalRecord/Treatment/Surgery/ProcedureOpcs/@code') as T(p)
), COSD as (
	select
		Id,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate
	from CosdRecords
)
select
	distinct
		c.NhsNumber,
		c.ProcedureDate,
		p.ProcedureOpcsCode
from COSD c
	inner join ProcedureOpcs p
		on c.Id = p.Id;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20Cosd%20V9%20Procedure%20Occurrence%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V9 Procedure Occurrence Primary Procedure Opcs
Source column  `PrimaryProcedureOpcs`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `PrimaryProcedureOpcs` PRIMARY PROCEDURE (OPCS) is the OPCS Classification of Interventions and Procedures code which is used to identify the primary Patient Procedure carried out. [PRIMARY PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/primary_procedure__opcs_.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),								
CosdRecords as (				
	select								
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,								
		T.staging.query('.') as Node								
		from omop_staging.cosd_staging								
	cross apply content.nodes('COSD901:COSD/*') as T(staging)								
	where T.staging.exist('Id/@root') = 1								
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'								
		and substring (FileName, 15, 2) = 'CO'								
), COSD as (
	select
		Id,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/Treatment/Surgery/PrimaryProcedureOpcs/@code)[1]', 'varchar(max)') as PrimaryProcedureOpcs
	from CosdRecords
)
select
	distinct
		NhsNumber,
		ProcedureDate,
		PrimaryProcedureOpcs
from COSD c
where ProcedureDate is not null and PrimaryProcedureOpcs is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20Cosd%20V9%20Procedure%20Occurrence%20Primary%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V8 Procedure Occurrence Procedure Opcs
Source column  `ProcedureOpcsCode`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `ProcedureOpcsCode` PROCEDURE (OPCS) is a Patient Procedure other than the PRIMARY PROCEDURE (OPCS). [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

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
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/PrimaryProcedureOPCS/@code)[1]', 'varchar(max)') as PrimaryProcedureOpcs
	from CosdRecords        
), ProcedureOpcs as (				
	select								
		Id,								
		T.p.value('.', 'varchar(max)') as ProcedureOpcsCode															
	from CosdRecords								
	cross apply Node.nodes('ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureOPCS/@code') as T(p)
)
select
	distinct
		c.NhsNumber,
		c.ProcedureDate,
		p.ProcedureOpcsCode
from CO c
	inner join ProcedureOpcs p
		on c.Id = p.Id;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20Cosd%20V8%20Procedure%20Occurrence%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V8 Procedure Occurrence Primary Procedure Opcs
Source column  `PrimaryProcedureOpcs`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `PrimaryProcedureOpcs` PRIMARY PROCEDURE (OPCS) is the OPCS Classification of Interventions and Procedures code which is used to identify the primary Patient Procedure carried out. [PRIMARY PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/primary_procedure__opcs_.html)

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
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/PrimaryProcedureOPCS/@code)[1]', 'varchar(max)') as PrimaryProcedureOpcs
	from CosdRecords        
)
select
	distinct
		NhsNumber,
		ProcedureDate,
		PrimaryProcedureOpcs
from CO c
where ProcedureDate is not null and PrimaryProcedureOpcs is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20Cosd%20V8%20Procedure%20Occurrence%20Primary%20Procedure%20Opcs%20mapping){: .btn }
### CDS Procedure Occurrence
Source column  `PrimaryProcedure`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `PrimaryProcedure` OPC4 Procedure code. [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

```sql
select
	distinct
		l1.RecordConnectionIdentifier,
		l1.NHSNumber,
		p.PrimaryProcedureDate,
		p.PrimaryProcedure
from omop_staging.cds_line01 l1
	inner join omop_staging.cds_procedure p
		on l1.MessageId = p.MessageId
where l1.NHSNumber is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20CDS%20Procedure%20Occurrence%20mapping){: .btn }

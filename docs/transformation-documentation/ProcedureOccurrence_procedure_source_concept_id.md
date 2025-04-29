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
		and AttendedorDidNotAttend in ('5','6')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20SUS%20Outpatient%20Procedure%20Occurrence%20mapping){: .btn }
### SUS CCMDS Procedure Occurrence
Source column  `ProcedureSourceValue`.
CCMDS Critical Care Activity Code Concept IDs


|ProcedureSourceValue|procedure_source_concept_id|notes|
|------|-----|-----|
|1|4161831|Respiratory support via a tracheal tube (Respiratory support via a tracheal tube provided)|
|2|4165535|Nasal Continuous Positive Airway Pressure (nCPAP) (PATIENT receiving nCPAP for any part of the day)|
|3|4301351|Surgery (PATIENT received surgery)|
|4|4193981|Exchange Transfusion (PATIENT received exchange transfusion)|
|5|4324124|Peritoneal Dialysis (PATIENT received Peritoneal Dialysis)|
|6|44806352|Continuous infusion of inotrope, pulmonary vasodilator or prostaglandin (PATIENT received a continuous infusion of an inotrope, vasodilator (includes pulmonary vasodilators) or prostaglandin|
|7|4021169|Parenteral Nutrition (PATIENT receiving Parenteral Nutrition (amino acids +/- lipids))|
|8|4273223|Convulsions (PATIENT having convulsions requiring treatment)|
|9|4239130|Oxygen Therapy|
|10|46271806|Neonatal abstinence syndrome (PATIENT receiving drug treatment for neonatal abstinence (withdrawal) syndrome)|
|11|37395956|Care of an intra-arterial catheter or chest drain (PATIENT receiving care of an intra-arterial catheter or chest drain)|
|12|4050429|Dilution Exchange Transfusion (PATIENT received Dilution Exchange Transfusion)|
|13|4262010|Tracheostomy cared for by nursing staff (PATIENT receiving care of tracheostomy cared for by nursing staff not by an external Carer (e.g. parent))|
|14|4262010|Tracheostomy cared for by external Carer (PATIENT receiving care of tracheostomy cared for by an external Carer (e.g. parent) not by a NURSE)|
|15|4122478|Recurrent apnoea (PATIENT has recurrent apnoea needing frequent intervention, i.e. over 5 stimulations in 8 hours, or resuscitation with IPPV two or more times in 24 hours)|
|16|4050864|Haemofiltration (PATIENT received Haemofiltration)|
|21|4237490|Resident - Caring for Baby|
|22|4141651|Continuous monitoring|
|23|4165358|Intravenous glucose and electrolyte solutions (PATIENT being given intravenous glucose and electrolyte solutions)|
|24|4263536|Tube-fed (PATIENT being tube-fed)|
|25|618552|Barrier nursed (PATIENT being barrier nursed)|
|26|4151902|Phototherapy (PATIENT receiving phototherapy)|
|27|4301936|Special monitoring|
|28|4033847|Observations at regular intervals|
|29|4303434|Intravenous medication|
|50|4141651|Continuous electrocardiogram monitoring|
|51|37157166|Invasive ventilation via endotracheal tube|
|52|4337047|Invasive ventilation via tracheostomy tube|
|53|44791135|Non-invasive ventilatory support|
|55|4082245|Nasopharyngeal airway|
|56|4074666|Advanced ventilatory support (Jet or Oscillatory ventilation)|
|57|4061066|Upper airway obstruction requiring nebulised Epinephrine/ Adrenaline|
|58|4122478|Apnoea requiring intervention|
|59|46272934|Acute severe asthma requiring intravenous bronchodilator therapy or continuous nebuliser|
|60|4213288|Arterial line monitoring|
|61|4049990|Cardiac pacing via an external box (pacing wires or external pads or oesophageal pacing)|
|62|4322479|Central venous pressure monitoring|
|63|4161519|Bolus intravenous fluids (> 80 ml/kg/day) in addition to maintenance intravenous fluids|
|64|4232320|Cardio-pulmonary resuscitation (CPR)|
|65|4336747|Extracorporeal membrane oxygenation (ECMO) or Ventricular Assist Device (VAD) or aortic balloon pump|
|66|4120120|Haemodialysis|
|67|4052539|Plasma filtration or Plasma exchange|
|68|2000097|ICP-intracranial pressure monitoring|
|69|40756782|Intraventricular catheter or external ventricular drain|
|70|4080110|Diabetic ketoacidosis (DKA) requiring continuous infusion of insulin|
|71|4144062|Intravenous infusion of thrombolytic agent (limited to tissue plasminogen activator [tPA] and streptokinase)|
|72|44805305|Extracorporeal liver support using Molecular Absorbent Liver Recirculating System (MARS)|
|73|4262005|Continuous pulse oximetry|
|74|4222885|Patient nursed in single occupancy cubicle|
|80|37158406|Heated Humidified High Flow Therapy (HHHFT)|
|81|4051310|Presence of an umbilical venous line|
|82|4080110|Continuous infusion of insulin (PATIENT  receiving a continuous infusion of insulin)|
|83|4203429|Therapeutic hypothermia|
|87|4022139|Administration of intravenous (IV) blood products|
|96|4086422|intravenous infusion of sedative agent|

Notes
* [CRITICAL CARE ACTIVITY CODES](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/attributes/critical_care_activity_code.html)
* [OMOP Procedures](https://athena.ohdsi.org/search-terms/terms?domain=Procedure&invalidReason=Valid&standardConcept=Standard&vocabulary=SNOMED&page=1&pageSize=15&query=)

* `ProcedureSourceValue` Used to look up the Procedure code. [CRITICAL CARE ACTIVITY CODE](https://www.datadictionary.nhs.uk/data_elements/critical_care_activity_code.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.GeneratedRecordIdentifier,
				cc.CriticalCareStartDate as ProcedureOccurrenceStartDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as ProcedureOccurrenceStartTime,
				coalesce(cc.CriticalCarePeriodDischargeDate, cc.EventDate) as ProcedureOccurrenceEndDate,
				coalesce(cc.CriticalCarePeriodDischargeTime, '00:00:00') as ProcedureOccurrenceEndTime,
				d.CriticalCareActivityCode as ProcedureSourceValue
		from omop_staging.sus_CCMDS_CriticalCareActivityCode d
		inner join omop_staging.sus_CCMDS cc on d.MessageId = cc.MessageId
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
		and d.CriticalCareActivityCode != '99'  -- No Defined Critical Care Activity

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_source_concept_id%20field%20SUS%20CCMDS%20Procedure%20Occurrence%20mapping){: .btn }
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
Accident and Emergency Treatment to OMOP Procedure Concept IDs


|PrimaryProcedure|procedure_source_concept_id|notes|
|------|-----|-----|
|01|4080499|Dressing|
|011|4080499|Dressing - dressing minor wound/burn/eye|
|012|4080499|Dressing - dressing major wound/burn|
|02|4080807|Bandage|
|03|4147691|Sutures|
|031|4147691|Sutures - primary sutures|
|032|4147691|Sutures - secondary/complex suture|
|033|4147691|Sutures - removal of sutures/clips|
|04|42538257|Wound Closure|
|041|4074344|Wound Closure - steristrips|
|042|4141971|Wound Closure - wound glue|
|043|42538257|Wound Closure - other (e.g. clips)|
|05|4232206|Plaster of Paris|
|051|4108844|Plaster of Paris - application|
|052|4078743|Plaster of Paris - removal|
|06|4194049|Splint|
|08|4032408|Removal|
|09|4080504|Physiotherapy|
|091|4080504|Physiotherapy - strapping, ultra sound treatment, short wave diathermy, manipulation|
|092|4218040|Physiotherapy - gait re-education, falls prevention|
|10|4190331|Manipulation|
|101|4042533|Manipulation - manipulation of upper limb fracture|
|102|42709780|Manipulation - manipulation of lower limb fracture|
|103|4190331|Manipulation - manipulation of dislocation|
|11|4211374|I&D|
|12|4311035|IV Cannula|
|13|4041656|Central Line|
|14|4178105|Irrigation|
|15|4202832|Intubation|
|16|44782942|Chest Drain|
|17|4074328|Urinary Catheter|
|18|4180456|Defibrillation|
|181|4180456|Defibrillation - defibrillation|
|182|4180456|Defibrillation - external pacing|
|19|4205502|CPR|
|20|46273093|Minor Surgery|
|21|4304206|Observation|
|22|4172321|Guidance|
|221|4172321|Guidance - written|
|222|4172321|Guidance - verbal|
|23|4160439|Anaesthesia|
|231|4174669|Anaesthesia - general anaesthetic|
|232|4303995|Anaesthesia - local anaesthetic|
|233|4117443|Anaesthesia - regional block|
|234|4140470|Anaesthesia - entonox|
|235|4219502|Anaesthesia - sedation|
|236|4160439|Anaesthesia - other|
|24|4293740|Tetanus|
|241|4293740|Tetanus - immune|
|242|4293740|Tetanus - tetanus toxoid course|
|243|4293740|Tetanus - tetanus toxoid booster|
|244|4037789|Tetanus - human immunoglobulin|
|245|4250328|Tetanus - combined tetanus/diphtheria course|
|246|4133518|Tetanus - combined tetanus/diphtheria booster|
|25|44790388|Nebuliser|
|28|4085113|Thrombolysis|
|281|4018703|Thrombolysis - streptokinase parenteral thrombolysis|
|282|4085113|Thrombolysis - recombinant|
|283|4241698|Thrombolysis - plasminogen activator|
|29|4088217|Parenteral Drugs|
|291|4161519|Parenteral Drugs - intravenous drug, e.g. stat/bolus|
|292|4030886|Parenteral Drugs - intravenous infusion|
|30|4254901|Vital Signs|
|31|4118442|Burns Review|
|32|4079701|X-ray Review|
|33|4295944|Fracture Review|
|34|4075964|Wound Cleaning|
|35|44793314|Dressing/Wound Review|
|36|4180243|Sling|
|37|4262407|Epistaxis Control|
|38|4092976|Nasal Airway|
|39|4339620|Oral Airway|
|40|4239130|Supplemental Oxygen|
|41|4306204|Positive Pressure|
|42|4213288|Arterial Line|
|43|763496|Infusion Fluids|
|44|4024656|Blood Transfusion|
|45|4149930|Pericardiocentesis|
|46|4080549|Lumbar Puncture|
|47|4170811|Joint Aspiration|
|48|4083710|Minor Plastic|
|49|4086432|Rewarming|
|50|4086433|Cooling|
|51|4162585|Medication|
|511|4123242|Medication - oral|
|512|4298276|Medication - intra-muscular|
|513|4303435|Medication - subcutaneous|
|514|4302260|Medication - per rectum|
|515|4123242|Medication - sublingual|
|516|4235706|Medication - intra-nasal|
|517|4021805|Medication - eye drops|
|518|4334396|Medication - ear drops|
|519|4075356|Medication - topical skin cream|
|52|4261887|OT|
|521|4261887|OT - OT functional assessment|
|522|4013690|OT - OT activities of daily living equipment provision|
|53|4083010|Walking Aid Loan|
|54|44791868|Social Work|
|55|4148277|Eye|
|551|4148277|Eye - orthoptic exercises|
|552|4162096|Eye - laser of retina/iris or posterior capsule|
|553|4259619|Eye - retrobulbar injection|
|554|4161695|Eye - epilation of lashes|
|555|4252594|Eye - subconjunctival injection|
|56|4305000|Dental|
|57|4052492|Prescription|
|27||Not Mappable|
|99||Not Mappable|

Notes
* [ACCIDENT and EMERGENCY CLINICAL CODES](https://archive.datadictionary.nhs.uk/DD%20Release%20September%202020/supporting_information/accident_and_emergency_treatment_tables.html)
* [OMOP Procedures](https://athena.ohdsi.org/search-terms/terms?domain=Procedure&invalidReason=Valid&standardConcept=Standard&vocabulary=SNOMED&page=1&pageSize=15&query=)

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

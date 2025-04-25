---
layout: default
title: device_source_concept_id
parent: DeviceExposure
grand_parent: Transformation Documentation
has_toc: false
---
# device_source_concept_id
### SUS OP Device Exposure
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_source_concept_id%20field%20SUS%20OP%20Device%20Exposure%20mapping){: .btn }
### SUS CCMDS Device Exposure
Source column  `CriticalCareActivityCode`.
CCMDS Critical Care Activity Code Device Concept IDs


|CriticalCareActivityCode|device_source_concept_id|notes|
|------|-----|-----|
|1|4107141|Respiratory support via a tracheal tube (Respiratory support via a tracheal tube provided)|
|2|45761109|Nasal Continuous Positive Airway Pressure (nCPAP) (PATIENT receiving nCPAP for any part of the day)|
|5|45757846|Peritoneal Dialysis (PATIENT received Peritoneal Dialysis)|
|7|4209766|Parenteral Nutrition (PATIENT receiving Parenteral Nutrition (amino acids +/- lipids))|
|9|45759341|Oxygen Therapy|
|11|4121351|Care of an intra-arterial catheter or chest drain (PATIENT receiving care of an intra-arterial catheter or chest drain)|
|13|4229159|Tracheostomy cared for by nursing staff (PATIENT receiving care of tracheostomy cared for by nursing staff not by an external Carer (e.g. parent))|
|14|4229159|Tracheostomy cared for by external Carer (PATIENT receiving care of tracheostomy cared for by an external Carer (e.g. parent) not by a NURSE)|
|16|45758443|Haemofiltration (PATIENT received Haemofiltration)|
|26|36715434|Phototherapy (PATIENT receiving phototherapy)|
|51|4097216|Invasive ventilation via endotracheal tube|
|52|4044008|Invasive ventilation via tracheostomy tube|
|53|45768197|Non-invasive ventilatory support|
|55|4266238|Nasopharyngeal airway|
|56|45768197|Advanced ventilatory support (Jet or Oscillatory ventilation)|
|59|4219814|Acute severe asthma requiring intravenous bronchodilator therapy or continuous nebuliser|
|60|4126195|Arterial line monitoring|
|61|4030875|Cardiac pacing via an external box (pacing wires or external pads or oesophageal pacing)|
|62|4179206|Central venous pressure monitoring|
|63|4042177|Bolus intravenous fluids (> 80 ml/kg/day) in addition to maintenance intravenous fluids|
|73|40491434|Continuous pulse oximetry|
|80|4139525|Heated Humidified High Flow Therapy (HHHFT)|
|81|4124293|Presence of an umbilical venous line|

Notes
* [CRITICAL CARE ACTIVITY CODES](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/attributes/critical_care_activity_code.html)
* [OMOP Devices](https://athena.ohdsi.org/search-terms/terms?domain=Device&invalidReason=Valid&standardConcept=Standard&page=1&pageSize=500&query=)

* `CriticalCareActivityCode` Used to look up the Device code. [CRITICAL CARE ACTIVITY CODE](https://www.datadictionary.nhs.uk/data_elements/critical_care_activity_code.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.HospitalProviderSpellNumber,
				cc.CriticalCareStartDate as DeviceExposureStartDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as DeviceExposureStartTime,
				coalesce(cc.CriticalCarePeriodDischargeDate, cc.EventDate) as DeviceExposureEndDate,
				coalesce(cc.CriticalCarePeriodDischargeTime, '00:00:00') as DeviceExposureEndTime,
				d.CriticalCareActivityCode as CriticalCareActivityCode
		from omop_staging.sus_CCMDS_CriticalCareActivityCode d
		inner join omop_staging.sus_CCMDS cc on d.MessageId = cc.MessageId
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
		and d.CriticalCareActivityCode not in('3','4','6','8','10','12','15','21','22','23','24','25','27','28','29','50','57','58','64','65','66','67','68','69','70','71','72','74','82','83','87','99')

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_source_concept_id%20field%20SUS%20CCMDS%20Device%20Exposure%20mapping){: .btn }
### SUS APC Procedure Occurrence
Source column  `PrimaryProcedure`.
Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.

* `PrimaryProcedure` OPC4 Procedure code. [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

```sql
select
	distinct
		apc.GeneratedRecordIdentifier,
		apc.HospitalSpellProviderNumber,
		apc.NHSNumber,
		p.ProcedureDateOPCS as PrimaryProcedureDate,
		p.ProcedureOPCS as PrimaryProcedure
from omop_staging.sus_APC apc
	inner join omop_staging.sus_OPCSProcedure p
		on apc.MessageId = p.MessageId
where NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_source_concept_id%20field%20SUS%20APC%20Procedure%20Occurrence%20mapping){: .btn }
### SUS AE Procedure Device Exposure
Source column  `PrimaryProcedure`.
Lookup discharge destination concept.


|PrimaryProcedure|device_source_concept_id|notes|
|------|-----|-----|
|01|45768233|X-ray|
|02|45768113|Electrocardiograph|
|08|45768357|Microscope (histology)|
|10|45768281|Ultrasound|
|11|4234381|Magnetic Resonance Imaging (MRI)|
|12|45762714|Computerised Tomography (CT)|
|09|45762714|Computerised Tomography (CT)|
|19|618883|Blood culture bottle|


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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_source_concept_id%20field%20SUS%20AE%20Procedure%20Device%20Exposure%20mapping){: .btn }
### SUS AE Investigation Device Exposure
Source column  `AccidentAndEmergencyInvestigation`.
Lookup discharge destination concept.


|AccidentAndEmergencyInvestigation|device_source_concept_id|notes|
|------|-----|-----|
|01|45768233|X-ray|
|02|45768113|Electrocardiograph|
|08|45768357|Microscope (histology)|
|10|45768281|Ultrasound|
|11|4234381|Magnetic Resonance Imaging (MRI)|
|12|45762714|Computerised Tomography (CT)|
|09|45762714|Computerised Tomography (CT)|
|19|618883|Blood culture bottle|


* `AccidentAndEmergencyInvestigation` A broad coding of types of investigation which may be requested to assist with diagnosis as a result of Accident and Emergency Attendances. [ACCIDENT AND EMERGENCY INVESTIGATION]()

```sql
	select
		distinct
		ae.AEAttendanceNumber,
		ae.NHSNumber,
		coalesce(ae.ArrivalDate, ae.CDSActivityDate) as StartDate,
		coalesce(ae.ArrivalTime, '000000') as StartTime,
		coalesce(ae.AEDepartureDate, ae.AEAttendanceConclusionDate) as EndDate,
		coalesce(ae.AEDepartureTime, ae.AEAttendanceConclusionTime, '000000') as EndTime,
		i.AccidentAndEmergencyInvestigation
	from omop_staging.sus_AE_investigation i
		inner join omop_staging.sus_AE ae
			on i.MessageId = ae.MessageId
	where ae.NHSNumber is not null
	and i.AccidentAndEmergencyInvestigation in ('01', '02', '08', '09', '10', '11', '12', '19')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_source_concept_id%20field%20SUS%20AE%20Investigation%20Device%20Exposure%20mapping){: .btn }

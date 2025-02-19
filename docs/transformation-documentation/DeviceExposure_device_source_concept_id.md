---
layout: default
title: device_source_concept_id
parent: DeviceExposure
grand_parent: Transformation Documentation
has_toc: false
---
# device_source_concept_id
### SUS AE Device Exposure
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
		ae.GeneratedRecordIdentifier,
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_source_concept_id%20field%20SUS%20AE%20Device%20Exposure%20mapping){: .btn }

---
layout: default
title: device_source_value
parent: DeviceExposure
grand_parent: Transformation Documentation
has_toc: false
---
# device_source_value
### SUS AE Device Exposure
* Value copied from `AccidentAndEmergencyInvestigation`

```sql
	select
		ae.AEAttendanceNumber,
		ae.NHSNumber,
		coalesce(ae.ArrivalDate, ae.CDSActivityDate) as StartDate,
		coalesce(ae.ArrivalTime, '000000') as StartTime,
		coalesce(ae.AEDepartureDate, ae.AEAttendanceConclusionDate) as EndDate,
		coalesce(ae.AEDepartureTime, ae.AEAttendanceConclusionTime, '000000') as EndTime,
		i.AccidentAndEmergencyInvestigation,
		case
			when i.AccidentAndEmergencyInvestigation = '01' then '45768233' --X-ray
			when i.AccidentAndEmergencyInvestigation = '02' then '45768113' --Electrocardiograph
			when i.AccidentAndEmergencyInvestigation = '08' then '45768357' --Microscope (histology)
			when i.AccidentAndEmergencyInvestigation = '10' then '45768281' --Ultrasound
			when i.AccidentAndEmergencyInvestigation = '11' then '4234381' --Magnetic Resonance Imaging (MRI)
			when i.AccidentAndEmergencyInvestigation in ('09', '12') then '45762714' --Computerised Tomography (CT)
			when i.AccidentAndEmergencyInvestigation = '19' then '618883' --Blood culture bottle
		else '' end as device_source_value
	from omop_staging.sus_AE_investigation i
		inner join omop_staging.sus_AE ae
			on i.MessageId = ae.MessageId
	where ae.NHSNumber is not null
	and i.AccidentAndEmergencyInvestigation in ('01', '02', '08', '09', '10', '11', '12', '19')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_source_value%20field%20SUS%20AE%20Device%20Exposure%20mapping){: .btn }

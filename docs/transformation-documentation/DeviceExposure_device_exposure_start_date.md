---
layout: default
title: device_exposure_start_date
parent: DeviceExposure
grand_parent: Transformation Documentation
has_toc: false
---
# device_exposure_start_date
### SUS AE Device Exposure
Source column  `StartDate`.
Converts text to dates.

* `StartDate` Start date of the episode. [START DATE (EPISODE)](https://www.datadictionary.nhs.uk/data_elements/start_date__episode_.html)

```sql
	select
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DeviceExposure%20table%20device_exposure_start_date%20field%20SUS%20AE%20Device%20Exposure%20mapping){: .btn }

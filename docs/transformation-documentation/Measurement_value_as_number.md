---
layout: default
title: value_as_number
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# value_as_number
### Sus CCMDS Measurement - Gestation Length at Delivery
Source column  `ValueAsNumber`.
Converts text to number.

* `ValueAsNumber` Value of the Length of Gestation at Delivery [GESTATION LENGTH (AT DELIVERY)](https://www.datadictionary.nhs.uk/data_elements/gestation_length__at_delivery_.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.GeneratedRecordIdentifier,
				cc.CriticalCareStartDate as MeasurementDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as MeasurementDateTime,
				cc.GestationLengthAtDelivery as ValueAsNumber
		from [omop_staging].[sus_CCMDS] cc 
		inner join [omop_staging].sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
		and cc.GestationLengthAtDelivery is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20Sus%20CCMDS%20Measurement%20-%20Gestation%20Length%20at%20Delivery%20mapping){: .btn }
### Sus CCMDS Measurement - Person Weight
Source column  `ValueAsNumber`.
Converts text to number.

* `ValueAsNumber` Value of the Person weight [PERSON WEIGHT](https://www.datadictionary.nhs.uk/data_elements/person_weight.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.GeneratedRecordIdentifier,
				cc.CriticalCareStartDate as MeasurementDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as MeasurementDateTime,
				cc.PersonWeight as ValueAsNumber
		from [omop_staging].[sus_CCMDS] cc 
		inner join [omop_staging].sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
		and cc.PersonWeight is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20Sus%20CCMDS%20Measurement%20-%20Person%20Weight%20mapping){: .btn }
### COSD V8 Measurement Tumour Height Above Anal Verge
Source column  `TumourHeightAboveAnalVerge`.
Converts text to number.

* `TumourHeightAboveAnalVerge` Is the approximate height of the lower limit of the Tumour above the anal verge (as measured by a rigid sigmoidoscopy) during a Colorectal Cancer Care Spell, where the UNIT OF MEASUREMENT is 'Centimetres (cm)' [TUMOUR HEIGHT ABOVE ANAL VERGE](https://www.datadictionary.nhs.uk/data_elements/tumour_height_above_anal_verge.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreDiagnosis/ColorectalDiagnosis/TumourHeightAboveAnalVerge/@value)[1]', 'varchar(max)') as TumourHeightAboveAnalVerge
	from CosdRecords
)
select distinct
	NhsNumber,
	ClinicalDateCancerDiagnosis,
	TumourHeightAboveAnalVerge
from CO
where TumourHeightAboveAnalVerge is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20COSD%20V8%20Measurement%20Tumour%20Height%20Above%20Anal%20Verge%20mapping){: .btn }

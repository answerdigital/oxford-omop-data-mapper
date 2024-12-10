---
layout: default
title: value_as_number
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# value_as_number
### COSD V8 Measurement Tumour Height Above Anal Verge
Source column  `TumourHeightAboveAnalVerge`.
Converts text to integers.

* `TumourHeightAboveAnalVerge` Is the approximate height of the lower limit of the Tumour above the anal verge (as measured by a rigid sigmoidoscopy) during a Colorectal Cancer Care Spell, where the UNIT OF MEASUREMENT is 'Centimetres (cm)' [TUMOUR HEIGHT ABOVE ANAL VERGE]()

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

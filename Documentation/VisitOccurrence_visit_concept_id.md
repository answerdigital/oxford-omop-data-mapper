# `VisitOccurrence` `visit_concept_id`
### CDS VisitOccurrenceWithSpell
* Value copied from `VisitOccurenceConceptId`
* `VisitOccurenceConceptId` 
			
| Visit Occurrence Type             | Location Class Condition                                                                                                                                                                   | Patient Classification Condition | Admission Method Code Condition |
|------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------|---------------------------------|
| Emergency Room and Inpatient Visit | Is either 21 (Emergency Admission : Emergency Care Department or dental casualty department of the Health Care Provider) or 24 (Consultant Clinic of this or another Health Care Provider) | Is 1 (Ordinary admission)        | Is not 02 (Home Visit)          |
| Emergency Room Visit               | Is either 21 (Emergency Admission : Emergency Care Department or dental casualty department of the Health Care Provider) or 24 (Consultant Clinic of this or another Health Care Provider) | Is not 1 (Ordinary admission)    | Is not 02 (Home Visit)          |
| Inpatient Visit                    | Is not 21 (Emergency Admission : Emergency Care Department or dental casualty department of the Health Care Provider) or 24 (Consultant Clinic of this or another Health Care Provider)    | Is 1 (Ordinary admission)        | Is not 02 (Home Visit)          |
| Home Visit                         | N/A                                                                                                                                                                                        | N/A                              | Is 02 (Home Visit)              |
| Outpatient Visit                   | Is not 21 (Emergency Admission : Emergency Care Department or dental casualty department of the Health Care Provider) or 24 (Consultant Clinic of this or another Health Care Provider)    | Is not 1 (Ordinary admission)    | Is not 02 (Home Visit)          |
		
<details>
<summary>SQL</summary>

```sql
select
	l1.NHSNumber,
	l5.HospitalProviderSpellNumber,
	min (l5.EpisodeStartDate) as EpisodeStartDate,
	coalesce 
	(
		min (l5.EpisodeStartTime), 
		'000000'
	) as EpisodeStartTime,
	coalesce 
	(
		max (l5.EpisodeEndDate), 
		max (l1.CDSActivityDate)
	) as EpisodeEndDate,
	coalesce 
	(
		max (l5.EpisodeEndTime), 
		'000000'
	) as EpisodeEndTime,
	case 
		when max(l5.AdmissionMethodCode) in ('21','24') and max(l5.PatientClassification) = 1 then 262
        when max(l5.AdmissionMethodCode) in ('21','24') then 9203
        when max(l5.PatientClassification) in (1) then 9201
        when max(l4.LocationClass) in ('02') then 581476
		else 9202
	end as VisitOccurenceConceptId,    -- "visit_concept_id"
	case 
		when max(l5.EpisodeEndDate) is null and max(l5.DischargeDateHospitalProviderSpell) is null then 32220
        else 32818
	end as VisitTypeConceptId
from omop_staging.cds_line01 l1
	left join omop_staging.cds_line04 l4 
		on l1.MessageId = l4.MessageId -- Location Details 
	left join omop_staging.cds_line05 l5 
		on l1.MessageId = l5.MessageId  -- Hospital Provider Spell
	inner join dbo.Code c 
		on c.Code = l1.ActivityTreatmentFunctionCode
where l1.CDSUpdateType = 9   -- New/Modification     (1 = Delete)
	and l1.NHSNumber is not null
	and c.CodeTypeId = 2 -- activity_treatment_function_code
	and l5.HospitalProviderSpellNumber is not null
group by 
	l1.NHSNumber, 
	l5.HospitalProviderSpellNumber;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_concept_id%20field%20CDS%20VisitOccurrenceWithSpell%20mapping)
### CDS VisitOccurrenceWithoutSpell
* Constant value set to `9202`. `Outpatient Visit`

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitOccurrence%20table%20visit_concept_id%20field%20CDS%20VisitOccurrenceWithoutSpell%20mapping)

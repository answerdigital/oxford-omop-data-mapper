---
layout: default
title: ConditionOccurrence
has_children: true
parent: Transformation Documentation
has_toc: false
---

# ConditionOccurrence
* [nhs_number]({% link docs/transformation-documentation/ConditionOccurrence_nhs_number.md %})
* [condition_start_date]({% link docs/transformation-documentation/ConditionOccurrence_condition_start_date.md %})
* [condition_type_concept_id]({% link docs/transformation-documentation/ConditionOccurrence_condition_type_concept_id.md %})
* [condition_status_concept_id]({% link docs/transformation-documentation/ConditionOccurrence_condition_status_concept_id.md %})
* [condition_status_source_value]({% link docs/transformation-documentation/ConditionOccurrence_condition_status_source_value.md %})
* [condition_source_concept_id]({% link docs/transformation-documentation/ConditionOccurrence_condition_source_concept_id.md %})
* [condition_concept_id]({% link docs/transformation-documentation/ConditionOccurrence_condition_concept_id.md %})
* [condition_source_value]({% link docs/transformation-documentation/ConditionOccurrence_condition_source_value.md %})
* [RecordConnectionIdentifier]({% link docs/transformation-documentation/ConditionOccurrence_RecordConnectionIdentifier.md %})

## CosdV8ConditionOccurrencePrimaryDiagnosis
<a href="CosdV8ConditionOccurrencePrimaryDiagnosis.svg" target="_blank"><img src="CosdV8ConditionOccurrencePrimaryDiagnosis.svg" /></a>

{: .important-title }
> Assumptions
>
> * Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)
> * If the same Diagnosis occurs but we have 2 separate "basis of diagnosis" values, then the first one will be taken only

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV8ConditionOccurrencePrimaryDiagnosis%20mapping){: .btn }
## CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography
<a href="CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography.svg" target="_blank"><img src="CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography.svg" /></a>

{: .important-title }
> Assumptions
>
> * For a given Diagnosis date, all valid combinations of Histology and Topography are added (thereby giving us an ICD-O-3 condition) as well as the ICD10 Diagnosis.
> * Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)
> * If the same Diagnosis occurs but we have 2 separate "basis of diagnosis" values, then the first one will be taken only

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV8ConditionOccurrencePrimaryDiagnosisHistologyTopography%20mapping){: .btn }
## CosdV9ConditionOccurrenceSecondaryDiagnosis
<a href="CosdV9ConditionOccurrenceSecondaryDiagnosis.svg" target="_blank"><img src="CosdV9ConditionOccurrenceSecondaryDiagnosis.svg" /></a>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV9ConditionOccurrenceSecondaryDiagnosis%20mapping){: .btn }
## CosdV9ConditionOccurrenceRecurrence
<a href="CosdV9ConditionOccurrenceRecurrence.svg" target="_blank"><img src="CosdV9ConditionOccurrenceRecurrence.svg" /></a>

{: .important-title }
> Assumptions
>
> * Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)
> * If the same Diagnosis occurs but we have 2 separate "basis of diagnosis" values, then the first one will be taken only

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV9ConditionOccurrenceRecurrence%20mapping){: .btn }
## CosdV9ConditionOccurrenceProgression
<a href="CosdV9ConditionOccurrenceProgression.svg" target="_blank"><img src="CosdV9ConditionOccurrenceProgression.svg" /></a>

{: .important-title }
> Assumptions
>
> * Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)
> * If the same Diagnosis occurs but we have 2 separate "basis of diagnosis" values, then the first one will be taken only

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV9ConditionOccurrenceProgression%20mapping){: .btn }
## CosdConditionOccurrencePrimaryDiagnosis
<a href="CosdConditionOccurrencePrimaryDiagnosis.svg" target="_blank"><img src="CosdConditionOccurrencePrimaryDiagnosis.svg" /></a>

{: .important-title }
> Assumptions
>
> * Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)
> * If the same Diagnosis occurs but we have 2 separate "basis of diagnosis" values, then the first one will be taken only

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdConditionOccurrencePrimaryDiagnosis%20mapping){: .btn }
## CosdConditionOccurrencePrimaryDiagnosisHistologyTopography
<a href="CosdConditionOccurrencePrimaryDiagnosisHistologyTopography.svg" target="_blank"><img src="CosdConditionOccurrencePrimaryDiagnosisHistologyTopography.svg" /></a>

{: .important-title }
> Assumptions
>
> * For a given Diagnosis date, all valid combinations of Histology and Topography are added (thereby giving us an ICD-O-3 condition) as well as the ICD10 Diagnosis.
> * Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)
> * If the same Diagnosis occurs but we have 2 separate "basis of diagnosis" values, then the first one will be taken only

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdConditionOccurrencePrimaryDiagnosisHistologyTopography%20mapping){: .btn }
## CdsConditionOccurrence
<a href="CdsConditionOccurrence.svg" target="_blank"><img src="CdsConditionOccurrence.svg" /></a>

{: .important-title }
> Duplicates
>
> CDS data contains numerous duplicated records for cds_diagnosis.DiagnosisCode (condition_concept_id), cds_line01.cdsActivityDate (condition_start_date) and cds_line01.NHSNumber (person_id).
>
> In order to avoid true duplicates occurring in the data, we have included distinct records for  cds_diagnosis.DiagnosisCode (condition_concept_id), cds_line01.cdsActivityDate (condition_start_date) , cds_line01.NHSNumber (person_id) and cds_line01.RecordConnectionIdentifier and excluded all duplicates.
>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsConditionOccurrence%20mapping){: .btn }

---
layout: default
title: ProcedureOccurrence
has_children: true
parent: Transformation Documentation
has_toc: false
---

# ProcedureOccurrence
* [nhs_number]({% link docs/transformation-documentation/ProcedureOccurrence_nhs_number.md %})
* [procedure_concept_id]({% link docs/transformation-documentation/ProcedureOccurrence_procedure_concept_id.md %})
* [procedure_date]({% link docs/transformation-documentation/ProcedureOccurrence_procedure_date.md %})
* [procedure_datetime]({% link docs/transformation-documentation/ProcedureOccurrence_procedure_datetime.md %})
* [procedure_type_concept_id]({% link docs/transformation-documentation/ProcedureOccurrence_procedure_type_concept_id.md %})
* [procedure_source_value]({% link docs/transformation-documentation/ProcedureOccurrence_procedure_source_value.md %})
* [procedure_source_concept_id]({% link docs/transformation-documentation/ProcedureOccurrence_procedure_source_concept_id.md %})
* [RecordConnectionIdentifier]({% link docs/transformation-documentation/ProcedureOccurrence_RecordConnectionIdentifier.md %})
* [quantity]({% link docs/transformation-documentation/ProcedureOccurrence_quantity.md %})

## SusOPProcedureOccurrence
<a href="SusOPProcedureOccurrence.svg" target="_blank"><img src="SusOPProcedureOccurrence.svg" /></a>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=SusOPProcedureOccurrence%20mapping){: .btn }
## SusAPCProcedureOccurrence
<a href="SusAPCProcedureOccurrence.svg" target="_blank"><img src="SusAPCProcedureOccurrence.svg" /></a>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=SusAPCProcedureOccurrence%20mapping){: .btn }
## CosdV9ProcedureOccurrenceProcedureOpcs
<a href="CosdV9ProcedureOccurrenceProcedureOpcs.svg" target="_blank"><img src="CosdV9ProcedureOccurrenceProcedureOpcs.svg" /></a>

{: .important-title }
> Duplicates
>
> COSD data contains numerous duplicated records due to repeated submissions that include the same records.  The latest record may occasionally have a NULL field that was previously populated.  We observed this for address fields, date of birth and other personal details, but did not observe it for procedure data.
>
> In order to avoid true duplicates occurring in the data, we have included distinct records for  NHSNumber (person_id) , PrimaryProcedureOpcs(procedure_concept_id), ProcedureOpcs(procedure_concept_id), ProcedureDate (procedure_date) and excluded all duplicates.  The tool will handle things a little differently, as each new submission will have to be dealt with as it arrives.
>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV9ProcedureOccurrenceProcedureOpcs%20mapping){: .btn }
## CosdV9ProcedureOccurrencePrimaryProcedureOpcs
<a href="CosdV9ProcedureOccurrencePrimaryProcedureOpcs.svg" target="_blank"><img src="CosdV9ProcedureOccurrencePrimaryProcedureOpcs.svg" /></a>

{: .important-title }
> Duplicates
>
> COSD data contains numerous duplicated records due to repeated submissions that include the same records.  The latest record may occasionally have a NULL field that was previously populated.  We observed this for address fields, date of birth and other personal details, but did not observe it for procedure data.
>
> In order to avoid true duplicates occurring in the data, we have included distinct records for  NHSNumber (person_id) , PrimaryProcedureOpcs(procedure_concept_id), ProcedureOpcs(procedure_concept_id), ProcedureDate (procedure_date) and excluded all duplicates.  The tool will handle things a little differently, as each new submission will have to be dealt with as it arrives.
>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV9ProcedureOccurrencePrimaryProcedureOpcs%20mapping){: .btn }
## CosdV8ProcedureOccurrenceProcedureOpcs
<a href="CosdV8ProcedureOccurrenceProcedureOpcs.svg" target="_blank"><img src="CosdV8ProcedureOccurrenceProcedureOpcs.svg" /></a>

{: .important-title }
> Duplicates
>
> COSD data contains numerous duplicated records due to repeated submissions that include the same records.  The latest record may occasionally have a NULL field that was previously populated.  We observed this for address fields, date of birth and other personal details, but did not observe it for procedure data.
>
> In order to avoid true duplicates occurring in the data, we have included distinct records for  NHSNumber (person_id) , PrimaryProcedureOpcs(procedure_concept_id), ProcedureOpcs(procedure_concept_id), ProcedureDate (procedure_date) and excluded all duplicates.  The tool will handle things a little differently, as each new submission will have to be dealt with as it arrives.
>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV8ProcedureOccurrenceProcedureOpcs%20mapping){: .btn }
## CosdV8ProcedureOccurrencePrimaryProcedureOpcs
<a href="CosdV8ProcedureOccurrencePrimaryProcedureOpcs.svg" target="_blank"><img src="CosdV8ProcedureOccurrencePrimaryProcedureOpcs.svg" /></a>

{: .important-title }
> Duplicates
>
> COSD data contains numerous duplicated records due to repeated submissions that include the same records.  The latest record may occasionally have a NULL field that was previously populated.  We observed this for address fields, date of birth and other personal details, but did not observe it for procedure data.
>
> In order to avoid true duplicates occurring in the data, we have included distinct records for  NHSNumber (person_id) , PrimaryProcedureOpcs(procedure_concept_id), ProcedureOpcs(procedure_concept_id), ProcedureDate (procedure_date) and excluded all duplicates.  The tool will handle things a little differently, as each new submission will have to be dealt with as it arrives.
>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CosdV8ProcedureOccurrencePrimaryProcedureOpcs%20mapping){: .btn }
## CdsProcedureOccurrence
<a href="CdsProcedureOccurrence.svg" target="_blank"><img src="CdsProcedureOccurrence.svg" /></a>

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=CdsProcedureOccurrence%20mapping){: .btn }

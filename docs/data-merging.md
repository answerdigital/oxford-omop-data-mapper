---
layout: default
title: Data Merging
nav_order: 8
---

# Data merging logic

When OMOP records are recorded some records must be merged. An example of this would be if we detected patient is more than one data source.

In some cases we may partially record a record with the hope of detecting the missing information in later transformations. For example if we have a person data source that does not define the patient's gender. 

If all data is transformed and incomplete records still exist, use the [`prune command`]({% link docs/user-guide/commands.md %}#prune-command). 

## Person

| Column | Merging rule |
|--------|-------------|
| gender_concept_id | If new value is not null, set it |
| year_of_birth | If new value is not null, set it |
| month_of_birth | If new value is not null, set it |
| day_of_birth | If new value is not null, set it |
| birth_datetime | If new value is not null, set it |
| race_concept_id | If new value is not null, set it |
| ethnicity_concept_id | If new value is not null, set it |
| location_id | If new value is not null, set it |
| provider_id | If new value is not null, set it |
| care_site_id | If new value is not null, set it |
| person_source_value | If new value is not null, set it |
| gender_source_value | If new value is not null, set it |
| gender_source_concept_id | If new value is not null, set it |
| race_source_value | If new value is not null, set it |
| race_source_concept_id | If new value is not null, set it |
| ethnicity_source_value | If new value is not null, set it |
| ethnicity_source_concept_id | If new value is not null, set it |

### Remarks

* If two records are related to the same person, the fields related to that person such as gender are populated based on last record wins. For example if one record says gender is Male and the next record says gender is Female, we overwrite the gender to be Female.
* However if the second value says gender is null, we would not overwrite the gender.
* The order in which data is loaded will define what the 'final' value of fields like gender.

## Location

Merging logic is not needed as we only record unique locations. If the location already exists in the `location` table, do not record it. We never update records in this table.

## Condition Occurrence

Cds condition occurrences have a unique key `DiagnosisId`. Records are added if they do not exist already. No merging logic is required.

## Death

Merging logic is not needed. If a patient deaths are recorded when no such record already exists.
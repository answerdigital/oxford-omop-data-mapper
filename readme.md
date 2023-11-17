# Person
## CNSRecord xml record
### person_source_value column
Value copied from `NhsNumber`
## CdsInpatientDemographics table
### gender_concept_id column


|before|after|notes|
|------|-----|-----|
|m|123|value notes can go here|
|f|345||
|u|567||

Notes
* Overall gender notes can go here.
### person_source_value column
Value copied from `nhs_number`
### month_of_birth column
Source column  `person_birth_date`.
Selects the month of the year or null if the date is null.

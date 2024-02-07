[![.NET](https://github.com/answerdigital/oxford-omop-data-mapper/actions/workflows/dotnet.yml/badge.svg)](https://github.com/answerdigital/oxford-omop-data-mapper/actions/workflows/dotnet.yml)

# OMOP Transformer CLI tool

```
PS C:\Code\oxford-omop-transformer\OmopTransformer\bin\Debug\net8.0> omop --help
omop 1.0.0+6da73ae9ec0fb4b0453328e149f8dd2facdf2a11
Copyright (C) 2024 omop

  stage        Handles staging operations.

  docs         Documentation generation.

  transform    Handles transformation operations.

  prune        Prunes incomplete OMOP records.

  help         Display more information on a specific command.

  version      Display version information.

```

# Supported Transformations

|          | **Location** | **Person** | **Condition Occurrence** | **Visit Occurrence** |
|----------|--------------|------------|--------------------------|----------------------|
| **CDS**  |      ✔️       |     ✔️      |✔️                      |         ✔           |
| **COSD** |     ✔️      |       ✔️     |                         |                      |
| **RTDS**  |     ✔️      |       ✔️     |                        |                      |
| **SACT** |      ✔️       |      ✔️      |                       |                      |

[Transformation documentation](Documentation/transformation-documentation.md)

## Docs command

Generates transformation documentation and records it to a specified directory.

### Example

Generates transformation documentation to the current directory.

```
omop docs .
```

### Remarks

The documentation comprises of a series of markdown documents and SVG diagrams.

Each OMOP field has a document that describes how each field is mapped from all known data sources. This could be as simple as a copy, or include complex transformations or lookups. If a transformation includes a SQL query, this is included with an explanation of the query output.

## Stage command

Loads staging data from a filesystem.

### Example

```
omop stage load --type cosd "Cancer_Reporting\COSD\April 2022 Submission.zip"
```

```
omop stage load --type sact "SACT_v3-20200101-20200131.csv"
```

```
omop stage load --type rtds "Rtds.zip"
```

```
omop stage load --type cds BNC62_1_20231020232835673
```

### Remarks

Supported data formats include
* CDS - EMIS Infoflex 6.2 fixed width multiline text format
* COSD - v8-1 and v9-0-1 xml formats
* [SACT - v3.0](https://digital.nhs.uk/data-and-information/information-standards/information-standards-and-data-collections-including-extractions/publications-and-notifications/standards-and-collections/dcb1533-systemic-anti-cancer-therapy-data-set)
* RTDS

Staged data is appended to existing staging tables. If the staging tables need to be cleared run the [`clear staging command`](#clear-staging-command) first.

## Clear staging command

Clears the staging tables.

### Example

```
omop stage clear --type cds
```

### Remarks

Supported type flags are `cds`, `rtds`, `cosd` and `sact`.

## Transform command

Transforms and inserts the staged data and its origin to the OMOP database.

### Example 

```
omop transform --type cds
```

### Remarks

Supported type flags are `cds`, `rtds`, `cosd` and `sact`.

The OMOP data provenance is recorded as each data set is transformed. [See data provenance.](#data-provenance)

## Prune command

Prunes incomplete OMOP records after all transformations are completed.

### Example

```
omop prune
```

### Remarks

Removes any Person records that either
* Have no gender
* Have no ethnicity

Removes any locations that are not used.

# Data provenance

The tool supports recording to a field level the origin of a OMOP record.

This data is held in the `provenance` table that is defined by the following columns.

| Column              | Explanation |
|---------------------|-------------|
| `table_type_id`    |  Table type, eg `21` for Location or `31` for Person.           |
| `table_key`   |  Key of the reference table, eg `123` from the `location_id` table.           |
| `column_name`   | Name of the tracked column, eg `address_1`.            |
| `data_source`   |   Explanation of the data origin, eg `CDS`          |

## Example usage - Persons report

The following query reports the breakdown of the data sources for every `person` in the person table. 

```
select
	data_source,
	count (*)
from provenance
where table_type_id = 31 -- person
	and column_name = 'person_source_value'
group by data_source
```

## Example usage - Reveal data source for person 123

The following query reports the data sources for each field in the `person` table for person id `123`.

```
select *
from provenance
where table_type_id = 31 -- person
	and table_key = 123;
```

# Data merging logic

When OMOP records are recorded some records must be merged. An example of this would be if we detected patient is more than one data source.

In some cases we may partially record a record with the hope of detecting the missing information in later transformations. For example if we have a person data source that does not define the patient's gender. 

If all data is transformed and incomplete records still exist, use the [`prune command`](#prune-command). 

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
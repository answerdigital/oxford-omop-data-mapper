[![.NET](https://github.com/answerdigital/oxford-omop-data-mapper/actions/workflows/dotnet.yml/badge.svg)](https://github.com/answerdigital/oxford-omop-data-mapper/actions/workflows/dotnet.yml)

# OMOP Transformer CLI tool

```
PS C:\Code\oxford-omop-transformer\OmopTransformer\bin\Debug\net8.0> omop --help
omop 1.0.0+db84dcb0f45f5cb4450b40e6c11bf437e9515117
Copyright (C) 2023 omop

  stage        Handles staging operations.

  docs         Documentation generation.

  transform    Handles transformation operations.

  help         Display more information on a specific command.

  version      Display version information.

```

# Supported Transformations

|          | **Location** | **Person** |
|----------|--------------|------------|
| **CDS**  |      ✔️       |     ✔️      |
| **COSD** |     ✔️      |       ✔️     |
| **RTDS**  |     ✔️      |       ✔️     |
| **SACT** |      ✔️       |      ✔️      |

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

Transforms and inserts the staged data to the omop database.

### Example 

```
omop transform --type cds
```

### Remarks

Supported type flags are `cds`, `rtds`, `cosd` and `sact`.

## Prune command

Prunes incomplete OMOP records.

### Example

```
omop prune
```

### Remarks

Removes any Person records that either
* Have no gender
* Have no ethnicity

Removes any locations that are not used.
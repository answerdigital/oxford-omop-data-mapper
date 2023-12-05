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
| **CDS**  |              |           |
| **COSD** |     ✔️      |            |
| **RTDS** |              |            |
| **SACT** |      ✔️       |            |

[Transformation documentation](transformation-documentation.md)

## Docs command

Generates transform documentation and records it to file.

Example usage `omop docs report.md`

## COSD

### Loading data

Loads COSD zip archives into a staging database.

Example usage `omop stage load --type cosd "\\10.134.180.238\Cancer_Reporting\COSD\April 2022 Submission.zip"`

### Clear staging

Clears the COSD staging tables.

Example usage `omop stage clear --type cosd`

## Transform

Transforms and inserts the staged data to the omop database.

Example usage `omop transform --type cosd`

## SACT

### Loading data

Loads a SACT csv into a staging database.

Example usage `omop stage load --type sact "SACT_v3-20200101-20200131.csv"`

### Clear staging

Clears the SACT staging tables.

Example usage `omop stage clear --type sact`

## Transform

Transforms and inserts the staged data to the omop database.

Example usage `omop transform --type sact`
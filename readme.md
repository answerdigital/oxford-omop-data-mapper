# OMOP Transformer CLI tool

```
PS C:\Code\oxford-omop-transformer\OmopTransformer\bin\Debug\net8.0> .\omop.exe --help
omop 1.0.0+f99d89ee6a577ea7c151a647af0738e2c19df5b2
Copyright (C) 2023 omop

  staging    Handles staging operations.

  docs       Documentation generation.

  help       Display more information on a specific command.

  version    Display version information.

```

## Docs command

Generates transform documentation and records it to file.

Example usage `omop docs report.md`

## COSD staging

### Loading data

Loads COSD zip archives into a staging database.

Example usage `omop staging load --type cosd "\\10.134.180.238\Cancer_Reporting\COSD\April 2022 Submission.zip"`

### Clear staging

Clears the COSD staging tables.

Example usage `omop staging clear --type cosd`

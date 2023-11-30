# OMOP Transformer CLI tool

```
PS C:\Code\oxford-omop-transformer\OmopTransformer\bin\Debug\net8.0> .\omop.exe --help
omop 1.0.0+a77649bac12e84decb8237667b610409aa2071fb
Copyright (C) 2023 omop

  staging      Handles staging operations.

  docs         Documentation generation.

  transform    Handles transformation operations.

  help         Display more information on a specific command.

  version      Display version information.

```

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
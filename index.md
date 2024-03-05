---
title: Home
layout: home
---

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

|          | **Location** | **Person** | **Condition Occurrence** | **Visit Occurrence** | **Visit Details** | **Measurement**      | **Death** | **Procedure Occurrence** | **Drug Exposure** | **Observation** |
|----------|--------------|------------|--------------------------|----------------------|-------------------|----------------------|-----------|---------------------------|------------------|-----------------|
| **CDS**  |      ✔️       |     ✔️      |✔️                      |         ✔️           |      ✔️             |	           ✔️ ❗     |    ✔️      |✔                         |✔           |        ✔       |
| **COSD** |     ✔️      |       ✔️     |                         |                      |                    |	                    |            |                          |                  |                 |
| **RTDS**  |     ✔️      |       ✔️     |                        |                      |                    |	                    |            |                          |                  |                 |
| **SACT** |      ✔️       |      ✔️      |                       |                      |                    |	                    |            |                          |                  |                 |

[Automatically Generated OMOP Data Transformation Documentation]({% link docs/transformation-documentation/transformation-documentation.md %}#prune-command){: .btn .btn-blue }
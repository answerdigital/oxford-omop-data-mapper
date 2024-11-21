# Data Quality Dashboard Container

## Overview

This project provides a containerised solution for running the [OHDSI Data Quality Dashboard](https://github.com/OHDSI/DataQualityDashboard), an open-source tool designed to evaluate and expose the quality of observational healthcare data conforming to the OMOP Common Data Model (CDM).

## Key Features

- Supports OMOP CDM versions: 5.2, 5.3, and 5.4
- Containerised deployment for easy setup and reproducibility
- Automated data quality checks based on the Kahn Framework
- Generates detailed quality assessment reports

## Prerequisites

### System Requirements
- Docker
- SQL Server
- Microsoft JDBC Driver for SQL Server

### Required Files
1. `.env` configuration file
2. Microsoft JDBC Driver (`.jar`)

## Configuration

### Environment File (`.env`)

Create a `.env` file with the following structure in the `drivers/` folder and populate with your SQl server and database credentials.

```env
USER=username
PASSWORD=password
SERVER=host.docker.internal
PORT=1433
DRIVER=drivers/
SETTINGS=;Database=omoptest;Encrypt=False;TrustServerCertificate=False;
```

### JDBC Driver Installation

1. Download the Microsoft JDBC Driver from [Microsoft's official documentation](https://learn.microsoft.com/en-us/sql/connect/jdbc/download-microsoft-jdbc-driver-for-sql-server?view=sql-server-ver16)
2. Place the `.jar` file in the `drivers/` folder, this gets copied into the container

## Running the Pipeline

### Powershell Execution

Run the pipeline using `run.ps1` with an output path argument, this will be where you want the containers output files to be saved:

```powershell
powershell ./run.ps1 -outpath "C:\path\to\output\directory"
```

### Pipeline/Build Workflow:

1. Installs dependencies (R, Python, Java)
2. Connects to SQL Server via JDBC driver
3. Executes data quality checks
4. Generates `results.json`
5. Parse results and creates `failed_checks.json`

## Output Files

- `results.json`: Comprehensive data quality check results
- `failed_checks.json`: Condensed file containing only failed checks (useful for reporting)

using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SACT.Staging;

internal class SactInserter : ISactInserter
{
    private readonly Configuration _configuration;
    private readonly ILogger<SactInserter> _logger;

    public SactInserter(IOptions<Configuration> configuration, ILogger<SactInserter> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Insert(IReadOnlyCollection<Sact> sactRows, CancellationToken cancellationToken)
    {
        if (sactRows == null) throw new ArgumentNullException(nameof(sactRows));

        _logger.LogInformation("Recording {0} sact rows.", sactRows.Count);

        var stopwatch = Stopwatch.StartNew();

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        var batches = sactRows.Batch(1000);
        foreach (var batch in batches)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var dataTable = new DataTable();

            dataTable.Columns.Add("NHS_Number");
            dataTable.Columns.Add("Local_Patient_Identifier");
            dataTable.Columns.Add("NHS_Number_Status_Indicator_Code");
            dataTable.Columns.Add("Person_Family_Name");
            dataTable.Columns.Add("Person_Given_Name");
            dataTable.Columns.Add("Date_Of_Birth");
            dataTable.Columns.Add("Person_Stated_Gender_Code");
            dataTable.Columns.Add("Patient_Postcode");
            dataTable.Columns.Add("Consultant_GMC_Code");
            dataTable.Columns.Add("Consultant_Specialty_Code");
            dataTable.Columns.Add("Organisation_Identifier_Code_Of_Provider");
            dataTable.Columns.Add("Primary_Diagnosis");
            dataTable.Columns.Add("Morphology_ICD_O");
            dataTable.Columns.Add("Diagnosis_Code_SNOMED_CT");
            dataTable.Columns.Add("Adjunctive_Therapy");
            dataTable.Columns.Add("Intent_Of_Treatment");
            dataTable.Columns.Add("Regimen");
            dataTable.Columns.Add("Height_At_Start_Of_Regimen");
            dataTable.Columns.Add("Weight_At_Start_Of_Regimen");
            dataTable.Columns.Add("Performance_Status_At_Start_Of_Regimen_Adult");
            dataTable.Columns.Add("Comorbidity_Adjustment");
            dataTable.Columns.Add("Date_Decision_To_Treat");
            dataTable.Columns.Add("Start_Date_Of_Regimen");
            dataTable.Columns.Add("Clinical_Trial");
            dataTable.Columns.Add("Cycle_Number");
            dataTable.Columns.Add("Start_Date_Of_Cycle");
            dataTable.Columns.Add("Weight_At_Start_Of_Cycle");
            dataTable.Columns.Add("Performance_Status_At_Start_Of_Cycle_Adult");
            dataTable.Columns.Add("Drug_Name");
            dataTable.Columns.Add("DM_D");
            dataTable.Columns.Add("Actual_Dose_Per_Administration");
            dataTable.Columns.Add("Administration_Measurement_Per_Actual_Dose");
            dataTable.Columns.Add("Other_Administration_Measurement_Per_Actual_Dose");
            dataTable.Columns.Add("Unit_Of_Measurement_SNOMED_CT_DM_D");
            dataTable.Columns.Add("SACT_Administration_Route");
            dataTable.Columns.Add("Route_Of_Administration_SNOMED_CT_DM_D");
            dataTable.Columns.Add("Administration_Date");
            dataTable.Columns.Add("Organisation_Identifier_Of_SACT_Administration");
            dataTable.Columns.Add("Regimen_Modification_Dose_Reduction");
            dataTable.Columns.Add("Regimen_Outcome_Summary_Curative_Completed_As_Planned");
            dataTable.Columns.Add("Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason");
            dataTable.Columns.Add("Other_Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason");
            dataTable.Columns.Add("Regimen_Outcome_Summary_Non_Curative");
            dataTable.Columns.Add("Regimen_Outcome_Summary_Toxicity");

            foreach (var row in batch)
            {
                dataTable.Rows.Add(
                    row.NHS_Number,
                    row.Local_Patient_Identifier,
                    row.NHS_Number_Status_Indicator_Code,
                    row.Person_Family_Name,
                    row.Person_Given_Name,
                    row.Date_Of_Birth,
                    row.Person_Stated_Gender_Code,
                    row.Patient_Postcode,
                    row.Consultant_GMC_Code,
                    row.Consultant_Specialty_Code,
                    row.Organisation_Identifier_Code_Of_Provider,
                    row.Primary_Diagnosis,
                    row.Morphology_ICD_O,
                    row.Diagnosis_Code_SNOMED_CT,
                    row.Adjunctive_Therapy,
                    row.Intent_Of_Treatment,
                    row.Regimen,
                    row.Height_At_Start_Of_Regimen,
                    row.Weight_At_Start_Of_Regimen,
                    row.Performance_Status_At_Start_Of_Regimen_Adult,
                    row.Comorbidity_Adjustment,
                    row.Date_Decision_To_Treat,
                    row.Start_Date_Of_Regimen,
                    row.Clinical_Trial,
                    row.Cycle_Number,
                    row.Start_Date_Of_Cycle,
                    row.Weight_At_Start_Of_Cycle,
                    row.Performance_Status_At_Start_Of_Cycle_Adult,
                    row.Drug_Name,
                    row.DM_D,
                    row.Actual_Dose_Per_Administration,
                    row.Administration_Measurement_Per_Actual_Dose,
                    row.Other_Administration_Measurement_Per_Actual_Dose,
                    row.Unit_Of_Measurement_SNOMED_CT_DM_D,
                    row.SACT_Administration_Route,
                    row.Route_Of_Administration_SNOMED_CT_DM_D,
                    row.Administration_Date,
                    row.Organisation_Identifier_Of_SACT_Administration,
                    row.Regimen_Modification_Dose_Reduction,
                    row.Regimen_Outcome_Summary_Curative_Completed_As_Planned,
                    row.Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason,
                    row.Other_Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason,
                    row.Regimen_Outcome_Summary_Non_Curative,
                    row.Regimen_Outcome_Summary_Toxicity);
            }

            var parameter = new
            {
                SactRows = dataTable.AsTableValuedParameter("[omop_staging].[sact_staging_row]")
            };

            await connection.ExecuteLongTimeoutAsync("[omop_staging].[insert_sact_rows]", parameter, commandType: CommandType.StoredProcedure);
        }

        stopwatch.Stop();

        _logger.LogTrace("Inserting rows took {0}ms.", stopwatch.ElapsedMilliseconds);
    }
}
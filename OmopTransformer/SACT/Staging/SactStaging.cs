using System.Diagnostics;
using System.Globalization;
using CsvHelper;
using Microsoft.Extensions.Logging;

namespace OmopTransformer.SACT.Staging;

internal class SactStaging : ISactStaging
{
    private readonly ILogger<SactStaging> _logger;
    private readonly StagingOptions _options;
    private readonly ISactInserter _sactInserter;

    public SactStaging(ILogger<SactStaging> logger, StagingOptions options, ISactInserter sactInserter)
    {
        _logger = logger;
        _options = options;
        _sactInserter = sactInserter;
    }

    public async Task StageData(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Staging sact data.");

        if (!File.Exists(_options.FileName))
        {
            _logger.LogError("File does not exist or is inaccessible. {0}", _options.FileName);
            Environment.ExitCode = (int)ExitCodes.FileDoesNotExist;
            return;
        }

        _logger.LogInformation("Reading {0}", _options.FileName);

        Stopwatch stopwatch = Stopwatch.StartNew();

        using var reader = new StreamReader(_options.FileName);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = new List<Sact>();
        await csv.ReadAsync();
        csv.ReadHeader();
        while (await csv.ReadAsync())
        {
            var record = new Sact
            {
                NHS_Number = csv.GetField("NHS_Number"),
                Local_Patient_Identifier = csv.GetField("Local_Patient_Identifier"),
                NHS_Number_Status_Indicator_Code = csv.GetField("NHS_Number_Status_Indicator_Code"),
                Person_Family_Name = csv.GetField("Person_Family_Name"),
                Person_Given_Name = csv.GetField("Person_Given_Name"),
                Date_Of_Birth = csv.GetField("Date_Of_Birth"),
                Person_Stated_Gender_Code = csv.GetField("Person_Stated_Gender_Code"),
                Consultant_GMC_Code = csv.GetField("Consultant_GMC_Code"),
                Consultant_Specialty_Code = csv.GetField("Consultant_Specialty_Code"),
                Organisation_Identifier_Code_Of_Provider = csv.GetField("Organisation_Identifier_(Code_Of_Provider)"),
                Primary_Diagnosis = csv.GetField("Primary_Diagnosis"),
                Morphology_ICD_O = csv.GetField("Morphology_ICD-O"),
                Diagnosis_Code_SNOMED_CT = csv.GetField("Diagnosis_Code_(SNOMED_CT)"),
                Adjunctive_Therapy = csv.GetField("Adjunctive_Therapy"),
                Intent_Of_Treatment = csv.GetField("Intent_Of_Treatment"),
                Regimen = csv.GetField("Regimen"),
                Height_At_Start_Of_Regimen = csv.GetField("Height_At_Start_Of_Regimen"),
                Weight_At_Start_Of_Regimen = csv.GetField("Weight_At_Start_Of_Regimen"),
                Performance_Status_At_Start_Of_Regimen_Adult = csv.GetField("Performance_Status_At_Start_Of_Regimen_-_Adult"),
                Comorbidity_Adjustment = csv.GetField("Comorbidity_Adjustment"),
                Date_Decision_To_Treat = csv.GetField("Date_Decision_To_Treat"),
                Start_Date_Of_Regimen = csv.GetField("Start_Date_Of_Regimen"),
                Clinical_Trial = csv.GetField("Clinical_Trial"),
                Cycle_Number = csv.GetField("Cycle_Number"),
                Start_Date_Of_Cycle = csv.GetField("Start_Date_Of_Cycle"),
                Weight_At_Start_Of_Cycle = csv.GetField("Weight_At_Start_Of_Cycle"),
                Performance_Status_At_Start_Of_Cycle_Adult = csv.GetField("Performance_Status_At_Start_Of_Cycle_-_Adult"),
                Drug_Name = csv.GetField("Drug_Name"),
                DM_D = csv.GetField("DM+D"),
                Actual_Dose_Per_Administration = csv.GetField("Actual_Dose_Per_Administration"),
                Administration_Measurement_Per_Actual_Dose = csv.GetField("Administration_Measurement_Per_Actual_Dose"),
                Other_Administration_Measurement_Per_Actual_Dose = csv.GetField("Other_-_ Administration_Measurement_Per_Actual_Dose"),
                Unit_Of_Measurement_SNOMED_CT_DM_D = csv.GetField("Unit_Of_Measurement_(SNOMED_CT_DM+D)"),
                SACT_Administration_Route = csv.GetField("SACT_Administration_Route"),
                Route_Of_Administration_SNOMED_CT_DM_D = csv.GetField("Route_Of_Administration_(SNOMED_CT_DM+D)"),
                Administration_Date = csv.GetField("Administration_Date"),
                Organisation_Identifier_Of_SACT_Administration = csv.GetField("Organisation_Identifier_Of_SACT_Administration"),
                Regimen_Modification_Dose_Reduction = csv.GetField("Regimen_Modification_-_Dose_Reduction"),
                Regimen_Outcome_Summary_Curative_Completed_As_Planned = csv.GetField("Regimen_Outcome_Summary_-_Curative_(Completed_As_Planned)"),
                Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason = csv.GetField("Regimen_Outcome_Summary_-_Curative_(Not_Completed_As_Planned)_Reason"),
                Other_Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason = csv.GetField("Other_-_Regimen_Outcome_Summary_-_Curative_(Not_Completed_As_Planned)_Reason"),
                Regimen_Outcome_Summary_Non_Curative = csv.GetField("Regimen_Outcome_Summary_Non_Curative"),
                Regimen_Outcome_Summary_Toxicity = csv.GetField("Regimen_Outcome_Summary_Toxicity"),
                Patient_Postcode = GetPatientPostcode(csv)
            };

            records.Add(record);
        }

        stopwatch.Stop();

        _logger.LogInformation("{0} records read in {1}ms.", records.Count, stopwatch.ElapsedMilliseconds);

        await _sactInserter.Insert(records, cancellationToken);

        _logger.LogInformation("Staging complete.");
    }

    private static string? GetPatientPostcode(CsvReader csv)
    {
        string? postcode = null;

        if (csv.TryGetField("Patient_Postcode", out postcode))
        {
            return postcode;
        }

        if (csv.TryGetField("Patient_PostCode", out postcode))
        {
            return postcode;
        }

        return null;
    }
}
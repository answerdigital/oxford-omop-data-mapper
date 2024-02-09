using OmopTransformer.Annotations;

namespace OmopTransformer.SACT;

[DataOrigin("SACT")]
[Description("SACT")]
internal class Sact
{
    public string? NHS_Number { get; init; }
    public string? Local_Patient_Identifier { get; init; }
    public string? NHS_Number_Status_Indicator_Code { get; init; }
    public string? Person_Family_Name { get; init; }
    public string? Person_Given_Name { get; init; }
    public string? Date_Of_Birth { get; init; }
    public string? Person_Stated_Gender_Code { get; init; }
    public string? Patient_Postcode { get; init; }
    public string? Consultant_GMC_Code { get; init; }
    public string? Consultant_Specialty_Code { get; init; }
    public string? Organisation_Identifier_Code_Of_Provider { get; init; }
    public string? Primary_Diagnosis { get; init; }
    public string? Morphology_ICD_O { get; init; }
    public string? Diagnosis_Code_SNOMED_CT { get; init; }
    public string? Adjunctive_Therapy { get; init; }
    public string? Intent_Of_Treatment { get; init; }
    public string? Regimen { get; init; }
    public string? Height_At_Start_Of_Regimen { get; init; }
    public string? Weight_At_Start_Of_Regimen { get; init; }
    public string? Performance_Status_At_Start_Of_Regimen_Adult { get; init; }
    public string? Comorbidity_Adjustment { get; init; }
    public string? Date_Decision_To_Treat { get; init; }
    public string? Start_Date_Of_Regimen { get; init; }
    public string? Clinical_Trial { get; init; }
    public string? Cycle_Number { get; init; }
    public string? Start_Date_Of_Cycle { get; init; }
    public string? Weight_At_Start_Of_Cycle { get; init; }
    public string? Performance_Status_At_Start_Of_Cycle_Adult { get; init; }
    public string? Drug_Name { get; init; }
    public string? DM_D { get; init; }
    public string? Actual_Dose_Per_Administration { get; init; }
    public string? Administration_Measurement_Per_Actual_Dose { get; init; }
    public string? Other_Administration_Measurement_Per_Actual_Dose { get; init; }
    public string? Unit_Of_Measurement_SNOMED_CT_DM_D { get; init; }
    public string? SACT_Administration_Route { get; init; }
    public string? Route_Of_Administration_SNOMED_CT_DM_D { get; init; }
    public string? Administration_Date { get; init; }
    public string? Organisation_Identifier_Of_SACT_Administration { get; init; }
    public string? Regimen_Modification_Dose_Reduction { get; init; }
    public string? Regimen_Outcome_Summary_Curative_Completed_As_Planned { get; init; }
    public string? Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason { get; init; }
    public string? Other_Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason { get; init; }
    public string? Regimen_Outcome_Summary_Non_Curative { get; init; }
    public string? Regimen_Outcome_Summary_Toxicity { get; init; }

}
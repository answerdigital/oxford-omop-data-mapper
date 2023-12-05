using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SACT.Staging;

internal class SactStagingSchema : StagingSchema, ISactStagingSchema
{
    public SactStagingSchema(IOptions<Configuration> configuration, ILogger<SactStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] DropStagingSql =>
        new[]
        {
            "if object_id('sact_staging') is not null begin drop table sact_staging; end",
            "if object_id ('insert_sact_rows') is not null begin drop procedure insert_sact_rows end",
            "if type_id ('[sact_staging_row]') is not null begin drop type [sact_staging_row] end;"
        };

    protected override string TableNameForExistenceCheck => "sact_staging";
    protected override string[] CreateStagingSql =>
        new[]
        {
            "CREATE TABLE [dbo].[sact_staging](" +
            "[NHS_Number] nvarchar(255) null, " +
            "[Local_Patient_Identifier] nvarchar(255) null, " +
            "[NHS_Number_Status_Indicator_Code] nvarchar(255) null, " +
            "[Person_Family_Name] nvarchar(255) null, " +
            "[Person_Given_Name] nvarchar(255) null, " +
            "[Date_Of_Birth] nvarchar(255) null, " +
            "[Person_Stated_Gender_Code] nvarchar(255) null, " +
            "[Patient_Postcode] nvarchar(255) null, " +
            "[Consultant_GMC_Code] nvarchar(255) null, " +
            "[Consultant_Specialty_Code] nvarchar(255) null, " +
            "[Organisation_Identifier_Code_Of_Provider] nvarchar(255) null, " +
            "[Primary_Diagnosis] nvarchar(255) null, " +
            "[Morphology_ICD_O] nvarchar(255) null, " +
            "[Diagnosis_Code_SNOMED_CT] nvarchar(255) null, " +
            "[Adjunctive_Therapy] nvarchar(255) null, " +
            "[Intent_Of_Treatment] nvarchar(255) null, " +
            "[Regimen] nvarchar(255) null, " +
            "[Height_At_Start_Of_Regimen] nvarchar(255) null, " +
            "[Weight_At_Start_Of_Regimen] nvarchar(255) null, " +
            "[Performance_Status_At_Start_Of_Regimen_Adult] nvarchar(255) null, " +
            "[Comorbidity_Adjustment] nvarchar(255) null, " +
            "[Date_Decision_To_Treat] nvarchar(255) null, " +
            "[Start_Date_Of_Regimen] nvarchar(255) null, " +
            "[Clinical_Trial] nvarchar(255) null, " +
            "[Cycle_Number] nvarchar(255) null, " +
            "[Start_Date_Of_Cycle] nvarchar(255) null, " +
            "[Weight_At_Start_Of_Cycle] nvarchar(255) null, " +
            "[Performance_Status_At_Start_Of_Cycle_Adult] nvarchar(255) null, " +
            "[Drug_Name] nvarchar(255) null, " +
            "[DM_D] nvarchar(255) null, " +
            "[Actual_Dose_Per_Administration] nvarchar(255) null, " +
            "[Administration_Measurement_Per_Actual_Dose] nvarchar(255) null, " +
            "[Other_Administration_Measurement_Per_Actual_Dose] nvarchar(255) null, " +
            "[Unit_Of_Measurement_SNOMED_CT_DM_D] nvarchar(255) null, " +
            "[SACT_Administration_Route] nvarchar(255) null, " +
            "[Route_Of_Administration_SNOMED_CT_DM_D] nvarchar(255) null, " +
            "[Administration_Date] nvarchar(255) null, " +
            "[Organisation_Identifier_Of_SACT_Administration] nvarchar(255) null, " +
            "[Regimen_Modification_Dose_Reduction] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Curative_Completed_As_Planned] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason] nvarchar(255) null, " +
            "[Other_Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Non_Curative] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Toxicity] nvarchar(255) null " +
            ")",
            "CREATE type [sact_staging_row] as table(" +
            "[NHS_Number] nvarchar(255) null, " +
            "[Local_Patient_Identifier] nvarchar(255) null, " +
            "[NHS_Number_Status_Indicator_Code] nvarchar(255) null, " +
            "[Person_Family_Name] nvarchar(255) null, " +
            "[Person_Given_Name] nvarchar(255) null, " +
            "[Date_Of_Birth] nvarchar(255) null, " +
            "[Person_Stated_Gender_Code] nvarchar(255) null, " +
            "[Patient_Postcode] nvarchar(255) null, " +
            "[Consultant_GMC_Code] nvarchar(255) null, " +
            "[Consultant_Specialty_Code] nvarchar(255) null, " +
            "[Organisation_Identifier_Code_Of_Provider] nvarchar(255) null, " +
            "[Primary_Diagnosis] nvarchar(255) null, " +
            "[Morphology_ICD_O] nvarchar(255) null, " +
            "[Diagnosis_Code_SNOMED_CT] nvarchar(255) null, " +
            "[Adjunctive_Therapy] nvarchar(255) null, " +
            "[Intent_Of_Treatment] nvarchar(255) null, " +
            "[Regimen] nvarchar(255) null, " +
            "[Height_At_Start_Of_Regimen] nvarchar(255) null, " +
            "[Weight_At_Start_Of_Regimen] nvarchar(255) null, " +
            "[Performance_Status_At_Start_Of_Regimen_Adult] nvarchar(255) null, " +
            "[Comorbidity_Adjustment] nvarchar(255) null, " +
            "[Date_Decision_To_Treat] nvarchar(255) null, " +
            "[Start_Date_Of_Regimen] nvarchar(255) null, " +
            "[Clinical_Trial] nvarchar(255) null, " +
            "[Cycle_Number] nvarchar(255) null, " +
            "[Start_Date_Of_Cycle] nvarchar(255) null, " +
            "[Weight_At_Start_Of_Cycle] nvarchar(255) null, " +
            "[Performance_Status_At_Start_Of_Cycle_Adult] nvarchar(255) null, " +
            "[Drug_Name] nvarchar(255) null, " +
            "[DM_D] nvarchar(255) null, " +
            "[Actual_Dose_Per_Administration] nvarchar(255) null, " +
            "[Administration_Measurement_Per_Actual_Dose] nvarchar(255) null, " +
            "[Other_Administration_Measurement_Per_Actual_Dose] nvarchar(255) null, " +
            "[Unit_Of_Measurement_SNOMED_CT_DM_D] nvarchar(255) null, " +
            "[SACT_Administration_Route] nvarchar(255) null, " +
            "[Route_Of_Administration_SNOMED_CT_DM_D] nvarchar(255) null, " +
            "[Administration_Date] nvarchar(255) null, " +
            "[Organisation_Identifier_Of_SACT_Administration] nvarchar(255) null, " +
            "[Regimen_Modification_Dose_Reduction] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Curative_Completed_As_Planned] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason] nvarchar(255) null, " +
            "[Other_Regimen_Outcome_Summary_Curative_Not_Completed_As_Planned_Reason] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Non_Curative] nvarchar(255) null, " +
            "[Regimen_Outcome_Summary_Toxicity] nvarchar(255) null " +
            ")",
            "create procedure insert_sact_rows			" +
            "	@SactRows sact_staging_row readonly		" +
            "as												" +
            "begin											" +
            "												" +
            "insert into dbo.sact_staging					" +
            "select *										" +
            "from @SactRows;								" +
            "												" +
            "end											"
        };
}
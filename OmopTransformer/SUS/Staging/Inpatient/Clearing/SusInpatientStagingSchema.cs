using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SUS.Staging.Inpatient.Clearing;

internal class SusInpatientStagingSchema : StagingSchema, ISusInpatientStagingSchema
{
    public SusInpatientStagingSchema(IOptions<Configuration> configuration, ILogger<SusInpatientStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "truncate table omop_staging.sus_OverseasVisitor;",
        "truncate table omop_staging.sus_ICDDiagnosis;",
        "truncate table omop_staging.sus_ReadDiagnosis;",
        "truncate table omop_staging.sus_CareLocation;",
        "truncate table omop_staging.sus_OPCSProcedure;",
        "truncate table omop_staging.sus_ReadProcedure;",
        "truncate table omop_staging.sus_Birth;",
        "truncate table omop_staging.sus_CriticalCare;",
        "truncate table omop_staging.sus_APC;",
        "truncate table omop_staging.sus_CCMDS_CriticalCareActivityCode",
        "truncate table omop_staging.sus_CCMDS_CriticalCareHighCostDrugs",
        "truncate table omop_staging.sus_CCMDS",
    ];
}
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SUS.Staging.APC.Clearing;

internal class SusAPCStagingSchema : StagingSchema, ISusAPCStagingSchema
{
    public SusAPCStagingSchema(IOptions<Configuration> configuration, ILogger<SusAPCStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "if object_id('omop_staging.sus_OverseasVisitor') is not null begin delete omop_staging.sus_OverseasVisitor end;",
        "if object_id('omop_staging.sus_ICDDiagnosis') is not null begin delete omop_staging.sus_ICDDiagnosis end;",
        "if object_id('omop_staging.sus_ReadDiagnosis') is not null begin delete omop_staging.sus_ReadDiagnosis end;",
        "if object_id('omop_staging.sus_CareLocation') is not null begin delete omop_staging.sus_CareLocation end;",
        "if object_id('omop_staging.sus_OPCSProcedure') is not null begin delete omop_staging.sus_OPCSProcedure end;",
        "if object_id('omop_staging.sus_ReadProcedure') is not null begin delete omop_staging.sus_ReadProcedure end;",
        "if object_id('omop_staging.sus_Birth') is not null begin delete omop_staging.sus_Birth end;",
        "if object_id('omop_staging.sus_CriticalCare') is not null begin delete omop_staging.sus_CriticalCare end;",
        "if object_id('omop_staging.sus_APC') is not null begin delete omop_staging.sus_APC end;",
    ];
}
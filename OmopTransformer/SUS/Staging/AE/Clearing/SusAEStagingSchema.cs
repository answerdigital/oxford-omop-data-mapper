using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OmopTransformer.SUS.Staging.APC.Clearing;

namespace OmopTransformer.SUS.Staging.AE.Clearing;

internal class SusAEStagingSchema : StagingSchema, ISusAEStagingSchema
{
    public SusAEStagingSchema(IOptions<Configuration> configuration, ILogger<SusAPCStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "if object_id('omop_staging.sus_AE_diagnosis') is not null begin delete omop_staging.sus_AE_diagnosis end;",
        "if object_id('omop_staging.sus_AE_investigation') is not null begin delete omop_staging.sus_AE_investigation end;",
        "if object_id('omop_staging.sus_AE_treatment') is not null begin delete omop_staging.sus_AE_treatment end;",
        "if object_id('omop_staging.sus_AE') is not null begin delete omop_staging.sus_AE end;"
    ];
}
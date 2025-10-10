using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SUS.Staging.AE.Clearing;

internal class SusAEStagingSchema : StagingSchema, ISusAEStagingSchema
{
    public SusAEStagingSchema(IOptions<Configuration> configuration, ILogger<SusAEStagingSchema> logger) : base(configuration, logger)
    {
    }

    protected override string[] ClearStagingSql =>
    [
        "truncate table omop_staging.sus_AE_diagnosis;",
        "truncate table omop_staging.sus_AE_investigation;",
        "truncate table omop_staging.sus_AE_treatment;",
        "truncate table omop_staging.sus_AE;"
    ];
}